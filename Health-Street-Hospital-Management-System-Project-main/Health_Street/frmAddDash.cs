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
    public partial class frmAddDash : Form
    {
        private SmdDbManager dbManager;
        public frmAddDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            ShowData();
            rowCount();

            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                 MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblAddmitionOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
        }

        private void rowCount()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT Room_Availability FROM ROOM WHERE Room_Availability='YES'");
            lblSoledRoom.Text = "+" + dt.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT Room_Availability FROM ROOM WHERE Room_Availability='NO'");
            lblAvailbaleRoom.Text = "+" + dt2.Rows.Count.ToString();
        }

        private void ShowData()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM ROOM");
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM WARD");
            dgvWard.AutoGenerateColumns = false;
            dgvWard.DataSource = dt2;
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            ShowData();
            rowCount();
        }

        private void dgvRoom_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvWard_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
