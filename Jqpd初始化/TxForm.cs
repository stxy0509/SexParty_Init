using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SQLite;
namespace JqpdInit
{
    public partial class TX_Form : Form
    {
        const int bitRate = 57600;
        const int maxNum = 99999;
        private bool portSelect = false;
        private SerialPort sp = null;
        private string[] allPortNames;       
        private SQLiteCommand command;
        public static SQLiteConnection dataBase;
        private void AddNewRecord()
        {
            int m_num = Program.machineNumber * 100000 + Program.currentNum;
            try
            {
                string tempString = "insert into jqpd values(datetime('now','localtime'),";
                command.CommandText = tempString + Program.lineNumber + "," + m_num + ");";
                command.ExecuteNonQuery();
            }
            catch(SQLiteException sqlex)
            {
                command.CommandText = "create table jqpd(time text,ln int,mn int);";
                command.ExecuteNonQuery();

                string tempString = "insert into jqpd values(datetime('now','localtime'),";
                command.CommandText = tempString + Program.lineNumber + "," + m_num + ");";
                command.ExecuteNonQuery();
            }
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

        public TX_Form()
        {
            InitializeComponent();
            Num_Start.Text = Program.startNum.ToString();
            Num_Current.Text = Program.currentNum.ToString();
            dataBase = new SQLiteConnection("Data Source=jqpd.db");
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

        private void AllLabels_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {           
            byte[] buff = new byte[12];
            int m_num = Program.machineNumber * 100000 + Program.currentNum;
            buff[0] = (byte)0xCA;
            buff[1] = (byte)0xD0;
            buff[2] = (byte)(Program.lineNumber / 200);
            buff[3] = (byte)(Program.lineNumber % 200);

            buff[4] = (byte)(m_num / (200 * 200 * 200) % 200);
            buff[5] = (byte)(m_num / (200 * 200) % 200);
            buff[6] = (byte)(m_num / (200) % 200);
            buff[7] = (byte)(m_num / (1) % 200);

            buff[8]  = (byte)(Program.nCodeTime / 200);
            buff[9]  = (byte)(Program.nCodeTime % 200);
            buff[10] = (byte)(Program.sale % 200);
            buff[11] = (byte)0xCB;

            if(!portSelect)
            {
                foreach(string port in allPortNames)
                {
                    sp = new SerialPort(port,bitRate,Parity.None,8,StopBits.One);
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
                        AddNewRecord();
                        ++Program.currentNum;
                        if(Program.currentNum > maxNum)
                        {
                            Program.currentNum = 1;
                        }
                        Num_Current.Text = Program.currentNum.ToString();
                        MessageBox.Show("保存成功!");
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
                    MessageBox.Show("保存失败！");
                }
                else
                {
                    AddNewRecord();
                    ++Program.currentNum;
                    if(Program.currentNum > maxNum)
                    {
                        Program.currentNum = 1;
                    }
                    Num_Current.Text = Program.currentNum.ToString();
                    MessageBox.Show("保存成功!");
                }
            }                            
        }

        private void SaleTypeButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "公司台")
            {
                b.Text = "买卖台";
                Program.sale = 1;
            }
            else
            {
                b.Text = "公司台";
                Program.sale = 0;
            }
        }

        private void CodeTimeButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int s = 0;
            foreach(char c in b.Text)
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
            switch(s)
            {
                case 20: s = 30;break;
                case 30: s = 40; break;
                case 40: s = 50; break;
                case 50: s = 60; break;
                case 60: s = 80; break;
                case 80: s = 100; break;
                case 100: s = 120; break;
                case 120: s = 150; break;
                case 150: s = 180; break;
                default: s = 20; break;
            }
            Program.nCodeTime = s;
            b.Text = s.ToString() + "小时";
        }

        private void LineNumButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int s = int.Parse(b.Text);
            s = (s + 1) % 10;
            for(int i = 1; i <= 3;i++ )
            {
                if(b.Name.EndsWith(i.ToString()))
                {
                    Program.ln[i - 1] = s;
                    break;
                }
            }
            Program.lineNumber = Program.ln[0] * 100 + Program.ln[1] * 10 + Program.ln[2];
            b.Text = s.ToString();
        }

        private void MachineNumButton_Click(object sender, EventArgs e)
        {
            int i;
            Button b = (Button)sender;
            int s = int.Parse(b.Text);
            s = (s + 1) % 10;
            for(i = 0; i < Program.mn.Length; i++)
            {
                if(b.Name.EndsWith((i + 1).ToString()))
                {
                    Program.mn[i] = s;
                    break;
                }
            }
            b.Text = s.ToString();
            int sum = 0;
            for(i = 0; i < Program.mn.Length; i++)
            {
                sum = 10 * sum + Program.mn[i];
            }
            Program.machineNumber = sum;
        }

        private void DbViewButton_Click(object sender, EventArgs e)
        {
            DbViewForm f = new DbViewForm();
            f.ShowDialog();
        }

        private void MinusOneButton_Click(object sender, EventArgs e)
        {
            if(Program.currentNum > Program.startNum)
            {
                --Program.currentNum;
            }
            else
            {
                Program.currentNum = Program.startNum;
            }
            Num_Current.Text = Program.currentNum.ToString();
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
                Program.startNum = n;
                Program.currentNum = Program.startNum;
                Num_Current.Text = Program.currentNum.ToString();
                tb.Text = n.ToString();
            }
            catch(System.Exception  ex)
            {
                Program.startNum = 0;
                Program.currentNum = 0;
                Num_Current.Text = Program.currentNum.ToString();
            }            
        }

        private void TxForm_Closed(object sender, FormClosedEventArgs e)
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
    }
}
