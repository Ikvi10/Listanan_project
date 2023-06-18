using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace List
{
    public partial class Admin : Form
    {
        public int selectedId = 0;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnTes_Click(object sender, EventArgs e)
        {
            String constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\"";
            MySqlConnection cnn = new MySqlConnection(constring);
            try
            {
                cnn.Open();
                MessageBox.Show("Berhasil terhubung ke database");
                //crud
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database" + ex.Message);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            String constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\"";
            MySqlConnection cnn = new MySqlConnection(constring);
            MySqlCommand cmd;
            cmd = cnn.CreateCommand();
            cmd.CommandText = "INSERT INTO tbbarang (namaBrg,Harga) VALUES (@nama,@harga)";
            cmd.Parameters.AddWithValue("nama", tboxNama.Text);
            cmd.Parameters.AddWithValue("harga", boxHrg.Text);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Data");
                //crud
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Input data" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            tampilkandata();
        }

        private void tampilkandata()
        {
            //mengatur koneksi ke database melalui connectionstring
            String constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\"";
            //membuat objek koneksi ke database  (mySqlconecction)
            MySqlConnection cnnn = new MySqlConnection(constring);
            //membuat objek mysqldataadapter
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbbarang", cnnn);
            //objek dataset
            DataSet ds = new DataSet();
            da.Fill(ds, "barang");
            //menampilkan data di gridview
            dataGridViewBrg.DataSource = ds.Tables["barang"].DefaultView;
        }

        private void btnHps_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\";Allow User Variables=True";
            MySqlConnection cnn = new MySqlConnection(constring);
            MySqlCommand cmd;
            cmd = cnn.CreateCommand();
            cmd.CommandText = "DELETE FROM tbbarang WHERE Id=@Id";
            cmd.Parameters.AddWithValue("Id", selectedId);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("hapus Data berhasil");
                //crud
                tampilkandata();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal\n" + ex.Message);
            }
        }

        private void dataGridViewBrg_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBrg.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewBrg.SelectedRows[0];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\";Allow User Variables=True";
            MySqlConnection cnn = new MySqlConnection(constring);
            MySqlCommand cmd;
            cmd = cnn.CreateCommand();
            cmd.CommandText = "UPDATE tbbarang SET NamaBrg = @NewNama, Harga = @NewHarga WHERE Id = @Id";
            cmd.Parameters.AddWithValue("Id", selectedId);
            cmd.Parameters.AddWithValue("NewNama", tboxNama.Text);
            cmd.Parameters.AddWithValue("NewHarga", boxHrg.Text);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data berhasil");
                //crud
                tampilkandata();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal\n" + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
           
        }
    }
}
