using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using QLHS.DTO;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmPhanLop : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_bus;
        private clsKHOI_BUS khoi_bus;
        private clsNAMHOC_BUS namHoc_bus;
        private clsHOCSINH_BUS hocsinh_bus;

        public frmPhanLop()
        {
            InitializeComponent();
            lop_bus = new clsLOP_BUS();
            khoi_bus = new clsKHOI_BUS();
            namHoc_bus = new clsNAMHOC_BUS();
            hocsinh_bus = new clsHOCSINH_BUS();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            khoi_bus.hienThiComboBox(cboKhoiLopCu);
            namHoc_bus.hienThiComboBox(cboNamHocCu);
            khoi_bus.hienThiComboBox(cboKhoiLopCu, cboKhoiLopMoi);
            namHoc_bus.hienThiComboBox(cboNamHocMoi);
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            IEnumerator ie = lstLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem oldItem = (ListViewItem)ie.Current;
                ListViewItem newItem = new ListViewItem();

                //Trạng thái học sinh đã được chuyển lớp hay chưa?
                bool state = false;

                foreach (ListViewItem item in lstLopMoi.Items)
                {
                    if (item.SubItems[0].Text == oldItem.SubItems[0].Text)
                    {
                        MessageBox.Show("Học sinh " + item.SubItems[1].Text + " hiện đang học trong lớp " + cboLopMoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                DataTable dT = new DataTable();
                if (cboNamHocMoi.SelectedValue != null)
                {
                    dT = hocsinh_bus.danhSachPhanLop(cboNamHocMoi);
                }

                foreach (DataRow row in dT.Rows)
                {
                    if (oldItem.SubItems[0].Text.ToString() == row["MAHS"].ToString())
                    {
                        MessageBox.Show("Học sinh " + row["TENHS"].ToString() + " hiện đang học trong lớp " + row["TENLOP"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                newItem.SubItems.Add(oldItem.SubItems[1].Text);
                newItem.Tag = oldItem.Tag;

                lstLopMoi.Items.Add(newItem);
                lstLopMoi.Items[lstLopMoi.Items.IndexOf(newItem)].Text = oldItem.SubItems[0].Text;
                lstLopCu.Items.Remove(oldItem);

            Cont:
                if (state == true)
                    break;
            }
        }

        private void cboNamHocCu_SelectedValueChanged(object sender, EventArgs e)
        {         
            lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu,cboKhoiLopCu.SelectedValue.ToString());
        }

        private void cboKhoiLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue!=null)
            {
                lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu, cboKhoiLopCu.SelectedValue.ToString());
                if (cboLopCu.Items.Count<=0)
                {
                    cboLopCu.Text = "";
                }
                khoi_bus.hienThiComboBox(cboKhoiLopCu, cboKhoiLopMoi);
            }
            
        }

        private void cboNamHocMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
        }

  
        private void cboKhoiLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null)
            {
                lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
                if (cboLopMoi.Items.Count <= 0)
                {
                    cboLopMoi.Text = "";
                }
            }
        }

        private void cboLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null && cboLopCu.SelectedValue != null)
            {
                hocsinh_bus.danhSachHocSinhTheoLop(cboNamHocCu, cboLopCu, lstLopCu);
            }
        }

        private void cboLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null && cboLopMoi.SelectedValue != null)
            {
                hocsinh_bus.danhSachHocSinhTheoLop(cboNamHocMoi, cboLopMoi, lstLopMoi);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa học sinh này khỏi lớp mới không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lstLopMoi.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lstLopMoi.Items.Remove(item);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null &&
                cboKhoiLopCu.SelectedValue != null &&
                cboLopCu.SelectedValue != null &&
                cboNamHocMoi.SelectedValue != null &&
                cboKhoiLopMoi.SelectedValue != null &&
                cboLopMoi.SelectedValue != null)
            {
                hocsinh_bus.themPhanLop(cboNamHocMoi, cboLopMoi, lstLopMoi);
                MessageBox.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                    MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            


        }

       
    }
}
