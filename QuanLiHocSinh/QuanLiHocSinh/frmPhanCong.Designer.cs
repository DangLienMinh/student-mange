﻿namespace QuanLiHocSinh
{
    partial class frmPhanCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            this.grdPhanCong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MANH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MAMH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MAGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtHienTai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTruoc = new DevComponents.DotNetBar.ButtonX();
            this.btnDau = new DevComponents.DotNetBar.ButtonX();
            this.btnCuoi = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.btnSau = new DevComponents.DotNetBar.ButtonX();
            this.optTenGV = new System.Windows.Forms.RadioButton();
            this.optTenLop = new System.Windows.Forms.RadioButton();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnGiaoVien = new DevComponents.DotNetBar.ButtonX();
            this.btnMonHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnLop = new DevComponents.DotNetBar.ButtonX();
            this.btnNamHoc = new DevComponents.DotNetBar.ButtonX();
            this.cboGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboMonHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhanCong)).BeginInit();
            this.navigationPanePanel1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPhanCong
            // 
            this.grdPhanCong.AllowUserToDeleteRows = false;
            this.grdPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANH,
            this.MALOP,
            this.MAMH,
            this.MAGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPhanCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPhanCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdPhanCong.EnableHeadersVisualStyles = false;
            this.grdPhanCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdPhanCong.Location = new System.Drawing.Point(0, 43);
            this.grdPhanCong.Name = "grdPhanCong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPhanCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPhanCong.Size = new System.Drawing.Size(1076, 474);
            this.grdPhanCong.TabIndex = 9;
            this.grdPhanCong.TabStop = false;
            this.grdPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhanCong_CellClick);
            this.grdPhanCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhanCong_CellContentClick);
            // 
            // MANH
            // 
            this.MANH.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MANH.HeaderText = "Năm học";
            this.MANH.Name = "MANH";
            this.MANH.Width = 56;
            // 
            // MALOP
            // 
            this.MALOP.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MALOP.HeaderText = "Lớp";
            this.MALOP.Name = "MALOP";
            this.MALOP.Width = 39;
            // 
            // MAMH
            // 
            this.MAMH.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MAMH.HeaderText = "Môn học";
            this.MAMH.Name = "MAMH";
            this.MAMH.Width = 55;
            // 
            // MAGV
            // 
            this.MAGV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MAGV.HeaderText = "Giáo viên";
            this.MAGV.Name = "MAGV";
            this.MAGV.Width = 58;
            // 
            // txtHienTai
            // 
            this.txtHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHienTai.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtHienTai.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtHienTai.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtHienTai.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtHienTai.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtHienTai.Border.Class = "TextBoxBorder";
            this.txtHienTai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHienTai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHienTai.Location = new System.Drawing.Point(500, 11);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(69, 20);
            this.txtHienTai.TabIndex = 15;
            this.txtHienTai.TabStop = false;
            // 
            // btnTruoc
            // 
            this.btnTruoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTruoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruoc.Location = new System.Drawing.Point(425, 9);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(64, 23);
            this.btnTruoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnTruoc.TabIndex = 13;
            this.btnTruoc.Text = "<";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDau.Location = new System.Drawing.Point(355, 9);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(64, 23);
            this.btnDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDau.TabIndex = 12;
            this.btnDau.Text = "|<";
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCuoi.Location = new System.Drawing.Point(650, 9);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(64, 23);
            this.btnCuoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCuoi.TabIndex = 15;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 36);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Năm học:";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(14, 84);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 15;
            this.labelX13.Text = "Lớp:";
            // 
            // btnSau
            // 
            this.btnSau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSau.Location = new System.Drawing.Point(578, 9);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(64, 23);
            this.btnSau.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSau.TabIndex = 14;
            this.btnSau.Text = ">";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // optTenGV
            // 
            this.optTenGV.AutoSize = true;
            this.optTenGV.ForeColor = System.Drawing.Color.Blue;
            this.optTenGV.Location = new System.Drawing.Point(14, 83);
            this.optTenGV.Name = "optTenGV";
            this.optTenGV.Size = new System.Drawing.Size(130, 17);
            this.optTenGV.TabIndex = 15;
            this.optTenGV.TabStop = true;
            this.optTenGV.Tag = "";
            this.optTenGV.Text = "Tìm theo tên giáo viên";
            this.optTenGV.UseVisualStyleBackColor = true;
            this.optTenGV.CheckedChanged += new System.EventHandler(this.optTenGV_CheckedChanged);
            // 
            // optTenLop
            // 
            this.optTenLop.AutoSize = true;
            this.optTenLop.ForeColor = System.Drawing.Color.Blue;
            this.optTenLop.Location = new System.Drawing.Point(14, 60);
            this.optTenLop.Name = "optTenLop";
            this.optTenLop.Size = new System.Drawing.Size(101, 17);
            this.optTenLop.TabIndex = 14;
            this.optTenLop.TabStop = true;
            this.optTenLop.Tag = "";
            this.optTenLop.Text = "Tìm theo tên lớp";
            this.optTenLop.UseVisualStyleBackColor = true;
            this.optTenLop.CheckedChanged += new System.EventHandler(this.optMaGV_CheckedChanged);
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtTim.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTim.Location = new System.Drawing.Point(14, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(163, 20);
            this.txtTim.TabIndex = 12;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(14, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(145, 23);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "Nhập thông tin tìm kiếm:";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.optTenGV);
            this.navigationPanePanel1.Controls.Add(this.optTenLop);
            this.navigationPanePanel1.Controls.Add(this.txtTim);
            this.navigationPanePanel1.Controls.Add(this.labelX7);
            this.navigationPanePanel1.Controls.Add(this.btnTim);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(278, 536);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Image = global::QuanLiHocSinh.Properties.Resources.Timkiem;
            this.btnTim.Location = new System.Drawing.Point(14, 110);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(163, 32);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnItemTim
            // 
            this.btnItemTim.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemTim.Image = ((System.Drawing.Image)(resources.GetObject("btnItemTim.Image")));
            this.btnItemTim.Name = "btnItemTim";
            this.btnItemTim.OptionGroup = "navBar";
            this.btnItemTim.Text = "Tìm kiếm thông tin";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.btnSua);
            this.navigationPanePanel2.Controls.Add(this.btnXoa);
            this.navigationPanePanel2.Controls.Add(this.btnHuy);
            this.navigationPanePanel2.Controls.Add(this.btnDongY);
            this.navigationPanePanel2.Controls.Add(this.btnThem);
            this.navigationPanePanel2.Controls.Add(this.btnGiaoVien);
            this.navigationPanePanel2.Controls.Add(this.btnMonHoc);
            this.navigationPanePanel2.Controls.Add(this.btnLop);
            this.navigationPanePanel2.Controls.Add(this.btnNamHoc);
            this.navigationPanePanel2.Controls.Add(this.cboGiaoVien);
            this.navigationPanePanel2.Controls.Add(this.cboMonHoc);
            this.navigationPanePanel2.Controls.Add(this.cboNamHoc);
            this.navigationPanePanel2.Controls.Add(this.cboLop);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Controls.Add(this.labelX1);
            this.navigationPanePanel2.Controls.Add(this.labelX4);
            this.navigationPanePanel2.Controls.Add(this.labelX13);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(278, 410);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            this.navigationPanePanel2.Click += new System.EventHandler(this.navigationPanePanel2_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = global::QuanLiHocSinh.Properties.Resources.Sua;
            this.btnSua.Location = new System.Drawing.Point(188, 287);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 35);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QuanLiHocSinh.Properties.Resources.Xoa;
            this.btnXoa.Location = new System.Drawing.Point(97, 287);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 35);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Image = global::QuanLiHocSinh.Properties.Resources.Huybo;
            this.btnHuy.Location = new System.Drawing.Point(135, 328);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 35);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Image = global::QuanLiHocSinh.Properties.Resources.Dongy;
            this.btnDongY.Location = new System.Drawing.Point(44, 328);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(85, 35);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDongY.TabIndex = 24;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnThem.Location = new System.Drawing.Point(6, 287);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 35);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGiaoVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGiaoVien.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnGiaoVien.Location = new System.Drawing.Point(206, 206);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(33, 23);
            this.btnGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnGiaoVien.TabIndex = 20;
            this.btnGiaoVien.Tooltip = "Thêm giáo viên mới";
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMonHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMonHoc.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnMonHoc.Location = new System.Drawing.Point(206, 157);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(33, 23);
            this.btnMonHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnMonHoc.TabIndex = 20;
            this.btnMonHoc.Tooltip = "Thêm môn học mới";
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnLop
            // 
            this.btnLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLop.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnLop.Location = new System.Drawing.Point(206, 108);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(33, 23);
            this.btnLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnLop.TabIndex = 20;
            this.btnLop.Tooltip = "Thêm lớp mới";
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnNamHoc
            // 
            this.btnNamHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNamHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNamHoc.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnNamHoc.Location = new System.Drawing.Point(206, 59);
            this.btnNamHoc.Name = "btnNamHoc";
            this.btnNamHoc.Size = new System.Drawing.Size(33, 23);
            this.btnNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnNamHoc.TabIndex = 20;
            this.btnNamHoc.Tooltip = "Thêm năm học mới";
            this.btnNamHoc.Click += new System.EventHandler(this.btnNamHoc_Click);
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.DisplayMember = "Text";
            this.cboGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.FormattingEnabled = true;
            this.cboGiaoVien.ItemHeight = 14;
            this.cboGiaoVien.Location = new System.Drawing.Point(14, 209);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(174, 20);
            this.cboGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboGiaoVien.TabIndex = 19;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DisplayMember = "Text";
            this.cboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.ItemHeight = 14;
            this.cboMonHoc.Location = new System.Drawing.Point(14, 159);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(174, 20);
            this.cboMonHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboMonHoc.TabIndex = 19;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DisplayMember = "Text";
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.ItemHeight = 14;
            this.cboNamHoc.Location = new System.Drawing.Point(14, 59);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(174, 20);
            this.cboNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboNamHoc.TabIndex = 19;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 14;
            this.cboLop.Location = new System.Drawing.Point(14, 108);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(174, 20);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboLop.TabIndex = 19;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 184);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(155, 23);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Giáo viên giảng dạy:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(14, 134);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Môn học:";
            // 
            // btnItemNhap
            // 
            this.btnItemNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemNhap.Checked = true;
            this.btnItemNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnItemNhap.Image")));
            this.btnItemNhap.Name = "btnItemNhap";
            this.btnItemNhap.OptionGroup = "navBar";
            this.btnItemNhap.Text = "Nhập liệu thông tin";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnCuoi);
            this.groupPanel1.Controls.Add(this.btnSau);
            this.groupPanel1.Controls.Add(this.btnTruoc);
            this.groupPanel1.Controls.Add(this.btnDau);
            this.groupPanel1.Controls.Add(this.txtHienTai);
            this.groupPanel1.Controls.Add(this.grdPhanCong);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(280, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1082, 538);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 7;
            this.groupPanel1.Text = "DANH SÁCH PHÂN CÔNG GIÁO VIÊN GIẢNG DẠY";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhap,
            this.btnItemTim});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 102;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(280, 538);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 6;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(278, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Nhập liệu thông tin";
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 538);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmPhanCong";
            this.Text = "PHÂN CÔNG GIẢNG DẠY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhanCong)).EndInit();
            this.navigationPanePanel1.ResumeLayout(false);
            this.navigationPanePanel1.PerformLayout();
            this.navigationPanePanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.navigationPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdPhanCong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHienTai;
        private DevComponents.DotNetBar.ButtonX btnTruoc;
        private DevComponents.DotNetBar.ButtonX btnDau;
        private DevComponents.DotNetBar.ButtonX btnCuoi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.ButtonX btnSau;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private System.Windows.Forms.RadioButton optTenGV;
        private System.Windows.Forms.RadioButton optTenLop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.ButtonX btnGiaoVien;
        private DevComponents.DotNetBar.ButtonX btnMonHoc;
        private DevComponents.DotNetBar.ButtonX btnLop;
        private DevComponents.DotNetBar.ButtonX btnNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGiaoVien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMonHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.DataGridViewComboBoxColumn MANH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAGV;
    }
}