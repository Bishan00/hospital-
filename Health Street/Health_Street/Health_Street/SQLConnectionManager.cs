using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace Health_Street
{
    public class SQLConnectionManager
    {
        public static SqlConnection sqlCon;
        public static SqlCommand cmd;
        public static SqlDataAdapter sqlDa;

        public static SqlConnection getSqlConnection()
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
            return sqlCon;
        }

        public static string ReadValue(string command)
        {
            getSqlConnection();
            sqlCon.Open();
            cmd = new SqlCommand(command,sqlCon);
            SqlDataReader sqlRd = cmd.ExecuteReader();
            string value = null;

            if (sqlRd.HasRows)
            {
                sqlRd.Read();
                switch(sqlRd[1].ToString())
                {
                    case "R0001":
                        value = "Pharmasician";
                        break;
                    case "R0002":
                        value = "Laboratorian";
                        break;
                    case "R0003":
                        value = "Channeling Officer";
                        break;
                    case "R0004":
                        value = "Admission Officer";
                        break;
                    case "R0005":
                        value = "Billing Officer";
                        break;
                    case "R0006":
                        value = "Paediatrician";
                        break;
                    case "R0007":
                        value = "Paediatric Surgeon";
                        break;
                    case "R0008":
                        value = "Paediatric Oncologist";
                        break;
                    case "R0009":
                        value = "Paediatric Neurologist";
                        break;
                    default:
                        value = "nothing";
                        break;
                }
                
            }
            else
            {
                //HSMessageBox.Show("The username or password \n that you've entered doesn't match ", "Loggin Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                value = "Error";
            }
            return value;


        }

        public static int insrtUpdteDelt(string command)
        {
            getSqlConnection();
            sqlCon.Open();
            cmd = new SqlCommand(command,sqlCon);
            int i = cmd.ExecuteNonQuery();
            sqlCon.Close();
            return i;
        }

        public static int chek(string command)
        {
            int i = 0;
            getSqlConnection();
            sqlCon.Open();
            sqlDa = new SqlDataAdapter(command,sqlCon);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            if(dt.Rows.Count<1)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }    
            sqlCon.Close();
            return i;
        }

        public static DataTable getdata(string cmd)
        {
            getSqlConnection();
            sqlCon.Open();
            sqlDa = new SqlDataAdapter(cmd,sqlCon);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            sqlCon.Close();
            return dt;
        }
    }
}
