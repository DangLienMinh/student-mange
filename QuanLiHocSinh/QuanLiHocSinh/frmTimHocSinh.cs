using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using QLHS.DTO;
using System.IO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmTimHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsHOCSINH_DTO hocSinh_DTO;
        private int tempCheckMaHS;
        private int tempChecTenHS;
        private int tempCheckDanToc;
        private int tempCheckNgNhapHoc;
        private BindingSource bs;
        #endregion

        #region Click event
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (optMaHS.Checked == false && optTenHS.Checked == false && optDanToc.Checked == false && optNgNhapHoc.Checked == false)
            {
                MessageBox.Show("Bạn phải lựa chọn ít nhất một cách tìm kiếm !!!");
            }
            else
            {
                if (optMaHS.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtMaHS.Text))
                    {
                        MessageBox.Show("Xin nhập mã học sinh bạn muốn tìm vào");
                    }
                    else
                    {
                        bindingData(hocSinh_BUS.timHocSinhMaHS(txtMaHS));
                        if (grdHocSinh.Rows.Count == 1)
                        {
                            MessageBox.Show("không tìm thấy");
                        }
                    }
                }
                else if (optTenHS.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtTenHS.Text))
                    {
                        MessageBox.Show("Xin nhập tên học sinh bạn muốn tìm vào");
                    }
                    else
                    {
                        bindingData(hocSinh_BUS.timHocSinhTenHS(txtTenHS));
                        if (grdHocSinh.Rows.Count == 1)
                        {
                            MessageBox.Show("không tìm thấy");
                        }
                    }
                }
                else if (optDanToc.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtDanToc.Text))
                    {
                        MessageBox.Show("Xin nhập dân tộc bạn muốn tìm vào");
                    }
                    else
                    {
                        bindingData(hocSinh_BUS.timHocSinhDanToc(txtDanToc));
                        if (grdHocSinh.Rows.Count == 1)
                        {
                            MessageBox.Show("không tìm thấy");
                        }
                    }
                }
                else
                {
                    bindingData(hocSinh_BUS.timHocSinhNgNhapHoc(dtiNgNhapHoc));
                    if (grdHocSinh.Rows.Count == 1)
                    {
                        MessageBox.Show("không tìm thấy");
                    }
                }

            }

        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (optMaHS1.Checked == false && optTenHS1.Checked == false && optDanToc1.Checked == false && optNgNhapHoc1.Checked == false)
            {
                MessageBox.Show("Bạn phải lựa chọn ít nhất một cách tìm kiếm !!!");
            }
            else
            {
                if (optMaHS1.Checked == true)
                {
                    if (txtMaHS1.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã học sinh.\nCảm phiền nhập lại");
                        goto tt;
                    }
                    else
                    {
                        hocSinh_DTO.Mahs = txtMaHS1.Text;
                    }
                }
                if (optTenHS1.Checked == true)
                {
                    if (txtTenHS1.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập họ tên học sinh.\nCảm phiền nhập lại");
                        goto tt;
                    }
                    else
                    {
                        hocSinh_DTO.Tenhs = txtTenHS1.Text;
                    }
                }
                if (optDanToc1.Checked == true)
                {
                    if (txtDanToc1.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập dân tộc.\nCảm phiền nhập lại");
                        goto tt;
                    }
                    else
                    {
                        hocSinh_DTO.Dantoc = txtDanToc1.Text;
                    }
                }
                if (optNgNhapHoc1.Checked == true)
                {
                    hocSinh_DTO.Ngnhaphoc = dtiNgNhapHoc1.Value;
                }
                if (optAnd.Checked)
                {
                    dt = hocSinh_BUS.timHocSinhNangCao(hocSinh_DTO, optAnd);
                }
                else
                {
                    dt = hocSinh_BUS.timHocSinhNangCao(hocSinh_DTO, optOr);
                }

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy");

                }
                bindingData(dt);
            tt: ;
            }
        }

        //sự kiện click radio button
        private void opt_MouseClick(object sender, MouseEventArgs e)
        {
            RadioButton x = new RadioButton();
            x = (RadioButton)sender;
            if (x.Name == "optMaHS1")
            {
                if (++tempCheckMaHS == 2)
                {
                    optMaHS1.Checked = false;
                    tempCheckMaHS = 0;
                }
                else
                {
                    optMaHS1.Checked = true;
                }
            }
            else if (x.Name == "optTenHS1")
            {
                if (++tempChecTenHS == 2)
                {
                    optTenHS1.Checked = false;
                    tempChecTenHS = 0;
                }
                else
                {
                    optTenHS1.Checked = true;
                }
            }
            else if (x.Name == "optDanToc1")
            {
                if (++tempCheckDanToc == 2)
                {
                    optDanToc1.Checked = false;
                    tempCheckDanToc = 0;
                }
                else
                {
                    optDanToc1.Checked = true;
                }
            }
            else
            {
                if (++tempCheckNgNhapHoc == 2)
                {
                    optNgNhapHoc1.Checked = false;
                    tempCheckNgNhapHoc = 0;
                }
                else
                {
                    optNgNhapHoc1.Checked = true;
                }
            }

        }
        #endregion

        #region Check changed
        private void optMaHS_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHS.Enabled = true;
            txtMaHS.Focus();
            txtTenHS.Enabled = false;
            txtDanToc.Enabled = false;
            dtiNgNhapHoc.Enabled = false;
            txtTenHS.Text = "";
            txtDanToc.Text = "";
        }

        private void optTenHS_CheckedChanged(object sender, EventArgs e)
        {
            txtTenHS.Enabled = true;
            txtTenHS.Focus();
            txtMaHS.Enabled = false;
            txtDanToc.Enabled = false;
            dtiNgNhapHoc.Enabled = false;
            txtMaHS.Text = "";
            txtDanToc.Text = "";
        }

        private void optDanToc_CheckedChanged(object sender, EventArgs e)
        {
            txtDanToc.Enabled = true;
            txtDanToc.Focus();
            txtTenHS.Enabled = false;
            txtMaHS.Enabled = false;
            dtiNgNhapHoc.Enabled = false;
            txtMaHS.Text = "";
            txtTenHS.Text = "";
        }

        private void optNgNhapHoc_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHS.Enabled = false;
            txtTenHS.Enabled = false;
            txtDanToc.Enabled = false;
            dtiNgNhapHoc.Enabled = true;
            txtTenHS.Text = "";
            txtDanToc.Text = "";
            txtMaHS.Text = "";
        }
        #endregion
        
        public frmTimHocSinh()
        {
            InitializeComponent();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hocSinh_DTO=new clsHOCSINH_DTO();
            tempCheckDanToc = 0;
            tempCheckMaHS = 0;
            tempCheckNgNhapHoc = 0;
            tempChecTenHS = 0;
            datagridMakeUp(grdHocSinh);
            this.KeyPreview = true;
        }

        //Trang trí datagrid như nền, canh chỉnh các hàng, ...
        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
           // temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        private void frmTimHocSinh_Load(object sender, EventArgs e)
        {
            optAnd.Select();

            hocSinh_BUS.autoComplete(txtMaHS, "MAHS");
            hocSinh_BUS.autoComplete(txtMaHS1, "MAHS");
            hocSinh_BUS.autoComplete(txtTenHS, "TENHS");
            hocSinh_BUS.autoComplete(txtTenHS1, "TENHS");
            hocSinh_BUS.autoComplete(txtDanToc, "DANTOC");
            hocSinh_BUS.autoComplete(txtDanToc1, "DANTOC");
        }

        private void bindingData(DataTable table)
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = table;
            grdHocSinh.DataSource = bs;
            bnaHocSinh.BindingSource = bs;
            if (grdHocSinh.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in grdHocSinh.Rows)
                {
                    if (row.Cells["MAHS"].Value != null)
                    {
                        char x = char.Parse(row.Cells["GIOITINHHS"].Value.ToString());
                        if (x == '1')
                        {
                            row.Cells["GIOITINHHS"].Value = "Nam";
                        }
                        else
                        {
                            row.Cells["GIOITINHHS"].Value = "Nữ";
                        }
                        Image image = Image.FromFile(row.Cells["HINHANHHS"].Value.ToString());
                        row.Cells["pic"].Value = image;
                        
                        //row.Cells["pic"].Value = img;
                    }
                   

                }
                
            }
        }

        private void frmTimHocSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
           ((TextBox)sender).BackColor = Color.Yellow;
            //((TextBox)sender).Enabled = true;
            //((TextBox)sender).Focus();
        }

        private void txt_Leave(object sender, EventArgs e)
        {
           ((TextBox)sender).Enabled = false;
            ((TextBox)sender).BackColor = SystemColors.Control;
            
        }

        

       

    }
}
