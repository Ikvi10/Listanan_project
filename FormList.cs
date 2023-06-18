using MySqlX.XDevAPI.Relational;
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
    public partial class ListBrg : Form
    {

        public ListBrg()
        {
        }

        

        private void FormList_Load(object sender, EventArgs e)
        {
            tampildata();
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
            GridViewList.DataSource = ds.Tables["barang"].DefaultView;
        }
    }
}
