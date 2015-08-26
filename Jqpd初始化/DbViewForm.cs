using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace JqpdInit
{
    public partial class DbViewForm : Form
    {
        public DbViewForm()
        {
            InitializeComponent();
            dataTable.GridLines = true;     //表格是否显示网格线
            dataTable.FullRowSelect = true; //是否选中整行

            dataTable.View = View.Details;  //设置显示方式
            dataTable.Scrollable = true;    //是否自动显示滚动条
            dataTable.MultiSelect = false;  //是否可以选择多行

            //添加表头（列）
            dataTable.Columns.Add("序号",      60, HorizontalAlignment.Center);
            dataTable.Columns.Add("时间",     200, HorizontalAlignment.Center);
            dataTable.Columns.Add("线号",      80, HorizontalAlignment.Center);
            dataTable.Columns.Add("机台号码", 140, HorizontalAlignment.Center);

            int i = 0;
            SQLiteDataReader reader;
            SQLiteCommand command = TX_Form.dataBase.CreateCommand();
            command.CommandText = "select * from jqpd;";
            try
            {            
                 reader = command.ExecuteReader();
            }
            catch(SQLiteException sqlex)
            {
                command.CommandText = "create table jqpd(time text,ln int,mn int);";
                command.ExecuteNonQuery();

                command.CommandText = "select * from jqpd;";
                reader = command.ExecuteReader();
            }   
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();
                item.SubItems[0].Text = (i + 1).ToString();
                item.SubItems.Add(reader.GetString(0));
                item.SubItems.Add(reader.GetInt32(1).ToString("d3"));
                item.SubItems.Add(reader.GetInt32(2).ToString("d8"));
                dataTable.Items.Add(item);
                ++i;
            }
        }

        private void DataTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
