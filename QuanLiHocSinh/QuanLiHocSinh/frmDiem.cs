using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmDiem : DevComponents.DotNetBar.Office2007Form
    {
        private int flag = 0;
        private int viTri, Tong;
        private frmLoaiDiem frm_LoaiDiem = null;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsLOAIDIEM_BUS loaiDiem_BUS;
        private clsMONHOC_BUS monHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsDIEM_BUS diem_BUS;

        public frmDiem()
        {
            InitializeComponent();
            namHoc_BUS=new clsNAMHOC_BUS();
            lop_BUS=new clsLOP_BUS();
            hocKy_BUS=new clsHOCKY_BUS();
            loaiDiem_BUS = new clsLOAIDIEM_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            diem_BUS=new clsDIEM_BUS();
           
            monHoc_BUS.HienThiDataGridViewComboBoxColumn(MAMH1);
            loaiDiem_BUS.HienThiDataGridViewComboBoxColumn(MALD1);
            namHoc_BUS.HienThiDataGridViewComboBoxColumn(MANH1);
            this.KeyPreview = true;
            datagridMakeUp(grdDiemRieng);
        }

        //Trang trí datagrid như nền, canh chỉnh các hàng, ...
        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        //bật cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa bị mờ đi
        private void FlagEnable()
        {
            btnDongY.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        //tắt cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa sáng lên
        private void FlagDisable()
        {
            btnDongY.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void cbNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHoc.SelectedValue.ToString(), treKhoi);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            namHoc_BUS.hienThiComboBox(cboNamHoc1);
            hocKy_BUS.hienThiComboBox(cboHocKy1);
            hocKy_BUS.hienThiComboBox(cboHocKy);
            monHoc_BUS.hienThiComboBox(cboMonHoc);
            monHoc_BUS.hienThiComboBox(cboMonHoc1);
            loaiDiem_BUS.hienThiComboBox(cboLoaiDiem1);

           

           
            tabControl1.SelectedTab = btnItemLop;
        }

        private void insert()
        {
            //cờ kiểm tra mã giáo viên đã tồn tại trong CSSDL chưa
            int test = 1;
            int count=0;

            if (cboHocSinh1.SelectedValue==null||cboLoaiDiem1.SelectedValue==null||cboHocKy1.SelectedItem==null||cboNamHoc1.SelectedValue==null||cboMonHoc1.SelectedValue==null)
            {
                MessageBox.Show("Xin chọn dữ liệu đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1, grdDiemRieng);
                count = grdDiemRieng.Rows.Count-1;
                switch (cboLoaiDiem1.SelectedValue.ToString())
                {
                    case "LD01":
                        {
                            if (count>=2)
                            {
                                test = -1;
                            }
                            break;
                        }
                    case "LD02":
                        {
                            if (count >= 5)
                            {
                                test = -1;
                            }
                            break;
                        }
                    case "LD03":
                        {
                            if (count >= 5)
                            {
                                test = -1;
                            }
                            break;
                        }
                    case "LD04":
                        {
                            if (count >= 1)
                            {
                                test = -1;
                            }
                            break;
                        }
                       
                    default:
                        break;
                }
                if (test!=-1)
                {
                    diem_BUS.themDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1, txtDiem1);
                    MessageBox.Show("thêm điểm thành công");
                    diem_BUS.themDong();
                }
                else
                {
                    MessageBox.Show("Loại điểm  "+cboLoaiDiem1.SelectedValue.ToString()+" đã vượt quá số lượng cho phép thêm");
                }
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiDiem_Click(object sender, EventArgs e)
        {
            if (frm_LoaiDiem == null || frm_LoaiDiem.IsDisposed)
            {
                frm_LoaiDiem = new frmLoaiDiem();
                frm_LoaiDiem.FormBorderStyle = FormBorderStyle.None;
                frm_LoaiDiem.MdiParent = frmMain.ActiveForm;
                frm_LoaiDiem.Show();
            }
            else
                frm_LoaiDiem.Activate(); 
        }

        private void cboNamHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc1.SelectedValue!=null)
            {
                lop_BUS.hienThiCboLopTheoNamHoc(cboNamHoc1.SelectedValue.ToString(), cboLop1);
            }
        }

        private void cboLop1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLop1.SelectedValue!=null && cboNamHoc1.SelectedValue!=null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHoc1, cboLop1, cboHocSinh1);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FlagEnable();
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            //if (flag == 2) delete();
            //if (flag == 3) update();
            //sapXep();
            //txtMaGV.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
        }

        private void cboLoaiDiem1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiDiem1.SelectedValue != null && cboHocSinh1.SelectedValue!=null){
                diem_BUS.thongTinDiemTheoHS(cboNamHoc1,cboHocKy1,cboLoaiDiem1, cboMonHoc1,cboHocSinh1,grdDiemRieng);
            }
        }

        private void cboHocSinh1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiDiem1.SelectedValue != null && cboHocSinh1.SelectedValue != null)
            {
                diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1, grdDiemRieng);
            }
        }




    }
}

