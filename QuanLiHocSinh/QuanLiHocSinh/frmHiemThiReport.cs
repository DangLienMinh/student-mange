using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using QLHS.BUS;
using System.IO;
namespace QuanLiHocSinh
{ 
   
    public partial class frmHiemThiReport : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_BUS;
        string query = "";
        private string rptName;
      

        public frmHiemThiReport(string query,string rptName)
        {
            this.query = query;
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            this.rptName = rptName;
            this.query = query;
        }

        public frmHiemThiReport()
        {
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
        }

        private void frmHiemThiReport_Load(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            try
            {
                switch (rptName)
                {
                    case "frmDSLop":
                        {
                            DataSet ds = lop_BUS.reportDanhSachLop();
                            ds.WriteXmlSchema(Application.StartupPath + @"\DSLop.xsd");

                            document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSLop.rpt");
                            document.SetDataSource(ds.Tables["Lop"].Select(query).CopyToDataTable());
 
                        }
                        break;
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
