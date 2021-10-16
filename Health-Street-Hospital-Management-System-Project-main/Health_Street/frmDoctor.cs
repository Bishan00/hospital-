﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMySQLDBManager;

namespace Health_Street
{
    public partial class frmDoctor : Form
    {
        private SmdDbManager dbManager; 
        public frmDoctor()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hospital;UID=root;PASSWORD=;");



            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM 'LOG_IN_USER' WHERE Roll_name = 'DOCTOR' ");
            dgvOfficer.AutoGenerateColumns = false;
            dgvOfficer.DataSource = dt;
        }
        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmADaddmitPatient_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt =dbManager.getdata("SELECT * FROM LOG_IN_USER WHERE Roll_name LIKE '" + frmLogin.passingRollName + "%' AND ( Roll_Id LIKE '" + txtSearch.text + "%' OR First_Name LIKE '" + txtSearch.text + "%' OR Middle_Name LIKE '" + txtSearch.text + "%' OR Gender LIKE '" + txtSearch.text + "%' )");
            dgvOfficer.DataSource = dt;
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {

        }

        private void dgvOfficer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
