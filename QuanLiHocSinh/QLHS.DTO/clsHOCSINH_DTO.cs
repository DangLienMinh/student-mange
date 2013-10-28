using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHS.DTO
{
    public class clsHOCSINH_DTO
    {
        public clsHOCSINH_DTO()
        {
            mahs = "";
            tenhs = "";
            dantoc = "";
            ngnhaphoc = DateTime.MinValue;
        }
 
        private string manh;

        public string Manh
        {
            get { return manh; }
            set { manh = value; }
        }
        private string malop;

        public string Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        private string mahs;

        public string Mahs
        {
            get { return mahs; }
            set { mahs = value; }
        }
        private string tenhs;

        public string Tenhs
        {
            get { return tenhs; }
            set { tenhs = value; }
        }
        private DateTime ngaysinhhs;

        public DateTime Ngaysinhhs
        {
            get { return ngaysinhhs; }
            set { ngaysinhhs = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string diachihs;

        public string Diachihs
        {
            get { return diachihs; }
            set { diachihs = value; }
        }
        private string dienthoaihs;

        public string Dienthoaihs
        {
            get { return dienthoaihs; }
            set { dienthoaihs = value; }
        }
        private DateTime ngnhaphoc;

        public DateTime Ngnhaphoc
        {
            get { return ngnhaphoc; }
            set { ngnhaphoc = value; }
        }
        private string hinhanhhs;

        public string Hinhanhhs
        {
            get { return hinhanhhs; }
            set { hinhanhhs = value; }
        }
        private string dantoc;

        public string Dantoc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }
    }
}
