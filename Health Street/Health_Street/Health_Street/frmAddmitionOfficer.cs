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
using MySql.Data.MySqlClient;

namespace Health_Street
{
    public partial class frmAddmitionOfficer : Form
    {
        private SmdDbManager dbManager;
        clsOpnChild chFrmObj = new clsOpnChild();
        public frmAddmitionOfficer()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hospital;UID=root;PASSWORD=;");
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private const int CS_Dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_Dropshadow;
                return cp;
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            chFrmObj.openChild(new frmPhrDash(), pnlPhrChild);
        }


        private void btnCmt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnOfficer.Checked = false;
            btnAdmitPatient.Checked = false;
            btnSettings.Checked = false;

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnOfficer.Checked = false;
            btnAdmitPatient.Checked = false;
            btnSettings.Checked = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            chFrmObj.openChild(new frmPhrDash(), pnlPhrChild);
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
        }

        private void btnPchas_Click(object sender, EventArgs e)
        {
            this.btnAdmitPatient.Checked = true;
            chFrmObj.openChild(new frmADaddmitPatient(), pnlPhrChild);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(HSMessageBox.Show("Sachintha","Madhawa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.No)
            {
                this.Hide();
            }
        }
    }
}
