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
    public partial class frmChanlDash : Form
    {
        private SmdDbManager dbManager;
        public frmChanlDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            DashName();
            tabeleLoad();
            rowCountDoctors();
            rowCountCustomers();


        }

        private void rowCountDoctors()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM SPECIALIST_DOCTOR");
            lblDoctors.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountCustomers()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM CUSTOMER");
            lblCustomers.Text = "+" + dt.Rows.Count.ToString();
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            DashName();

            tabeleLoad();
        }

        private void tabeleLoad()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM SPECIALIST_DOCTOR");
            dgvDoctor.AutoGenerateColumns = false;
            dgvDoctor.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM CUSTOMER");
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt2;
        }

        private void DashName()
        {
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblChanlOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
        }

        private void dgvDoctor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvCustomer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
