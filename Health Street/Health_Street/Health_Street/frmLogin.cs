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
    public partial class frmLogin : Form
    {
        public static string passingRoll, passingRollName;
        private SmdDbManager dbManager;
        public frmLogin()
        {
            InitializeComponent();
            LoadCredentials();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            login.Start();
            txtUsername.Focus();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShwPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnShwPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void rememberMe()
        {
            if(chkbxRememberMe.Checked == false)
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            else if (chkbxRememberMe.Checked == true)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }

        void LoadCredentials()
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkbxRememberMe.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            string a = dbManager.ReadValue("SELECT * FROM account WHERE Login_Username = '" + txtUsername.Text + "' AND Login_Password = '" + txtPassword.Text + "' ",1);

            switch (a)
            {
                case "DOCTOR":
                    rememberMe();
                    this.Hide();
                    passingRoll = dbManager.getValue("SELECT * FROM 'ACCOUNT'", txtUsername.Text, 2, 0);
                    passingRollName = dbManager.getValue("SELECT * FROM 'ACCOUNT'", txtUsername.Text, 2, 1);
                    new frmAddmitionOfficer().Show();
                    if (txtPassword.Text == "hospharm0019")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Laboratorian":
                    rememberMe();
                    this.Hide();
                    new frmLaboratory().Show();
                    if (txtPassword.Text == "hoslabo00212")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Channeling Officer":
                    rememberMe();
                    this.Hide();
                    new frmChanlingOfficer().Show();
                    if (txtPassword.Text == "hoschan00346")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Admission Officer":
                    rememberMe();
                    this.Hide();
                    new frmAddmitionOfficer().Show();
                    if (txtPassword.Text == "hosadmit0019")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Billing Officer":
                    rememberMe();
                    this.Hide();
                    new frmBillingOfficer().Show();
                    if (txtPassword.Text == "hosbill00878")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Paediatrician":
                    rememberMe();
                    this.Hide();
                    new frmDctMain().Show();
                    if (txtPassword.Text == "hosdoc123406")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Paediatric Surgeon":
                    rememberMe();
                    this.Hide();
                    new frmLaboratory().Show();
                    if (txtPassword.Text == "hossurg87655")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Paediatric Oncologist":
                    rememberMe();
                    this.Hide();
                    new frmLaboratory().Show();
                    if (txtPassword.Text == "hosonco34236")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Paediatric Neurologist":
                    rememberMe();
                    this.Hide();
                    new frmLaboratory().Show();
                    if (txtPassword.Text == "hosneuro0087")
                    {
                        new Health_Street.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Error":
                    HSMessageBox.Show("The username or password \n that you've entered doesn't match ", "Loggin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    break;
            }
        }

        private void btnShwPass_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkLblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmForgetPassword().Show();
        }
    }
}
