namespace List
{
    partial class FormList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewList = new System.Windows.Forms.DataGridView();
            this.NamaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnlist);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::List.Properties.Resources.logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(489, 22);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(732, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlist.Location = new System.Drawing.Point(648, 32);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(65, 23);
            this.btnlist.TabIndex = 5;
            this.btnlist.Text = "list";
            this.btnlist.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "|";
            // 
            // GridViewList
            // 
            this.GridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaId,
            this.NamaBrg,
            this.Harga});
            this.GridViewList.Location = new System.Drawing.Point(12, 92);
            this.GridViewList.Name = "GridViewList";
            this.GridViewList.RowHeadersWidth = 51;
            this.GridViewList.RowTemplate.Height = 24;
            this.GridViewList.Size = new System.Drawing.Size(701, 346);
            this.GridViewList.TabIndex = 1;
            // 
            // NamaId
            // 
            this.NamaId.HeaderText = "Id";
            this.NamaId.MinimumWidth = 6;
            this.NamaId.Name = "NamaId";
            this.NamaId.Width = 125;
            // 
            // NamaBrg
            // 
            this.NamaBrg.HeaderText = "Nama";
            this.NamaBrg.MinimumWidth = 6;
            this.NamaBrg.Name = "NamaBrg";
            this.NamaBrg.Width = 125;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.Width = 125;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewList);
            this.Controls.Add(this.panel1);
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridViewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
    }
}