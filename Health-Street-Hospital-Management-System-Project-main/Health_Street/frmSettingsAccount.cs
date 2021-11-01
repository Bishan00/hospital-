using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using SMDMySQLDBManager;
using MySql.Data.MySqlClient;

namespace Health_Street
{
    public partial class frmSettingsAccount : Form
    {
        private SmdDbManager dbManager;
        public static Image ProfilePic;
        public frmSettingsAccount()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1; PORT=3306; DATABASE=hospital; UID=root; PASSWORD=;");
            showData();
            
        }



        private void showData()
        {
            if (dbManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader1 = dbManager.ReadAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblFname.Text = reader1["First_Name"].ToString();
                    lblMname.Text = reader1["Middle_Name"].ToString();
                    lblSname.Text = reader1["Surname"].ToString();
                    lblDof.Text = reader1["Date_Of_Birth"].ToString();
                    lblGender.Text = reader1["Gender"].ToString();
                    lblAddress.Text = reader1["User_Address"].ToString();
                    lblTpNumber.Text = reader1["User_Tele_No"].ToString();
                    lblDesignation.Text = reader1["Designation"].ToString();
                    lblSalary.Text = "Rs." + reader1["Salary"].ToString();

                    string image = Convert.ToString(reader1[6]);
                    if (image == "System.Byte[]")
                    {
                        MemoryStream mstream = new MemoryStream((byte[])reader1[6]);
                        try
                        {
                            pbProfile.Image = new Bitmap(mstream);
                        }
                        catch (ArgumentException)
                        {
                            pbProfile.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("not Have a picturer");
                        pbProfile.Image = null;
                    }

                }
            }

            if (dbManager.chek("SELECT * FROM ACCOUNT WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                MySqlDataReader reader2 = dbManager.ReadAndGet("SELECT * FROM ACCOUNT WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader2.Read())
                {
                    lblGmail.Text = reader2["E_mail"].ToString();
                }
            }
        }

        private void frm_Update(object sender, frmSettingsAccountEdit.UpdatedEventArgs args)
        {
            showData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmSettingsAccountEdit frm = new frmSettingsAccountEdit();
            frm.updateEvent += frm_Update;
            new Health_Street.frmTranceparentBG(frm);
        }
    }
}
