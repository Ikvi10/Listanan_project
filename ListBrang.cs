using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace List
{
    public partial class ListBrang : Form
    {
        public int selectedId = 0;
        public ListBrang()
        {
            InitializeComponent();
        }



        private void tampildata()
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
            GridViewLst.DataSource = ds.Tables["barang"].DefaultView;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBrang_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void btnTbh_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\";Allow User Variables=True";
            MySqlConnection cnn = new MySqlConnection(constring);
            MySqlCommand cmd;
            cmd = cnn.CreateCommand();
            cmd.CommandText = "INSERT INTO tblist (Id, NamaBrg, Harga)\r\nSELECT Id, NamaBrg, Harga\r\nFROM tbbarang\r\nWHERE Id = @Id;\r\n";
            cmd.Parameters.AddWithValue("Id", selectedId);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("tambahkan ke List berhasil");
                //crud
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambahkan ke List gagal\n" + ex.Message);
            }
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            Dashboard form2 = new Dashboard();

            // Menampilkan form lain
            form2.Show();
            this.Close();
        }

        private void btnInf_Click(object sender, EventArgs e)
        {
            InfoBrg form5 = new InfoBrg();

            form5.Show();
            this.Close();
        }

        private void GridViewLst_SelectionChanged(object sender, EventArgs e)
        {
            if (GridViewLst.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridViewLst.SelectedRows[0];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }
    }
}
