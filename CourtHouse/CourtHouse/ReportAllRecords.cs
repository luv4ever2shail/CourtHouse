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
    public partial class ReportAllRecords : MetroFramework.Forms.MetroForm
    {
        String connection;
        SqlConnection cn;
        DataTable dt;

        public ReportAllRecords()
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

        private void EvictionsHome_Load(object sender, EventArgs e)
        {

            onload();
        }

        void onload()
        {
            Showallitems();
            //getcountrecords("Evictions");
            //getcountrecords("WOP");
            counttyperecords();
        }

        private void Showallitems()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("ShowAllRecords", cn);

                dt.Clear();
                sda.Fill(dt);
                evictionsdatagrid.DataSource = dt;
                evictionsdatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[6].Visible = false;

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

        private void getcountrecords(string type)
        {
            using (SqlCommand sqlCommand = new SqlCommand("CountRecords", cn) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    sqlCommand.Parameters.AddWithValue("@type", type);
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (type == "Evictions")
                    {
                        countevictxt.Text = count.ToString();
                    }
                    else
                    {
                        countwoptxt.Text = count.ToString();
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
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    mainsearch(txtsearch.Text);
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;

            //}
        }

        DataTable table0 = new DataTable();

        private void mainsearch(string search)
        {
            //Showallitems();
            //DataView dv = dt.DefaultView;
            //string fullsearch = ("FullSearch LIKE '%{0}%'");
            //try
            //{
            //    search = search.Replace("'", "''");
            //    search = search.Replace("[", "[[]");
            //    dv.RowFilter = string.Format(fullsearch, search);
            //    evictionsdatagrid.DataSource = dt;
            //    table0 = dv.ToTable();
            //    evictionsdatagrid.Update();
            //    evictionsdatagrid.Refresh();
            //}
            //catch (Exception)

            //{
            //    MessageBox.Show("Invalid Search Criteria Operator.", "SPM Connect");
            //    txtsearch.Clear();

            //}
        }

        private void evictionsdatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string filenumber;
            //if (evictionsdatagrid.SelectedRows.Count == 1)
            //{
            //    int selectedrowindex = evictionsdatagrid.SelectedCells[0].RowIndex;
            //    DataGridViewRow slectedrow = evictionsdatagrid.Rows[selectedrowindex];
            //    filenumber = Convert.ToString(slectedrow.Cells[0].Value);
            //    using(NewEviction itemInfo = new NewEviction())//Open main form and hide login form
            //    {
            //        itemInfo.getfileno(filenumber);
            //        itemInfo.ShowDialog();
            //        itemInfo.Dispose();
            //    }
            // }

        }

        private void loaddatabttn_Click(object sender, EventArgs e)
        {
            loaddatabetween(frmdatepick.Value.ToString("yyyy-MM-dd"), todatepic.Value.ToString("yyyy-MM-dd"));
            //getcountrecordsbetween("Evictions", frmdatepick.Value.ToString(), todatepic.Value.ToString());
            //getcountrecordsbetween("WOP", frmdatepick.Value.ToString(), todatepic.Value.ToString());
            counttyperecords();
        }

        private void loaddatabetween(string datefrom, string dateto)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("ShowAllRecordsBetween", cn))
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@datestart", datefrom);
                    sda.SelectCommand.Parameters.AddWithValue("@dateto", dateto);
                    dt.Clear();
                    sda.Fill(dt);

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

        private void getcountrecordsbetween(string type, string datefrom, string dateto)
        {
            using (SqlCommand sqlCommand = new SqlCommand("CountRecordsBetween", cn) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    sqlCommand.Parameters.AddWithValue("@type", type);
                    sqlCommand.Parameters.AddWithValue("@datestart", datefrom);
                    sqlCommand.Parameters.AddWithValue("@dateto", dateto);
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (type == "Evictions")
                    {
                        countevictxt.Text = count.ToString();
                    }
                    else
                    {
                        countwoptxt.Text = count.ToString();
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
        }

        private void showallbttn_Click(object sender, EventArgs e)
        {
            onload();
        }

        void counttyperecords()
        {
            int countwop = 0;
            int countevic = 0;

            foreach (DataGridViewRow row in evictionsdatagrid.Rows)
            {
                if (row.Cells[7].Value.ToString().Equals("WOP"))
                {
                    countwop += 1;

                }
                else
                {
                    countevic += 1;
                }
            }
            countwoptxt.Text = countwop.ToString();
            countevictxt.Text = countevic.ToString();

        }

    }
}
