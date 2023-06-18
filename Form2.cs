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
    public partial class Dashboard : Form
    {
        private int angka = 1;
        private int h1 = 38000;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnlist_Click(object sender, EventArgs e)
        {

            ListBrang form4 = new ListBrang();

            // Menampilkan form lain
            form4.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoBrg form5 = new InfoBrg();

            form5.Show();
            this.Close();
        }

        private void btnt1_Click(object sender, EventArgs e)
        {
            angka++; // Menambahkan nilai saat tombol "+" diklik
            lbl1.Text = angka.ToString();

            int akali = 2;
            h1 *=akali ;
            lblh1.Text = h1.ToString();
        }



        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnm1_Click(object sender, EventArgs e)
        {
            angka --; // Menambahkan nilai saat tombol "+" diklik
            lbl1.Text = angka.ToString();

            int akali = 38000;
            h1 -= akali;
            lblh1.Text = h1.ToString();
        }
    }
}
