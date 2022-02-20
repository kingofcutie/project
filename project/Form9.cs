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
    public partial class Ostan : Form
    {
        private SQLiteConnection DB;
        public Ostan()
        {
            InitializeComponent();
        }

        private void Ostan_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = База.db; Version = 3");
            DB.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Остановка([Название остановки], [Список остановок]) values( @name, @spis)";
                CMD.Parameters.Add("@name", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                CMD.Parameters.Add("@spis", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                CMD.ExecuteNonQuery();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Text = "Добавление прошло успешно";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Остановка where [Название остановки] like '%' || @name || '%'";
                CMD.Parameters.Add("@name", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        textBox1.Text += "Название остановки: " + SQL["Название остановки"] + " | Список остановок: " + SQL["Список остановок"] + "\r\n";
                    }
                }
                else textBox1.Text = "В таблице отсутствует эта информация";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from Остановка";
            CMD.ExecuteNonQuery();
            textBox1.Text = "Удаление прошло успешно";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Остановка";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    textBox1.Text += "Название остановки: " + SQL["Название остановки"] + " | Список остановок: " + SQL["Список остановок"] + "\r\n";
                }
            }
            else textBox1.Text = "В таблице отсутствует информация";
        }
    }
}
