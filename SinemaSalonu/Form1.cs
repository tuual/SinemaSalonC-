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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Visible = true;
            }
            else
            {
                if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("1234"))
                {
                    label4.Visible = true;
                    label4.Text = "Giriş Başarılı";
                    label4.ForeColor = Color.Green;

                    frmMenuler frmmenu = new frmMenuler();
                    frmmenu.Show();
                    this.Hide();
                    
                }
                else
                {

                }
        
            }
        }
    }
}
