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
    public partial class RaspisDvizh : Form
    {
        private SQLiteConnection DB;
        public RaspisDvizh()
        {
            InitializeComponent();
        }

        private void RaspisDvizh_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = База.db; Version = 3");
            DB.Open();
        }

        private void btnOch_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox1.Text = "";
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from [Расписание движения] where [Список видов остановок] like '%' || @ostan || '%'";
                CMD.Parameters.Add("@ostan", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        textBox1.Text += "Название остановки: " + SQL["Список видов остановок"] + " | Список маршрутов транспорта: " + SQL["Список маршрутов транспорта"] + " | Время прибытия транспорта: " + SQL["Время прибытия транспорта"] + "\r\n";
                    }
                }
                else textBox1.Text = "В таблице отсутствует эта информация";
                textBox3.Text = "";
            }
        }

        private void btnTabl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from [Расписание движения]";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    textBox1.Text += "Название остановки: " + SQL["Список видов остановок"] + " | Список маршрутов транспорта: " + SQL["Список маршрутов транспорта"] + " | Время прибытия транспорта: " + SQL["Время прибытия транспорта"] + "\r\n";
                }
            }
            else textBox1.Text = "В таблице отсутствует информация";
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into [Расписание движения]([Список видов остановок], [Список маршрутов транспорта], [Время прибытия транспорта]) values( @ostan, @marsh, @time)";
                CMD.Parameters.Add("@ostan", System.Data.DbType.String).Value = textBox3.Text.ToUpper();
                CMD.Parameters.Add("@marsh", System.Data.DbType.String).Value = textBox2.Text.ToUpper();
                CMD.Parameters.Add("@time", System.Data.DbType.String).Value = textBox4.Text.ToUpper();
                CMD.ExecuteNonQuery();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Text = "Добавление прошло успешно";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "delete from [Расписание движения]";
            CMD.ExecuteNonQuery();
            textBox1.Text = "Удаление прошло успешно";
        }
    }
}
