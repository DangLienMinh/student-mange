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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopHoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.cboBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboKhoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTenLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtSiSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMaLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.contextMenuBar2 = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.grdLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MALOP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHOI1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MANH1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SISO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGV1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BAN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnaLop = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaLop)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhap,
            this.btnItemTim});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 102;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(248, 557);
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
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(246, 24);
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
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.btnSua);
            this.navigationPanePanel2.Controls.Add(this.btnXoa);
            this.navigationPanePanel2.Controls.Add(this.btnHuy);
            this.navigationPanePanel2.Controls.Add(this.btnDongY);
            this.navigationPanePanel2.Controls.Add(this.btnThem);
            this.navigationPanePanel2.Controls.Add(this.cboBan);
            this.navigationPanePanel2.Controls.Add(this.cboGiaoVien);
            this.navigationPanePanel2.Controls.Add(this.cboNamHoc);
            this.navigationPanePanel2.Controls.Add(this.cboKhoi);
            this.navigationPanePanel2.Controls.Add(this.labelX8);
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
            this.navigationPanePanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(246, 429);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = global::QuanLiHocSinh.Properties.Resources.Sua;
            this.btnSua.Location = new System.Drawing.Point(166, 321);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Image = global::QuanLiHocSinh.Properties.Resources.Xoa;
            this.btnXoa.Location = new System.Drawing.Point(85, 322);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Image = global::QuanLiHocSinh.Properties.Resources.Huybo;
            this.btnHuy.Location = new System.Drawing.Point(126, 362);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 30);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDongY.Image = global::QuanLiHocSinh.Properties.Resources.Dongy;
            this.btnDongY.Location = new System.Drawing.Point(30, 362);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(90, 30);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDongY.TabIndex = 9;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnThem.Location = new System.Drawing.Point(4, 322);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboBan
            // 
            this.cboBan.DisplayMember = "Text";
            this.cboBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboBan.FormattingEnabled = true;
            this.cboBan.ItemHeight = 15;
            this.cboBan.Location = new System.Drawing.Point(11, 285);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(211, 21);
            this.cboBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboBan.TabIndex = 5;
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.DisplayMember = "Text";
            this.cboGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboGiaoVien.FormattingEnabled = true;
            this.cboGiaoVien.ItemHeight = 15;
            this.cboGiaoVien.Location = new System.Drawing.Point(11, 233);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(211, 21);
            this.cboGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboGiaoVien.TabIndex = 5;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DisplayMember = "Text";
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.ItemHeight = 15;
            this.cboNamHoc.Location = new System.Drawing.Point(11, 181);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(211, 21);
            this.cboNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboNamHoc.TabIndex = 4;
            // 
            // cboKhoi
            // 
            this.cboKhoi.DisplayMember = "Text";
            this.cboKhoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboKhoi.FormattingEnabled = true;
            this.cboKhoi.ItemHeight = 15;
            this.cboKhoi.Location = new System.Drawing.Point(11, 130);
            this.cboKhoi.Name = "cboKhoi";
            this.cboKhoi.Size = new System.Drawing.Size(96, 21);
            this.cboKhoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboKhoi.TabIndex = 2;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX8.Location = new System.Drawing.Point(11, 261);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(124, 23);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Phân ban:";
            // 
            // txtTenLop
            // 
            // 
            // 
            // 
            this.txtTenLop.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenLop.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenLop.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenLop.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenLop.Border.Class = "TextBoxBorder";
            this.txtTenLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTenLop.Location = new System.Drawing.Point(11, 80);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(211, 21);
            this.txtTenLop.TabIndex = 1;
            this.txtTenLop.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTenLop.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX6.Location = new System.Drawing.Point(11, 209);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(155, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Giáo viên chủ nhiệm:";
            // 
            // txtSiSo
            // 
            // 
            // 
            // 
            this.txtSiSo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtSiSo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtSiSo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtSiSo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtSiSo.Border.Class = "TextBoxBorder";
            this.txtSiSo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSiSo.Location = new System.Drawing.Point(126, 130);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(96, 21);
            this.txtSiSo.TabIndex = 3;
            this.txtSiSo.Enter += new System.EventHandler(this.txt_Enter);
            this.txtSiSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiSo_KeyPress);
            this.txtSiSo.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX4.Location = new System.Drawing.Point(11, 157);
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
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX5.Location = new System.Drawing.Point(126, 107);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(96, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Sỉ số:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX2.Location = new System.Drawing.Point(11, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên lớp:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX3.Location = new System.Drawing.Point(11, 108);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Khối lớp:";
            // 
            // txtMaLop
            // 
            // 
            // 
            // 
            this.txtMaLop.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaLop.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaLop.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaLop.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaLop.Border.Class = "TextBoxBorder";
            this.txtMaLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMaLop.Location = new System.Drawing.Point(11, 29);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(211, 21);
            this.txtMaLop.TabIndex = 1;
            this.txtMaLop.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelX1.Location = new System.Drawing.Point(11, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã lớp:";
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
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.txtTim);
            this.navigationPanePanel1.Controls.Add(this.labelX7);
            this.navigationPanePanel1.Controls.Add(this.btnTim);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(246, 453);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.Location = new System.Drawing.Point(11, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(155, 21);
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
            this.labelX7.Size = new System.Drawing.Size(189, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Nhập thông tin tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTim.Image = global::QuanLiHocSinh.Properties.Resources.Timkiem;
            this.btnTim.Location = new System.Drawing.Point(45, 70);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(133, 28);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm kiếm";
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.contextMenuBar2);
            this.groupPanel1.Controls.Add(this.grdLop);
            this.groupPanel1.Controls.Add(this.bnaLop);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(248, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1114, 557);
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
            // contextMenuBar2
            // 
            this.contextMenuBar2.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.contextMenuBar2.Location = new System.Drawing.Point(547, 246);
            this.contextMenuBar2.Name = "contextMenuBar2";
            this.contextMenuBar2.Size = new System.Drawing.Size(75, 25);
            this.contextMenuBar2.Stretch = true;
            this.contextMenuBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.contextMenuBar2.TabIndex = 18;
            this.contextMenuBar2.TabStop = false;
            this.contextMenuBar2.Text = "contextMenuBar2";
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
            this.btnRefesh.Click += new System.EventHandler(this.frmLopHoc_Load);
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
            // grdLop
            // 
            this.grdLop.AllowUserToDeleteRows = false;
            this.grdLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOP1,
            this.TENLOP1,
            this.MAKHOI1,
            this.MANH1,
            this.SISO1,
            this.MAGV1,
            this.BAN1});
            this.contextMenuBar2.SetContextMenuEx(this.grdLop, this.btnMenu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLop.EnableHeadersVisualStyles = false;
            this.grdLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdLop.Location = new System.Drawing.Point(0, 25);
            this.grdLop.Name = "grdLop";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLop.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdLop.Size = new System.Drawing.Size(1108, 511);
            this.grdLop.TabIndex = 9;
            this.grdLop.TabStop = false;
            this.grdLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLop_CellClick);
            // 
            // MALOP1
            // 
            this.MALOP1.DataPropertyName = "MALOP";
            this.MALOP1.HeaderText = "Mã lớp học";
            this.MALOP1.Name = "MALOP1";
            // 
            // TENLOP1
            // 
            this.TENLOP1.DataPropertyName = "TENLOP";
            this.TENLOP1.HeaderText = "Tên lớp học";
            this.TENLOP1.Name = "TENLOP1";
            // 
            // MAKHOI1
            // 
            this.MAKHOI1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MAKHOI1.HeaderText = "Khối lớp";
            this.MAKHOI1.Name = "MAKHOI1";
            // 
            // MANH1
            // 
            this.MANH1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MANH1.HeaderText = "Năm học ";
            this.MANH1.Name = "MANH1";
            // 
            // SISO1
            // 
            this.SISO1.DataPropertyName = "SISO";
            this.SISO1.HeaderText = "Sỉ số";
            this.SISO1.Name = "SISO1";
            // 
            // MAGV1
            // 
            this.MAGV1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MAGV1.HeaderText = "Giáo viên chủ nhiệm";
            this.MAGV1.Name = "MAGV1";
            // 
            // BAN1
            // 
            this.BAN1.DataPropertyName = "MABAN";
            this.BAN1.HeaderText = "Ban";
            this.BAN1.Name = "BAN1";
            // 
            // bnaLop
            // 
            this.bnaLop.AntiAlias = true;
            this.bnaLop.CountLabel = this.bindingNavigatorCountItem;
            this.bnaLop.CountLabelFormat = "of {0}";
            this.bnaLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnaLop.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bnaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnaLop.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem1});
            this.bnaLop.Location = new System.Drawing.Point(0, 0);
            this.bnaLop.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bnaLop.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bnaLop.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bnaLop.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bnaLop.Name = "bnaLop";
            this.bnaLop.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bnaLop.Size = new System.Drawing.Size(1108, 25);
            this.bnaLop.Stretch = true;
            this.bnaLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnaLop.TabIndex = 25;
            this.bnaLop.TabStop = false;
            this.bnaLop.Text = "bindingNavigatorEx1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text = "of {0}";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.BeginGroup = true;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxWidth = 54;
            this.bindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.BeginGroup = true;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Image = global::QuanLiHocSinh.Properties.Resources.add;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "buttonItem2";
            this.buttonItem8.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // buttonItem9
            // 
            this.buttonItem9.Image = global::QuanLiHocSinh.Properties.Resources.delete;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "buttonItem3";
            this.buttonItem9.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::QuanLiHocSinh.Properties.Resources.refresh;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            this.buttonItem1.Click += new System.EventHandler(this.frmLopHoc_Load);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 557);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmLopHoc";
            this.Text = "QUẢN LÝ LỚP HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLopHoc_KeyDown);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGiaoVien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboKhoi;
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
        private DevComponents.DotNetBar.Controls.DataGridViewX grdLop;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar2;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBan;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAKHOI1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MANH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAN1;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bnaLop;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        
    }
}