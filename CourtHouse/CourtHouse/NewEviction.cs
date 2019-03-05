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

namespace CourtHouse
{
    public partial class NewEviction : Form
    {
        string fileno;
        String connection;
        SqlConnection cn;
        DataTable dt;

        public NewEviction()
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
            dt = new DataTable();
        }

        private void NewEviction_Load(object sender, EventArgs e)
        {
            filldatatable(fileno);
        }

        public string getfileno(string file)
        {
            if (file.Length > 0)
                return fileno = file;
            return null;
        }

        private void filldatatable(string filenumber)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("EvictionsDetails", cn))
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@filenumber", filenumber);
                    dt.Clear();
                    sda.Fill(dt);
                    fillinfo();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "error12", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }

            }
        }

        private void fillinfo()
        {
            DataRow r = dt.Rows[0];
            filenotxt.Text = r["FileNo"].ToString();
            firstnametxt.Text = r["FirstName"].ToString();
            lastnametxt.Text = r["LastName"].ToString();
            addtxt.Text = r["Address"].ToString();
            citytxt.Text = r["City"].ToString();
            posttxt.Text = r["PostalCode"].ToString();
            provincetxt.Text = r["Province"].ToString();
            contacttxt.Text = r["Phone"].ToString();
            emailtxt.Text = r["Email"].ToString();
            ordernotxt.Text = r["OrderNo"].ToString();
            lastsavedbylbl.Text = r["Filedby"].ToString();
            datelastsaved.Text = r["DateSaved"].ToString();
            datefilelbl.Text = r["DateFiled"].ToString();
            if (r["Cancelled"].ToString().Equals("1"))
            {
                cnclyes.Checked = true;

            }
            else 
            {
                cnclno.Checked = true;
            }
            if (r["Stayed"].ToString().Equals("1"))
            {
                styedyes.Checked = true;

            }
            else 
            {
                styedno.Checked = true;
            }
            try
            {
                string pattern = "yyyy/MM/dd";
                DateTime parsedDate;

                string dateValue = r["EvictionDate"].ToString();

                if (DateTime.TryParseExact(dateValue, pattern, null,
                                          System.Globalization.DateTimeStyles.None, out parsedDate))
                {
                    // MessageBox.Show(string.Format("Converted '{0}' to {1:d}.", dateValue, parsedDate));
                }
                else
                {
                    //MessageBox.Show(string.Format("Unable to convert '{0}' to a date and time.",
                    // dateValue));
                }
                dateTimePicker1.Value = parsedDate;
            }
            catch
            {

            }
          
        }

        private void NewEviction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (savebttn.Visible == true)
            {
                DialogResult result = MessageBox.Show("Are you sure want to close without saving changes?", "SPM Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                }
                else
                {
                    e.Cancel = (result == DialogResult.No);
                }
            }
        }

        void lockdown()
        {
            filenotxt.Enabled = false;
            firstnametxt.Enabled =false;
            lastnametxt.Enabled = false;
            addtxt.Enabled = false;
            citytxt.Enabled = false;
            posttxt.Enabled = false;
            provincetxt.Enabled = false;
            contacttxt.Enabled = false;
            emailtxt.Enabled = false;
            ordernotxt.Enabled = false;   
            dateTimePicker1.Enabled = false;
            canclepanel.Enabled = false;
            styedpanel.Enabled = false;
        }

        void openup()
        {
            filenotxt.Enabled = true;
            firstnametxt.Enabled = true;
            lastnametxt.Enabled = true;
            addtxt.Enabled = true;
            citytxt.Enabled = true;
            posttxt.Enabled = true;
            provincetxt.Enabled = true;
            contacttxt.Enabled = true;
            emailtxt.Enabled = true;
            ordernotxt.Enabled = true;
            dateTimePicker1.Enabled = true;
            canclepanel.Enabled = true;
            styedpanel.Enabled = true;
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            savebttn.Visible = false;
            editbttn.Visible = true;
            lockdown();
            graballinfo();
            savetosql(list[0].ToString(), list[1].ToString(), list[2].ToString(), list[3].ToString(), list[4].ToString(), list[5].ToString(), list[6].ToString(), list[7].ToString(), list[8].ToString(), list[9].ToString(), list[10].ToString());

        }

        List<string> list = new List<string>();

        private void graballinfo()
        {
            list.Clear();
            list.Add(filenotxt.Text);
            list.Add(firstnametxt.Text);
            list.Add(lastnametxt.Text);
            list.Add(addtxt.Text);
            list.Add(citytxt.Text);
            list.Add(posttxt.Text);
            list.Add(provincetxt.Text);
            list.Add(contacttxt.Text);
            list.Add(emailtxt.Text);
            list.Add(ordernotxt.Text);
            list.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].Replace("'", "''");
            }

        }

        private void editbttn_Click(object sender, EventArgs e)
        {
            editbttn.Visible = false;
            savebttn.Visible = true;
            openup();
        }

        private void savetosql(string fileno, string firstname, string lastname, string address, string city, string postcode, string province, string contact, string email, string orderno, string evictiondate)
        {
            DateTime dateedited = DateTime.Now;
            string sqlFormattedDate = dateedited.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEvictions";

                cmd.Parameters.AddWithValue("@file", fileno);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@postcode", postcode);
                cmd.Parameters.AddWithValue("@province", province);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@email", email);                
                cmd.Parameters.AddWithValue("@orderno", orderno);
                cmd.Parameters.AddWithValue("@evictiondate", evictiondate);
                cmd.Parameters.AddWithValue("@cancelled", (cnclyes.Checked ? 1 : 0));
                cmd.Parameters.AddWithValue("@stayed", (styedyes.Checked ? 1 : 0));
                cmd.Parameters.AddWithValue("@user", "admin");
                cmd.Parameters.AddWithValue("@lastsaved", sqlFormattedDate);


                cmd.ExecuteNonQuery();
                cn.Close();
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

    }
}
