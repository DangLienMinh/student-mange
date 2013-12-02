using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QuanLiHocSinh
{
    public partial class frmNhatKy : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource bs;
        public frmNhatKy()
        {
            InitializeComponent();
            bs=new BindingSource();
            datagridMakeUp(grdNhatKy);
        }

        //Trang trí datagrid như nền, canh chỉnh các hàng, ...
        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MAND");
            table.Columns.Add("MALND");
            table.Columns.Add("TENND");
            table.Columns.Add("THOIGIAN");
            foreach (var line in File.ReadAllLines(Application.StartupPath+@"\log.txt"))
            {
                var columns = line.Split(',');
                table.Rows.Add(columns[0], columns[1], columns[2], columns[3]);
            }
            bs.DataSource = table;
            bnaNhatKy.BindingSource = bs;
            grdNhatKy.DataSource = bs;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            StreamWriter strm = File.CreateText(Application.StartupPath+@"\log.txt");
            strm.Flush();
            strm.Close();
            MessageBox.Show("Làm sạch nhật ký thành công!!!");
            bs.DataSource = null;
        }
    }
}
