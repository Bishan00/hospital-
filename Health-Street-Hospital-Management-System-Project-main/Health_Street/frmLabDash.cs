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
using SMDMySQLDBManager;
using MySql.Data.MySqlClient;

namespace Health_Street
{
    public partial class frmLabDash : Form
    {
        private SmdDbManager dbManager;
        public frmLabDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            dataShow();
            DashName();
            rowCountInpatient();
            rowCountOutpatient();
        }

        private void rowCountInpatient()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM IN_SAMPLE");
            lblInpatient.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountOutpatient()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM OUT_SAMPLE");
            lblOutpatient.Text = "+" + dt.Rows.Count.ToString();
        }

        private void frmLabDash_Load(object sender, EventArgs e)
        {
            dataShow();
        }

        private void DashName()
        {
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblLabOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM LABORATORY_STAFF");
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM IN_SAMPLE");
            dgvSample.AutoGenerateColumns = false;
            dgvSample.DataSource = dt2;
        }

        private void dgvStaff_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvSample_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
