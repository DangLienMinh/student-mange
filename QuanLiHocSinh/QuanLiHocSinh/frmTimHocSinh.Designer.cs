namespace QuanLiHocSinh
{
    partial class frmTimHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimHocSinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.dtiNgNhapHoc = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.optNgNhapHoc = new System.Windows.Forms.RadioButton();
            this.optDanToc = new System.Windows.Forms.RadioButton();
            this.optTenHS = new System.Windows.Forms.RadioButton();
            this.optMaHS = new System.Windows.Forms.RadioButton();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCuoi = new DevComponents.DotNetBar.ButtonX();
            this.btnSau = new DevComponents.DotNetBar.ButtonX();
            this.btnTruoc = new DevComponents.DotNetBar.ButtonX();
            this.btnDau = new DevComponents.DotNetBar.ButtonX();
            this.txtHienTai = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.txtMaHS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDanToc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.navigationPanePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgNhapHoc)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHocSinh)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(149, 234);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(57, 234);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(72, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.txtDanToc);
            this.navigationPanePanel2.Controls.Add(this.txtTenHS);
            this.navigationPanePanel2.Controls.Add(this.txtMaHS);
            this.navigationPanePanel2.Controls.Add(this.dtiNgNhapHoc);
            this.navigationPanePanel2.Controls.Add(this.labelX5);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Controls.Add(this.labelX1);
            this.navigationPanePanel2.Controls.Add(this.labelX2);
            this.navigationPanePanel2.Controls.Add(this.optNgNhapHoc);
            this.navigationPanePanel2.Controls.Add(this.optDanToc);
            this.navigationPanePanel2.Controls.Add(this.optTenHS);
            this.navigationPanePanel2.Controls.Add(this.optMaHS);
            this.navigationPanePanel2.Controls.Add(this.btnHuy);
            this.navigationPanePanel2.Controls.Add(this.btnTim);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(292, 420);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // dtiNgNhapHoc
            // 
            // 
            // 
            // 
            this.dtiNgNhapHoc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiNgNhapHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgNhapHoc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiNgNhapHoc.ButtonDropDown.Visible = true;
            this.dtiNgNhapHoc.IsPopupCalendarOpen = false;
            this.dtiNgNhapHoc.Location = new System.Drawing.Point(135, 182);
            // 
            // 
            // 
            this.dtiNgNhapHoc.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgNhapHoc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgNhapHoc.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiNgNhapHoc.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiNgNhapHoc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgNhapHoc.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
            this.dtiNgNhapHoc.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiNgNhapHoc.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgNhapHoc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiNgNhapHoc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgNhapHoc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiNgNhapHoc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgNhapHoc.MonthCalendar.TodayButtonVisible = true;
            this.dtiNgNhapHoc.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiNgNhapHoc.Name = "dtiNgNhapHoc";
            this.dtiNgNhapHoc.Size = new System.Drawing.Size(112, 20);
            this.dtiNgNhapHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiNgNhapHoc.TabIndex = 30;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(40, 179);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 23);
            this.labelX5.TabIndex = 29;
            this.labelX5.Text = "Ngày nhập học:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(40, 131);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Dân tộc:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 82);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "Tên học sinh:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(40, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "Mã học sinh:";
            // 
            // optNgNhapHoc
            // 
            this.optNgNhapHoc.AutoSize = true;
            this.optNgNhapHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.optNgNhapHoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optNgNhapHoc.Location = new System.Drawing.Point(15, 163);
            this.optNgNhapHoc.Name = "optNgNhapHoc";
            this.optNgNhapHoc.Size = new System.Drawing.Size(140, 17);
            this.optNgNhapHoc.TabIndex = 18;
            this.optNgNhapHoc.TabStop = true;
            this.optNgNhapHoc.Text = "Tìm theo ngày nhập học";
            this.optNgNhapHoc.UseVisualStyleBackColor = true;
            // 
            // optDanToc
            // 
            this.optDanToc.AutoSize = true;
            this.optDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.optDanToc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optDanToc.Location = new System.Drawing.Point(15, 114);
            this.optDanToc.Name = "optDanToc";
            this.optDanToc.Size = new System.Drawing.Size(105, 17);
            this.optDanToc.TabIndex = 18;
            this.optDanToc.TabStop = true;
            this.optDanToc.Text = "Tìm theo dân tộc";
            this.optDanToc.UseVisualStyleBackColor = true;
            // 
            // optTenHS
            // 
            this.optTenHS.AutoSize = true;
            this.optTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.optTenHS.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optTenHS.Location = new System.Drawing.Point(15, 65);
            this.optTenHS.Name = "optTenHS";
            this.optTenHS.Size = new System.Drawing.Size(127, 17);
            this.optTenHS.TabIndex = 18;
            this.optTenHS.TabStop = true;
            this.optTenHS.Text = "Tìm theo tên học sinh";
            this.optTenHS.UseVisualStyleBackColor = true;
            // 
            // optMaHS
            // 
            this.optMaHS.AutoSize = true;
            this.optMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.optMaHS.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optMaHS.Location = new System.Drawing.Point(15, 16);
            this.optMaHS.Name = "optMaHS";
            this.optMaHS.Size = new System.Drawing.Size(126, 17);
            this.optMaHS.TabIndex = 18;
            this.optMaHS.TabStop = true;
            this.optMaHS.Text = "Tìm theo mã học sinh";
            this.optMaHS.UseVisualStyleBackColor = true;
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnCuoi);
            this.groupPanel1.Controls.Add(this.btnSau);
            this.groupPanel1.Controls.Add(this.btnTruoc);
            this.groupPanel1.Controls.Add(this.btnDau);
            this.groupPanel1.Controls.Add(this.txtHienTai);
            this.groupPanel1.Controls.Add(this.grdHocSinh);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(294, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(741, 548);
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
            this.groupPanel1.TabIndex = 9;
            this.groupPanel1.Text = "DANH SÁCH HỌC SINH";
            // 
            // btnCuoi
            // 
            this.btnCuoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCuoi.Location = new System.Drawing.Point(478, 10);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(64, 23);
            this.btnCuoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCuoi.TabIndex = 20;
            this.btnCuoi.Text = ">|";
            // 
            // btnSau
            // 
            this.btnSau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSau.Location = new System.Drawing.Point(406, 10);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(64, 23);
            this.btnSau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSau.TabIndex = 19;
            this.btnSau.Text = ">";
            // 
            // btnTruoc
            // 
            this.btnTruoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTruoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruoc.Location = new System.Drawing.Point(253, 10);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(64, 23);
            this.btnTruoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruoc.TabIndex = 18;
            this.btnTruoc.Text = "<";
            // 
            // btnDau
            // 
            this.btnDau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDau.Location = new System.Drawing.Point(183, 10);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(64, 23);
            this.btnDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDau.TabIndex = 17;
            this.btnDau.Text = "|<";
            // 
            // txtHienTai
            // 
            this.txtHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtHienTai.Border.Class = "TextBoxBorder";
            this.txtHienTai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHienTai.Location = new System.Drawing.Point(328, 12);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(69, 20);
            this.txtHienTai.TabIndex = 15;
            this.txtHienTai.TabStop = false;
            // 
            // grdHocSinh
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdHocSinh.EnableHeadersVisualStyles = false;
            this.grdHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdHocSinh.Location = new System.Drawing.Point(0, 53);
            this.grdHocSinh.Name = "grdHocSinh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHocSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdHocSinh.Size = new System.Drawing.Size(735, 474);
            this.grdHocSinh.TabIndex = 9;
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
            this.NGNHAPHOC.HeaderText = "Ngày nhập học";
            this.NGNHAPHOC.Name = "NGNHAPHOC";
            // 
            // HINHANHHS
            // 
            this.HINHANHHS.DataPropertyName = "HINHANHHS";
            this.HINHANHHS.HeaderText = "Hình ảnh";
            this.HINHANHHS.Name = "HINHANHHS";
            this.HINHANHHS.Visible = false;
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(292, 444);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
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
            this.navigationPane1.Size = new System.Drawing.Size(294, 548);
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
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(292, 24);
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
            // txtMaHS
            // 
            // 
            // 
            // 
            this.txtMaHS.Border.Class = "TextBoxBorder";
            this.txtMaHS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHS.Location = new System.Drawing.Point(135, 36);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(112, 20);
            this.txtMaHS.TabIndex = 31;
            // 
            // txtTenHS
            // 
            // 
            // 
            // 
            this.txtTenHS.Border.Class = "TextBoxBorder";
            this.txtTenHS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHS.Location = new System.Drawing.Point(135, 85);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(112, 20);
            this.txtTenHS.TabIndex = 31;
            // 
            // txtDanToc
            // 
            // 
            // 
            // 
            this.txtDanToc.Border.Class = "TextBoxBorder";
            this.txtDanToc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDanToc.Location = new System.Drawing.Point(135, 134);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(112, 20);
            this.txtDanToc.TabIndex = 31;
            // 
            // frmTimHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 548);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmTimHocSinh";
            this.Text = "frmTimHocSinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimHocSinh_Load);
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPanePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgNhapHoc)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHocSinh)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private System.Windows.Forms.RadioButton optMaHS;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnCuoi;
        private DevComponents.DotNetBar.ButtonX btnSau;
        private DevComponents.DotNetBar.ButtonX btnTruoc;
        private DevComponents.DotNetBar.ButtonX btnDau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHienTai;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdHocSinh;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton optTenHS;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.RadioButton optDanToc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiNgNhapHoc;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.RadioButton optNgNhapHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINHHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINHHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAIHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGNHAPHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANHHS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDanToc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHS;
    }
}