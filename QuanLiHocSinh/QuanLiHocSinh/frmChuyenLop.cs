using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using QLHS.DTO;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmChuyenLop : DevComponents.DotNetBar.OfficeForm
    {
        private clsLOP_BUS lop_BUS;
        private clsKHOI_BUS khoi_BUS;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        clsQUYDINH_BUS quyDinh_BUS;
        int flag = -1;//kiểm tra bấm hủy hay chuyển 

        public frmChuyenLop()
        {
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            khoi_BUS = new clsKHOI_BUS();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            quyDinh_BUS = new clsQUYDINH_BUS();
            this.KeyPreview = true;
        }

        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocCu);
            namHoc_BUS.hienThiComboBox(cboNamHocMoi);
            lop_BUS.cboBan(cboPhanBanCu);
            lop_BUS.cboBan(cboPhanBanMoi);
            khoi_BUS.hienThiComboBox(cboKhoiLopCu);
            khoi_BUS.hienThiComboBoxChuyenLop(cboKhoiLopCu, cboKhoiLopMoi);
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
                    if (item.SubItems[1].Text == oldItem.SubItems[1].Text)
                    {
                        MessageBox.Show("Học sinh " + item.SubItems[1].Text + " hiện đang học trong lớp " + cboLopMoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }
                newItem.SubItems.Add(oldItem.SubItems[1].Text);
                newItem.SubItems.Add(oldItem.SubItems[2].Text);
                newItem.Tag = oldItem.Tag;

                lstLopMoi.Items.Add(newItem);
                lstLopMoi.Items[lstLopMoi.Items.IndexOf(newItem)].Text = (lstLopMoi.Items.Count).ToString();
                lstLopCu.Items.Remove(oldItem);
            Cont:
                if (state == true)
                    break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa học sinh này khỏi lớp không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ////xóa các item được chọn khỏi csdl
                for (int i = 0; i < lstLopMoi.SelectedItems.Count; i++)
                {
                    string maHS = lstLopMoi.SelectedItems[i].SubItems[1].Text;
                    hocSinh_BUS.xoaPhanLop(cboNamHocMoi, cboLopMoi, maHS);
                }
                //cờ kiểm tra list item có được xóa
                //flag1 = 1;
                //xóa các list items được chọn
                IEnumerator ie = lstLopMoi.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lstLopMoi.Items.Remove(item);
                }
                //tải lại số thứ tự cho listview
                int count = 0;
                foreach (ListViewItem item in lstLopMoi.Items)
                {
                    item.SubItems[0].Text = (++count).ToString();
                }
                //tải lại list học sinh
                if (cboNamHocCu.SelectedValue != null)
                {
                    hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHocCu, cboLopCu, lstLopCu,cboPhanBanCu);
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
                if (flag != 1)
                {
                    hocSinh_BUS.themPhanLop(cboNamHocMoi, cboLopMoi, lstLopMoi);
                }

                MessageBox.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboKhoiLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu, cboKhoiLopCu.SelectedValue.ToString());
                if (cboLopCu.Items.Count <= 0)
                {
                    cboLopCu.Text = "";
                }
                khoi_BUS.hienThiComboBox(cboKhoiLopCu, cboKhoiLopMoi);
            }
        }

        private void cboNamHocCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopCu.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu, cboKhoiLopCu.SelectedValue.ToString());
            }
        }

        private void cboLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null && cboLopCu.SelectedValue != null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHocCu, cboLopCu, lstLopCu,cboPhanBanCu);
            }
        }

        private void cboNamHocMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopMoi.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
            }
        }

        private void cboKhoiLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
                if (cboLopMoi.Items.Count <= 0)
                {
                    cboLopMoi.Text = "";
                }
            }
        }

        private void cboLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null && cboLopMoi.SelectedValue != null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHocMoi, cboLopMoi, lstLopMoi,cboPhanBanMoi);
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hocSinh_BUS.timHocSinhChuyenLop(txtTim, cboNamHocCu, cboLopCu, lstLopCu);                
            }
        }
    }
}
