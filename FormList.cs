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
    public partial class FormList : Form
    {
        private DataGridViewRow[] rows;

        public FormList()
        {
        }

        public FormList(DataGridViewRowCollection rows)
        {
            
            
        }

        public FormList(DataGridViewRow[] rows)
        {
            InitializeComponent();
            this.rows = rows;
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in rows)
            {
                DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    clonedRow.Cells[i].Value = row.Cells[i].Value;
                }
                GridViewList.Rows.Add(clonedRow);
            }
        }
    }
}
