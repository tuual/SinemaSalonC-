using System;
using System.Collections;
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
    public partial class frmSeansGuncelle : Form
    {
        private List<string> seanssaatler = new List<string>();
        public frmSeansGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkboxs()
        {
            if (checkBox1.Checked)
            {
                seanssaatler.Add(checkBox1.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox1.Text);

            }

            if (checkBox2.Checked)
            {
                seanssaatler.Add(checkBox2.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox2.Text);
            }

            if (checkBox3.Checked)
            {
                seanssaatler.Add(checkBox3.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox3.Text);
            }


            if (checkBox4.Checked)
            {
                seanssaatler.Add(checkBox4.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox4.Text);
            }

            if (checkBox5.Checked)
            {
                seanssaatler.Add(checkBox5.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox5.Text);
            }

            if (checkBox6.Checked)
            {
                seanssaatler.Add(checkBox6.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox6.Text);
            }

            if (checkBox7.Checked)
            {
                seanssaatler.Add(checkBox7.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox7.Text);
            }

            if (checkBox8.Checked)
            {
                seanssaatler.Add(checkBox8.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox8.Text);
            }

            if (checkBox9.Checked)
            {
                seanssaatler.Add(checkBox9.Text);

            }
            else
            {
                seanssaatler.Remove(checkBox9.Text);
            }





        }

        private void updateQuery()
        {

        }
    }
}
