namespace QuanLiHocSinh
{
    partial class frmGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnChonAnh = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtiNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.optTenGV = new System.Windows.Forms.RadioButton();
            this.optMaGV = new System.Windows.Forms.RadioButton();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCuoi = new DevComponents.DotNetBar.ButtonX();
            this.btnSau = new DevComponents.DotNetBar.ButtonX();
            this.btnTruoc = new DevComponents.DotNetBar.ButtonX();
            this.btnDau = new DevComponents.DotNetBar.ButtonX();
            this.txtHienTai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grdGiaoVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINHGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINHGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANHGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.picGiaoVien = new System.Windows.Forms.PictureBox();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgaySinh)).BeginInit();
            this.navigationPanePanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiaoVien)).BeginInit();
            this.SuspendLayout();
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
            this.navigationPane1.Size = new System.Drawing.Size(294, 538);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 4;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(292, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(148)))));
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Nhập liệu thông tin";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.btnHuy);
            this.navigationPanePanel2.Controls.Add(this.btnDongY);
            this.navigationPanePanel2.Controls.Add(this.btnChonAnh);
            this.navigationPanePanel2.Controls.Add(this.picGiaoVien);
            this.navigationPanePanel2.Controls.Add(this.labelX1);
            this.navigationPanePanel2.Controls.Add(this.dtiNgaySinh);
            this.navigationPanePanel2.Controls.Add(this.cboGioiTinh);
            this.navigationPanePanel2.Controls.Add(this.btnSua);
            this.navigationPanePanel2.Controls.Add(this.btnXoa);
            this.navigationPanePanel2.Controls.Add(this.btnThem);
            this.navigationPanePanel2.Controls.Add(this.labelX2);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Controls.Add(this.labelX4);
            this.navigationPanePanel2.Controls.Add(this.labelX13);
            this.navigationPanePanel2.Controls.Add(this.txtDienThoai);
            this.navigationPanePanel2.Controls.Add(this.txtDiaChi);
            this.navigationPanePanel2.Controls.Add(this.txtTenGV);
            this.navigationPanePanel2.Controls.Add(this.txtMaGV);
            this.navigationPanePanel2.Controls.Add(this.labelX14);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(292, 410);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(149, 295);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(67, 295);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(72, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChonAnh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChonAnh.Location = new System.Drawing.Point(185, 124);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(95, 32);
            this.btnChonAnh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChonAnh.TabIndex = 6;
            this.btnChonAnh.Tag = "";
            this.btnChonAnh.Text = "Chọn ảnh ...";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(107, 144);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "Giới tính";
            // 
            // dtiNgaySinh
            // 
            // 
            // 
            // 
            this.dtiNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiNgaySinh.ButtonDropDown.Visible = true;
            this.dtiNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtiNgaySinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtiNgaySinh.IsPopupCalendarOpen = false;
            this.dtiNgaySinh.Location = new System.Drawing.Point(12, 118);
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
            this.dtiNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtiNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiNgaySinh.Name = "dtiNgaySinh";
            this.dtiNgaySinh.Size = new System.Drawing.Size(154, 20);
            this.dtiNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiNgaySinh.TabIndex = 2;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DisplayMember = "Text";
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.ItemHeight = 14;
            this.cboGioiTinh.Location = new System.Drawing.Point(107, 167);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(59, 20);
            this.cboGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGioiTinh.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(198, 257);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(107, 257);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(14, 257);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 189);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Địa chỉ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 46);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Tên giáo viên:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(11, 144);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(124, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Điện thoại:";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(11, 95);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 15;
            this.labelX13.Text = "Ngày sinh:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDienThoai.Location = new System.Drawing.Point(11, 167);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(75, 20);
            this.txtDienThoai.TabIndex = 3;
            this.txtDienThoai.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            this.txtDienThoai.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Location = new System.Drawing.Point(11, 214);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(155, 20);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDiaChi.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtTenGV
            // 
            this.txtTenGV.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtTenGV.Border.Class = "TextBoxBorder";
            this.txtTenGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenGV.Location = new System.Drawing.Point(11, 69);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(155, 20);
            this.txtTenGV.TabIndex = 1;
            this.txtTenGV.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTenGV.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtMaGV
            // 
            this.txtMaGV.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtMaGV.Border.Class = "TextBoxBorder";
            this.txtMaGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaGV.Location = new System.Drawing.Point(11, 25);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(155, 20);
            this.txtMaGV.TabIndex = 0;
            this.txtMaGV.Enter += new System.EventHandler(this.txt_Enter);
            this.txtMaGV.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(11, 2);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(108, 23);
            this.labelX14.TabIndex = 18;
            this.labelX14.Text = "Mã giáo viên:";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.optTenGV);
            this.navigationPanePanel1.Controls.Add(this.optMaGV);
            this.navigationPanePanel1.Controls.Add(this.txtTim);
            this.navigationPanePanel1.Controls.Add(this.labelX7);
            this.navigationPanePanel1.Controls.Add(this.btnTim);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(292, 434);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // optTenGV
            // 
            this.optTenGV.AutoSize = true;
            this.optTenGV.ForeColor = System.Drawing.Color.Blue;
            this.optTenGV.Location = new System.Drawing.Point(42, 87);
            this.optTenGV.Name = "optTenGV";
            this.optTenGV.Size = new System.Drawing.Size(90, 17);
            this.optTenGV.TabIndex = 15;
            this.optTenGV.TabStop = true;
            this.optTenGV.Tag = "";
            this.optTenGV.Text = "Tên giáo viên";
            this.optTenGV.UseVisualStyleBackColor = true;
            // 
            // optMaGV
            // 
            this.optMaGV.AutoSize = true;
            this.optMaGV.ForeColor = System.Drawing.Color.Blue;
            this.optMaGV.Location = new System.Drawing.Point(42, 60);
            this.optMaGV.Name = "optMaGV";
            this.optMaGV.Size = new System.Drawing.Size(86, 17);
            this.optMaGV.TabIndex = 14;
            this.optMaGV.TabStop = true;
            this.optMaGV.Tag = "";
            this.optMaGV.Text = "Mã giáo viên";
            this.optMaGV.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTim.Location = new System.Drawing.Point(14, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(233, 20);
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
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(55, 119);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(155, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.ctxMenu);
            this.groupPanel1.Controls.Add(this.btnCuoi);
            this.groupPanel1.Controls.Add(this.btnSau);
            this.groupPanel1.Controls.Add(this.btnTruoc);
            this.groupPanel1.Controls.Add(this.btnDau);
            this.groupPanel1.Controls.Add(this.txtHienTai);
            this.groupPanel1.Controls.Add(this.grdGiaoVien);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(294, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1068, 538);
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
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // btnCuoi
            // 
            this.btnCuoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCuoi.Location = new System.Drawing.Point(647, 14);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(64, 23);
            this.btnCuoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCuoi.TabIndex = 15;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSau.Location = new System.Drawing.Point(575, 14);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(64, 23);
            this.btnSau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSau.TabIndex = 14;
            this.btnSau.Text = ">";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTruoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruoc.Location = new System.Drawing.Point(422, 14);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(64, 23);
            this.btnTruoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruoc.TabIndex = 13;
            this.btnTruoc.Text = "<";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDau.Location = new System.Drawing.Point(352, 14);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(64, 23);
            this.btnDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDau.TabIndex = 12;
            this.btnDau.Text = "|<";
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // txtHienTai
            // 
            this.txtHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHienTai.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtHienTai.Border.Class = "TextBoxBorder";
            this.txtHienTai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHienTai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHienTai.Location = new System.Drawing.Point(497, 16);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(69, 20);
            this.txtHienTai.TabIndex = 15;
            this.txtHienTai.TabStop = false;
            // 
            // grdGiaoVien
            // 
            this.grdGiaoVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAGV,
            this.TENGV,
            this.NGSINHGV,
            this.DIACHIGV,
            this.GIOITINHGV,
            this.DIENTHOAIGV,
            this.HINHANHGV});
            this.ctxMenu.SetContextMenuEx(this.grdGiaoVien, this.btnMenu);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdGiaoVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdGiaoVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdGiaoVien.EnableHeadersVisualStyles = false;
            this.grdGiaoVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdGiaoVien.Location = new System.Drawing.Point(0, 53);
            this.grdGiaoVien.Name = "grdGiaoVien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGiaoVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGiaoVien.Size = new System.Drawing.Size(1062, 464);
            this.grdGiaoVien.TabIndex = 9;
            this.grdGiaoVien.TabStop = false;
            this.grdGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGiaoVien_CellClick);
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "Mã giáo viên";
            this.MAGV.Name = "MAGV";
            // 
            // TENGV
            // 
            this.TENGV.DataPropertyName = "TENGV";
            this.TENGV.HeaderText = "Tên giáo viên";
            this.TENGV.Name = "TENGV";
            // 
            // NGSINHGV
            // 
            this.NGSINHGV.DataPropertyName = "NGSINHGV";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NGSINHGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.NGSINHGV.HeaderText = "Ngày sinh";
            this.NGSINHGV.Name = "NGSINHGV";
            // 
            // DIACHIGV
            // 
            this.DIACHIGV.DataPropertyName = "DIACHIGV";
            this.DIACHIGV.HeaderText = "Địa chỉ";
            this.DIACHIGV.Name = "DIACHIGV";
            // 
            // GIOITINHGV
            // 
            this.GIOITINHGV.DataPropertyName = "GIOITINHGV";
            this.GIOITINHGV.HeaderText = "Giới tính";
            this.GIOITINHGV.Name = "GIOITINHGV";
            // 
            // DIENTHOAIGV
            // 
            this.DIENTHOAIGV.DataPropertyName = "DIENTHOAIGV";
            this.DIENTHOAIGV.HeaderText = "Điện thoại";
            this.DIENTHOAIGV.Name = "DIENTHOAIGV";
            // 
            // HINHANHGV
            // 
            this.HINHANHGV.DataPropertyName = "HINHANHGV";
            this.HINHANHGV.HeaderText = "Hình ảnh";
            this.HINHANHGV.Name = "HINHANHGV";
            this.HINHANHGV.Visible = false;
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(494, 246);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(75, 25);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 16;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefesh,
            this.btnDelete,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLiHocSinh.Properties.Resources.add;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::QuanLiHocSinh.Properties.Resources.refresh;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefesh.Text = "Làm tươi danh dách";
            this.btnRefesh.Click += new System.EventHandler(this.frmGiaoVien_Load);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLiHocSinh.Properties.Resources.delete;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::QuanLiHocSinh.Properties.Resources.exit;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picGiaoVien
            // 
            this.picGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGiaoVien.Location = new System.Drawing.Point(181, 8);
            this.picGiaoVien.Name = "picGiaoVien";
            this.picGiaoVien.Size = new System.Drawing.Size(100, 110);
            this.picGiaoVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGiaoVien.TabIndex = 29;
            this.picGiaoVien.TabStop = false;
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
            // btnItemTim
            // 
            this.btnItemTim.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemTim.Image = ((System.Drawing.Image)(resources.GetObject("btnItemTim.Image")));
            this.btnItemTim.Name = "btnItemTim";
            this.btnItemTim.OptionGroup = "navBar";
            this.btnItemTim.Text = "Tìm kiếm thông tin";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 538);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmGiaoVien";
            this.Text = "QUẢN LÝ GIÁO VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGiaoVien_KeyDown);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgaySinh)).EndInit();
            this.navigationPanePanel1.ResumeLayout(false);
            this.navigationPanePanel1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private System.Windows.Forms.RadioButton optTenGV;
        private System.Windows.Forms.RadioButton optMaGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnChonAnh;
        private System.Windows.Forms.PictureBox picGiaoVien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiNgaySinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGioiTinh;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaGV;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnCuoi;
        private DevComponents.DotNetBar.ButtonX btnSau;
        private DevComponents.DotNetBar.ButtonX btnTruoc;
        private DevComponents.DotNetBar.ButtonX btnDau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHienTai;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINHGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINHGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANHGV;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}