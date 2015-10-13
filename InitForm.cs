using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SQLite;
namespace JqpdInit
{
    public partial class Init_Form : Form
    {
        const int bitRate = 57600;
        const int maxNum = 99999;
        private bool portSelect = false;
        private SerialPort sp = null;
        private string[] allPortNames;
        private SQLiteCommand command;
        public static SQLiteConnection dataBase;
        private int sale = 0;
        private int lineNumber = 0;
        private int[] ln = new int[3] { 0, 0, 0 };
        private int machineNumber = 0;
        private int[] mn = new int[3] { 0, 0, 0 };
        private int codeTime = 20;
        private int startNum = 0;
        private int currentNum = 0;
        private Properties.Settings userSet;
        private void AddNewRecord()
        {
            int m_num = machineNumber * 100000 + currentNum;
            try
            {
                InsertRecord(lineNumber, m_num);
            }
            catch(SQLiteException sqlex)
            {
                command.CommandText = "create table jqpd(time text,ln int,mn int);";
                command.ExecuteNonQuery();
                InsertRecord(lineNumber, m_num);
            }
        }

        private void InsertRecord(int ln, int mn)
        {
            string tempString = "insert into jqpd values(datetime('now','localtime'),";
            command.CommandText = tempString + ln + "," + mn + ");";
            command.ExecuteNonQuery();
        }

        private bool SaveData()
        {
            byte[] buff = new byte[4];
            try
            {
                int n = sp.Read(buff, 0, buff.Length);
                if(n >= 4 && buff[0] == 0xC9 && buff[1] == 0xD0 &&
                             buff[2] == 0x01 && buff[3] == 0xCB)
                {
                    return true;
                }
            }
            catch(System.Exception excep)
            {
            }
            sp.Close();
            sp.Dispose();
            return false;
        }

        void LoadSavedValue()
        {
            userSet = Properties.Settings.Default;
            lineNumber = userSet.savedLineNum;
            machineNumber = userSet.savedMachineNum;
            startNum = userSet.savedStart;
            currentNum = userSet.savedCurrent;
            
            ln[0] = lineNumber / 100;
            ln[1] = lineNumber / 10 % 10;
            ln[2] = lineNumber % 10;

            mn[0] = machineNumber / 100;
            mn[1] = machineNumber / 10 % 10;
            mn[2] = machineNumber % 10;

            cbLN1.SelectedIndex = ln[0];
            cbLN2.SelectedIndex = ln[1];
            cbLN3.SelectedIndex = ln[2];

            cbMN1.SelectedIndex = mn[0];
            cbMN2.SelectedIndex = mn[1];
            cbMN3.SelectedIndex = mn[2];
        }

        public Init_Form()
        {
            InitializeComponent();
            LoadSavedValue();
            startNumTB.Text = startNum.ToString();
            currentNumLabel.Text = currentNum.ToString();
            timeList.SelectedIndex = 0;
            dataBase = new SQLiteConnection("Data Source = jqpd.db");
            dataBase.Open();
            command = dataBase.CreateCommand();            
        }

