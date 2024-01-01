using MySql.Data.MySqlClient;
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
        private MySqlConnection con;
        public frmMenuler()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=sinemasalon; Uid=root; Pwd=''");

        }

        private void filmSeansıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();

            if (con.State != ConnectionState.Closed)
            {
                frmSeansEkle frmSeansEkle = new frmSeansEkle();
                frmSeansEkle.Show();
                con.Close();

            }
            else
            {
                MessageBox.Show("Veri tabanı bağlantısı gerçekleştirelemedi." + MessageBoxIcon.Error);
                con.Close();

            }
            con.Close();

        }

        private void filmSeanslarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            if (con.State != ConnectionState.Closed)
            {
                frmSeanslar frmseans = new frmSeanslar();
                frmseans.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Veri tabanı bağlantısı gerçekleştirelemedi."+MessageBoxIcon.Error);
                con.Close();
            }

        }

    }
}
