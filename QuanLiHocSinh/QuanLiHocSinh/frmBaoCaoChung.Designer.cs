namespace QuanLiHocSinh
{
    partial class frmBaoCaoChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoChung));
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnInDSGiaoVien = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnInDSLop = new DevComponents.DotNetBar.ButtonX();
            this.cboNamHocDSLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel3 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnDshocsinh = new DevComponents.DotNetBar.ButtonX();
            this.treLop = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.lblchonlop = new DevComponents.DotNetBar.LabelX();
            this.cboNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.treLopTheHS = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector3 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle3 = new DevComponents.DotNetBar.ElementStyle();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnInTheHS = new DevComponents.DotNetBar.ButtonX();
            this.cboNamHocTheHS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.rptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.navigationPanePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).BeginInit();
            this.navigationPanePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treLopTheHS)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel3);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhap,
            this.btnItemTim,
            this.buttonItem1});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 137;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(248, 536);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 1;
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
            this.navigationPane1.TitlePanel.Text = "In thẻ học sinh";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.groupPanel2);
            this.navigationPanePanel1.Controls.Add(this.groupPanel1);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(246, 534);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnInDSGiaoVien);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 158);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(246, 144);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "In danh sách giáo viên";
            // 
            // btnInDSGiaoVien
            // 
            this.btnInDSGiaoVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInDSGiaoVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInDSGiaoVien.Location = new System.Drawing.Point(81, 36);
            this.btnInDSGiaoVien.Name = "btnInDSGiaoVien";
            this.btnInDSGiaoVien.Size = new System.Drawing.Size(75, 23);
            this.btnInDSGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInDSGiaoVien.TabIndex = 46;
            this.btnInDSGiaoVien.Text = "In";
            this.btnInDSGiaoVien.Click += new System.EventHandler(this.btnInDSGiaoVien_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnInDSLop);
            this.groupPanel1.Controls.Add(this.cboNamHocDSLop);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(246, 158);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "In danh sách lớp";
            // 
            // btnInDSLop
            // 
            this.btnInDSLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInDSLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInDSLop.Location = new System.Drawing.Point(81, 90);
            this.btnInDSLop.Name = "btnInDSLop";
            this.btnInDSLop.Size = new System.Drawing.Size(75, 23);
            this.btnInDSLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInDSLop.TabIndex = 48;
            this.btnInDSLop.Text = "In";
            this.btnInDSLop.Click += new System.EventHandler(this.btnInDSLop_Click);
            // 
            // cboNamHocDSLop
            // 
            this.cboNamHocDSLop.DisplayMember = "Text";
            this.cboNamHocDSLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHocDSLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHocDSLop.FormattingEnabled = true;
            this.cboNamHocDSLop.ItemHeight = 15;
            this.cboNamHocDSLop.Location = new System.Drawing.Point(19, 45);
            this.cboNamHocDSLop.Name = "cboNamHocDSLop";
            this.cboNamHocDSLop.Size = new System.Drawing.Size(148, 21);
            this.cboNamHocDSLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNamHocDSLop.TabIndex = 46;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 23);
            this.labelX1.TabIndex = 47;
            this.labelX1.Text = "Chọn năm học:";
            // 
            // btnItemTim
            // 
            this.btnItemTim.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemTim.Image = ((System.Drawing.Image)(resources.GetObject("btnItemTim.Image")));
            this.btnItemTim.Name = "btnItemTim";
            this.btnItemTim.OptionGroup = "navBar";
            this.btnItemTim.Text = "In danh sách lớp, giáo viên";
            // 
            // navigationPanePanel3
            // 
            this.navigationPanePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel3.Controls.Add(this.btnDshocsinh);
            this.navigationPanePanel3.Controls.Add(this.treLop);
            this.navigationPanePanel3.Controls.Add(this.lblchonlop);
            this.navigationPanePanel3.Controls.Add(this.cboNamHoc);
            this.navigationPanePanel3.Controls.Add(this.labelX2);
            this.navigationPanePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel3.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel3.Name = "navigationPanePanel3";
            this.navigationPanePanel3.ParentItem = this.buttonItem1;
            this.navigationPanePanel3.Size = new System.Drawing.Size(246, 397);
            this.navigationPanePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel3.Style.GradientAngle = 90;
            this.navigationPanePanel3.TabIndex = 4;
            // 
            // btnDshocsinh
            // 
            this.btnDshocsinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDshocsinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDshocsinh.Location = new System.Drawing.Point(69, 266);
            this.btnDshocsinh.Name = "btnDshocsinh";
            this.btnDshocsinh.Size = new System.Drawing.Size(75, 23);
            this.btnDshocsinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDshocsinh.TabIndex = 47;
            this.btnDshocsinh.Text = "In";
            this.btnDshocsinh.Click += new System.EventHandler(this.btnDshocsinh_Click);
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
            this.treLop.Location = new System.Drawing.Point(11, 97);
            this.treLop.Name = "treLop";
            this.treLop.NodesConnector = this.nodeConnector2;
            this.treLop.NodeStyle = this.elementStyle2;
            this.treLop.PathSeparator = ";";
            this.treLop.Size = new System.Drawing.Size(177, 142);
            this.treLop.Styles.Add(this.elementStyle2);
            this.treLop.TabIndex = 44;
            this.treLop.Text = "advTree2";
            this.treLop.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treLop_NodeClick);
            this.treLop.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treLop_NodeDoubleClick);
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // lblchonlop
            // 
            // 
            // 
            // 
            this.lblchonlop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblchonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblchonlop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblchonlop.Location = new System.Drawing.Point(11, 68);
            this.lblchonlop.Name = "lblchonlop";
            this.lblchonlop.Size = new System.Drawing.Size(75, 23);
            this.lblchonlop.TabIndex = 46;
            this.lblchonlop.Text = "Chọn lớp:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DisplayMember = "Text";
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.ItemHeight = 18;
            this.cboNamHoc.Location = new System.Drawing.Point(11, 38);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(148, 24);
            this.cboNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNamHoc.TabIndex = 43;
            this.cboNamHoc.SelectedValueChanged += new System.EventHandler(this.cboNamHoc_SelectedValueChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(11, 9);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(103, 23);
            this.labelX2.TabIndex = 45;
            this.labelX2.Text = "Chọn năm học:";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "In danh sách học sinh theo lớp";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.treLopTheHS);
            this.navigationPanePanel2.Controls.Add(this.labelX9);
            this.navigationPanePanel2.Controls.Add(this.btnInTheHS);
            this.navigationPanePanel2.Controls.Add(this.cboNamHocTheHS);
            this.navigationPanePanel2.Controls.Add(this.labelX4);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(246, 373);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // treLopTheHS
            // 
            this.treLopTheHS.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treLopTheHS.AllowDrop = true;
            this.treLopTheHS.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treLopTheHS.BackgroundStyle.Class = "TreeBorderKey";
            this.treLopTheHS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treLopTheHS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treLopTheHS.Location = new System.Drawing.Point(20, 117);
            this.treLopTheHS.Name = "treLopTheHS";
            this.treLopTheHS.NodesConnector = this.nodeConnector3;
            this.treLopTheHS.NodeStyle = this.elementStyle3;
            this.treLopTheHS.PathSeparator = ";";
            this.treLopTheHS.Size = new System.Drawing.Size(166, 135);
            this.treLopTheHS.Styles.Add(this.elementStyle3);
            this.treLopTheHS.TabIndex = 52;
            this.treLopTheHS.Text = "advTree2";
            this.treLopTheHS.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treLopTheHS_NodeDoubleClick);
            // 
            // nodeConnector3
            // 
            this.nodeConnector3.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle3
            // 
            this.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelX9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX9.Location = new System.Drawing.Point(22, 88);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 51;
            this.labelX9.Text = "Chọn lớp:";
            // 
            // btnInTheHS
            // 
            this.btnInTheHS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInTheHS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInTheHS.Location = new System.Drawing.Point(69, 271);
            this.btnInTheHS.Name = "btnInTheHS";
            this.btnInTheHS.Size = new System.Drawing.Size(75, 23);
            this.btnInTheHS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInTheHS.TabIndex = 50;
            this.btnInTheHS.Text = "In";
            this.btnInTheHS.Click += new System.EventHandler(this.btnInTheHS_Click);
            // 
            // cboNamHocTheHS
            // 
            this.cboNamHocTheHS.DisplayMember = "Text";
            this.cboNamHocTheHS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHocTheHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHocTheHS.FormattingEnabled = true;
            this.cboNamHocTheHS.ItemHeight = 15;
            this.cboNamHocTheHS.Location = new System.Drawing.Point(22, 46);
            this.cboNamHocTheHS.Name = "cboNamHocTheHS";
            this.cboNamHocTheHS.Size = new System.Drawing.Size(148, 21);
            this.cboNamHocTheHS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNamHocTheHS.TabIndex = 49;
            this.cboNamHocTheHS.SelectedValueChanged += new System.EventHandler(this.cboNamHocTheHS_SelectedValueChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(22, 21);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(103, 23);
            this.labelX4.TabIndex = 48;
            this.labelX4.Text = "Chọn năm học:";
            // 
            // btnItemNhap
            // 
            this.btnItemNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemNhap.Checked = true;
            this.btnItemNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnItemNhap.Image")));
            this.btnItemNhap.Name = "btnItemNhap";
            this.btnItemNhap.OptionGroup = "navBar";
            this.btnItemNhap.Text = "In thẻ học sinh";
            // 
            // rptView
            // 
            this.rptView.ActiveViewIndex = -1;
            this.rptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptView.Location = new System.Drawing.Point(248, 0);
            this.rptView.Name = "rptView";
            this.rptView.Size = new System.Drawing.Size(1114, 536);
            this.rptView.TabIndex = 2;
            // 
            // frmBaoCaoChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 536);
            this.Controls.Add(this.rptView);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmBaoCaoChung";
            this.Text = "BÁO CÁO CHUNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoChung_Load);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.navigationPanePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).EndInit();
            this.navigationPanePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treLopTheHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptView;
        private DevComponents.DotNetBar.ButtonX btnDshocsinh;
        private DevComponents.AdvTree.AdvTree treLop;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.LabelX lblchonlop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHoc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.AdvTree.AdvTree treLopTheHS;
        private DevComponents.AdvTree.NodeConnector nodeConnector3;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnInTheHS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHocTheHS;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnInDSLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHocDSLop;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnInDSGiaoVien;

    }
}