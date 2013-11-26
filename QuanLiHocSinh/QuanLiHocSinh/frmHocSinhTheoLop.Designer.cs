namespace QuanLiHocSinh
{
    partial class frmHocSinhTheoLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinhTheoLop));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblchonlop = new DevComponents.DotNetBar.LabelX();
            this.cboNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.treLop = new DevComponents.AdvTree.AdvTree();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnDanhSach = new DevComponents.DotNetBar.ButtonX();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grdHocSinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINHHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINHHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAIHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGNHAPHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANHHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnaDanhSach = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).BeginInit();
            this.navigationPanePanel2.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 34;
            this.labelX2.Text = "Chọn năm học:";
            // 
            // lblchonlop
            // 
            // 
            // 
            // 
            this.lblchonlop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblchonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblchonlop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblchonlop.Location = new System.Drawing.Point(14, 66);
            this.lblchonlop.Name = "lblchonlop";
            this.lblchonlop.Size = new System.Drawing.Size(75, 23);
            this.lblchonlop.TabIndex = 37;
            this.lblchonlop.Text = "Chọn lớp:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DisplayMember = "Text";
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.ItemHeight = 14;
            this.cboNamHoc.Location = new System.Drawing.Point(14, 36);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(148, 20);
            this.cboNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedValueChanged += new System.EventHandler(this.cboNamHoc_SelectedValueChanged);
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // treLop
            // 
            this.treLop.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treLop.AllowDrop = true;
            this.treLop.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treLop.BackgroundStyle.Class = "TreeBorderKey";
            this.treLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treLop.Location = new System.Drawing.Point(14, 95);
            this.treLop.Name = "treLop";
            this.treLop.NodesConnector = this.nodeConnector2;
            this.treLop.NodeStyle = this.elementStyle2;
            this.treLop.PathSeparator = ";";
            this.treLop.Size = new System.Drawing.Size(177, 245);
            this.treLop.Styles.Add(this.elementStyle2);
            this.treLop.TabIndex = 2;
            this.treLop.Text = "advTree2";
            this.treLop.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treLop_NodeDoubleClick);
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.treLop);
            this.navigationPanePanel2.Controls.Add(this.lblchonlop);
            this.navigationPanePanel2.Controls.Add(this.cboNamHoc);
            this.navigationPanePanel2.Controls.Add(this.btnDanhSach);
            this.navigationPanePanel2.Controls.Add(this.labelX2);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(209, 445);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDanhSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Image = global::QuanLiHocSinh.Properties.Resources.danhsach;
            this.btnDanhSach.Location = new System.Drawing.Point(14, 366);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(177, 37);
            this.btnDanhSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDanhSach.TabIndex = 3;
            this.btnDanhSach.Text = "Hiển thị danh sách";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
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
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhap});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 67;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(211, 538);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 8;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(209, 24);
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.grdHocSinh);
            this.groupPanel1.Controls.Add(this.bnaDanhSach);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(211, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1151, 538);
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
            this.groupPanel1.TabIndex = 10;
            this.groupPanel1.Text = "DANH SÁCH LỚP";
            // 
            // grdHocSinh
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHS,
            this.TENHS,
            this.NGSINHHS,
            this.GIOITINHHS,
            this.DIACHIHS,
            this.DIENTHOAIHS,
            this.DANTOC,
            this.NGNHAPHOC,
            this.HINHANHHS});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHocSinh.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHocSinh.EnableHeadersVisualStyles = false;
            this.grdHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdHocSinh.Location = new System.Drawing.Point(0, 25);
            this.grdHocSinh.Name = "grdHocSinh";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHocSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdHocSinh.Size = new System.Drawing.Size(1145, 492);
            this.grdHocSinh.TabIndex = 16;
            this.grdHocSinh.TabStop = false;
            // 
            // MAHS
            // 
            this.MAHS.DataPropertyName = "MAHS";
            this.MAHS.HeaderText = "Mã học sinh";
            this.MAHS.Name = "MAHS";
            // 
            // TENHS
            // 
            this.TENHS.DataPropertyName = "TENHS";
            this.TENHS.HeaderText = "Tên học sinh";
            this.TENHS.Name = "TENHS";
            // 
            // NGSINHHS
            // 
            this.NGSINHHS.DataPropertyName = "NGSINHHS";
            dataGridViewCellStyle12.Format = "dd/MM/yyyy";
            this.NGSINHHS.DefaultCellStyle = dataGridViewCellStyle12;
            this.NGSINHHS.HeaderText = "Ngày sinh";
            this.NGSINHHS.Name = "NGSINHHS";
            // 
            // GIOITINHHS
            // 
            this.GIOITINHHS.DataPropertyName = "GIOITINHHS";
            this.GIOITINHHS.HeaderText = "Giới tính";
            this.GIOITINHHS.Name = "GIOITINHHS";
            // 
            // DIACHIHS
            // 
            this.DIACHIHS.DataPropertyName = "DIACHIHS";
            this.DIACHIHS.HeaderText = "Địa chỉ";
            this.DIACHIHS.Name = "DIACHIHS";
            // 
            // DIENTHOAIHS
            // 
            this.DIENTHOAIHS.DataPropertyName = "DIENTHOAIHS";
            this.DIENTHOAIHS.HeaderText = "Điện thoại";
            this.DIENTHOAIHS.Name = "DIENTHOAIHS";
            // 
            // DANTOC
            // 
            this.DANTOC.DataPropertyName = "DANTOC";
            this.DANTOC.HeaderText = "Dân tộc";
            this.DANTOC.Name = "DANTOC";
            // 
            // NGNHAPHOC
            // 
            this.NGNHAPHOC.DataPropertyName = "NGNHAPHOC";
            dataGridViewCellStyle13.Format = "dd/MM/yyyy";
            this.NGNHAPHOC.DefaultCellStyle = dataGridViewCellStyle13;
            this.NGNHAPHOC.HeaderText = "Ngày nhập học";
            this.NGNHAPHOC.Name = "NGNHAPHOC";
            this.NGNHAPHOC.Width = 120;
            // 
            // HINHANHHS
            // 
            this.HINHANHHS.DataPropertyName = "HINHANHHS";
            this.HINHANHHS.HeaderText = "Hình ảnh";
            this.HINHANHHS.Name = "HINHANHHS";
            this.HINHANHHS.Visible = false;
            // 
            // bnaDanhSach
            // 
            this.bnaDanhSach.AntiAlias = true;
            this.bnaDanhSach.CountLabel = this.bindingNavigatorCountItem;
            this.bnaDanhSach.CountLabelFormat = "of {0}";
            this.bnaDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnaDanhSach.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bnaDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnaDanhSach.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bnaDanhSach.Location = new System.Drawing.Point(0, 0);
            this.bnaDanhSach.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bnaDanhSach.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bnaDanhSach.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bnaDanhSach.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bnaDanhSach.Name = "bnaDanhSach";
            this.bnaDanhSach.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bnaDanhSach.Size = new System.Drawing.Size(1145, 25);
            this.bnaDanhSach.Stretch = true;
            this.bnaDanhSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnaDanhSach.TabIndex = 22;
            this.bnaDanhSach.TabStop = false;
            this.bnaDanhSach.Text = "bindingNavigatorEx1";
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
            // frmHocSinhTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 538);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmHocSinhTheoLop";
            this.Text = "DANH SÁCH HỌC SINH THEO LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocSinhTheoLop_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHocSinhTheoLop_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).EndInit();
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPane1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblchonlop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHoc;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.AdvTree.AdvTree treLop;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnDanhSach;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINHHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINHHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAIHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGNHAPHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANHHS;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bnaDanhSach;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
    }
}