        private void TxForm_Load(object sender, EventArgs e)
        {          
            try
            {
                allPortNames = SerialPort.GetPortNames();
            }
            catch(System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show("找不到可用串口,程序将退出", "严重错误");
                Application.Exit();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            byte[] buff = new byte[12];
            int m_num = machineNumber * 100000 + currentNum;
            buff[0] = (byte)0xCA;
            buff[1] = (byte)0xD0;
            buff[2] = (byte)(lineNumber / 200);
            buff[3] = (byte)(lineNumber % 200);

            buff[4] = (byte)(m_num / (200 * 200 * 200) % 200);
            buff[5] = (byte)(m_num / (200 * 200) % 200);
            buff[6] = (byte)(m_num / (200) % 200);
            buff[7] = (byte)(m_num / (1) % 200);

            buff[8] = (byte)(codeTime / 200);
            buff[9] = (byte)(codeTime % 200);
            buff[10] = (byte)(sale % 200);
            buff[11] = (byte)0xCB;

            if(!portSelect)
            {
                foreach(string port in allPortNames)
                {
                    sp = new SerialPort(port, bitRate, Parity.None, 8, StopBits.One);
                    sp.ReadTimeout = 1;
                    if(!sp.IsOpen)
                    {
                        try
                        {
                            sp.Open();
                        }
                        catch(System.Exception ex)
                        {
                            sp.Dispose();
                            sp = null;
                            continue;
                        }
                    }
                    sp.Write(buff, 0, buff.Length);
                    System.Threading.Thread.Sleep(20);
                    if(SaveData())
                    {
                        portSelect = true;
                        OnSaveSucceed();
                        return;
                    }
                }
                MessageBox.Show("没有找到合适的串口！<激情派对>和电脑是否连接？");
            }
            else
            {
                sp.Write(buff, 0, buff.Length);
                System.Threading.Thread.Sleep(20);
                if(!SaveData())
                {
                    portSelect = false;
                    MessageBox.Show("写入失败！");
                }
                else
                {
                    OnSaveSucceed();
                }
            }
        }

        private void OnSaveSucceed()
        {
            AddNewRecord();
            ++currentNum;
            if(currentNum > maxNum)
            {
                currentNum = 1;
                startNum = 1;
            }
            userSet.savedStart = startNum;
            userSet.savedCurrent = currentNum;
            userSet.Save();
            currentNumLabel.Text = currentNum.ToString();
            MessageBox.Show("写入成功!");
        }

        private void SaleTypeButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "公司台")
            {
                b.Text = "买卖台";
                sale = 1;
            }
            else
            {
                b.Text = "公司台";
                sale = 0;
            }
        }      

        private void DbViewButton_Click(object sender, EventArgs e)
        {
            DbViewForm f = new DbViewForm();
            f.ShowDialog();
        }

        private void StartNum_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int n;
            try
            {
                n = int.Parse(tb.Text);
                if(n < 0)
                {
                    n = 0;
                }
                else if(n > maxNum)
                {
                    n = maxNum;
                }
                startNum = n;
                currentNum = n;
                currentNumLabel.Text = n.ToString();
                tb.Text = n.ToString();
            }
            catch(System.Exception ex)
            {
                startNum = 0;
                currentNum = 0;
                currentNumLabel.Text = currentNum.ToString();
            }
            userSet.savedStart = startNum;
            userSet.savedCurrent = currentNum;
            userSet.Save();
        }

        private void InitForm_Closed(object sender, FormClosedEventArgs e)
        {
            if(sender != this)
            {
                return;
            }
            if(sp != null)
            {
                if(sp.IsOpen)
                {
                    sp.Close();
                }
                sp.Dispose();
            }
            if(dataBase != null)
            {
                dataBase.Close();
            }
        }

        private void TimeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int index = cb.SelectedIndex;
            string text = (string)cb.Items[index];

            int s = 0;
            foreach(char c in text)
            {
                if(!char.IsDigit(c))
                {
                    break;
                }
                else
                {
                    s = 10 * s + c - '0';
                }
            }
            codeTime = s;
        }

        private void lineNumberChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int n = cb.SelectedIndex;
            for(int i=1;i<=ln.Length;i++)
            {
                if(cb.Name.EndsWith(i.ToString()))
                {
                    ln[i - 1] = n;
                    break;
                }
            }
            lineNumber = ln[0]*100 + ln[1]*10 + ln[2];
            userSet.savedLineNum = lineNumber;
            userSet.Save();
        }

        private void machineNumberChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int n = cb.SelectedIndex;
            for(int i=1;i<=mn.Length;i++)
            {
                if(cb.Name.EndsWith(i.ToString()))
                {
                    mn[i - 1] = n;
                    break;
                }
            }
            machineNumber = mn[0]*100 + mn[1]*10 + mn[2];
            userSet.savedMachineNum = machineNumber;
            userSet.Save();
        }
    }
}
