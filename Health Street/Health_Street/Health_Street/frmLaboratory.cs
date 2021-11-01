using System;
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
    public partial class frmLaboratory : Form
    {

        private SmdDbManager dbManager;
        clsOpnChild chFrmObj = new clsOpnChild();
        public frmLaboratory()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hospital;UID=root;PASSWORD=;");
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

        private void subPnlClose()
        {
            if (pnlSubbtn.Visible == true)
            {
                pnlSubbtn.Visible = false;
                btnStaf.Checked = false;
                btnSettings.Checked = false;
                btnInpatient.Checked = false;
                btnOutpatient.Checked = false;
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            chFrmObj.openChild(new frmLabDash(), pnlPhrChild);
        }


        private void btnCmt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnSample.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnSample.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            subPnlClose();
            chFrmObj.openChild(new frmLabDash(), pnlPhrChild);
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            btnSample.Checked = false;
            if (pnlSubbtn.Visible != true)
            {
                btnDashboard.Checked = false;
                btnStaf.Checked = false;
                btnSettings.Checked = false;
                pnlSubbtn.Visible = true;
            }
            else
            {
                pnlSubbtn.Visible = false;
                btnInpatient.Checked = false;
                btnOutpatient.Checked = false;
            }
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            subPnlClose();
            chFrmObj.openChild(new frmLabSettings(), pnlPhrChild);
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
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(HSMessageBox.Show("Sachintha","Madhawa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.No)
            {
                this.Hide();
            }
        }

        private void btnInpatient_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;
        }

        private void btnStaf_Click(object sender, EventArgs e)
        {
            subPnlClose();
            this.btnStaf.Checked = true;
            chFrmObj.openChild(new frmLabStaff(), pnlPhrChild);
        }
    }
}
