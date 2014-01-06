using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using System.Data.SqlClient;

namespace QuanLiHocSinh
{
    public partial class frmConnection : DevComponents.DotNetBar.Office2007Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            cmbAuthentication.SelectedIndex = 0;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
                clsKhoiTaoCSDL.XMLWriter("ConnectString.con", txtServer.Text, cmbDatabase.Text, "true");
            else
                clsKhoiTaoCSDL.XMLWriter("ConnectString.con", txtServer.Text, txtUsername.Text, txtPassword.Text, cmbDatabase.Text, "false");

            this.DialogResult = DialogResult.OK;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            int test = 0;
            //Quyền Windows
            if (cmbAuthentication.SelectedIndex == 0)
            {
                cmbDatabase.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                //SP_DATABASES là một store procedure có sẵn của sql server để lấy ra tất cả csdl trong sql server
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDatabase.Items.Add(reader[0].ToString());
                    }
                    cmbDatabase.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                    cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cmbAuthentication.SelectedIndex == 1)
            {
                cmbDatabase.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                SqlDataReader reader;

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDatabase.Items.Add(reader[0].ToString());
                    }
                    cmbDatabase.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    test = 1;
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                    cmd.Dispose();
                }

            }
            if (test == 0)
            {
                FileInfo file = new FileInfo(Application.StartupPath + @"\minh32.sql");
                string script = file.OpenText().ReadToEnd();
                SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;");

                Server server = new Server(new ServerConnection(con));
                server.ConnectionContext.ExecuteNonQuery(script);
                file.OpenText().Close();
                MessageBox.Show("Khởitạo CSDL thành công");
            }
            else
            {
                FileInfo file = new FileInfo(Application.StartupPath + @"\minh32.sql");
                string script = file.OpenText().ReadToEnd();
                SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                Server server = new Server(new ServerConnection(con));
                server.ConnectionContext.ExecuteNonQuery(script);
                file.OpenText().Close();
                MessageBox.Show("Khởitạo CSDL thành công");
            }
            cmbDatabase.Text = "TEST";
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
}
