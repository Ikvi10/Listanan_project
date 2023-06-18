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

namespace List
{
    public partial class InfoBrg : Form
    {
        public int selectedId = 0;
        public InfoBrg()
        {
            InitializeComponent();
        }

        private void InfoBrg_Load(object sender, EventArgs e)
        {
            tampilInfo();
        }

        private void tampilInfo()
        {
            //mengatur koneksi ke database melalui connectionstring
            String constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\"";
            //membuat objek koneksi ke database  (mySqlconecction)
            MySqlConnection cnnn = new MySqlConnection(constring);
            //membuat objek mysqldataadapter
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tblist", cnnn);
            //objek dataset
            DataSet ds = new DataSet();
            da.Fill(ds, "barang");
            //menampilkan data di gridview
            GridViewInfo.DataSource = ds.Tables["barang"].DefaultView;
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            Dashboard form2 = new Dashboard();

            // Menampilkan form lain
            form2.Show();
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListBrang form4 = new ListBrang();

            // Menampilkan form lain
            form4.Show();
            this.Close();
        }

        private void btnHps_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;database=db_barang;uid=root;pwd=\"\";Allow User Variables=True";
            MySqlConnection cnn = new MySqlConnection(constring);
            MySqlCommand cmd;
            cmd = cnn.CreateCommand();
            cmd.CommandText = "DELETE FROM tblist WHERE Id=@Id";
            cmd.Parameters.AddWithValue("Id", selectedId);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("hapus Data berhasil");
                //crud
                tampilInfo();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal\n" + ex.Message);
            }
        }

        private void GridViewInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (GridViewInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridViewInfo.SelectedRows[0];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }
    }
}
