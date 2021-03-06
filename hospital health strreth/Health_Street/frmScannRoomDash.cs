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
    public partial class frmScannRoomDash : Form
    {
        private SmdDbManager dbManager;
        public frmScannRoomDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            DashName();
            dataShow();
            rowCountInpatients();
            rowCountOutpatients();
        }

        private void rowCountInpatients()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM IN_PATIENT_SCAN");
            lblInpatients.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountOutpatients()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM OUT_PATIENT_SCAN");
            lblOutpatients.Text = "+" + dt.Rows.Count.ToString();
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            DashName();
            dataShow();
        }

        private void DashName()
        {
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblScanOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM SCAN_ROOM");
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM IN_PATIENT_SCAN,OUT_PATIENT_SCAN");
            dgvScann.AutoGenerateColumns = false;
            dgvScann.DataSource = dt2;
        }

        private void dgvStaff_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvScann_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
