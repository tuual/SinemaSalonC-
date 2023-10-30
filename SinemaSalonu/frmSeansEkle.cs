using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SinemaSalonu
{
    public partial class frmSeansEkle : Form
    {
        private bool checkBox2Added = false;
        private int sayac = 0;
        private List<string> seanssaatler = new List<string>();

        private MySqlConnection con;
        private MySqlCommand cmd;
        public frmSeansEkle()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=sinemasalon; Uid=root; Pwd=''");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            checkboxs();

           string joinedSeanssaatler = string.Join(", ", seanssaatler);
            MessageBox.Show(joinedSeanssaatler);
            insertMethod(joinedSeanssaatler);
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

        private void insertMethod(String saatler) {
            try
            {
                String query = "INSERT INTO tblseans(filmadi,filmkonusu	,filmsuresi	,salonno, seanstarih, seanssaatler) VALUES(@filmadi,@filmkonusu,@filmsuresi,@salonno,@seanstarih,@seanssaatler)";
                cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@filmadi", textBox1.Text);
                cmd.Parameters.AddWithValue("@filmkonusu", textBox2.Text);
                cmd.Parameters.AddWithValue("@filmsuresi", textBox3.Text);
                cmd.Parameters.AddWithValue("@salonno", textBox6.Text);
                cmd.Parameters.AddWithValue("@seanstarih", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@seanssaatler", saatler);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }





        }
    }

}
