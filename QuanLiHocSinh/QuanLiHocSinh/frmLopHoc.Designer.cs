namespace QuanLiHocSinh
{
    partial class frmLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopHoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTenLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtSiSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbKhoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.ư = new DevComponents.DotNetBar.ButtonX();
            this.btnCuoi = new DevComponents.DotNetBar.ButtonX();
            this.btnSau = new DevComponents.DotNetBar.ButtonX();
            this.btnTruoc = new DevComponents.DotNetBar.ButtonX();
            this.btnDau = new DevComponents.DotNetBar.ButtonX();
            this.txtHienTai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
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
            this.navigationPane1.Size = new System.Drawing.Size(185, 510);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 0;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(183, 24);
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
            // btnItemTim
            // 
            this.btnItemTim.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemTim.Image = ((System.Drawing.Image)(resources.GetObject("btnItemTim.Image")));
            this.btnItemTim.Name = "btnItemTim";
            this.btnItemTim.OptionGroup = "navBar";
            this.btnItemTim.Text = "Tìm kiếm thông tin";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.txtTim);
            this.navigationPanePanel1.Controls.Add(this.labelX7);
            this.navigationPanePanel1.Controls.Add(this.btnTim);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(183, 508);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Controls.Add(this.btnCuoi);
            this.groupPanel1.Controls.Add(this.btnSau);
            this.groupPanel1.Controls.Add(this.btnTruoc);
            this.groupPanel1.Controls.Add(this.btnDau);
            this.groupPanel1.Controls.Add(this.txtHienTai);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel1.Location = new System.Drawing.Point(185, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(526, 510);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "DANH SÁCH LỚP";
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
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPanePanel2.Controls.Add(this.btnSua);
            this.navigationPanePanel2.Controls.Add(this.btnXoa);
            this.navigationPanePanel2.Controls.Add(this.ư);
            this.navigationPanePanel2.Controls.Add(this.btnDongY);
            this.navigationPanePanel2.Controls.Add(this.btnThem);
            this.navigationPanePanel2.Controls.Add(this.cbGiaoVien);
            this.navigationPanePanel2.Controls.Add(this.cbNamHoc);
            this.navigationPanePanel2.Controls.Add(this.cbKhoi);
            this.navigationPanePanel2.Controls.Add(this.txtTenLop);
            this.navigationPanePanel2.Controls.Add(this.labelX6);
            this.navigationPanePanel2.Controls.Add(this.txtSiSo);
            this.navigationPanePanel2.Controls.Add(this.labelX4);
            this.navigationPanePanel2.Controls.Add(this.labelX5);
            this.navigationPanePanel2.Controls.Add(this.labelX2);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Controls.Add(this.txtMaLop);
            this.navigationPanePanel2.Controls.Add(this.labelX1);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(183, 382);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            // 
            // 
            // 
            this.txtMaLop.Border.Class = "TextBoxBorder";
            this.txtMaLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLop.Location = new System.Drawing.Point(11, 35);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(155, 20);
            this.txtMaLop.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            // 
            // 
            // 
            this.txtTenLop.Border.Class = "TextBoxBorder";
            this.txtTenLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLop.Location = new System.Drawing.Point(11, 83);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(155, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 108);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Khối lớp:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(11, 154);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Năm học:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(104, 107);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Sỉ số:";
            // 
            // txtSiSo
            // 
            // 
            // 
            // 
            this.txtSiSo.Border.Class = "TextBoxBorder";
            this.txtSiSo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSiSo.Location = new System.Drawing.Point(104, 130);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(62, 20);
            this.txtSiSo.TabIndex = 1;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(11, 206);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(124, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Giáo viên chủ nhiệm:";
            // 
            // cbKhoi
            // 
            this.cbKhoi.DisplayMember = "Text";
            this.cbKhoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.ItemHeight = 14;
            this.cbKhoi.Location = new System.Drawing.Point(11, 130);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(75, 20);
            this.cbKhoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbKhoi.TabIndex = 2;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DisplayMember = "Text";
            this.cbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.ItemHeight = 14;
            this.cbNamHoc.Location = new System.Drawing.Point(11, 178);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(155, 20);
            this.cbNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNamHoc.TabIndex = 2;
            // 
            // cbGiaoVien
            // 
            this.cbGiaoVien.DisplayMember = "Text";
            this.cbGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGiaoVien.FormattingEnabled = true;
            this.cbGiaoVien.ItemHeight = 14;
            this.cbGiaoVien.Location = new System.Drawing.Point(11, 230);
            this.cbGiaoVien.Name = "cbGiaoVien";
            this.cbGiaoVien.Size = new System.Drawing.Size(155, 20);
            this.cbGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbGiaoVien.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(3, 272);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(62, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(125, 272);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 23);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(30, 306);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(45, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            // 
            // ư
            // 
            this.ư.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ư.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ư.Location = new System.Drawing.Point(90, 306);
            this.ư.Name = "ư";
            this.ư.Size = new System.Drawing.Size(45, 23);
            this.ư.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ư.TabIndex = 3;
            this.ư.Text = "Hủy";
            // 
            // btnCuoi
            // 
            this.btnCuoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCuoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCuoi.Location = new System.Drawing.Point(378, 7);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(64, 23);
            this.btnCuoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCuoi.TabIndex = 5;
            this.btnCuoi.Text = ">|";
            // 
            // btnSau
            // 
            this.btnSau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSau.Location = new System.Drawing.Point(306, 7);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(64, 23);
            this.btnSau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSau.TabIndex = 6;
            this.btnSau.Text = ">";
            // 
            // btnTruoc
            // 
            this.btnTruoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruoc.Location = new System.Drawing.Point(153, 7);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(64, 23);
            this.btnTruoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruoc.TabIndex = 7;
            this.btnTruoc.Text = "<";
            // 
            // btnDau
            // 
            this.btnDau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDau.Location = new System.Drawing.Point(83, 7);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(64, 23);
            this.btnDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDau.TabIndex = 8;
            this.btnDau.Text = "|<";
            // 
            // txtHienTai
            // 
            // 
            // 
            // 
            this.txtHienTai.Border.Class = "TextBoxBorder";
            this.txtHienTai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHienTai.Location = new System.Drawing.Point(228, 9);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(69, 20);
            this.txtHienTai.TabIndex = 4;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(520, 447);
            this.dataGridViewX1.TabIndex = 9;
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.Location = new System.Drawing.Point(11, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(155, 20);
            this.txtTim.TabIndex = 3;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(11, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(145, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Nhập thông tin tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(34, 65);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm kiếm";
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 510);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmLopHoc";
            this.Text = "QUẢN LÝ LỚP HỌC";
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.navigationPanePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX ư;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGiaoVien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbKhoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLop;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSiSo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLop;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btnCuoi;
        private DevComponents.DotNetBar.ButtonX btnSau;
        private DevComponents.DotNetBar.ButtonX btnTruoc;
        private DevComponents.DotNetBar.ButtonX btnDau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHienTai;
    }
}