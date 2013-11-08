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
    public partial class frmScreen : DevComponents.DotNetBar.Office2007Form
    {
        private Timer timer;
        
        public frmScreen()
        {
            timer = new Timer();
            InitializeComponent();
 
            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (32) * (1);             // Timer will tick evert 10 seconds
            timer.Enabled = true;                       // Enable the timer
            timer.Start();         
           
        }

        void timer_Tick(object sender, EventArgs e)
        {
           
            if (circularProgress1.Value <circularProgress1.Maximum-1)
            {
                circularProgress1.Value++;
            }
            else
            {
                timer.Enabled = false;
                this.Close();
                this.Dispose();
                threadMainForm();

            }
        }

        private void frmScreen_Load(object sender, EventArgs e)
        {
            circularProgress1.Maximum = 100;
        }

        //bat dau main Form
        private void mainFormStart()
        {
           frmMain main=new frmMain();
           
            Application.Run(main);
            
            
        }

        //run main Form trong thread moi doc lap voi thread chinh
        private void threadMainForm()
        {
            System.Threading.Thread m_thread = new System.Threading.Thread(new System.Threading.ThreadStart(mainFormStart));
            m_thread.SetApartmentState(System.Threading.ApartmentState.STA);
            m_thread.Start();
            m_thread.Join();
        }

        private void frmScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
