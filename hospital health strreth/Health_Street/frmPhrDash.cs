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
    public partial class frmPhrDash : Form
    {
        private SmdDbManager dbManager;
        public frmPhrDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            show();
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblPharmacy.Text = "Hi, " + reader1[2].ToString();

                }
            }

            rowCountMedicinet();
            rowCountSupplier();
        }

        private void rowCountMedicinet()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM DRUG");
            lblMedicine.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountSupplier()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM DRUG_SUPPLIER");
            lblSupplier.Text = "+" + dt.Rows.Count.ToString();
        }

        private void show()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM DRUG");
            dgvMedicine.AutoGenerateColumns = false;
            dgvMedicine.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM DRUG_SUPPLIER");
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dt2;
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            show();
            rowCountMedicinet();
            rowCountSupplier();
        }

        private void dgvMedicine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvSupplier_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
