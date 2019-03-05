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
    public partial class WritOfPossesionsHome : MetroFramework.Forms.MetroForm
    {
        String connection;
        SqlConnection cn;
        DataTable dt;

        public WritOfPossesionsHome()
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
            Showallitems();
        }

        private void Showallitems()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("GetAllWOP", cn);

                dt.Clear();
                sda.Fill(dt);
                evictionsdatagrid.DataSource = dt;
                evictionsdatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                evictionsdatagrid.Columns[5].Visible = false;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                mainsearch(txtsearch.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        DataTable table0 = new DataTable();

        private void mainsearch(string search)
        {
            Showallitems();
            DataView dv = dt.DefaultView;
            string fullsearch = ("FullSearch LIKE '%{0}%'");
            try
            {
                search = search.Replace("'", "''");
                search = search.Replace("[", "[[]");
                dv.RowFilter = string.Format(fullsearch, search);
                evictionsdatagrid.DataSource = dt;
                table0 = dv.ToTable();
                evictionsdatagrid.Update();
                evictionsdatagrid.Refresh();
            }
            catch (Exception)

            {
                MessageBox.Show("Invalid Search Criteria Operator.", "SPM Connect");
                txtsearch.Clear();

            }
        }

        private void evictionsdatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string filenumber;
            if (evictionsdatagrid.SelectedRows.Count == 1)
            {
                int selectedrowindex = evictionsdatagrid.SelectedCells[0].RowIndex;
                DataGridViewRow slectedrow = evictionsdatagrid.Rows[selectedrowindex];
                filenumber = Convert.ToString(slectedrow.Cells[0].Value);
                using(NewWOP itemInfo = new NewWOP())//Open main form and hide login form
                {
                    itemInfo.getfileno(filenumber);
                    itemInfo.ShowDialog();
                    itemInfo.Dispose();
                    Showallitems();
                }
            }

        }

        private void newbttn_Click(object sender, EventArgs e)
        {
            string newfileno = idincrement(getlastfileno());
            insertinto_table(newfileno);
            using (NewWOP itemInfo = new NewWOP())//Open main form and hide login form
            {
                itemInfo.getfileno(newfileno);
                itemInfo.ShowDialog();
                itemInfo.Dispose();
                Showallitems();
            }
        }

        private string getlastfileno()
        {
            using (SqlCommand sqlCommand = new SqlCommand("GetLastFileNo", cn) { CommandType = System.Data.CommandType.Text })
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    string count = (string)sqlCommand.ExecuteScalar();

                    return count.ToString();

                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
                return "";
            }
        }

        private string idincrement(string lastnumber)
        {
            int x = 0;
            Int32.TryParse(lastnumber.Substring(8), out x);
            x += 1;
            string newid = lastnumber.Substring(0, 8) + x.ToString();
            return newid;

        }

        private void insertinto_table(string uniqueid)
        {
            DateTime dateedited = DateTime.Now;
            string sqlFormattedDate = dateedited.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertNewFileNoWOP";
                cmd.Parameters.AddWithValue("@fileno", uniqueid.ToString());
                cmd.Parameters.AddWithValue("@datefiled", sqlFormattedDate);
                cmd.ExecuteNonQuery();
                cn.Close();
                //MessageBox.Show("New entry created", "SPM Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
