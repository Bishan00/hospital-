using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SMDMySQLDBManager;
using MySql.Data.MySqlClient;

namespace Health_Street
{
    public partial class frmBillDash : Form
    {
        private SmdDbManager dbManager;
        public frmBillDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            ShowData();

            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblBillOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }

            rowCountGuardian();
            rowCountOrganzation();
        }

        private void rowCountGuardian()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM GUARDIAN");
            lblGuardian.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountOrganzation()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM ORGANIZATION");
            lblOrganization.Text = "+" + dt.Rows.Count.ToString();
        }

        private void ShowData()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM ORGANIZATION");
            dgvOrgniz.AutoGenerateColumns = false;
            dgvOrgniz.DataSource = dt;
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dgvOrgniz_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
