using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSalonu
{
    public partial class frmMenuler : Form
    {
        public frmMenuler()
        {
            InitializeComponent();
        }

        private void filmSeansıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeansEkle frmSeansEkle = new frmSeansEkle();
            frmSeansEkle.Show();
            
        }

        private void filmSeanslarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeanslar frmseans = new frmSeanslar();
            frmseans.Show();
        }

    }
}
