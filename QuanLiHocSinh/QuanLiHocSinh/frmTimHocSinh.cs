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
        private clsHOCSINH_BUS hocsinh_bus;

        public frmTimHocSinh()
        {
            InitializeComponent();
            hocsinh_bus = new clsHOCSINH_BUS();
        }

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
                        MessageBox.Show("Xin nhập họ tên độc giả bạn muốn tìm vào");
                    }
                    else
                    {
                        hocsinh_bus.timHocSinhMaHS(grdHocSinh, txtMaHS);
                        if (grdHocSinh.Rows.Count <= 0)
                        {
                            MessageBox.Show("không tìm thấy");
                        }
                    }
                    
                    
                }
                
            }
        }

        private void frmTimHocSinh_Load(object sender, EventArgs e)
        {

        }


    }
}
