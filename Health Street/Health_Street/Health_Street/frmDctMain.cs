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
    public partial class frmDctMain : Form
    {

        private SmdDbManager dbManager;
        clsOpnChild chld = new clsOpnChild();
        public frmDctMain()
        {
            InitializeComponent();
            dctAnimate.Start();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PnlScrollOut(Panel pnl)
        {
            pnl.AutoScroll = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmDctMain_Load(object sender, EventArgs e)
        {
            dctAnimate.Start();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            chld.openChild(new frmDctDash(), pnlChildForms);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = true;
            chld.openChild(new frmDctDash(), pnlChildForms);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(HSMessageBox.Show("Sachintha","Madhawa",MessageBoxButtons.YesNo,MessageBoxIcon.Error)!=DialogResult.No)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void pnlDctmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPatinents_Click_1(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = false;
            chld.openChild(new frmDctPatient(), pnlChildForms);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = false;
            chld.openChild(new frmDctSettings(), pnlChildForms);
        }

        private void btnGuardian_Click(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = false;
            chld.openChild(new frmDctGuardian(), pnlChildForms);
        }
    }
}
