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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void btnTransp_Click(object sender, EventArgs e)
        {
            Transp transp = new Transp();
            transp.ShowDialog();
        }

        private void btnVid_Click(object sender, EventArgs e)
        {
            Vid vid = new Vid();
            vid.ShowDialog();
        }

        private void btnKoshel_Click(object sender, EventArgs e)
        {
            Koshel koshel = new Koshel();
            koshel.ShowDialog();
        }

        private void btnOstan_Click(object sender, EventArgs e)
        {
            Ostan ostan = new Ostan();
            ostan.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void btnRaspis_Click(object sender, EventArgs e)
        {
            RaspisDvizh raspis = new RaspisDvizh();
            raspis.ShowDialog();
        }

        private void btnTalon_Click(object sender, EventArgs e)
        {
            Talon talon = new Talon();
            talon.ShowDialog();
        }
    }
}
