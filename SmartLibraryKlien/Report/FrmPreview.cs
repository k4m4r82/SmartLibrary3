using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataDynamics.ActiveReports.Document;

namespace SmartLibraryKlien.Report
{
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();
        }

        public FrmPreview(string header, Document document)
            : this()
        {
            this.Text = header;
            ARViewer.Document = document;
        }
    }
}

