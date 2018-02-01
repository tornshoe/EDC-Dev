using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Data;
using System.Windows.Forms;

namespace EDC
{
    class EDCTable
    {

        private int currentEDC { get; set; }            //The EDC currently being worked on
        private DataTable dt = new DataTable();         //The results of the SQL query will be stored here as a list of EDC entries
        

        public void getEDC(string status)
        {
            string query = "SELECT * FROM edc " +
                "WHERE Status = " + status;             //A modifiable query meant to be usable by multiple forms

            //MessageBox.Show(ConfigurationManager.AppSettings["sqlDestination"]);

            using (SqlConnection destServ = new SqlConnection(ConfigurationManager.AppSettings["sqlDestination"]))
            using (SqlCommand cmd = new SqlCommand(query, destServ))
            {
                try
                {
                    destServ.Open();
                }

                catch
                {
                    MessageBox.Show("Could not connect to SQL server!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = new DataTable();

                try
                {
                    dt.Load(cmd.ExecuteReader());
                }

                catch
                {
                    MessageBox.Show("Could not execute SQL query!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.dt = dt;
            }
        }

        public void sendEDC(string status, DataRow currentRow)
        {
            ///Will need to send only data which can change in a given form
        }

        public DataTable getDT()
        {
            return dt;
        }

        public int getCurrentEDC()
        {
            return currentEDC;
        }

        public void setCurrentEDC(int current)
        {
            currentEDC = current;
        }

        public EDCTable()
        {
            currentEDC = 0;
        }

    }
}