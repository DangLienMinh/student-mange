namespace QuanLiHocSinh
{
    partial class frmDanhSachLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.styleManager3 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbltieude = new System.Windows.Forms.Label();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.cbonamhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txthoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.treeKhoi = new DevComponents.AdvTree.AdvTree();
            this.node13 = new DevComponents.AdvTree.Node();
            this.node16 = new DevComponents.AdvTree.Node();
            this.node14 = new DevComponents.AdvTree.Node();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node15 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.btntimkiem = new DevComponents.DotNetBar.ButtonX();
            this.lblhoten = new DevComponents.DotNetBar.LabelX();
            this.lbldanhsachhocsinh = new DevComponents.DotNetBar.LabelX();
            this.lblchonlop = new DevComponents.DotNetBar.LabelX();
            this.dgvdanhsachhocsinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeKhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachhocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Khối 11";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // styleManager3
            // 
            this.styleManager3.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager3.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.Blue;
            this.lbltieude.Location = new System.Drawing.Point(430, 36);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(242, 25);
            this.lbltieude.TabIndex = 6;
            this.lbltieude.Text = "DANH SÁCH HỌC SINH";
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Controls.Add(this.cbonamhoc);
            this.pnl.Controls.Add(this.labelX1);
            this.pnl.Controls.Add(this.txthoten);
            this.pnl.Controls.Add(this.treeKhoi);
            this.pnl.Controls.Add(this.btntimkiem);
            this.pnl.Controls.Add(this.lblhoten);
            this.pnl.Controls.Add(this.lbldanhsachhocsinh);
            this.pnl.Controls.Add(this.lblchonlop);
            this.pnl.Controls.Add(this.dgvdanhsachhocsinh);
            this.pnl.Location = new System.Drawing.Point(10, 83);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1011, 373);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 7;
            this.pnl.Text = "panelEx1";
            this.pnl.Click += new System.EventHandler(this.pnl_Click);
            // 
            // cbonamhoc
            // 
            this.cbonamhoc.DisplayMember = "Text";
            this.cbonamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbonamhoc.FormattingEnabled = true;
            this.cbonamhoc.ItemHeight = 14;
            this.cbonamhoc.Location = new System.Drawing.Point(7, 32);
            this.cbonamhoc.Name = "cbonamhoc";
            this.cbonamhoc.Size = new System.Drawing.Size(144, 20);
            this.cbonamhoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbonamhoc.TabIndex = 30;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(7, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "Năm học";
            // 
            // txthoten
            // 
            // 
            // 
            // 
            this.txthoten.Border.Class = "TextBoxBorder";
            this.txthoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txthoten.Location = new System.Drawing.Point(801, 6);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(141, 20);
            this.txthoten.TabIndex = 28;
            // 
            // treeKhoi
            // 
            this.treeKhoi.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeKhoi.AllowDrop = true;
            this.treeKhoi.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeKhoi.BackgroundStyle.Class = "TreeBorderKey";
            this.treeKhoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeKhoi.Location = new System.Drawing.Point(6, 90);
            this.treeKhoi.Name = "treeKhoi";
            this.treeKhoi.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node13,
            this.node14,
            this.node15});
            this.treeKhoi.NodesConnector = this.nodeConnector2;
            this.treeKhoi.NodeStyle = this.elementStyle2;
            this.treeKhoi.PathSeparator = ";";
            this.treeKhoi.Size = new System.Drawing.Size(145, 271);
            this.treeKhoi.Styles.Add(this.elementStyle2);
            this.treeKhoi.TabIndex = 26;
            this.treeKhoi.Text = "advTree2";
            // 
            // node13
            // 
            this.node13.Expanded = true;
            this.node13.Name = "node13";
            this.node13.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node16});
            this.node13.Text = "Khối 10";
            // 
            // node16
            // 
            this.node16.Expanded = true;
            this.node16.Name = "node16";
            this.node16.Text = "10A1";
            // 
            // node14
            // 
            this.node14.Expanded = true;
            this.node14.Name = "node14";
            this.node14.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.node14.Text = "Khối 11";
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "11A1";
            // 
            // node15
            // 
            this.node15.Expanded = true;
            this.node15.Name = "node15";
            this.node15.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2});
            this.node15.Text = "Khối 12";
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Text = "12A1";
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
            // btntimkiem
            // 
            this.btntimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(939, 6);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(63, 23);
            this.btntimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntimkiem.TabIndex = 27;
            this.btntimkiem.Text = "Tìm kiếm";
            // 
            // lblhoten
            // 
            // 
            // 
            // 
            this.lblhoten.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.ForeColor = System.Drawing.Color.Blue;
            this.lblhoten.Location = new System.Drawing.Point(718, 3);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(77, 23);
            this.lblhoten.TabIndex = 25;
            this.lblhoten.Text = "Họ và tên :";
            this.lblhoten.Click += new System.EventHandler(this.lblhoten_Click);
            // 
            // lbldanhsachhocsinh
            // 
            // 
            // 
            // 
            this.lbldanhsachhocsinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbldanhsachhocsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachhocsinh.ForeColor = System.Drawing.Color.Blue;
            this.lbldanhsachhocsinh.Location = new System.Drawing.Point(157, 5);
            this.lbldanhsachhocsinh.Name = "lbldanhsachhocsinh";
            this.lbldanhsachhocsinh.Size = new System.Drawing.Size(114, 23);
            this.lbldanhsachhocsinh.TabIndex = 24;
            this.lbldanhsachhocsinh.Text = "Danh sách học sinh";
            // 
            // lblchonlop
            // 
            // 
            // 
            // 
            this.lblchonlop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblchonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchonlop.ForeColor = System.Drawing.Color.Blue;
            this.lblchonlop.Location = new System.Drawing.Point(7, 61);
            this.lblchonlop.Name = "lblchonlop";
            this.lblchonlop.Size = new System.Drawing.Size(75, 23);
            this.lblchonlop.TabIndex = 23;
            this.lblchonlop.Text = "Chọn lớp";
            // 
            // dgvdanhsachhocsinh
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdanhsachhocsinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdanhsachhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachhocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Hoten,
            this.ngaysinh,
            this.Gioitinh,
            this.Quequan,
            this.Dantoc,
            this.email,
            this.sodienthoai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdanhsachhocsinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdanhsachhocsinh.EnableHeadersVisualStyles = false;
            this.dgvdanhsachhocsinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvdanhsachhocsinh.Location = new System.Drawing.Point(157, 32);
            this.dgvdanhsachhocsinh.Name = "dgvdanhsachhocsinh";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdanhsachhocsinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdanhsachhocsinh.Size = new System.Drawing.Size(845, 329);
            this.dgvdanhsachhocsinh.TabIndex = 22;
            // 
            // MaHS
            // 
            this.MaHS.HeaderText = "Mã HS";
            this.MaHS.Name = "MaHS";
            // 
            // Hoten
            // 
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Quequan
            // 
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.Name = "Quequan";
            // 
            // Dantoc
            // 
            this.Dantoc.HeaderText = "Dân tộc";
            this.Dantoc.Name = "Dantoc";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // sodienthoai
            // 
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // frmDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 461);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lbltieude);
            this.Name = "frmDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeKhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachhocsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.DotNetBar.StyleManager styleManager3;
        private System.Windows.Forms.Label lbltieude;
        private DevComponents.DotNetBar.PanelEx pnl;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.TextBoxX txthoten;
        private DevComponents.AdvTree.AdvTree treeKhoi;
        private DevComponents.AdvTree.Node node13;
        private DevComponents.AdvTree.Node node16;
        private DevComponents.AdvTree.Node node14;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.Node node15;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.ButtonX btntimkiem;
        private DevComponents.DotNetBar.LabelX lblhoten;
        private DevComponents.DotNetBar.LabelX lbldanhsachhocsinh;
        private DevComponents.DotNetBar.LabelX lblchonlop;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdanhsachhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbonamhoc;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}