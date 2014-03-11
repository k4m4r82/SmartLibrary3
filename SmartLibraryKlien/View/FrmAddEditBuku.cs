using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// namespace utk mengakses interface dao dan class model
using SmartLibraryLib.IDao;
using SmartLibraryLib.Model;

namespace SmartLibraryKlien.View
{
    public partial class FrmAddEditBuku : Form
    {
        private IPenerbitDao penerbitDao = null;
        private IBukuDao bukuDao = null;

        private List<int> penerbitID = new List<int>();
        private bool addData = false;

        // constructor
        public FrmAddEditBuku()
        {
            InitializeComponent();

            string server = "localhost";
            string port = "1234";
            string uri = "SmartLibraryServer.PenerbitDao";

            string url = "tcp://" + server + ":" + port + "/" + uri;

            // mendapatkan proxy untuk remote object dari class PenerbitDao
            penerbitDao = (IPenerbitDao)Activator.GetObject(typeof(IPenerbitDao), url);

            LoadPenerbit(cmbPenerbit);
        }

        public FrmAddEditBuku(bool addData, IBukuDao bukuDao, object[] data)
            : this()
        {
            this.addData = addData;
            this.bukuDao = bukuDao;

            if (!addData)
            {
                txtISBN.Enabled = false;

                txtISBN.Text = data[0].ToString();
                txtJudul.Text = data[1].ToString();
                txtBahasa.Text = data[2].ToString();
                txtEdisi.Text = data[3].ToString();
                cmbPenerbit.Text = data[4].ToString();
            }
            
        }

        private IListener _listener;
        public virtual IListener Listener
        {
            set { _listener = value; }
        }

        private void LoadPenerbit(ComboBox obj)
        {
            obj.Items.Clear();

            List<Penerbit> daftarPenerbit = penerbitDao.GetAll();
            foreach (Penerbit penerbit in daftarPenerbit)
            {
                penerbitID.Add(penerbit.PenerbitID);
                obj.Items.Add(penerbit.Nama);                
            }
            if (obj.Items.Count > 0) obj.SelectedIndex = 0;
        }

        private void ResetInput()
        {
            txtISBN.Clear();
            txtJudul.Clear();
            txtBahasa.Clear();
            txtEdisi.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int result = 0;

            Buku buku = new Buku();
            buku.ISBN = txtISBN.Text;
            buku.Judul = txtJudul.Text;
            buku.Bahasa = txtBahasa.Text;
            buku.Edisi = txtEdisi.Text;
            buku.Penerbit.PenerbitID = penerbitID[cmbPenerbit.SelectedIndex];

            object[] data = new object[] { buku.ISBN, buku.Judul, buku.Bahasa, buku.Edisi, cmbPenerbit.Text };
            if (this.addData) // data baru
            {
                result = bukuDao.Save(buku);
                if (result > 0)
                {
                    if (this._listener != null) this._listener.Ok(this.addData, data);

                    ResetInput();
                    txtISBN.Focus();
                }
                else
                {
                    MessageBox.Show("Data buku gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                result = bukuDao.Update(buku);
                if (result > 0)
                {
                    if (this._listener != null) this._listener.Ok(this.addData, data);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data buku gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}