using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.DTO;
using QLHS.BUS;
namespace QuanLiHocSinh
{
    public partial class frmPhanCong : DevComponents.DotNetBar.Office2007Form
    {
        private clsGIANGDAY_BUS giangday_bus;
        private Boolean flagInsert;
        private Boolean flagUpdate;
        private Boolean flagDelete;
        public frmPhanCong()
        {
            InitializeComponent();
            giangday_bus = new clsGIANGDAY_BUS();
            flagInsert = false;
            flagUpdate = false;
            flagDelete = false;
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            giangday_bus.hienthiLop(cboLop);
            giangday_bus.hienthiNamhoc(cboNamHoc);
            giangday_bus.hienthiGiaovien(cboGiaoVien);
            giangday_bus.hienthiMonhoc(cboMonHoc);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            flagInsert = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            flagUpdate = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            flagDelete = true;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            anHienButton(true);
            if (flagInsert == true)
            {
                Insert();
            }
            else
            {
                if (flagUpdate == true)
                {
                    Update();
                }
                else
                {
                    Delete();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            anHienButton(true);
        }
        public void Insert()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public void anHienButton(Boolean b)
        {
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            if (b == true)
            {
                btnDongY.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnDongY.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
    }
}
