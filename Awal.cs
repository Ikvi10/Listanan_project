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
    public partial class Awal : Form
    {
        public Awal()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Menampilkan form lain
            form1.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin form3 = new Admin();

            // Menampilkan form lain
            form3.Show();
        }
    }
}
