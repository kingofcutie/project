using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace проект
{
    public partial class Vid : Form
    {
        private SQLiteConnection DB;
        public Vid()
        {
            InitializeComponent();
        }

        private void Vid_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = База.db; Version = 3");
            DB.Open();
        }

        private void btnOch_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnTabl_Click(object sender, EventArgs e)
        {
            tbResults.Text = "";
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Вид";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    tbResults.Text += "Вид: " + SQL["Вид"] + " | Цена талона: " + SQL["Цена талона"] + "\r\n";
                }
            }
            else tbResults.Text = "В таблице отсутствует информация";
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                tbResults.Text = "";
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Вид where Вид like '%' || @vid || '%'";
                CMD.Parameters.Add("@vid", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        tbResults.Text += "Вид: " + SQL["Вид"] + " | Цена талона: " + SQL["цена талона"] + "\r\n";
                    }
                }
                else tbResults.Text = "В таблице отсутствует эта информация";
                textBox3.Text = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from Вид";
            CMD.ExecuteNonQuery();
            tbResults.Text = "Удаление прошло успешно";
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Вид(Вид, [цена талона]) values( @vid , @price)";
                CMD.Parameters.Add("@vid", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                CMD.Parameters.Add("@price", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                CMD.ExecuteNonQuery();
                textBox2.Text = "";
                textBox3.Text = "";
                tbResults.Text = "Добавление прошло успешно";
            }
        }
    }
}
