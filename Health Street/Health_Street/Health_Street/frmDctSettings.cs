using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI;
using Guna.UI.WinForms;
using SMDMySQLDBManager;
using MySql.Data.MySqlClient;

namespace Health_Street
{
    public partial class frmDctSettings : Form
    {
        private SmdDbManager dbManager;
        public frmDctSettings()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hospital;UID=root;PASSWORD=;");
        }

        clsOpnChild obj = new clsOpnChild();

        private void btnStngLogin_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            pbIcon.Image = Properties.Resources.password;
            obj.openChild(new frmDctSettingsLogin(), pnlDctSettingsChild);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            pbIcon.Image = Properties.Resources.account;
            obj.openChild(new frmDctSettingsAccount(), pnlDctSettingsChild);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            pbIcon.Image = Properties.Resources.ContactUs;
            //obj.openChild(new frmdct(), pnlDctSettingsChild);
        }

        private void frmDctSettings_Load(object sender, EventArgs e)
        {
            pbIcon.Image = Properties.Resources.password;
            obj.openChild(new frmDctSettingsLogin(), pnlDctSettingsChild);
        }
    }
}
