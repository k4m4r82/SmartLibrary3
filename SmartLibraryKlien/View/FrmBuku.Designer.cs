namespace SmartLibraryKlien.View
{
    partial class FrmBuku
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
            this.lvwBuku = new System.Windows.Forms.ListView();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnPerbaiki = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwBuku
            // 
            this.lvwBuku.Location = new System.Drawing.Point(12, 12);
            this.lvwBuku.Name = "lvwBuku";
            this.lvwBuku.Size = new System.Drawing.Size(665, 335);
            this.lvwBuku.TabIndex = 8;
            this.lvwBuku.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(601, 402);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 7;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(174, 402);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPerbaiki
            // 
            this.btnPerbaiki.Location = new System.Drawing.Point(91, 402);
            this.btnPerbaiki.Name = "btnPerbaiki";
            this.btnPerbaiki.Size = new System.Drawing.Size(75, 23);
            this.btnPerbaiki.TabIndex = 5;
            this.btnPerbaiki.Text = "Perbaiki";
            this.btnPerbaiki.UseVisualStyleBackColor = true;
            this.btnPerbaiki.Click += new System.EventHandler(this.btnPerbaiki_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 402);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtJudul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 47);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " [ Pencarian ] ";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(616, 19);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(43, 20);
            this.btnCari.TabIndex = 12;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(72, 19);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(538, 20);
            this.txtJudul.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Judul Buku";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(255, 402);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // FrmBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwBuku);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnPerbaiki);
            this.Controls.Add(this.btnTambah);
            this.MaximizeBox = false;
            this.Name = "FrmBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Buku";
            this.Load += new System.EventHandler(this.FrmBuku_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBuku;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnPerbaiki;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnPreview;
    }
}