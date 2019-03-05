using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CourtHouse
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        String connection;
        SqlConnection cn;

        public LoginForm()
        {
            InitializeComponent();
           
            connection = System.Configuration.ConfigurationManager.ConnectionStrings["CourtHouse.Properties.Settings.cndb"].ConnectionString;
            
            try
            {
                cn = new SqlConnection(connection);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate();
            if (Properties.Settings.Default.RememberMe)//True
            {
                //Set value to username textbox and password textbox

                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;

            }
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)//Set value to user settings
            {

                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.RememberMe = chkRememberMe.Checked;
            Properties.Settings.Default.Save();//Save data to user settings
        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            try
            {
                string pass = ConverterHash.Encrypt(txtPassword.Text.Trim());
                using (SqlCommand sqlCommand = new SqlCommand("GetEmployeeLogininfo", cn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    cn.Open();

                    sqlCommand.Parameters.AddWithValue("@username", txtUserName.Text);
                    sqlCommand.Parameters.AddWithValue("@password", pass);

                    int userCount = (int)sqlCommand.ExecuteScalar();
                    if (userCount == 1)
                    {
                        using (FrmMain frm = new FrmMain())//Open main form and hide login form
                        {
                            this.Hide();
                            frm.ShowDialog();
                            frm.Dispose();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginBttn.PerformClick();
            }
        }
    }
}
