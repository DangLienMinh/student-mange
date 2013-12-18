using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
namespace QuanLiHocSinh
{
    public partial class Testdulieu : Form
    {
        clsNAMHOC_BUS namHoc_Bus = new clsNAMHOC_BUS();
        clsHANHKIEM_BUS hanhKiem_bus = new clsHANHKIEM_BUS();
        clsHOCSINH_BUS hocsinh_bus = new clsHOCSINH_BUS();
        clsBAOCAO_BUS baocao_bus = new clsBAOCAO_BUS();
        public Testdulieu()
        {
            InitializeComponent();
        }

        private void Testdulieu_Load(object sender, EventArgs e)
        {
            namHoc_Bus.hienThiComboBox(cboNamhoc);
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void advTree1_Click(object sender, EventArgs e)
        {

        }

        private void advTree1_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLop.SelectedNode.Name.Substring(0, 1).ToString() == "L")
            {
                hocsinh_bus.HienThicbodsHocSinh(cboHocsinh, cboNamhoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString());
            }
        }

        private void cboNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            if (cboNamhoc.SelectedValue != null)
            {
                hanhKiem_bus.hienThiLopHoc(treLop,cboNamhoc);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = baocao_bus.bangDiemHocSinh(cboNamhoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString(), cboHocsinh.SelectedValue.ToString()).Tables[0];
            dataGridView1.DataSource = table;
        }
    }
}
