using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiHocSinh
{   
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private OpenFileDialog restoreDialog;
        private SaveFileDialog backupDialog;
        private SqlConnection connection;
        private frmLopHoc m_FrmLop = null;
        private frmGiaoVien m_FrmGiaoVien = null;
        private frmMonHoc m_FrmMonHoc = null;
        private frmNamHoc m_FrmNamHoc = null;
        private frmTiepNhanHocSinh m_FrmHocSinh = null;
        private frmNguoiDung m_FrmNguoiDung = null;
        private frmPhanLop m_FrmPhanLop = null;
        private frmThongSo m_FrmQuyDinh = null;
        private frmPhanCong m_FrmPhanCong = null;
        private frmHocSinhTheoLop m_FrmTimLop = null;
        private frmTimHocSinh m_FrmTimHocSinh = null;
        private frmDangNhap m_FrmLogin = null;

        public frmMain()
        {
            InitializeComponent();
            backupDialog = new SaveFileDialog();
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "QLHocSinhTHPT";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";

            restoreDialog = new OpenFileDialog();
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "QLHocSinhTHPT.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            
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
            if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new frmNguoiDung();
                m_FrmNguoiDung.FormBorderStyle = FormBorderStyle.None;
                m_FrmNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();
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

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            if (m_FrmHocSinh == null || m_FrmHocSinh.IsDisposed)
            {
                m_FrmHocSinh = new frmTiepNhanHocSinh();
                m_FrmHocSinh.FormBorderStyle = FormBorderStyle.None;
                m_FrmHocSinh.MdiParent = frmMain.ActiveForm;
                m_FrmHocSinh.Show();
            }
            else
                m_FrmHocSinh.Activate();
        }

        private void btnThamSo_Click(object sender, EventArgs e)
        {
            if (m_FrmQuyDinh == null || m_FrmQuyDinh.IsDisposed)
            {
                m_FrmQuyDinh = new frmThongSo();
                m_FrmQuyDinh.Show();
            }
            else
                m_FrmQuyDinh.Activate();
        }


        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            if (m_FrmPhanLop == null || m_FrmPhanLop.IsDisposed)
            {
                m_FrmPhanLop = new frmPhanLop();
                m_FrmPhanLop.FormBorderStyle = FormBorderStyle.None;
                m_FrmPhanLop.MdiParent = frmMain.ActiveForm;
                m_FrmPhanLop.Show();
            }
            else
                m_FrmPhanLop.Activate();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (m_FrmPhanCong == null || m_FrmPhanCong.IsDisposed)
            {
                m_FrmPhanCong = new frmPhanCong();
                m_FrmPhanCong.FormBorderStyle = FormBorderStyle.None;
                m_FrmPhanCong.MdiParent = frmMain.ActiveForm;
                m_FrmPhanCong.Show();
            }
            else
                m_FrmPhanCong.Activate();
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            if (m_FrmTimLop == null || m_FrmTimLop.IsDisposed)
            {
                m_FrmTimLop = new frmHocSinhTheoLop();
                m_FrmTimLop.FormBorderStyle = FormBorderStyle.None;
                m_FrmTimLop.MdiParent = frmMain.ActiveForm;
                m_FrmTimLop.Show();
            }
            else
                m_FrmTimLop.Activate();
            
        }

        private void btnTimHocSinh_Click(object sender, EventArgs e)
        {
            if (m_FrmTimHocSinh == null || m_FrmTimHocSinh.IsDisposed)
            {
                m_FrmTimHocSinh = new frmTimHocSinh();
                m_FrmTimHocSinh.FormBorderStyle = FormBorderStyle.None;
                m_FrmTimHocSinh.MdiParent = frmMain.ActiveForm;
                m_FrmTimHocSinh.Show();
            }
            else
                m_FrmTimHocSinh.Activate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Create the list of frequently used commands for the QAT Customize menu
            ribbonControl1.QatFrequentCommands.Add(btnDangNhap);
            ribbonControl1.QatFrequentCommands.Add(btnDangXuat);
            ribbonControl1.QatFrequentCommands.Add(btnThoat);

            // Load Quick Access Toolbar layout if one is saved from last session...
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
            if (key != null)
            {
                try
                {
                    string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                    if (layout != "" && layout != null)
                        ribbonControl1.QatLayout = layout;
                }
                finally
                {
                    key.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new frmNguoiDung();
                m_FrmNguoiDung.MdiParent = this;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl1.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl1.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
           

            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
               
                string connectionStr = @"Data Source=DANGLIENMINH\SQLEXPRESS;Initial Catalog=QuanLyHocSinh2;Integrated Security=True";
                connection = new SqlConnection(connectionStr);
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + "QuanLyHocSinh2" + " TO DISK = '" + backupDialog.FileName.ToString() + "'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {

            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                
                string connectionStr = @"Data Source=DANGLIENMINH\SQLEXPRESS;Initial Catalog=QuanLyHocSinh2;Integrated Security=True";
                connection = new SqlConnection(connectionStr);
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand("USE master RESTORE DATABASE " + "QuanLyHocSinh2" + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

    }
}
