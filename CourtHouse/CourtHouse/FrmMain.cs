using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtHouse
{
    public partial class FrmMain:MetroFramework.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
         //   Application.Exit();
        }

        private void evicttile_Click(object sender, EventArgs e)
        {
            using (EvictionsHome frm = new EvictionsHome())//Open main form and hide login form
            {
                //this.Hide();
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void woptile_Click(object sender, EventArgs e)
        {
            using (WritOfPossesionsHome frm = new WritOfPossesionsHome())//Open main form and hide login form
            {
                //this.Hide();
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void viewreportbttn_Click(object sender, EventArgs e)
        {
            using (ReportAllRecords frm = new ReportAllRecords())//Open main form and hide login form
            {
                //this.Hide();
                frm.ShowDialog();
                frm.Dispose();
            }
        }
    }
}
