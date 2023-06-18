namespace List
{
    partial class ListBrang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInf = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridViewLst = new System.Windows.Forms.DataGridView();
            this.btnTbh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLst)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInf);
            this.panel1.Controls.Add(this.btnBck);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInf
            // 
            this.btnInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(107)))), ((int)(((byte)(142)))));
            this.btnInf.Location = new System.Drawing.Point(728, 35);
            this.btnInf.Name = "btnInf";
            this.btnInf.Size = new System.Drawing.Size(60, 23);
            this.btnInf.TabIndex = 3;
            this.btnInf.Text = "info";
            this.btnInf.UseVisualStyleBackColor = false;
            this.btnInf.Click += new System.EventHandler(this.btnInf_Click);
            // 
            // btnBck
            // 
            this.btnBck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(107)))), ((int)(((byte)(142)))));
            this.btnBck.Location = new System.Drawing.Point(662, 35);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(60, 23);
            this.btnBck.TabIndex = 2;
            this.btnBck.Text = "Back";
            this.btnBck.UseVisualStyleBackColor = false;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 22);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::List.Properties.Resources.logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GridViewLst
            // 
            this.GridViewLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewLst.Location = new System.Drawing.Point(23, 108);
            this.GridViewLst.Name = "GridViewLst";
            this.GridViewLst.RowHeadersWidth = 51;
            this.GridViewLst.RowTemplate.Height = 24;
            this.GridViewLst.Size = new System.Drawing.Size(474, 287);
            this.GridViewLst.TabIndex = 1;
            this.GridViewLst.SelectionChanged += new System.EventHandler(this.GridViewLst_SelectionChanged);
            // 
            // btnTbh
            // 
            this.btnTbh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(107)))), ((int)(((byte)(142)))));
            this.btnTbh.Location = new System.Drawing.Point(526, 236);
            this.btnTbh.Name = "btnTbh";
            this.btnTbh.Size = new System.Drawing.Size(245, 39);
            this.btnTbh.TabIndex = 2;
            this.btnTbh.Text = "Tambah Barang";
            this.btnTbh.UseVisualStyleBackColor = false;
            this.btnTbh.Click += new System.EventHandler(this.btnTbh_Click);
            // 
            // ListBrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTbh);
            this.Controls.Add(this.GridViewLst);
            this.Controls.Add(this.panel1);
            this.Name = "ListBrang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBrang";
            this.Load += new System.EventHandler(this.ListBrang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInf;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView GridViewLst;
        private System.Windows.Forms.Button btnTbh;
    }
}