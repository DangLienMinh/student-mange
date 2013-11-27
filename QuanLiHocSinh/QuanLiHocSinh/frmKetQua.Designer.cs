namespace QuanLiHocSinh
{
    partial class frmKetQua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQua));
            this.grdKQ = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH07 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH08 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH09 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANHKIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnaKQ = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.treLop = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.lblchonlop = new DevComponents.DotNetBar.LabelX();
            this.cboNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDanhSach = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnItemNhapLop = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaKQ)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).BeginInit();
            this.SuspendLayout();
            // 
            // grdKQ
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdKQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHS,
            this.TENHS,
            this.MH01,
            this.MH02,
            this.MH03,
            this.MH04,
            this.MH05,
            this.MH06,
            this.MH07,
            this.MH08,
            this.MH09,
            this.MH10,
            this.MH11,
            this.MH12,
            this.CN,
            this.HANHKIEM});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdKQ.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKQ.EnableHeadersVisualStyles = false;
            this.grdKQ.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdKQ.Location = new System.Drawing.Point(229, 25);
            this.grdKQ.Name = "grdKQ";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdKQ.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdKQ.Size = new System.Drawing.Size(1133, 513);
            this.grdKQ.TabIndex = 28;
            // 
            // MAHS
            // 
            this.MAHS.DataPropertyName = "MAHS";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MAHS.DefaultCellStyle = dataGridViewCellStyle6;
            this.MAHS.HeaderText = "Mã học sinh";
            this.MAHS.Name = "MAHS";
            this.MAHS.ReadOnly = true;
            // 
            // TENHS
            // 
            this.TENHS.DataPropertyName = "TENHS";
            this.TENHS.HeaderText = "Tên học sinh";
            this.TENHS.Name = "TENHS";
            // 
            // MH01
            // 
            this.MH01.HeaderText = "Toán";
            this.MH01.Name = "MH01";
            this.MH01.Width = 55;
            // 
            // MH02
            // 
            this.MH02.HeaderText = "Vật lý";
            this.MH02.Name = "MH02";
            this.MH02.Width = 55;
            // 
            // MH03
            // 
            this.MH03.HeaderText = "Hóa học";
            this.MH03.Name = "MH03";
            this.MH03.Width = 55;
            // 
            // MH04
            // 
            this.MH04.HeaderText = "Sinh học";
            this.MH04.Name = "MH04";
            this.MH04.Width = 55;
            // 
            // MH05
            // 
            this.MH05.HeaderText = "Văn";
            this.MH05.Name = "MH05";
            this.MH05.Width = 55;
            // 
            // MH06
            // 
            this.MH06.HeaderText = "Anh văn";
            this.MH06.Name = "MH06";
            this.MH06.Width = 55;
            // 
            // MH07
            // 
            this.MH07.HeaderText = "Lịch sử";
            this.MH07.Name = "MH07";
            this.MH07.Width = 55;
            // 
            // MH08
            // 
            this.MH08.HeaderText = "Địa lý";
            this.MH08.Name = "MH08";
            this.MH08.Width = 55;
            // 
            // MH09
            // 
            this.MH09.HeaderText = "GDCD";
            this.MH09.Name = "MH09";
            this.MH09.Width = 55;
            // 
            // MH10
            // 
            this.MH10.HeaderText = "Thể dục";
            this.MH10.Name = "MH10";
            this.MH10.Width = 55;
            // 
            // MH11
            // 
            this.MH11.HeaderText = "Công nghệ";
            this.MH11.Name = "MH11";
            this.MH11.Width = 55;
            // 
            // MH12
            // 
            this.MH12.HeaderText = "Tin học";
            this.MH12.Name = "MH12";
            this.MH12.Width = 55;
            // 
            // CN
            // 
            this.CN.HeaderText = "CN";
            this.CN.Name = "CN";
            this.CN.Width = 55;
            // 
            // HANHKIEM
            // 
            this.HANHKIEM.HeaderText = "Hạnh kiểm";
            this.HANHKIEM.Name = "HANHKIEM";
            // 
            // bnaKQ
            // 
            this.bnaKQ.AntiAlias = true;
            this.bnaKQ.CountLabel = this.bindingNavigatorCountItem;
            this.bnaKQ.CountLabelFormat = "of {0}";
            this.bnaKQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnaKQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnaKQ.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.btnRefresh});
            this.bnaKQ.Location = new System.Drawing.Point(229, 0);
            this.bnaKQ.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bnaKQ.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bnaKQ.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bnaKQ.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bnaKQ.Name = "bnaKQ";
            this.bnaKQ.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bnaKQ.Size = new System.Drawing.Size(1133, 25);
            this.bnaKQ.Stretch = true;
            this.bnaKQ.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnaKQ.TabIndex = 29;
            this.bnaKQ.TabStop = false;
            this.bnaKQ.Text = "bindingNavigatorEx1";
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
            // btnRefresh
            // 
            this.btnRefresh.Image = global::QuanLiHocSinh.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "buttonItem1";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhapLop});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 67;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(229, 538);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 27;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(227, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Chọn thông tin";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.treLop);
            this.navigationPanePanel1.Controls.Add(this.lblchonlop);
            this.navigationPanePanel1.Controls.Add(this.cboNamHoc);
            this.navigationPanePanel1.Controls.Add(this.btnDanhSach);
            this.navigationPanePanel1.Controls.Add(this.labelX2);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemNhapLop;
            this.navigationPanePanel1.Size = new System.Drawing.Size(227, 445);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
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
            this.treLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.treLop.Location = new System.Drawing.Point(17, 84);
            this.treLop.Name = "treLop";
            this.treLop.NodesConnector = this.nodeConnector2;
            this.treLop.NodeStyle = this.elementStyle2;
            this.treLop.PathSeparator = ";";
            this.treLop.Size = new System.Drawing.Size(192, 215);
            this.treLop.Styles.Add(this.elementStyle2);
            this.treLop.TabIndex = 31;
            this.treLop.Text = "advTree2";
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
            this.lblchonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblchonlop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblchonlop.Location = new System.Drawing.Point(19, 59);
            this.lblchonlop.Name = "lblchonlop";
            this.lblchonlop.Size = new System.Drawing.Size(75, 23);
            this.lblchonlop.TabIndex = 30;
            this.lblchonlop.Text = "Chọn lớp:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DisplayMember = "Text";
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.ItemHeight = 15;
            this.cboNamHoc.Location = new System.Drawing.Point(18, 28);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(148, 21);
            this.cboNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboNamHoc.TabIndex = 29;
            this.cboNamHoc.SelectedValueChanged += new System.EventHandler(this.cboNamHoc_SelectedValueChanged);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDanhSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSach.Image")));
            this.btnDanhSach.Location = new System.Drawing.Point(37, 322);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(159, 35);
            this.btnDanhSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDanhSach.TabIndex = 2;
            this.btnDanhSach.Text = "Hiển thị danh sách";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(114, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "Chọn năm học:";
            // 
            // btnItemNhapLop
            // 
            this.btnItemNhapLop.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemNhapLop.Checked = true;
            this.btnItemNhapLop.Image = ((System.Drawing.Image)(resources.GetObject("btnItemNhapLop.Image")));
            this.btnItemNhapLop.Name = "btnItemNhapLop";
            this.btnItemNhapLop.OptionGroup = "navBar";
            this.btnItemNhapLop.Text = "Chọn thông tin";
            // 
            // frmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 538);
            this.Controls.Add(this.grdKQ);
            this.Controls.Add(this.bnaKQ);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmKetQua";
            this.Text = "KẾT QUẢ HỌC LỰC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaKQ)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdKQ;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bnaKQ;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.AdvTree.AdvTree treLop;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.LabelX lblchonlop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamHoc;
        private DevComponents.DotNetBar.ButtonX btnDanhSach;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonItem btnItemNhapLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH01;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH02;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH03;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH04;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH05;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH06;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH07;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH08;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH09;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANHKIEM;
    }
}