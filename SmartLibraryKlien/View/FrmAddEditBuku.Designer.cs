namespace SmartLibraryKlien.View
{
    partial class FrmAddEditBuku
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
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBahasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPenerbit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(282, 153);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(201, 153);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Penerbit";
            // 
            // txtEdisi
            // 
            this.txtEdisi.Location = new System.Drawing.Point(67, 96);
            this.txtEdisi.MaxLength = 2;
            this.txtEdisi.Name = "txtEdisi";
            this.txtEdisi.Size = new System.Drawing.Size(58, 20);
            this.txtEdisi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edisi";
            // 
            // txtBahasa
            // 
            this.txtBahasa.Location = new System.Drawing.Point(67, 68);
            this.txtBahasa.MaxLength = 20;
            this.txtBahasa.Name = "txtBahasa";
            this.txtBahasa.Size = new System.Drawing.Size(121, 20);
            this.txtBahasa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bahasa";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(67, 40);
            this.txtJudul.MaxLength = 255;
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(290, 20);
            this.txtJudul.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Judul";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(67, 12);
            this.txtISBN.MaxLength = 20;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(121, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ISBN";
            // 
            // cmbPenerbit
            // 
            this.cmbPenerbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenerbit.FormattingEnabled = true;
            this.cmbPenerbit.Location = new System.Drawing.Point(67, 124);
            this.cmbPenerbit.Name = "cmbPenerbit";
            this.cmbPenerbit.Size = new System.Drawing.Size(290, 21);
            this.cmbPenerbit.TabIndex = 4;
            // 
            // FrmAddEditBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 185);
            this.Controls.Add(this.cmbPenerbit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBahasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddEditBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Buku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBahasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPenerbit;
    }
}