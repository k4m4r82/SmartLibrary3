using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace SmartLibraryKlien.Report
{
    /// <summary>
    /// Summary description for ArLapBuku.
    /// </summary>
    public partial class ArLapBuku : DataDynamics.ActiveReports.ActiveReport3
    {

        public ArLapBuku()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private static void SetAutoHeight(object detail, object control)
        {
            ((ARControl)control).Height = ((Detail)detail).Height;
        }

        private void detail_Format(object sender, EventArgs e)
        {
            txtNo.Text = Convert.ToString(int.Parse(txtNo.Text) + 1);
            txtISBN.Text = this.Fields["isbn"].Value.ToString();
            txtJudul.Text = this.Fields["judul"].Value.ToString();
            txtPenerbit.Text = this.Fields["penerbit"].Value.ToString();
        }

        private void detail_BeforePrint(object sender, EventArgs e)
        {
            SetAutoHeight(sender, txtNo);
            SetAutoHeight(sender, txtISBN);
            SetAutoHeight(sender, txtJudul);
            SetAutoHeight(sender, txtPenerbit);
        }
    }
}
