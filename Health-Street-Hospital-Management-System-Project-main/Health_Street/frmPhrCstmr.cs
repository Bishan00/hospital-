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

namespace Health_Street
{
    public partial class frmPhrCstmr : Form
    {
        private SmdDbManager dbManager;
        public frmPhrCstmr()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hospital;UID=root;PASSWORD=;");


            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = dbManager.getdata("SELECT * FROM 'HOSPITAL_CUSTOMER'");
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt;
        }

        private void frmPhrCstmr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {

        }
       

        private void dgvCustomer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
