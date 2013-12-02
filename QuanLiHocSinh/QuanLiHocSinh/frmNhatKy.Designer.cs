namespace QuanLiHocSinh
{
    partial class frmNhatKy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKy));
            this.bnaNhatKy = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.grdNhatKy = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            this.btnClear = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bnaNhatKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // bnaNhatKy
            // 
            this.bnaNhatKy.AntiAlias = true;
            this.bnaNhatKy.CountLabel = this.bindingNavigatorCountItem;
            this.bnaNhatKy.CountLabelFormat = "of {0}";
            this.bnaNhatKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnaNhatKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnaNhatKy.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.btnClear});
            this.bnaNhatKy.Location = new System.Drawing.Point(0, 0);
            this.bnaNhatKy.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bnaNhatKy.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bnaNhatKy.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bnaNhatKy.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bnaNhatKy.Name = "bnaNhatKy";
            this.bnaNhatKy.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bnaNhatKy.Size = new System.Drawing.Size(1362, 25);
            this.bnaNhatKy.Stretch = true;
            this.bnaNhatKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnaNhatKy.TabIndex = 26;
            this.bnaNhatKy.TabStop = false;
            this.bnaNhatKy.Text = "bindingNavigatorEx1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text = "of {0}";
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
            // grdNhatKy
            // 
            this.grdNhatKy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAND,
            this.MALND,
            this.TENND,
            this.THOIGIAN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNhatKy.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhatKy.EnableHeadersVisualStyles = false;
            this.grdNhatKy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdNhatKy.Location = new System.Drawing.Point(0, 25);
            this.grdNhatKy.Name = "grdNhatKy";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNhatKy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdNhatKy.Size = new System.Drawing.Size(1362, 532);
            this.grdNhatKy.TabIndex = 27;
            this.grdNhatKy.TabStop = false;
            // 
            // MAND
            // 
            this.MAND.DataPropertyName = "MAND";
            this.MAND.HeaderText = "Mã người dùng";
            this.MAND.Name = "MAND";
            this.MAND.Width = 103;
            // 
            // MALND
            // 
            this.MALND.DataPropertyName = "MALND";
            this.MALND.HeaderText = "Loại người dùng";
            this.MALND.Name = "MALND";
            this.MALND.Width = 108;
            // 
            // TENND
            // 
            this.TENND.DataPropertyName = "TENND";
            this.TENND.HeaderText = "Tên người dùng";
            this.TENND.Name = "TENND";
            this.TENND.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TENND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TENND.Width = 150;
            // 
            // THOIGIAN
            // 
            this.THOIGIAN.DataPropertyName = "THOIGIAN";
            this.THOIGIAN.HeaderText = "Thời gian";
            this.THOIGIAN.Name = "THOIGIAN";
            this.THOIGIAN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.THOIGIAN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.THOIGIAN.Width = 200;
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
            // btnClear
            // 
            this.btnClear.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClear.Image = global::QuanLiHocSinh.Properties.Resources.recycle;
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "Dọn sạch";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 557);
            this.Controls.Add(this.grdNhatKy);
            this.Controls.Add(this.bnaNhatKy);
            this.DoubleBuffered = true;
            this.Name = "frmNhatKy";
            this.Text = "frmNhatKy";
            this.Load += new System.EventHandler(this.frmNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnaNhatKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bnaNhatKy;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdNhatKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENND;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN;
        private DevComponents.DotNetBar.ButtonItem btnClear;
    }
}