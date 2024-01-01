using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private int lineID;
        private frmSeanslar seanslar1;
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private List<string> seansaatlerArray = new List<string>();

        public frmSeansGuncelle(frmSeanslar seanslar, int id)
        {
            InitializeComponent();
            lineID = id;
            seanslar1 = seanslar;
            con = new MySqlConnection("Server=localhost; Database=sinemasalon; Uid=root; Pwd='';");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkboxs();
            string joinedSeanssaatler = string.Join(", ", seanssaatler);
            MessageBox.Show(joinedSeanssaatler);

            updateData(joinedSeanssaatler);
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

        private void frmSeansGuncelle_Load(object sender, EventArgs e)
        {
            MessageBox.Show(lineID.ToString());
            veriGetirme();
        }

        private void veriGetirme()
        {
            String query = "Select * From tblSeans WHERE ID=" + lineID;
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["filmadi"].ToString().Trim();
                textBox2.Text = reader["filmkonusu"].ToString().Trim();
                textBox3.Text = reader["filmsuresi"].ToString().Trim();
                textBox6.Text = reader["salonno"].ToString().Trim();
                dateTimePicker1.Text = reader["seanstarih"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Eşleşen Veri Bulunamadı");
            }
            reader.Close();
            con.Close();

        }
        private void updateData(String saatler)
        {

            String updateQuery = "UPDATE tblSeans SET filmadi=@filmadi,filmkonusu=@filmkonusu,filmsuresi=@filmsuresi,salonno=@salonno,seanstarih=@seanstarih,seanssaatler=@seanssaatler WHERE ID="+lineID;
            cmd = new MySqlCommand(updateQuery, con);
            con.Open();
            cmd.Parameters.AddWithValue("@filmadi",textBox1.Text);
            cmd.Parameters.AddWithValue("@filmkonusu",textBox2.Text);
            cmd.Parameters.AddWithValue("@filmsuresi",textBox3.Text);
            cmd.Parameters.AddWithValue("@salonno",textBox6.Text);
            cmd.Parameters.AddWithValue("@seanstarih", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@seanssaatler",saatler);
            cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
       

        
    }        

}
