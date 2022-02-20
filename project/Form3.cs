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
    public partial class User : Form
    {
        private SQLiteConnection DB;
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = База.db; Version = 3");
            DB.Open();
        }

        private void btnTabl_Click(object sender, EventArgs e)
        {
            tbResults.Text = "";
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Пользователь";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    tbResults.Text += "Аккаунт: " + SQL["Аккаунт"] + " | Пароль: " + SQL["Пароль"] + " | Список избранных маршрутов: " + SQL["Список избранных маршрутов"] + " | Список избранных остановок: " + SQL["Список избранных остановок"] + " | Данные банковской карты: " + SQL["Данные банковской карты"] + "\r\n";
                }
            }
            else tbResults.Text = "В таблице отсутствует информация";
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Пользователь(Аккаунт, Пароль, [Список избранных маршрутов], [Список избранных остановок], [Данные банковской карты]) values( @akk , @parol, @spisIzbrMarsh, @spisIzbrOstan, @card)";
                CMD.Parameters.Add("@akk", System.Data.DbType.String).Value = textBox1.Text.ToUpper();
                CMD.Parameters.Add("@parol", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                CMD.Parameters.Add("@spisIzbrMarsh", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                CMD.Parameters.Add("@spisIzbrOstan", System.Data.DbType.String).Value = textBox4.Text.ToUpper();
                CMD.Parameters.Add("@card", System.Data.DbType.String).Value = textBox5.Text.ToUpper();
                CMD.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                tbResults.Text = "Добавление прошло успешно";
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from Пользователь";
            CMD.ExecuteNonQuery();
            tbResults.Text = "Удаление прошло успешно";
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Пользователь where Аккаунт like '%' || @akk || '%'";
                CMD.Parameters.Add("@akk", System.Data.DbType.String).Value = textBox1.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        tbResults.Text += "Аккаунт: " + SQL["Аккаунт"] + " | Пароль: " + SQL["Пароль"] + " | Список избранных маршрутов: " + SQL["Список избранных маршрутов"] + " | Список избранных остановок: " + SQL["Список избранных остановок"] + " | Данные банковской карты: " + SQL["Данные банковской карты"] + "\r\n";
                    }
                }
                else tbResults.Text = "В таблице отсутствует эта информация";
                textBox1.Text = "";
            }
        }

        private void btnOch_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
