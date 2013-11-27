namespace QuanLiHocSinh
{
    partial class frmHiemThiReport
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
            this.rptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptView
            // 
            this.rptView.ActiveViewIndex = -1;
            this.rptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptView.Location = new System.Drawing.Point(0, 0);
            this.rptView.Name = "rptView";
            this.rptView.Size = new System.Drawing.Size(284, 261);
            this.rptView.TabIndex = 0;
            // 
            // frmHiemThiReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rptView);
            this.DoubleBuffered = true;
            this.Name = "frmHiemThiReport";
            this.Text = "HIỂN THỊ BÁO CÁO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHiemThiReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptView;
    }
}