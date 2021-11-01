﻿using System;
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
    public partial class frmWdDash : Form
    {
        private SmdDbManager dbManager;
        public frmWdDash()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            show();
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblBillOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
            rowCount();
        }

        private void rowCount()
        {
            DataTable dt1 = new DataTable();
            dt1 = dbManager.getdata("SELECT * FROM ROOM");
            lblRooms.Text = "+" + dt1.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM WARD");
            lblWards.Text = "+" + dt2.Rows.Count.ToString();

            DataTable dt3 = new DataTable();
            dt3 = dbManager.getdata("SELECT * FROM IN_PATIENT");
            lblPatient.Text = "+" + dt3.Rows.Count.ToString();
        }
        private void show()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM ROOM,WARD WHERE ROOM.Ward_Number = WARD.Ward_Number");
            dgvRooms.AutoGenerateColumns = false;
            dgvRooms.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM IN_PATIENT");
            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = dt2;
        }

        private void frmWdDash_Load(object sender, EventArgs e)
        {
            show();
            rowCount();
        }

        private void dgvRooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvPatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
