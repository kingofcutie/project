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
    public partial class Transp : Form
    {
        private SQLiteConnection DB;
        public Transp()
        {
            InitializeComponent();
        }

        private void btnOch_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Транспорт where [список транспорта] like '%' || @transp || '%'";
                CMD.Parameters.Add("@transp", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        textBox1.Text += "Вид транспорта: " + SQL["список транспорта"] + " | Маршруты транспорта: " + SQL["маршрут транспорта"] + "\r\n";
                    }
                }
                else textBox1.Text = "В таблице отсутствует эта информация";
                textBox2.Text = "";
            }
        }

        private void Transp_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = База.db; Version = 3");
            DB.Open();
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Транспорт([список транспорта], [маршрут транспорта]) values( @transp, @marsh)";
                CMD.Parameters.Add("@transp", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                CMD.Parameters.Add("@marsh", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                CMD.ExecuteNonQuery();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Text = "Добавление прошло успешно";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from Транспорт";
            CMD.ExecuteNonQuery();
            textBox1.Text = "Удаление прошло успешно";
        }

        private void btnTabl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Транспорт";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    textBox1.Text += "Вид транспорта: " + SQL["список транспорта"] + " | Маршруты транспорта: " + SQL["маршрут транспорта"] + "\r\n";
                }
            }
            else textBox1.Text = "В таблице отсутствует информация";
        }
    }
}
