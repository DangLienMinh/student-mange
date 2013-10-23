using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace QuanLiHocSinh
{
    public partial class frmNamHoc : DevComponents.DotNetBar.Office2007Form
    {
        private int flag = 0;
        private int viTri, Tong;

        public frmNamHoc()
        {
            InitializeComponent();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            txtMaNH.Text = "NH" + DateTime.Now.ToString("yy") + DateTime.Now.AddYears(1).ToString("yy");
        }

        private void FlagEnable()
        {
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnChange.Enabled = false;
        }

        private void FlagDisable()
        {
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnChange.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenNH.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 3) update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
        }

        private void resetAll()
        {
            txtTenNH.Text = "";
        }

        private void insert()
        {

            if (string.IsNullOrEmpty(txtMaGV.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtTenGV.Text) || picGiaoVien.Image == null)
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string txtGioiTinh = "";
                if (cbGioiTinh.SelectedItem == "Nam")
                {
                    txtGioiTinh = "0";
                }
                else
                {
                    txtGioiTinh = "1";
                }
                string linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + open.SafeFileName;
                File.Copy(open.FileName, linkimage);

                //reset all openfiledialog
                open.Reset();

                giaoVien_BUS.themGiaoVien(txtMaGV.Text, txtTenGV.Text, dtiNgaySinh, txtDienThoai.Text, txtGioiTinh, txtDiaChi.Text, linkimage);
                MessageBox.Show("Bạn đã thêm thành công!");
                giaoVien_BUS.themDong();
                FlagDisable();
                flag = 0;
            }
        }

        private void update()
        {
            if (grdGiaoVien.SelectedRows.Count >= 1 && txtMaGV.Text != "")
            {
                string txtGioiTinh = "";
                if (cbGioiTinh.SelectedItem == "Nam")
                {
                    txtGioiTinh = "0";
                }
                else
                {
                    txtGioiTinh = "1";
                }

                if (open.FileName != "")
                {
                    string linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + open.SafeFileName;
                    File.Copy(open.FileName, linkimage);
                    if (string.Compare(grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString(), linkimage) == -1)
                    {
                        giaoVien_BUS.suaGiaoVien(txtMaGV.Text, txtTenGV.Text, dtiNgaySinh, txtDienThoai.Text, txtGioiTinh, txtDiaChi.Text, linkimage);

                        // sử dụng filestream để có thể xóa hình ảnh mafkhoong bị thằng picturebox chiếm giữ
                        FileStream fs = new FileStream(linkimage, FileMode.Open, FileAccess.Read);
                        picGiaoVien.Image = Image.FromStream(fs);
                        fs.Close();

                        File.Delete(grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString());
                    }
                }
                else
                {
                    giaoVien_BUS.suaGiaoVien(txtMaGV.Text, txtTenGV.Text, dtiNgaySinh, txtDienThoai.Text, txtGioiTinh, txtDiaChi.Text, grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString());

                }

                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                giaoVien_BUS.suaDataGrid(grdGiaoVien);

                FlagDisable();
                flag = 0;

            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
