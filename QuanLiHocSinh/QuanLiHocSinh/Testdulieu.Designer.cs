namespace QuanLiHocSinh
{
    partial class Testdulieu
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.treLop = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.cboHocsinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboNamhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(712, 26);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Test";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
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
            this.treLop.Location = new System.Drawing.Point(12, 26);
            this.treLop.Name = "treLop";
            this.treLop.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.treLop.NodesConnector = this.nodeConnector1;
            this.treLop.NodeStyle = this.elementStyle1;
            this.treLop.PathSeparator = ";";
            this.treLop.Size = new System.Drawing.Size(100, 62);
            this.treLop.Styles.Add(this.elementStyle1);
            this.treLop.TabIndex = 1;
            this.treLop.Text = "treLop";
            this.treLop.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.advTree1_NodeClick);
            this.treLop.Click += new System.EventHandler(this.advTree1_Click);
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "node1";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // cboHocsinh
            // 
            this.cboHocsinh.DisplayMember = "Text";
            this.cboHocsinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocsinh.FormattingEnabled = true;
            this.cboHocsinh.ItemHeight = 14;
            this.cboHocsinh.Location = new System.Drawing.Point(222, 26);
            this.cboHocsinh.Name = "cboHocsinh";
            this.cboHocsinh.Size = new System.Drawing.Size(154, 20);
            this.cboHocsinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHocsinh.TabIndex = 2;
            this.cboHocsinh.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // cboNamhoc
            // 
            this.cboNamhoc.DisplayMember = "Text";
            this.cboNamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamhoc.FormattingEnabled = true;
            this.cboNamhoc.ItemHeight = 14;
            this.cboNamhoc.Location = new System.Drawing.Point(456, 26);
            this.cboNamhoc.Name = "cboNamhoc";
            this.cboNamhoc.Size = new System.Drawing.Size(167, 20);
            this.cboNamhoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNamhoc.TabIndex = 3;
            this.cboNamhoc.SelectedIndexChanged += new System.EventHandler(this.cboNamhoc_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 276);
            this.dataGridView1.TabIndex = 4;
            // 
            // Testdulieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboNamhoc);
            this.Controls.Add(this.cboHocsinh);
            this.Controls.Add(this.treLop);
            this.Controls.Add(this.buttonX1);
            this.Name = "Testdulieu";
            this.Text = "Testdulieu";
            this.Load += new System.EventHandler(this.Testdulieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.AdvTree.AdvTree treLop;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHocsinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNamhoc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}