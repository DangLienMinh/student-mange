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
            cboAuthentication.SelectedIndex = 0;            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboDatabase.SelectedItem!=null)
            {
                //quyền windows
                if (cboAuthentication.SelectedIndex == 0)
                    clsKhoiTaoCSDL.XMLWriter("ConnectString.con", txtServer.Text, cboDatabase.Text, "true");
                else
                    //quyền sql server
                    clsKhoiTaoCSDL.XMLWriter("ConnectString.con", txtServer.Text, txtUsername.Text, txtPassword.Text, cboDatabase.Text, "false");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Phải chọn kiểm tra dữ liệu trước");
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (txtServer.Text!="")
            {
                //biến kiểm tra kiểu đăng nhập nếu quyền windows là 0, quyền sql server là 1
                int flag = 0;

                //Quyền Windows
                if (cboAuthentication.SelectedIndex == 0)
                {
                    cboDatabase.Items.Clear();
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
                            cboDatabase.Items.Add(reader[0].ToString());
                        }
                        cboDatabase.Enabled = true;
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
                if (cboAuthentication.SelectedIndex == 1)
                {
                    cboDatabase.Items.Clear();
                    SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                    SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                    SqlDataReader reader;

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cboDatabase.Items.Add(reader[0].ToString());
                        }
                        cboDatabase.Enabled = true;
                        MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = 1;
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
                if (flag == 0)
                {
                    FileInfo file = new FileInfo(Application.StartupPath + @"\minh32.sql");
                    string script = file.OpenText().ReadToEnd();
                    SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;");

                    Server server = new Server(new ServerConnection(con));
                    server.ConnectionContext.ExecuteNonQuery(script);
                    file.OpenText().Close();
                    MessageBox.Show("Khởi tạo CSDL thành công");
                }
                else
                {
                    FileInfo file = new FileInfo(Application.StartupPath + @"\minh32.sql");
                    string script = file.OpenText().ReadToEnd();
                    SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                    Server server = new Server(new ServerConnection(con));
                    server.ConnectionContext.ExecuteNonQuery(script);
                    file.OpenText().Close();
                    MessageBox.Show("Khởi tạo CSDL thành công");
                }
                cboDatabase.Text = "QuanLyHocSinh";
            }
            else
            {
                MessageBox.Show("Phải nhập tên server trước khi kiểm tra kết nối");
            }           
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthentication.SelectedIndex == 0)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
