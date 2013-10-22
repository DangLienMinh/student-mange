﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using System.IO;

namespace QuanLiHocSinh
{
    public partial class frmGiaoVien : DevComponents.DotNetBar.Office2007Form
    {
        private clsGIAOVIEN_BUS giaoVien_BUS = new clsGIAOVIEN_BUS();
        private OpenFileDialog open=new OpenFileDialog();
        private int flag = 0,dong;
        private string hinhAnh="";
        
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void FlagEnable()
        {
            btnDongY.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FlagDisable()
        {
            btnDongY.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            giaoVien_BUS.hienThiDanhSach(grdGiaoVien);
            giaoVien_BUS.hienThiComboBox(cbGioiTinh);
            FlagDisable();
            flag = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                //picGiaoVien.SizeMode = PictureBoxSizeMode.StretchImage;
                picGiaoVien.Image = Image.FromFile(open.FileName);
                
            }
        }

        private void insert()
        {
            
            if (string.IsNullOrEmpty(txtMaGV.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtTenGV.Text) || picGiaoVien.Image==null)
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
                giaoVien_BUS.addRows();
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

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
        }

        private void grdGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong>=0)
            {
                
                txtMaGV.Text = grdGiaoVien.Rows[dong].Cells[0].Value.ToString();
                txtTenGV.Text = grdGiaoVien.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = grdGiaoVien.Rows[dong].Cells[4].Value.ToString();
                txtDienThoai.Text = grdGiaoVien.Rows[dong].Cells[5].Value.ToString();

                string ngaySinh = grdGiaoVien.Rows[dong].Cells[2].Value.ToString();
                string gioiTinh = grdGiaoVien.Rows[dong].Cells[3].Value.ToString();

                if (gioiTinh == "0")
                {
                    cbGioiTinh.SelectedItem = "Nam";
                }
                else
                {
                    cbGioiTinh.SelectedItem = "Nữ";
                }

                if (ngaySinh != "")
                {
                    DateTime d = new DateTime();
                    d = DateTime.Parse(ngaySinh);
                    dtiNgaySinh.Value = d;
                }

                // sử dụng filestream để có thể xóa hình ảnh mà không bị thằng picturebox chiếm giữ
                string imageLink = grdGiaoVien.Rows[dong].Cells[6].Value.ToString();
                FileStream fs = new FileStream(imageLink,FileMode.Open,FileAccess.Read);
                picGiaoVien.Image = Image.FromStream(fs);
                fs.Close();       
            }  
        }

        private void delete() 
        {
            if (grdGiaoVien.SelectedRows.Count >= 1 && txtMaGV.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa giáo viên đã được lựa chọn ", "Xóa giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    giaoVien_BUS.xoaGiaoVien(txtMaGV.Text);
                    foreach (DataGridViewRow row in grdGiaoVien.Rows)
                    {
                        if (string.Compare(row.Cells["MAGV"].Value.ToString().Trim(), txtMaGV.Text.Trim()) == 0)
                        {
                            
                            File.Delete(row.Cells["HINHANHGV"].Value.ToString());
                            grdGiaoVien.Rows.RemoveAt(row.Index);
                            resetAll();
                            FlagDisable();
                            flag = 0;
                            break;
                        }
                    } 
                }
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            //resetAll();
            FlagEnable();
        }

        private void resetAll()
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            dtiNgaySinh.Value = DateTime.Now;
            picGiaoVien.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
        }


    }
}
