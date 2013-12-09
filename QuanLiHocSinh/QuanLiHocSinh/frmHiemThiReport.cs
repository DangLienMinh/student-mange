using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using QLHS.BUS;
using System.IO;
namespace QuanLiHocSinh
{ 
   
    public partial class frmHiemThiReport : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_BUS;
        private clsGIAOVIEN_BUS giaoVien_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        string query = "";
        private string rptName;
        private string maLop;
        private string maNH;
        private string tenND;

        public frmHiemThiReport(string query,string rptName,string tenND)
        {
            this.query = query;
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            giaoVien_BUS = new clsGIAOVIEN_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            this.rptName = rptName;
            this.query = query;
            this.tenND = tenND;
        }

        public frmHiemThiReport(string rptName,string tenND)
        {
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            giaoVien_BUS = new clsGIAOVIEN_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            this.rptName = rptName;
            this.tenND = tenND;
        }

        //public frmHiemThiReport(string manh,string malop,string rptName,string tenND)
        //{
        //    InitializeComponent();
        //    this.maLop = malop;
        //    this.maNH = manh;
        //    hocSinh_BUS = new clsHOCSINH_BUS();
        //    this.rptName = rptName;
        //    this.tenND = tenND;
        //}

        public frmHiemThiReport()
        {
            InitializeComponent();
            //lop_BUS = new clsLOP_BUS();
            //giaoVien_BUS = new clsGIAOVIEN_BUS();
        }

        private void frmHiemThiReport_Load(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            try
            {
                switch (rptName)
                {
                    //case "frmDSLop":
                    //    {
                    //        DataSet ds = lop_BUS.reportDanhSachLop();
                    //        ds.WriteXmlSchema(Application.StartupPath + @"\DSLop.xsd");

                    //        document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSLop.rpt");
                    //        document.SetDataSource(ds.Tables["Lop"].Select(query).CopyToDataTable());
                    //        //document.SetParameterValue("NguoiLap1", "your parameter value");
                    //        TextObject text = (TextObject)document.ReportDefinition.ReportObjects["NguoiLap1"];
                    //        text.Text = tenND;
                    //        //ParameterFieldDefinitions crParameterFieldDefinitions;
                    //        //ParameterFieldDefinition crParameterFieldDefinition;
                    //        //ParameterValues crParameterValues = new ParameterValues();
                    //        //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                    //        //crParameterDiscreteValue.Value = tenND;
                    //        //crParameterFieldDefinitions = document.DataDefinition.ParameterFields;
                    //        //crParameterFieldDefinition = crParameterFieldDefinitions["NguoiLap"];
                    //        //crParameterValues = crParameterFieldDefinition.CurrentValues;

                    //        //crParameterValues.Clear();
                    //        //crParameterValues.Add(crParameterDiscreteValue);
                    //        //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    //        //rptView.ReportSource = document;
                    //        //rptView.Refresh(); 
 
                    //    }
                    //    break;
                    //case "frmDSGiaoVien":
                    //    {
                    //        DataSet ds = giaoVien_BUS.reportDanhSachGiaoVien();
                    //        ds.WriteXmlSchema(Application.StartupPath + @"\DSGiaoVien.xsd");

                    //        document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSGiaoVien.rpt");
                    //        document.SetDataSource(ds.Tables["GiaoVien"].Select(query).CopyToDataTable());
                    //        TextObject text = (TextObject)document.ReportDefinition.ReportObjects["NguoiLap"];
                    //        text.Text = tenND;
                    //    }
                    //    break;
                    //case "frmTheHocSinh":
                    //    {
                    //        DataSet ds = hocSinh_BUS.reportTheHocSinh(query);
                    //        ds.WriteXmlSchema(Application.StartupPath + @"\TheHocSinh.xsd");

                    //        document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\TheHocSinh.rpt");
                    //        document.SetDataSource(ds.Tables["TheHocSinh"]);
                    //    }
                    //    break;
                    //case "frmDSHocSinh":
                    //    {
                    //        DataSet ds= hocSinh_BUS.danhSachHocSinh_NH_LOP(maNH,maLop);
                    //        ds.WriteXmlSchema(Application.StartupPath + @"\DanhSachHocSinh.xsd");
                    //        document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSHS_Lop.rpt");
                    //        document.SetDataSource(ds.Tables["DanhSachHocSinh"]);
                    //    }
                    //    break;
                    default:
                        break;
                }
                
               
                rptView.ReportSource = document;
                rptView.RefreshReport();

            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
