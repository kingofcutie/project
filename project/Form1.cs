using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект
{
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void btnVhod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "1234")
            {
                this.Close();
                Base bas = new Base();
                bas.ShowDialog();
            }
        }
    }
}
