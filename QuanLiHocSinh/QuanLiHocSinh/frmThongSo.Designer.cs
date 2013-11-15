namespace QuanLiHocSinh
{
    partial class frmThongSo
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtTuoiTD = new DevComponents.Editors.IntegerInput();
            this.labelX03 = new DevComponents.DotNetBar.LabelX();
            this.labelX04 = new DevComponents.DotNetBar.LabelX();
            this.txtTuoiTT = new DevComponents.Editors.IntegerInput();
            this.tabControlPanelDoTuoi = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenTruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX07 = new DevComponents.DotNetBar.LabelX();
            this.labelX06 = new DevComponents.DotNetBar.LabelX();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabControlPanelTruong = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtSiSoTD = new DevComponents.Editors.IntegerInput();
            this.labelX02 = new DevComponents.DotNetBar.LabelX();
            this.txtSiSoTT = new DevComponents.Editors.IntegerInput();
            this.labelX01 = new DevComponents.DotNetBar.LabelX();
            this.tabControlPanelSiSo = new DevComponents.DotNetBar.TabItem(this.components);
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiTT)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoTT)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 176);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabControlPanelDoTuoi);
            this.tabControl1.Tabs.Add(this.tabControlPanelSiSo);
            this.tabControl1.Tabs.Add(this.tabControlPanelTruong);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.txtTuoiTD);
            this.tabControlPanel1.Controls.Add(this.labelX03);
            this.tabControlPanel1.Controls.Add(this.labelX04);
            this.tabControlPanel1.Controls.Add(this.txtTuoiTT);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(352, 150);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabControlPanelDoTuoi;
            // 
            // txtTuoiTD
            // 
            // 
            // 
            // 
            this.txtTuoiTD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTuoiTD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTuoiTD.Location = new System.Drawing.Point(182, 64);
            this.txtTuoiTD.MaxValue = 40;
            this.txtTuoiTD.MinValue = 10;
            this.txtTuoiTD.Name = "txtTuoiTD";
            this.txtTuoiTD.ShowUpDown = true;
            this.txtTuoiTD.Size = new System.Drawing.Size(120, 20);
            this.txtTuoiTD.TabIndex = 6;
            this.txtTuoiTD.Value = 10;
            // 
            // labelX03
            // 
            this.labelX03.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX03.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX03.Location = new System.Drawing.Point(22, 24);
            this.labelX03.Name = "labelX03";
            this.labelX03.Size = new System.Drawing.Size(154, 20);
            this.labelX03.TabIndex = 4;
            this.labelX03.Text = "Độ tuổi tối thiểu của học sinh:";
            // 
            // labelX04
            // 
            this.labelX04.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX04.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX04.Location = new System.Drawing.Point(22, 64);
            this.labelX04.Name = "labelX04";
            this.labelX04.Size = new System.Drawing.Size(154, 20);
            this.labelX04.TabIndex = 3;
            this.labelX04.Text = "Độ tuổi tối đa của học sinh:";
            // 
            // txtTuoiTT
            // 
            // 
            // 
            // 
            this.txtTuoiTT.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTuoiTT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTuoiTT.Location = new System.Drawing.Point(182, 24);
            this.txtTuoiTT.MaxValue = 40;
            this.txtTuoiTT.MinValue = 10;
            this.txtTuoiTT.Name = "txtTuoiTT";
            this.txtTuoiTT.ShowUpDown = true;
            this.txtTuoiTT.Size = new System.Drawing.Size(120, 20);
            this.txtTuoiTT.TabIndex = 5;
            this.txtTuoiTT.Value = 10;
            // 
            // tabControlPanelDoTuoi
            // 
            this.tabControlPanelDoTuoi.AttachedControl = this.tabControlPanel1;
            this.tabControlPanelDoTuoi.Name = "tabControlPanelDoTuoi";
            this.tabControlPanelDoTuoi.Text = "Độ tuổi";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.txtDiaChi);
            this.tabControlPanel3.Controls.Add(this.txtTenTruong);
            this.tabControlPanel3.Controls.Add(this.labelX07);
            this.tabControlPanel3.Controls.Add(this.labelX06);
            this.tabControlPanel3.Controls.Add(this.txtDienThoai);
            this.tabControlPanel3.Controls.Add(this.labelX1);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(352, 150);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabControlPanelTruong;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Location = new System.Drawing.Point(81, 53);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenTruong
            // 
            // 
            // 
            // 
            this.txtTenTruong.Border.Class = "TextBoxBorder";
            this.txtTenTruong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTruong.Location = new System.Drawing.Point(81, 13);
            this.txtTenTruong.Name = "txtTenTruong";
            this.txtTenTruong.Size = new System.Drawing.Size(210, 20);
            this.txtTenTruong.TabIndex = 9;
            // 
            // labelX07
            // 
            this.labelX07.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX07.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX07.Location = new System.Drawing.Point(11, 53);
            this.labelX07.Name = "labelX07";
            this.labelX07.Size = new System.Drawing.Size(64, 20);
            this.labelX07.TabIndex = 7;
            this.labelX07.Text = "Địa chỉ:";
            // 
            // labelX06
            // 
            this.labelX06.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX06.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX06.Location = new System.Drawing.Point(11, 13);
            this.labelX06.Name = "labelX06";
            this.labelX06.Size = new System.Drawing.Size(64, 20);
            this.labelX06.TabIndex = 8;
            this.labelX06.Text = "Tên trường:";
            // 
            // txtDienThoai
            // 
            // 
            // 
            // 
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoai.Location = new System.Drawing.Point(81, 90);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(127, 20);
            this.txtDienThoai.TabIndex = 6;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 89);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 20);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Điện thoại:";
            // 
            // tabControlPanelTruong
            // 
            this.tabControlPanelTruong.AttachedControl = this.tabControlPanel3;
            this.tabControlPanelTruong.Name = "tabControlPanelTruong";
            this.tabControlPanelTruong.Text = "Thông tin Trường";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.txtSiSoTD);
            this.tabControlPanel2.Controls.Add(this.labelX02);
            this.tabControlPanel2.Controls.Add(this.txtSiSoTT);
            this.tabControlPanel2.Controls.Add(this.labelX01);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(352, 150);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabControlPanelSiSo;
            // 
            // txtSiSoTD
            // 
            // 
            // 
            // 
            this.txtSiSoTD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSiSoTD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSiSoTD.Location = new System.Drawing.Point(179, 64);
            this.txtSiSoTD.MaxValue = 100;
            this.txtSiSoTD.MinValue = 10;
            this.txtSiSoTD.Name = "txtSiSoTD";
            this.txtSiSoTD.ShowUpDown = true;
            this.txtSiSoTD.Size = new System.Drawing.Size(120, 20);
            this.txtSiSoTD.TabIndex = 6;
            this.txtSiSoTD.Value = 10;
            // 
            // labelX02
            // 
            this.labelX02.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX02.Location = new System.Drawing.Point(19, 64);
            this.labelX02.Name = "labelX02";
            this.labelX02.Size = new System.Drawing.Size(143, 20);
            this.labelX02.TabIndex = 3;
            this.labelX02.Text = "Sỉ số tối đa trong một lớp:";
            // 
            // txtSiSoTT
            // 
            // 
            // 
            // 
            this.txtSiSoTT.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSiSoTT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSiSoTT.Location = new System.Drawing.Point(179, 25);
            this.txtSiSoTT.MaxValue = 100;
            this.txtSiSoTT.MinValue = 10;
            this.txtSiSoTT.Name = "txtSiSoTT";
            this.txtSiSoTT.ShowUpDown = true;
            this.txtSiSoTT.Size = new System.Drawing.Size(120, 20);
            this.txtSiSoTT.TabIndex = 5;
            this.txtSiSoTT.Value = 10;
            // 
            // labelX01
            // 
            this.labelX01.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX01.Location = new System.Drawing.Point(19, 25);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(143, 20);
            this.labelX01.TabIndex = 4;
            this.labelX01.Text = "Sỉ số tối thiểu trong một lớp:";
            // 
            // tabControlPanelSiSo
            // 
            this.tabControlPanelSiSo.AttachedControl = this.tabControlPanel2;
            this.tabControlPanelSiSo.Name = "tabControlPanelSiSo";
            this.tabControlPanelSiSo.Text = "Sỉ số";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(82, 189);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(182, 189);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThongSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 224);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDongY);
            this.DoubleBuffered = true;
            this.Name = "frmThongSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG SỐ";
            this.Load += new System.EventHandler(this.frmThongSo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThongSo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiTT)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabControlPanelTruong;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabControlPanelDoTuoi;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabControlPanelSiSo;
        private DevComponents.Editors.IntegerInput txtTuoiTD;
        private DevComponents.DotNetBar.LabelX labelX03;
        private DevComponents.DotNetBar.LabelX labelX04;
        private DevComponents.Editors.IntegerInput txtTuoiTT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTruong;
        private DevComponents.DotNetBar.LabelX labelX07;
        private DevComponents.DotNetBar.LabelX labelX06;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput txtSiSoTD;
        private DevComponents.DotNetBar.LabelX labelX02;
        private DevComponents.Editors.IntegerInput txtSiSoTT;
        private DevComponents.DotNetBar.LabelX labelX01;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}