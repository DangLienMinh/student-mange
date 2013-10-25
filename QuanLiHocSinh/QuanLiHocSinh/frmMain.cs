using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiHocSinh
{   
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private frmLopHoc m_FrmLop = null;
        private frmGiaoVien m_FrmGiaoVien = null;
        private frmMonHoc m_FrmMonHoc = null;
        private frmNamHoc m_FrmNamHoc = null;
        private frmLoaiDiem m_FrmLoaiDiem = null;
        private frmNguoiDung frmNguoiDung = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThemeBlue_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
        }

        private void btnThemeVista_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
        }

        private void btnTheme8_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }

        private void btnThemeSilver_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
        }

        private void btnThemeBlack_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
        }

        private void btnTheme7_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (frmNguoiDung == null || frmNguoiDung.IsDisposed)
            {
                frmNguoiDung = new frmNguoiDung();
                frmNguoiDung.FormBorderStyle = FormBorderStyle.None;
                frmNguoiDung.MdiParent = frmMain.ActiveForm;
                frmNguoiDung.Show();
            }
            else
                frmNguoiDung.Activate();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            if (m_FrmGiaoVien == null || m_FrmGiaoVien.IsDisposed)
            {
                m_FrmGiaoVien = new frmGiaoVien();
                m_FrmGiaoVien.FormBorderStyle = FormBorderStyle.None;     
                m_FrmGiaoVien.MdiParent = frmMain.ActiveForm;
                m_FrmGiaoVien.Show();
            }
            else
                m_FrmGiaoVien.Activate();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (m_FrmMonHoc == null || m_FrmMonHoc.IsDisposed)
            {
                m_FrmMonHoc = new frmMonHoc();
                m_FrmMonHoc.FormBorderStyle = FormBorderStyle.None;
                m_FrmMonHoc.MdiParent = frmMain.ActiveForm;
                m_FrmMonHoc.Show();
            }
            else
                m_FrmMonHoc.Activate();
        }

        private void btnKhaiBao_Click(object sender, EventArgs e)
        {
            if (m_FrmNamHoc == null || m_FrmNamHoc.IsDisposed)
            {
                m_FrmNamHoc = new frmNamHoc();
                m_FrmNamHoc.FormBorderStyle = FormBorderStyle.None;
                m_FrmNamHoc.MdiParent = frmMain.ActiveForm;
                m_FrmNamHoc.Show();
            }
            else
                m_FrmNamHoc.Activate();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            if (m_FrmLop == null || m_FrmLop.IsDisposed)
            {
                m_FrmLop = new frmLopHoc();
                m_FrmLop.FormBorderStyle = FormBorderStyle.None;            
                m_FrmLop.MdiParent = frmMain.ActiveForm;
                m_FrmLop.Show();
            }
            else
                m_FrmLop.Activate();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (m_FrmLoaiDiem == null || m_FrmLoaiDiem.IsDisposed)
            {
                m_FrmLoaiDiem = new frmLoaiDiem();
                m_FrmLoaiDiem.FormBorderStyle = FormBorderStyle.None;
                m_FrmLoaiDiem.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiDiem.Show();
            }
            else
                m_FrmLoaiDiem.Activate();
        }
    }
}
