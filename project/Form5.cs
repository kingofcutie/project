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
    public partial class Talon : Form
    {
        private SQLiteConnection DB;
        public Talon()
        {
            InitializeComponent();
        }

        private void Talon_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = База.db; Version = 3");
            DB.Open();
        }

        private void btnOch_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Талон where [стоимость талона] like '%' || @talon || '%'";
                CMD.Parameters.Add("@talon", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        textBox1.Text += "Стоимость талона: " + SQL["стоимость талона"] + " | Список приобретенных талонов: " + SQL["список приобретенных талонов"] + "\r\n";
                    }
                }
                else textBox1.Text = "В таблице отсутствует эта информация";
                textBox2.Text = "";
            }
        }

        private void btnTabl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Талон";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    textBox1.Text += "Стоимость талона: " + SQL["стоимость талона"] + " | Список приобретенных талонов: " + SQL["список приобретенных талонов"] + "\r\n";
                }
            }
            else textBox1.Text = "В таблице отсутствует информация";
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Талон([стоимость талона]) values( @price)";
                CMD.Parameters.Add("@price", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                CMD.ExecuteNonQuery();
                textBox2.Text = "";
                textBox1.Text = "Добавление прошло успешно";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from Талон";
            CMD.ExecuteNonQuery();
            textBox1.Text = "Удаление прошло успешно";
        }
    }
}
