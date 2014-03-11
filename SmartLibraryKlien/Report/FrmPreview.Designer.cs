namespace SmartLibraryKlien.Report
{
    partial class FrmPreview
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
            this.ARViewer = new DataDynamics.ActiveReports.Viewer.Viewer();
            this.SuspendLayout();
            // 
            // ARViewer
            // 
            this.ARViewer.BackColor = System.Drawing.SystemColors.Control;
            this.ARViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARViewer.Document = new DataDynamics.ActiveReports.Document.Document("ARNet Document");
            this.ARViewer.Location = new System.Drawing.Point(0, 0);
            this.ARViewer.Name = "ARViewer";
            this.ARViewer.ReportViewer.CurrentPage = 0;
            this.ARViewer.ReportViewer.MultiplePageCols = 3;
            this.ARViewer.ReportViewer.MultiplePageRows = 2;
            this.ARViewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal;
            this.ARViewer.Size = new System.Drawing.Size(557, 350);
            this.ARViewer.TabIndex = 0;
            this.ARViewer.TableOfContents.Text = "Table Of Contents";
            this.ARViewer.TableOfContents.Width = 200;
            this.ARViewer.TabTitleLength = 35;
            this.ARViewer.Toolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 350);
            this.Controls.Add(this.ARViewer);
            this.Name = "FrmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DataDynamics.ActiveReports.Viewer.Viewer ARViewer;
    }
}