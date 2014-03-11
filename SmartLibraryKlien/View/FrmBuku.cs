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
using SmartLibraryKlien.Report;

namespace SmartLibraryKlien.View
{
    public partial class FrmBuku : Form, IListener
    {
        private IBukuDao bukuDao = null;

        // constructor
        public FrmBuku()
        {
            InitializeComponent();

            string server = "localhost";
            string port = "1234";
            string uri = "SmartLibraryServer.BukuDao";

            string url = "tcp://" + server + ":" + port + "/" + uri;

            // mendapatkan proxy untuk remote object dari class BukuDao
            bukuDao = (IBukuDao)Activator.GetObject(typeof(IBukuDao), url);

            // tampilkan semua data buku
            LoadDataBuku();            
        }

        // pengaturan propery listview
        private void InisialisasiListView()
        {            
            lvwBuku.View = System.Windows.Forms.View.Details;
            lvwBuku.FullRowSelect = true;
            lvwBuku.GridLines = true;

            lvwBuku.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwBuku.Columns.Add("ISBN", 91, HorizontalAlignment.Left);
            lvwBuku.Columns.Add("Judul", 290, HorizontalAlignment.Left);
            lvwBuku.Columns.Add("Bahasa", 70, HorizontalAlignment.Left);
            lvwBuku.Columns.Add("Edisi", 50, HorizontalAlignment.Left);
            lvwBuku.Columns.Add("Penerbit", 130, HorizontalAlignment.Left);
        }

        // method untuk menampilkan data buku ke listview
        private void FillToListView(bool addData, Buku buku)
        {
            if (addData)
            {
                int noUrut = lvwBuku.Items.Count + 1;

                ListViewItem item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(buku.ISBN);
                item.SubItems.Add(buku.Judul);
                item.SubItems.Add(buku.Bahasa);
                item.SubItems.Add(buku.Edisi);
                item.SubItems.Add(buku.Penerbit.Nama);

                lvwBuku.Items.Add(item);
            }
            else
            {
                int row = lvwBuku.SelectedIndices[0];

                ListViewItem itemRow = lvwBuku.Items[row];
                itemRow.SubItems[2].Text = buku.Judul;
                itemRow.SubItems[3].Text = buku.Bahasa;
                itemRow.SubItems[4].Text = buku.Edisi;
                itemRow.SubItems[5].Text = buku.Penerbit.Nama;
            }
        }

        // method untuk menampilkan semua data buku
        private void LoadDataBuku()
        {
            lvwBuku.Items.Clear();

            List<Buku> daftarBuku = bukuDao.GetAll();
            foreach (Buku buku in daftarBuku)
            {
                FillToListView(true, buku);
            }
        }

        // method untuk menampilkan semua data buku berdasarkan judul
        private void LoadDataBuku(string judul)
        {
            lvwBuku.Items.Clear();

            List<Buku> daftarBuku = bukuDao.GetByName(judul);
            foreach (Buku buku in daftarBuku)
            {
                FillToListView(true, buku);
            }
        }

        private void FrmBuku_Load(object sender, EventArgs e)
        {
            InisialisasiListView();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //frmAddEdit = new FrmAddEditBarang(true, new object[] { });
            //frmAddEdit.Listener = this;
            //frmAddEdit.ShowDialog();  

            FrmAddEditBuku frm = new FrmAddEditBuku(true, this.bukuDao, new object[] { });
            frm.Listener = this;
            frm.ShowDialog();
        }

        public void Ok(bool addData, object[] data)
        {
            Buku buku = new Buku();
            buku.ISBN = data[0].ToString();
            buku.Judul = data[1].ToString();
            buku.Bahasa = data[2].ToString();
            buku.Edisi = data[3].ToString();
            buku.Penerbit.Nama = data[4].ToString();

            if (addData)
            {
                FillToListView(true, buku);
            }
            else
            {
                FillToListView(false, buku);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwBuku.SelectedItems.Count > 0)
            {
                int row = lvwBuku.SelectedIndices[0];

                ListViewItem itemRow = lvwBuku.Items[row];

                string isbn = itemRow.SubItems[1].Text;
                string judul = itemRow.SubItems[2].Text;
                string bahasa = itemRow.SubItems[3].Text;
                string edisi = itemRow.SubItems[4].Text;
                string penerbit = itemRow.SubItems[5].Text;

                object[] data = { isbn, judul, bahasa, edisi, penerbit };

                FrmAddEditBuku frm = new FrmAddEditBuku(false, bukuDao, data);
                frm.Listener = this;
                frm.ShowDialog();

            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwBuku.SelectedItems.Count > 0)
            {
                int row = lvwBuku.SelectedIndices[0];

                ListViewItem itemRow = lvwBuku.Items[row];

                Buku buku = new Buku();
                buku.ISBN = itemRow.SubItems[1].Text;
                buku.Judul = itemRow.SubItems[2].Text;

                string msg = "Apakah data buku '" + buku.Judul + "' ingin dihapus ?";
                if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int result = bukuDao.Delete(buku);
                    if (result > 0) // data barang berhasil dihapus
                    {
                        MessageBox.Show("Data buku berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataBuku();
                    }
                    else
                    {
                        MessageBox.Show("Data buku gagal dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih");
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataBuku(txtJudul.Text);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            ArLapBuku ar = new ArLapBuku();
            DataSet ds = bukuDao.GetReportAll();
            ar.DataSource = ds;
            ar.DataMember = "buku";
            ar.Run(false);            

            FrmPreview frmPrev = new FrmPreview("Laporan Data Buku", ar.Document);
            frmPrev.ShowDialog();

            Cursor.Current = Cursors.Default;
        }        
    }
}