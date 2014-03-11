namespace SmartLibraryKlien.Report
{
    /// <summary>
    /// Summary description for ArLapBuku.
    /// </summary>
    partial class ArLapBuku
    {
        private DataDynamics.ActiveReports.PageHeader pageHeader;
        private DataDynamics.ActiveReports.Detail detail;
        private DataDynamics.ActiveReports.PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ArLapBuku));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtNo = new DataDynamics.ActiveReports.TextBox();
            this.txtISBN = new DataDynamics.ActiveReports.TextBox();
            this.txtJudul = new DataDynamics.ActiveReports.TextBox();
            this.txtPenerbit = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJudul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenerbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5});
            this.pageHeader.Height = 0.7604167F;
            this.pageHeader.Name = "pageHeader";
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.Black;
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.LeftColor = System.Drawing.Color.Black;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.TopColor = System.Drawing.Color.Black;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Height = 0.25F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.0625F;
            this.label1.Name = "label1";
            this.label1.Style = "ddo-char-set: 0; text-align: center; font-size: 14.25pt; ";
            this.label1.Text = "LAPORAN DATA BUKU";
            this.label1.Top = 0.125F;
            this.label1.Width = 6.375F;
            // 
            // label2
            // 
            this.label2.Border.BottomColor = System.Drawing.Color.Black;
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.LeftColor = System.Drawing.Color.Black;
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.RightColor = System.Drawing.Color.Black;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.TopColor = System.Drawing.Color.Black;
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Height = 0.1875F;
            this.label2.HyperLink = null;
            this.label2.Left = 0.0625F;
            this.label2.Name = "label2";
            this.label2.Style = "text-align: center; background-color: #E0E0E0; font-size: 8pt; ";
            this.label2.Text = "No.";
            this.label2.Top = 0.5625F;
            this.label2.Width = 0.3125F;
            // 
            // label3
            // 
            this.label3.Border.BottomColor = System.Drawing.Color.Black;
            this.label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.LeftColor = System.Drawing.Color.Black;
            this.label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.RightColor = System.Drawing.Color.Black;
            this.label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.TopColor = System.Drawing.Color.Black;
            this.label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Height = 0.1875F;
            this.label3.HyperLink = null;
            this.label3.Left = 0.375F;
            this.label3.Name = "label3";
            this.label3.Style = "text-align: center; background-color: #E0E0E0; font-size: 8pt; ";
            this.label3.Text = "ISBN";
            this.label3.Top = 0.5625F;
            this.label3.Width = 1.1875F;
            // 
            // label4
            // 
            this.label4.Border.BottomColor = System.Drawing.Color.Black;
            this.label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Border.LeftColor = System.Drawing.Color.Black;
            this.label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Border.RightColor = System.Drawing.Color.Black;
            this.label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.TopColor = System.Drawing.Color.Black;
            this.label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Height = 0.1875F;
            this.label4.HyperLink = null;
            this.label4.Left = 1.5625F;
            this.label4.Name = "label4";
            this.label4.Style = "text-align: center; background-color: #E0E0E0; font-size: 8pt; ";
            this.label4.Text = "Judul";
            this.label4.Top = 0.5625F;
            this.label4.Width = 3.125F;
            // 
            // label5
            // 
            this.label5.Border.BottomColor = System.Drawing.Color.Black;
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.LeftColor = System.Drawing.Color.Black;
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.RightColor = System.Drawing.Color.Black;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.TopColor = System.Drawing.Color.Black;
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Height = 0.1875F;
            this.label5.HyperLink = null;
            this.label5.Left = 4.6875F;
            this.label5.Name = "label5";
            this.label5.Style = "text-align: center; background-color: #E0E0E0; font-size: 8pt; ";
            this.label5.Text = "Penerbit";
            this.label5.Top = 0.5625F;
            this.label5.Width = 1.75F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtNo,
            this.txtISBN,
            this.txtJudul,
            this.txtPenerbit});
            this.detail.Height = 0.1875F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
            // 
            // txtNo
            // 
            this.txtNo.Border.BottomColor = System.Drawing.Color.Black;
            this.txtNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtNo.Border.LeftColor = System.Drawing.Color.Black;
            this.txtNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtNo.Border.RightColor = System.Drawing.Color.Black;
            this.txtNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtNo.Border.TopColor = System.Drawing.Color.Black;
            this.txtNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtNo.Height = 0.1875F;
            this.txtNo.Left = 0.0625F;
            this.txtNo.Name = "txtNo";
            this.txtNo.Style = "text-align: center; font-size: 8pt; vertical-align: middle; ";
            this.txtNo.Text = "0";
            this.txtNo.Top = 0F;
            this.txtNo.Width = 0.3125F;
            // 
            // txtISBN
            // 
            this.txtISBN.Border.BottomColor = System.Drawing.Color.Black;
            this.txtISBN.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtISBN.Border.LeftColor = System.Drawing.Color.Black;
            this.txtISBN.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtISBN.Border.RightColor = System.Drawing.Color.Black;
            this.txtISBN.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtISBN.Border.TopColor = System.Drawing.Color.Black;
            this.txtISBN.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtISBN.Height = 0.1875F;
            this.txtISBN.Left = 0.375F;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Style = "font-size: 8pt; vertical-align: middle; ";
            this.txtISBN.Text = null;
            this.txtISBN.Top = 0F;
            this.txtISBN.Width = 1.1875F;
            // 
            // txtJudul
            // 
            this.txtJudul.Border.BottomColor = System.Drawing.Color.Black;
            this.txtJudul.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJudul.Border.LeftColor = System.Drawing.Color.Black;
            this.txtJudul.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJudul.Border.RightColor = System.Drawing.Color.Black;
            this.txtJudul.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtJudul.Border.TopColor = System.Drawing.Color.Black;
            this.txtJudul.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtJudul.Height = 0.1875F;
            this.txtJudul.Left = 1.5625F;
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Style = "font-size: 8pt; vertical-align: middle; ";
            this.txtJudul.Text = null;
            this.txtJudul.Top = 0F;
            this.txtJudul.Width = 3.125F;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Border.BottomColor = System.Drawing.Color.Black;
            this.txtPenerbit.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtPenerbit.Border.LeftColor = System.Drawing.Color.Black;
            this.txtPenerbit.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtPenerbit.Border.RightColor = System.Drawing.Color.Black;
            this.txtPenerbit.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtPenerbit.Border.TopColor = System.Drawing.Color.Black;
            this.txtPenerbit.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPenerbit.Height = 0.1875F;
            this.txtPenerbit.Left = 4.6875F;
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Style = "font-size: 8pt; vertical-align: middle; ";
            this.txtPenerbit.Text = null;
            this.txtPenerbit.Top = 0F;
            this.txtPenerbit.Width = 1.75F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0.1041667F;
            this.pageFooter.Name = "pageFooter";
            // 
            // ArLapBuku
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJudul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenerbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.TextBox txtNo;
        private DataDynamics.ActiveReports.TextBox txtISBN;
        private DataDynamics.ActiveReports.TextBox txtJudul;
        private DataDynamics.ActiveReports.TextBox txtPenerbit;
    }
}
