namespace List
{
    partial class Admin
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnHps = new System.Windows.Forms.Button();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.boxHrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTes = new System.Windows.Forms.Button();
            this.dataGridViewBrg = new System.Windows.Forms.DataGridView();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInput.Location = new System.Drawing.Point(131, 214);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(113, 35);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Tambah";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnHps
            // 
            this.btnHps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHps.Location = new System.Drawing.Point(671, 288);
            this.btnHps.Name = "btnHps";
            this.btnHps.Size = new System.Drawing.Size(101, 40);
            this.btnHps.TabIndex = 1;
            this.btnHps.Text = "Hapus data";
            this.btnHps.UseVisualStyleBackColor = false;
            this.btnHps.Click += new System.EventHandler(this.btnHps_Click);
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(92, 102);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(196, 22);
            this.tboxNama.TabIndex = 3;
            // 
            // boxHrg
            // 
            this.boxHrg.Location = new System.Drawing.Point(92, 173);
            this.boxHrg.Name = "boxHrg";
            this.boxHrg.Size = new System.Drawing.Size(196, 22);
            this.boxHrg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daftar Sembako";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga";
            // 
            // btnTes
            // 
            this.btnTes.Location = new System.Drawing.Point(316, 293);
            this.btnTes.Name = "btnTes";
            this.btnTes.Size = new System.Drawing.Size(112, 31);
            this.btnTes.TabIndex = 10;
            this.btnTes.Text = "tes koneksi";
            this.btnTes.UseVisualStyleBackColor = true;
            this.btnTes.Click += new System.EventHandler(this.btnTes_Click);
            // 
            // dataGridViewBrg
            // 
            this.dataGridViewBrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrg.Location = new System.Drawing.Point(316, 99);
            this.dataGridViewBrg.Name = "dataGridViewBrg";
            this.dataGridViewBrg.RowHeadersWidth = 51;
            this.dataGridViewBrg.RowTemplate.Height = 24;
            this.dataGridViewBrg.Size = new System.Drawing.Size(456, 183);
            this.dataGridViewBrg.TabIndex = 11;
            this.dataGridViewBrg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewBrg.SelectionChanged += new System.EventHandler(this.dataGridViewBrg_SelectionChanged);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpd.Location = new System.Drawing.Point(131, 272);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(113, 35);
            this.btnUpd.TabIndex = 12;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSimpan.Location = new System.Drawing.Point(512, 293);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 35);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::List.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.dataGridViewBrg);
            this.Controls.Add(this.btnTes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxHrg);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.btnHps);
            this.Controls.Add(this.btnInput);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnHps;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox boxHrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTes;
        private System.Windows.Forms.DataGridView dataGridViewBrg;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnSimpan;
    }
}