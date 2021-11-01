using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SMDMySQLDBManager;
using MySql.Data.MySqlClient;

namespace Health_Street
{
    public partial class frmDctSettingsAccount : Form
    {
        private SmdDbManager dbManager;
        public frmDctSettingsAccount()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hospital;UID=root;PASSWORD=;");
        }

        private void frmDctSettingsAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void firstName()
        {
            txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
            lblFirstName.Text = "*First name cannot be blank";
        }
        private void surName()
        {
            txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
            lblSurname.Text = "*Surname cannot be blank";
        }
        private void dateOfBirth()
        {
            dtpDateofBirth.OnHoverBorderColor = Color.FromArgb(232, 17, 35);
            dtpDateofBirth.BorderColor = Color.FromArgb(232, 17, 35);
            dtpDateofBirth.ForeColor = Color.FromArgb(232, 17, 35);
            dtpDateofBirth.FocusedColor = Color.FromArgb(232, 17, 35);
            lblDateTime.Text = "*Cannot be blank";
        }
        private void tpNumber()
        {
            txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
            lblTp.Text = "TP number cannot be blank";
        }
        private void address()
        {
            txtAddress.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtAddress.BorderColor = Color.FromArgb(232, 17, 35);
            lblAddress.Text = "Address cannot be blank";
        }
        private void gmail()
        {
            txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
            lblGmail.Text = "Gmail canot be blank";
        }
        private void designation()
        {
            txtDesignation.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtDesignation.BorderColor = Color.FromArgb(232, 17, 35);
            lblDesignation.Text = "Designation cannot be blank";
        }

        private void salary()
        {
            txtSalary.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtSalary.BorderColor = Color.FromArgb(232, 17, 35);
            lblSalary.Text = "Salary Cannot be blank";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtSurname.Text) && DateTime.Now.Year == dtpDateofBirth.Value.Year && !rdoMale.Checked && !rdoFemale.Checked && string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtTp.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtDesignation.Text) && string.IsNullOrEmpty(txtSalary.Text))
            {
                firstName();
                surName();
                dateOfBirth();
                lblGender.Text = "*cannot be blank";
                tpNumber();
                address();
                gmail();
                designation();
                salary();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                firstName();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                surName();
                txtSurname.Focus();
            }
            else if ((DateTime.Now.Year == dtpDateofBirth.Value.Year))
            {
                dateOfBirth();
                dtpDateofBirth.Focus();
            }
            else if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                lblGender.Text = "*cannot be blank";
            }
            else if (string.IsNullOrEmpty(txtTpNumber.Text))
            {
                tpNumber();
                txtTpNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                address();
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(txtGmail.Text))
            {
                gmail();
                txtGmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtDesignation.Text))
            {
                designation();
                txtDesignation.Focus();
            }
            else if (string.IsNullOrEmpty(txtSalary.Text))
            {
                salary();
                txtSalary.Focus();
            }
            else if (DateTime.Now.Year <= dtpDateofBirth.Value.Year)
            {
                dtpDateofBirth.OnHoverBorderColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.BorderColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.ForeColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.FocusedColor = Color.FromArgb(232, 17, 35);
                lblDateTime.Text = "*cant";
            }
            else if (txtFirstName.Text.Any(char.IsDigit))
            {
                txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
                lblFirstName.Text = "cannot have numbers";
            }
            else if (txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
                lblSurname.Text = "cannot have numbers";
            }
            else if (txtMiddleName.Text.Any(char.IsDigit))
            {
                txtMiddleName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtMiddleName.BorderColor = Color.FromArgb(232, 17, 35);
                lblMiddleName.Text = "cannot have numbers";
            }
            else
            {
                if (dbManager.chek("SELECT * FROM LOG_IN_USER") == 1)
                {
                    MessageBox.Show("hi");
                }
                else if (dbManager.chek("SELECT * FROM LOG_IN_USER") == 0)
                {
                    string gender = string.Empty;
                    if(rdoMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if(rdoFemale.Checked)
                    {
                        gender = "Femail";
                    }
                    MessageBox.Show("INSERT INTO LOG_IN_USER VALUES('"+txtFirstName.Text+ "','"+txtMiddleName.Text+ "','"+txtSurname.Text+ "','"+dtpDateofBirth.Value+ "','"+gender+"')");
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !txtFirstName.Text.Any(char.IsDigit))
            {
                txtFirstName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtFirstName.BorderColor = Color.Silver;
                lblFirstName.ResetText();
            }
            else if (txtFirstName.Text.Any(char.IsDigit))
            {
                txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
                lblFirstName.Text = "cannot have numbers";
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSurname.Text) && !txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtSurname.BorderColor = Color.Silver;
                lblSurname.ResetText();
            }
            else if (txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
                lblSurname.Text = "cannot have numbers";
            }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!txtMiddleName.Text.Any(char.IsDigit))
            {
                txtMiddleName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtMiddleName.BorderColor = Color.Silver;
                lblMiddleName.ResetText();
            }
            else
            {
                txtMiddleName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtMiddleName.BorderColor = Color.FromArgb(232, 17, 35);
                lblMiddleName.Text = "cannot have numbers";
            }
        }

        private void dtpDateofBirth_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Now.Year > dtpDateofBirth.Value.Year)
            {
                dtpDateofBirth.OnHoverBorderColor = Color.FromArgb(250, 144, 156);
                dtpDateofBirth.BorderColor = Color.Silver;
                dtpDateofBirth.ForeColor = Color.FromArgb(50, 144, 156);
                dtpDateofBirth.FocusedColor = Color.FromArgb(50, 144, 156);
                lblDateTime.ResetText();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Image";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfilePic.Image = new Bitmap(ofd.FileName);
            }
        }

        private void txtTpNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
