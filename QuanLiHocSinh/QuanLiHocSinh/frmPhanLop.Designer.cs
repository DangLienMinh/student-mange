namespace QuanLiHocSinh
{
    partial class frmPhanLop
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
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lvwLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboKhoiLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelConTren = new System.Windows.Forms.Panel();
            this.groupPanelLopCu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboKhoiLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboNamHocCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanelLopMoi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboNamHocMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.colHoTenMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHSMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwLopMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyen = new DevComponents.DotNetBar.ButtonX();
            this.panelConPhai = new System.Windows.Forms.Panel();
            this.panelChaTrai = new System.Windows.Forms.Panel();
            this.splitContainerPhanLop = new System.Windows.Forms.SplitContainer();
            this.panelConTren.SuspendLayout();
            this.groupPanelLopCu.SuspendLayout();
            this.groupPanelLopMoi.SuspendLayout();
            this.panelConPhai.SuspendLayout();
            this.panelChaTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhanLop)).BeginInit();
            this.splitContainerPhanLop.Panel1.SuspendLayout();
            this.splitContainerPhanLop.Panel2.SuspendLayout();
            this.splitContainerPhanLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(55, 10);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(57, 20);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Năm học:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(55, 70);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(57, 19);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Lớp:";
            // 
            // lvwLopCu
            // 
            // 
            // 
            // 
            this.lvwLopCu.Border.Class = "ListViewBorder";
            this.lvwLopCu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvwLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSCu,
            this.colHoTenCu});
            this.lvwLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLopCu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLopCu.FullRowSelect = true;
            this.lvwLopCu.Location = new System.Drawing.Point(0, 120);
            this.lvwLopCu.Name = "lvwLopCu";
            this.lvwLopCu.Size = new System.Drawing.Size(665, 418);
            this.lvwLopCu.TabIndex = 2;
            this.lvwLopCu.UseCompatibleStateImageBehavior = false;
            this.lvwLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSCu
            // 
            this.colMaHSCu.Text = "Mã học sinh";
            this.colMaHSCu.Width = 90;
            // 
            // colHoTenCu
            // 
            this.colHoTenCu.Text = "Họ và tên";
            this.colHoTenCu.Width = 267;
            // 
            // cboLopMoi
            // 
            this.cboLopMoi.DisplayMember = "Text";
            this.cboLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopMoi.FormattingEnabled = true;
            this.cboLopMoi.ItemHeight = 14;
            this.cboLopMoi.Location = new System.Drawing.Point(125, 70);
            this.cboLopMoi.Name = "cboLopMoi";
            this.cboLopMoi.Size = new System.Drawing.Size(121, 20);
            this.cboLopMoi.TabIndex = 3;
            this.cboLopMoi.SelectedValueChanged += new System.EventHandler(this.cboLopMoi_SelectedValueChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(55, 40);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(57, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Khối lớp:";
            // 
            // cboKhoiLopMoi
            // 
            this.cboKhoiLopMoi.DisplayMember = "Text";
            this.cboKhoiLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoiLopMoi.FormattingEnabled = true;
            this.cboKhoiLopMoi.ItemHeight = 14;
            this.cboKhoiLopMoi.Location = new System.Drawing.Point(125, 40);
            this.cboKhoiLopMoi.Name = "cboKhoiLopMoi";
            this.cboKhoiLopMoi.Size = new System.Drawing.Size(121, 20);
            this.cboKhoiLopMoi.TabIndex = 2;
            this.cboKhoiLopMoi.SelectedValueChanged += new System.EventHandler(this.cboKhoiLopMoi_SelectedValueChanged);
            // 
            // panelConTren
            // 
            this.panelConTren.Controls.Add(this.groupPanelLopCu);
            this.panelConTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConTren.Location = new System.Drawing.Point(0, 0);
            this.panelConTren.Name = "panelConTren";
            this.panelConTren.Size = new System.Drawing.Size(665, 120);
            this.panelConTren.TabIndex = 0;
            // 
            // groupPanelLopCu
            // 
            this.groupPanelLopCu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopCu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopCu.Controls.Add(this.cboLopCu);
            this.groupPanelLopCu.Controls.Add(this.cboKhoiLopCu);
            this.groupPanelLopCu.Controls.Add(this.cboNamHocCu);
            this.groupPanelLopCu.Controls.Add(this.labelX3);
            this.groupPanelLopCu.Controls.Add(this.labelX2);
            this.groupPanelLopCu.Controls.Add(this.labelX1);
            this.groupPanelLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanelLopCu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanelLopCu.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLopCu.Name = "groupPanelLopCu";
            this.groupPanelLopCu.Size = new System.Drawing.Size(665, 120);
            // 
            // 
            // 
            this.groupPanelLopCu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopCu.Style.BackColorGradientAngle = 90;
            this.groupPanelLopCu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopCu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderBottomWidth = 1;
            this.groupPanelLopCu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopCu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderLeftWidth = 1;
            this.groupPanelLopCu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderRightWidth = 1;
            this.groupPanelLopCu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderTopWidth = 1;
            this.groupPanelLopCu.Style.CornerDiameter = 4;
            this.groupPanelLopCu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopCu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopCu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopCu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelLopCu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelLopCu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLopCu.TabIndex = 1;
            this.groupPanelLopCu.Text = "Thông tin lớp cũ";
            // 
            // cboLopCu
            // 
            this.cboLopCu.DisplayMember = "Text";
            this.cboLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopCu.FormattingEnabled = true;
            this.cboLopCu.ItemHeight = 14;
            this.cboLopCu.Location = new System.Drawing.Point(123, 70);
            this.cboLopCu.Name = "cboLopCu";
            this.cboLopCu.Size = new System.Drawing.Size(121, 20);
            this.cboLopCu.TabIndex = 3;
            this.cboLopCu.SelectedValueChanged += new System.EventHandler(this.cboLopCu_SelectedValueChanged);
            // 
            // cboKhoiLopCu
            // 
            this.cboKhoiLopCu.DisplayMember = "Text";
            this.cboKhoiLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoiLopCu.FormattingEnabled = true;
            this.cboKhoiLopCu.ItemHeight = 14;
            this.cboKhoiLopCu.Location = new System.Drawing.Point(123, 40);
            this.cboKhoiLopCu.Name = "cboKhoiLopCu";
            this.cboKhoiLopCu.Size = new System.Drawing.Size(121, 20);
            this.cboKhoiLopCu.TabIndex = 2;
            this.cboKhoiLopCu.SelectedValueChanged += new System.EventHandler(this.cboKhoiLopCu_SelectedValueChanged);
            // 
            // cboNamHocCu
            // 
            this.cboNamHocCu.DisplayMember = "Text";
            this.cboNamHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHocCu.FormattingEnabled = true;
            this.cboNamHocCu.ItemHeight = 14;
            this.cboNamHocCu.Location = new System.Drawing.Point(123, 10);
            this.cboNamHocCu.Name = "cboNamHocCu";
            this.cboNamHocCu.Size = new System.Drawing.Size(121, 20);
            this.cboNamHocCu.TabIndex = 1;
            this.cboNamHocCu.SelectedValueChanged += new System.EventHandler(this.cboNamHocCu_SelectedValueChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(53, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 19);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Lớp:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(53, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khối lớp:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(53, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Năm học:";
            // 
            // groupPanelLopMoi
            // 
            this.groupPanelLopMoi.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopMoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopMoi.Controls.Add(this.cboLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX5);
            this.groupPanelLopMoi.Controls.Add(this.cboKhoiLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX4);
            this.groupPanelLopMoi.Controls.Add(this.cboNamHocMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX6);
            this.groupPanelLopMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelLopMoi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanelLopMoi.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLopMoi.Name = "groupPanelLopMoi";
            this.groupPanelLopMoi.Size = new System.Drawing.Size(623, 120);
            // 
            // 
            // 
            this.groupPanelLopMoi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopMoi.Style.BackColorGradientAngle = 90;
            this.groupPanelLopMoi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopMoi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderBottomWidth = 1;
            this.groupPanelLopMoi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopMoi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderLeftWidth = 1;
            this.groupPanelLopMoi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderRightWidth = 1;
            this.groupPanelLopMoi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderTopWidth = 1;
            this.groupPanelLopMoi.Style.CornerDiameter = 4;
            this.groupPanelLopMoi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopMoi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopMoi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopMoi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelLopMoi.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelLopMoi.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLopMoi.TabIndex = 4;
            this.groupPanelLopMoi.Text = "Thông tin lớp mới";
            // 
            // cboNamHocMoi
            // 
            this.cboNamHocMoi.DisplayMember = "Text";
            this.cboNamHocMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHocMoi.FormattingEnabled = true;
            this.cboNamHocMoi.ItemHeight = 14;
            this.cboNamHocMoi.Location = new System.Drawing.Point(125, 10);
            this.cboNamHocMoi.Name = "cboNamHocMoi";
            this.cboNamHocMoi.Size = new System.Drawing.Size(121, 20);
            this.cboNamHocMoi.TabIndex = 1;
            this.cboNamHocMoi.SelectedValueChanged += new System.EventHandler(this.cboNamHocMoi_SelectedValueChanged);
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Họ và tên";
            this.colHoTenMoi.Width = 267;
            // 
            // colMaHSMoi
            // 
            this.colMaHSMoi.Text = "Mã học sinh";
            this.colMaHSMoi.Width = 90;
            // 
            // lvwLopMoi
            // 
            // 
            // 
            // 
            this.lvwLopMoi.Border.Class = "ListViewBorder";
            this.lvwLopMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvwLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSMoi,
            this.colHoTenMoi});
            this.lvwLopMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLopMoi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLopMoi.FullRowSelect = true;
            this.lvwLopMoi.Location = new System.Drawing.Point(0, 120);
            this.lvwLopMoi.Name = "lvwLopMoi";
            this.lvwLopMoi.Size = new System.Drawing.Size(623, 418);
            this.lvwLopMoi.TabIndex = 5;
            this.lvwLopMoi.UseCompatibleStateImageBehavior = false;
            this.lvwLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(12, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(43, 47);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Tooltip = "Đóng bảng phân lớp";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(12, 153);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(43, 46);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Tooltip = "Lưu bảng phân lớp";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(12, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 46);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Hủy";
            this.btnXoa.Tooltip = "Xóa học sinh khỏi lớp mới";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyen.Location = new System.Drawing.Point(12, 28);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(43, 37);
            this.btnChuyen.TabIndex = 1;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.Tooltip = "Chuyển lớp";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // panelConPhai
            // 
            this.panelConPhai.Controls.Add(this.btnThoat);
            this.panelConPhai.Controls.Add(this.btnLuu);
            this.panelConPhai.Controls.Add(this.btnXoa);
            this.panelConPhai.Controls.Add(this.btnChuyen);
            this.panelConPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConPhai.Location = new System.Drawing.Point(665, 0);
            this.panelConPhai.Name = "panelConPhai";
            this.panelConPhai.Size = new System.Drawing.Size(70, 538);
            this.panelConPhai.TabIndex = 3;
            // 
            // panelChaTrai
            // 
            this.panelChaTrai.Controls.Add(this.lvwLopCu);
            this.panelChaTrai.Controls.Add(this.panelConTren);
            this.panelChaTrai.Controls.Add(this.panelConPhai);
            this.panelChaTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChaTrai.Location = new System.Drawing.Point(0, 0);
            this.panelChaTrai.Name = "panelChaTrai";
            this.panelChaTrai.Size = new System.Drawing.Size(735, 538);
            this.panelChaTrai.TabIndex = 0;
            // 
            // splitContainerPhanLop
            // 
            this.splitContainerPhanLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPhanLop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPhanLop.Name = "splitContainerPhanLop";
            // 
            // splitContainerPhanLop.Panel1
            // 
            this.splitContainerPhanLop.Panel1.Controls.Add(this.panelChaTrai);
            // 
            // splitContainerPhanLop.Panel2
            // 
            this.splitContainerPhanLop.Panel2.Controls.Add(this.lvwLopMoi);
            this.splitContainerPhanLop.Panel2.Controls.Add(this.groupPanelLopMoi);
            this.splitContainerPhanLop.Size = new System.Drawing.Size(1362, 538);
            this.splitContainerPhanLop.SplitterDistance = 735;
            this.splitContainerPhanLop.TabIndex = 1;
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 538);
            this.Controls.Add(this.splitContainerPhanLop);
            this.DoubleBuffered = true;
            this.Name = "frmPhanLop";
            this.Text = "PHÂN LỚP HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            this.panelConTren.ResumeLayout(false);
            this.groupPanelLopCu.ResumeLayout(false);
            this.groupPanelLopMoi.ResumeLayout(false);
            this.panelConPhai.ResumeLayout(false);
            this.panelChaTrai.ResumeLayout(false);
            this.splitContainerPhanLop.Panel1.ResumeLayout(false);
            this.splitContainerPhanLop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhanLop)).EndInit();
            this.splitContainerPhanLop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ListViewEx lvwLopCu;
        private System.Windows.Forms.ColumnHeader colMaHSCu;
        private System.Windows.Forms.ColumnHeader colHoTenCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLopMoi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboKhoiLopMoi;
        private System.Windows.Forms.Panel panelConTren;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboKhoiLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHocCu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHocMoi;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
        private System.Windows.Forms.ColumnHeader colMaHSMoi;
        private DevComponents.DotNetBar.Controls.ListViewEx lvwLopMoi;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnChuyen;
        private System.Windows.Forms.Panel panelConPhai;
        private System.Windows.Forms.Panel panelChaTrai;
        private System.Windows.Forms.SplitContainer splitContainerPhanLop;
    }
}