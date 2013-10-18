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
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.inputDoTuoiCanTren = new DevComponents.Editors.IntegerInput();
            this.labelX04 = new DevComponents.DotNetBar.LabelX();
            this.inputDoTuoiCanDuoi = new DevComponents.Editors.IntegerInput();
            this.labelX03 = new DevComponents.DotNetBar.LabelX();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.inputSiSoCanTren = new DevComponents.Editors.IntegerInput();
            this.labelX02 = new DevComponents.DotNetBar.LabelX();
            this.inputSiSoCanDuoi = new DevComponents.Editors.IntegerInput();
            this.labelX01 = new DevComponents.DotNetBar.LabelX();
            this.txtDiaChiTruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenTruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX07 = new DevComponents.DotNetBar.LabelX();
            this.labelX06 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDoTuoiCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDoTuoiCanDuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSiSoCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSiSoCanDuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(311, 158);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Độ tuổi";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.inputDoTuoiCanTren);
            this.tabControlPanel1.Controls.Add(this.labelX03);
            this.tabControlPanel1.Controls.Add(this.labelX04);
            this.tabControlPanel1.Controls.Add(this.inputDoTuoiCanDuoi);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(311, 132);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Sỉ số";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.inputSiSoCanTren);
            this.tabControlPanel2.Controls.Add(this.labelX02);
            this.tabControlPanel2.Controls.Add(this.inputSiSoCanDuoi);
            this.tabControlPanel2.Controls.Add(this.labelX01);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(311, 132);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Thông tin Trường";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.txtDiaChiTruong);
            this.tabControlPanel3.Controls.Add(this.txtTenTruong);
            this.tabControlPanel3.Controls.Add(this.labelX07);
            this.tabControlPanel3.Controls.Add(this.labelX06);
            this.tabControlPanel3.Controls.Add(this.txtDienThoai);
            this.tabControlPanel3.Controls.Add(this.labelX1);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(311, 132);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // inputDoTuoiCanTren
            // 
            // 
            // 
            // 
            this.inputDoTuoiCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputDoTuoiCanTren.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputDoTuoiCanTren.Location = new System.Drawing.Point(182, 64);
            this.inputDoTuoiCanTren.MaxValue = 40;
            this.inputDoTuoiCanTren.MinValue = 10;
            this.inputDoTuoiCanTren.Name = "inputDoTuoiCanTren";
            this.inputDoTuoiCanTren.ShowUpDown = true;
            this.inputDoTuoiCanTren.Size = new System.Drawing.Size(120, 20);
            this.inputDoTuoiCanTren.TabIndex = 6;
            this.inputDoTuoiCanTren.Value = 10;
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
            // inputDoTuoiCanDuoi
            // 
            // 
            // 
            // 
            this.inputDoTuoiCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputDoTuoiCanDuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputDoTuoiCanDuoi.Location = new System.Drawing.Point(182, 24);
            this.inputDoTuoiCanDuoi.MaxValue = 40;
            this.inputDoTuoiCanDuoi.MinValue = 10;
            this.inputDoTuoiCanDuoi.Name = "inputDoTuoiCanDuoi";
            this.inputDoTuoiCanDuoi.ShowUpDown = true;
            this.inputDoTuoiCanDuoi.Size = new System.Drawing.Size(120, 20);
            this.inputDoTuoiCanDuoi.TabIndex = 5;
            this.inputDoTuoiCanDuoi.Value = 10;
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
            // inputSiSoCanTren
            // 
            // 
            // 
            // 
            this.inputSiSoCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputSiSoCanTren.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputSiSoCanTren.Location = new System.Drawing.Point(179, 64);
            this.inputSiSoCanTren.MaxValue = 100;
            this.inputSiSoCanTren.MinValue = 10;
            this.inputSiSoCanTren.Name = "inputSiSoCanTren";
            this.inputSiSoCanTren.ShowUpDown = true;
            this.inputSiSoCanTren.Size = new System.Drawing.Size(120, 20);
            this.inputSiSoCanTren.TabIndex = 6;
            this.inputSiSoCanTren.Value = 10;
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
            // inputSiSoCanDuoi
            // 
            // 
            // 
            // 
            this.inputSiSoCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputSiSoCanDuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputSiSoCanDuoi.Location = new System.Drawing.Point(179, 25);
            this.inputSiSoCanDuoi.MaxValue = 100;
            this.inputSiSoCanDuoi.MinValue = 10;
            this.inputSiSoCanDuoi.Name = "inputSiSoCanDuoi";
            this.inputSiSoCanDuoi.ShowUpDown = true;
            this.inputSiSoCanDuoi.Size = new System.Drawing.Size(120, 20);
            this.inputSiSoCanDuoi.TabIndex = 5;
            this.inputSiSoCanDuoi.Value = 10;
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
            // txtDiaChiTruong
            // 
            // 
            // 
            // 
            this.txtDiaChiTruong.Border.Class = "TextBoxBorder";
            this.txtDiaChiTruong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChiTruong.Location = new System.Drawing.Point(81, 53);
            this.txtDiaChiTruong.Name = "txtDiaChiTruong";
            this.txtDiaChiTruong.Size = new System.Drawing.Size(210, 20);
            this.txtDiaChiTruong.TabIndex = 10;
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
            // frmThongSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 158);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "frmThongSo";
            this.Text = "THÔNG SỐ";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDoTuoiCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDoTuoiCanDuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSiSoCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSiSoCanDuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.Editors.IntegerInput inputDoTuoiCanTren;
        private DevComponents.DotNetBar.LabelX labelX03;
        private DevComponents.DotNetBar.LabelX labelX04;
        private DevComponents.Editors.IntegerInput inputDoTuoiCanDuoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiTruong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTruong;
        private DevComponents.DotNetBar.LabelX labelX07;
        private DevComponents.DotNetBar.LabelX labelX06;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput inputSiSoCanTren;
        private DevComponents.DotNetBar.LabelX labelX02;
        private DevComponents.Editors.IntegerInput inputSiSoCanDuoi;
        private DevComponents.DotNetBar.LabelX labelX01;
    }
}