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
    public partial class frmPharmacy : Form
    {

        private SmdDbManager dbManager;
        clsOpnChild chFrmObj = new clsOpnChild();
        public frmPharmacy()
        {
            InitializeComponent();
            phrAnimate.Start();
            pnlCmSubBtn.Visible = false;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            phrAnimate.Start();
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            chFrmObj.openChild(new frmPhrDash(), pnlPhrChild);
        }

        private void subPnlClose()
        {
            if (pnlCmSubBtn.Visible == true)
            {
                pnlCmSubBtn.Visible = false;
                btnSupp.Checked = false;
                btnCus.Checked = false;
                btnPchas.Checked = false;
            }
        }

        private void btnCmt_Click(object sender, EventArgs e)
        {
            btnCmt.Checked = false;
            if (pnlCmSubBtn.Visible != true)
            {
                btnDashboard.Checked = false;
                btnMed.Checked = false;
                pnlCmSubBtn.Visible = true;
            }
            else
            {
                pnlCmSubBtn.Visible = false;
                btnSupp.Checked = false;
                btnCus.Checked = false;
            }    
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnMed.Checked = false;
            btnPchas.Checked = false;
            btnSettings.Checked = false;
            chFrmObj.openChild(new frmPhrSplr(), pnlPhrChild);

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnMed.Checked = false;
            btnPchas.Checked = false;
            btnSettings.Checked = false;
            chFrmObj.openChild(new frmPhrCstmr(), pnlPhrChild);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            subPnlClose();
            chFrmObj.openChild(new frmPhrDash(), pnlPhrChild);
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            chFrmObj.openChild(new frmPhrMdcn(), pnlPhrChild);
            subPnlClose();
        }

        private void btnPchas_Click(object sender, EventArgs e)
        {
            subPnlClose();
            this.btnPchas.Checked = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            subPnlClose();
            //chFrmObj.openChild(new frmPhrSettings(), pnlPhrChild);
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
        }
    }
}
