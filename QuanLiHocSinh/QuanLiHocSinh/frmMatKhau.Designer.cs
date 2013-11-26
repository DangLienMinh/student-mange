namespace QuanLiHocSinh
{
    partial class frmMatKhau
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
            this.gPanelDoiMK = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.lblNewPassError = new System.Windows.Forms.Label();
            this.lblOldPassError = new System.Windows.Forms.Label();
            this.lblReNPassError = new System.Windows.Forms.Label();
            this.lblReNewPass = new DevComponents.DotNetBar.LabelX();
            this.lblNewPass = new DevComponents.DotNetBar.LabelX();
            this.lblOldPass = new DevComponents.DotNetBar.LabelX();
            this.txtMkNhapLai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMkMoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMkCu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gPanelDoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gPanelDoiMK
            // 
            this.gPanelDoiMK.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelDoiMK.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gPanelDoiMK.Controls.Add(this.btnHuy);
            this.gPanelDoiMK.Controls.Add(this.btnDongY);
            this.gPanelDoiMK.Controls.Add(this.lblNewPassError);
            this.gPanelDoiMK.Controls.Add(this.lblOldPassError);
            this.gPanelDoiMK.Controls.Add(this.lblReNPassError);
            this.gPanelDoiMK.Controls.Add(this.lblReNewPass);
            this.gPanelDoiMK.Controls.Add(this.lblNewPass);
            this.gPanelDoiMK.Controls.Add(this.lblOldPass);
            this.gPanelDoiMK.Controls.Add(this.txtMkNhapLai);
            this.gPanelDoiMK.Controls.Add(this.txtMkMoi);
            this.gPanelDoiMK.Controls.Add(this.txtMkCu);
            this.gPanelDoiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPanelDoiMK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPanelDoiMK.Location = new System.Drawing.Point(0, 0);
            this.gPanelDoiMK.Name = "gPanelDoiMK";
            this.gPanelDoiMK.Size = new System.Drawing.Size(414, 223);
            // 
            // 
            // 
            this.gPanelDoiMK.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelDoiMK.Style.BackColorGradientAngle = 90;
            this.gPanelDoiMK.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelDoiMK.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDoiMK.Style.BorderBottomWidth = 1;
            this.gPanelDoiMK.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelDoiMK.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDoiMK.Style.BorderLeftWidth = 1;
            this.gPanelDoiMK.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDoiMK.Style.BorderRightWidth = 1;
            this.gPanelDoiMK.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDoiMK.Style.BorderTopWidth = 1;
            this.gPanelDoiMK.Style.CornerDiameter = 4;
            this.gPanelDoiMK.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelDoiMK.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gPanelDoiMK.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelDoiMK.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanelDoiMK.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanelDoiMK.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanelDoiMK.TabIndex = 1;
            this.gPanelDoiMK.Text = "Đổi mật khẩu cá nhân";
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLiHocSinh.Properties.Resources.Huybo;
            this.btnHuy.Location = new System.Drawing.Point(223, 143);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 30);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Image = global::QuanLiHocSinh.Properties.Resources.Dongy;
            this.btnDongY.Location = new System.Drawing.Point(114, 143);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(85, 30);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // lblNewPassError
            // 
            this.lblNewPassError.AutoSize = true;
            this.lblNewPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassError.ForeColor = System.Drawing.Color.Red;
            this.lblNewPassError.Location = new System.Drawing.Point(167, 80);
            this.lblNewPassError.Name = "lblNewPassError";
            this.lblNewPassError.Size = new System.Drawing.Size(0, 13);
            this.lblNewPassError.TabIndex = 0;
            // 
            // lblOldPassError
            // 
            this.lblOldPassError.AutoSize = true;
            this.lblOldPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassError.ForeColor = System.Drawing.Color.Red;
            this.lblOldPassError.Location = new System.Drawing.Point(167, 40);
            this.lblOldPassError.Name = "lblOldPassError";
            this.lblOldPassError.Size = new System.Drawing.Size(0, 13);
            this.lblOldPassError.TabIndex = 0;
            // 
            // lblReNPassError
            // 
            this.lblReNPassError.AutoSize = true;
            this.lblReNPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblReNPassError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReNPassError.ForeColor = System.Drawing.Color.Red;
            this.lblReNPassError.Location = new System.Drawing.Point(167, 120);
            this.lblReNPassError.Name = "lblReNPassError";
            this.lblReNPassError.Size = new System.Drawing.Size(0, 13);
            this.lblReNPassError.TabIndex = 0;
            // 
            // lblReNewPass
            // 
            this.lblReNewPass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblReNewPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblReNewPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReNewPass.Location = new System.Drawing.Point(8, 95);
            this.lblReNewPass.Name = "lblReNewPass";
            this.lblReNewPass.Size = new System.Drawing.Size(155, 23);
            this.lblReNewPass.TabIndex = 0;
            this.lblReNewPass.Text = "Nhập lại mật khẩu mới:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblNewPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNewPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(8, 55);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(155, 23);
            this.lblNewPass.TabIndex = 0;
            this.lblNewPass.Text = "Mật khẩu mới:";
            // 
            // lblOldPass
            // 
            this.lblOldPass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblOldPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOldPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(8, 15);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(155, 23);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Mật khẩu cũ:";
            // 
            // txtMkNhapLai
            // 
            // 
            // 
            // 
            this.txtMkNhapLai.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkNhapLai.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkNhapLai.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkNhapLai.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkNhapLai.Border.Class = "TextBoxBorder";
            this.txtMkNhapLai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMkNhapLai.Location = new System.Drawing.Point(169, 95);
            this.txtMkNhapLai.MaxLength = 30;
            this.txtMkNhapLai.Name = "txtMkNhapLai";
            this.txtMkNhapLai.PasswordChar = '●';
            this.txtMkNhapLai.Size = new System.Drawing.Size(160, 23);
            this.txtMkNhapLai.TabIndex = 3;
            this.txtMkNhapLai.WatermarkText = "Xác nhận mật khẩu mới";
            this.txtMkNhapLai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMkNhapLai_KeyDown);
            // 
            // txtMkMoi
            // 
            // 
            // 
            // 
            this.txtMkMoi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkMoi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkMoi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkMoi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkMoi.Border.Class = "TextBoxBorder";
            this.txtMkMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMkMoi.Location = new System.Drawing.Point(169, 55);
            this.txtMkMoi.MaxLength = 30;
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.PasswordChar = '●';
            this.txtMkMoi.Size = new System.Drawing.Size(160, 23);
            this.txtMkMoi.TabIndex = 2;
            this.txtMkMoi.WatermarkText = "Mật khẩu mới";
            // 
            // txtMkCu
            // 
            // 
            // 
            // 
            this.txtMkCu.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkCu.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkCu.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkCu.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMkCu.Border.Class = "TextBoxBorder";
            this.txtMkCu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMkCu.Location = new System.Drawing.Point(169, 15);
            this.txtMkCu.MaxLength = 30;
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.PasswordChar = '●';
            this.txtMkCu.Size = new System.Drawing.Size(160, 23);
            this.txtMkCu.TabIndex = 1;
            this.txtMkCu.WatermarkText = "Mật khẩu cũ";
            // 
            // frmMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 223);
            this.Controls.Add(this.gPanelDoiMK);
            this.Name = "frmMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.gPanelDoiMK.ResumeLayout(false);
            this.gPanelDoiMK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gPanelDoiMK;
        public System.Windows.Forms.Label lblNewPassError;
        public System.Windows.Forms.Label lblOldPassError;
        public System.Windows.Forms.Label lblReNPassError;
        private DevComponents.DotNetBar.LabelX lblReNewPass;
        private DevComponents.DotNetBar.LabelX lblNewPass;
        private DevComponents.DotNetBar.LabelX lblOldPass;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMkNhapLai;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMkMoi;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMkCu;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnDongY;
    }
}