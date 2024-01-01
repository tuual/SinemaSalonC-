using MySql.Data.MySqlClient;
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
    public partial class frmSeanslar : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private int id;

        public frmSeanslar()
        {
            InitializeComponent();
        }

        private void frmSeanslar_Load(object sender, EventArgs e)
        {
            tableUpdate();
        }

        private void tableUpdate()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;

            string query = "SELECT * FROM tblseans";
            con = new MySqlConnection("Server=localhost; Database=sinemasalon; Uid=root; Pwd=''");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }



        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            verisilme(e);
        }

        private void verisilme(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];
                    id = Convert.ToInt32(selectRow.Cells["ID"].Value);
                    String query = "Delete From uyeler WHERE ID=" + id;


                }
                else
                {
                    MessageBox.Show("Veri Bulunamadı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String silmequery = "DELETE FROM tblseans WHERE ID =" + id;
            con.Open();
            cmd = new MySqlCommand(silmequery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            con.Close();
            tableUpdate();
            id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSeansGuncelle seansGuncelle = new frmSeansGuncelle(this, id);
            if (id != null)
            {
                seansGuncelle.ShowDialog();
            }
            else
            {
                MessageBox.Show("ok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableUpdate();
        }
    }
}
