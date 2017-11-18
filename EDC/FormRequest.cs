using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Data.SqlClient;
using System.Configuration;

namespace EDC
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
            formSetup();
        }

        /// <summary>
        /// Initially clears the controls on the form, then automatically inputs the date, current user, and phone extension
        /// </summary>
        private void formSetup()
        {
            textBoxReqDate.Text = null;
            textBoxCheckNum.Text = null;
            textBoxContractNum.Text = null;
            textBoxCustName.Text = null;
            textBoxDesAct.Text = null;
            textBoxExt.Text = null;
            textBoxProblem.Text = null;
            textBoxReqBy.Text = null;
            textBoxStoreNum.Text = null;
            maskedTextBoxCustSSN.Text = null;
            checkBoxUrgent.Checked = false;

            textBoxReqDate.Text = DateTime.Now.ToString();

            UserPrincipal uPrincipal = UserPrincipal.Current;
            textBoxReqBy.Text = uPrincipal.DisplayName;
            textBoxExt.Text = uPrincipal.VoiceTelephoneNumber;
        }

        /// <summary>
        /// Closes the form and returns to the main menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Checks the required controls to make sure none are empty, then submits the request to the SQL table as a query and creates a new row in the EDC table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmitReq_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxStoreNum.Text)) && (!string.IsNullOrEmpty(textBoxCustName.Text)) && (!string.IsNullOrEmpty(maskedTextBoxCustSSN.Text)))
            {
                string cmdString = "INSERT INTO edc(Creqdt, Storenum, Custname, Custssn, Contractno, Creqby, Creqinfo, Checkno, Creqext, Urgent, Creqreason, Status) VALUES (@val1, @val2, @val3, @val4, @val5," +
                    "@val6, @val7, @val8, @val9, @val10, @val11, @val12)";

                using (SqlConnection destServ = new SqlConnection(ConfigurationManager.AppSettings["sqlDestination"]))
                using (SqlCommand command = new SqlCommand())
                {
                    destServ.Open();
                    command.Connection = destServ;
                    command.CommandText = cmdString;
                    command.Parameters.AddWithValue("@val1", Convert.ToDateTime(textBoxReqDate.Text));
                    command.Parameters.AddWithValue("@val2", textBoxStoreNum.Text);
                    command.Parameters.AddWithValue("@val3", textBoxCustName.Text);
                    command.Parameters.AddWithValue("@val4", maskedTextBoxCustSSN.Text);
                    command.Parameters.AddWithValue("@val5", textBoxContractNum.Text);
                    command.Parameters.AddWithValue("@val6", textBoxReqBy.Text);
                    command.Parameters.AddWithValue("@val7", textBoxProblem.Text);
                    command.Parameters.AddWithValue("@val8", textBoxCheckNum.Text);
                    command.Parameters.AddWithValue("@val9", textBoxExt.Text);
                    command.Parameters.AddWithValue("@val10", checkBoxUrgent.Checked);
                    command.Parameters.AddWithValue("@val11", textBoxDesAct.Text);
                    command.Parameters.AddWithValue("@val12", "In Progress");

                    try
                    {
                        command.ExecuteNonQuery();

                        formSetup();
                    }

                    catch (SqlException except)
                    {
                        MessageBox.Show(except.ToString(), "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Missing required info!", "Missing Info Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}