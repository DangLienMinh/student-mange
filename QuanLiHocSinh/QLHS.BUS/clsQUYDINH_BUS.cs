using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using System.Windows.Forms;
using System.Data;

namespace QLHS.BUS
{
    public class clsQUYDINH_BUS
    {
        clsQUYDINH_DAO quyDinh_DAO;
        clsQUYDINH_DTO quyDinh_DTO;
        DataTable tblQuyDinh;

        public clsQUYDINH_BUS()
        {
            quyDinh_DAO = new clsQUYDINH_DAO();
            tblQuyDinh = new DataTable();
        }

        //sửa đổi sỉ số tối thiểu
        public int siSoToiThieu()
        {
            int value = -1;
            tblQuyDinh = quyDinh_DAO.thongTinQuyDinh();
            for (int i = 0; i < tblQuyDinh.Rows.Count; i++)
            {
                //sỉ số tối thiểu ở dòng 4 tron csdl
                switch (i)
                {
                    case 4: value = int.Parse(tblQuyDinh.Rows[i][0].ToString());
                        break;
                   
                    default:
                        break;
                }
            }
            return value;
        }

        //sửa đổi sỉ số tối đa
        public int siSoToiDa()
        {
            int value = -1;
            tblQuyDinh = quyDinh_DAO.thongTinQuyDinh();
            for (int i = 0; i < tblQuyDinh.Rows.Count; i++)
            {
                switch (i)
                {

                    case 5: value = int.Parse(tblQuyDinh.Rows[i][0].ToString());
                        break;

                    default:
                        break;
                }
            }
            return value;
        }

        //hiển thị thông tin quy định lên các control
        public void hienThiDanhSach(IntegerInput txtTuoiTT,
                            IntegerInput txtTuoiTD,
                            IntegerInput txtSiSoTT,
                            IntegerInput txtSiSoTD,
                            TextBoxX txtTenTruong,
                            TextBoxX txtDiaChi,
                            TextBoxX txtDienThoai)
        {
            tblQuyDinh = quyDinh_DAO.thongTinQuyDinh();
            for (int i = 0; i < tblQuyDinh.Rows.Count;i++)
            {
                switch (i)
                {
                    case 2: txtTuoiTT.Value = int.Parse(tblQuyDinh.Rows[i][0].ToString());
                        break;
                    case 3: txtTuoiTD.Value = int.Parse(tblQuyDinh.Rows[i][0].ToString());
                        break;
                    case 4: txtSiSoTT.Value = int.Parse(tblQuyDinh.Rows[i][0].ToString());
                        break;
                    case 5: txtSiSoTD.Value = int.Parse(tblQuyDinh.Rows[i][0].ToString());
                        break;
                    case 6: txtTenTruong.Text = tblQuyDinh.Rows[i][0].ToString();
                        break;
                    case 7: txtDiaChi.Text = tblQuyDinh.Rows[i][0].ToString();
                        break;
                    case 8: txtDienThoai.Text = tblQuyDinh.Rows[i][0].ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        //sửa thông tin trường
        public void suaThongTinTruong(TextBoxX txtTenTruong,TextBoxX txtDiaChi,TextBoxX txtDienThoai)
        {
            quyDinh_DTO = new clsQUYDINH_DTO();
            quyDinh_DTO.TenTruong = txtTenTruong.Text;
            quyDinh_DTO.DiaChi = txtDiaChi.Text;
            quyDinh_DTO.DienThoai = txtDienThoai.Text;
            quyDinh_DAO.suaTruongHoc(quyDinh_DTO);
        }

        //sửa thông tin sỉ số
        public void suaThongTinSiSo(IntegerInput txtSiSoTT,IntegerInput txtSiSoTD)
        {
            quyDinh_DTO = new clsQUYDINH_DTO();
            quyDinh_DTO.SiSoTT = txtSiSoTT.Value.ToString();
            quyDinh_DTO.SiSoTD = txtSiSoTD.Value.ToString();  
            quyDinh_DAO.suaSiSo(quyDinh_DTO);
        }

        //sửa thông tin tuổi
        public void suaThongTinTuoi(IntegerInput txtTuoiTT, IntegerInput txtTuoiTD)
        {
            quyDinh_DTO = new clsQUYDINH_DTO();
            quyDinh_DTO.TuoiTT = txtTuoiTT.Value.ToString();
            quyDinh_DTO.TuoiTD = txtTuoiTD.Value.ToString();
            quyDinh_DAO.suaTuoi(quyDinh_DTO);
        }
    }
}
