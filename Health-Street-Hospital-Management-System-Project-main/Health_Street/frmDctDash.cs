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
    public partial class frmDctDash : Form
    {
        private SmdDbManager dbManager;
        public frmDctDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblDCTname.Text = "Hi, Dr."+reader1[2].ToString();

                }
            }

            rowCountOutPatient(); 
            rowCountInPatient();


            //SqlDataReader reader3 = dbManager.readAndGet("SELECT * FROM OUT_PATIENT");

            //while(reader3.Read())
            //{
            //    chrtPatient.Series[1].Points.AddXY(reader3[5].ToString(),Convert.ToInt32(reader3[4]));
            //}

        }

        private void rowCountOutPatient()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM OUT_PATIENT");
            lblOutpatient.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountInPatient()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM PATIENT_PRIVATE_DETAIL,GUARDIAN,IN_PATIENT WHERE PATIENT_PRIVATE_DETAIL.Guardian_Id_Number = GUARDIAN.Guardian_Id_Number AND PATIENT_PRIVATE_DETAIL.Patient_Id_Number=IN_PATIENT.Patient_Id_Number");
            lblInpatient.Text = "+" + dt.Rows.Count.ToString();
        }

        private void frmDctDash_Load(object sender, EventArgs e)
        {
            rowCountOutPatient();
            rowCountInPatient();
        }

    }
}
