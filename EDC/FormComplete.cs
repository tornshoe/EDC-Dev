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
using System.Configuration;
using System.DirectoryServices.AccountManagement;

namespace EDC
{
    public partial class FormComplete : Form
    {
        EDCTable table = new EDCTable();

        public FormComplete()
        {
            InitializeComponent();

            string[] primaryCause = new[] { "Cashwise", "Store", "Admin - Completed Incorrectly", "Admin - Submitted Incorrectly", "Other", "Manual Process" };
            comboBoxPrimCause.DataSource = primaryCause;

            string[] causeDetail = new[] { "CW Calculating Principle/Interest Incorrectly", "Partially Processed NEW Transaction", "Partially Processed PAY/PIC/EXT Transaction",
            "Pending Deferred is Not Available", "Transaction/Data was Not Entered", "Transaction/Data was Entered Inccorectly", "Transaction/Data Should Not have been Entered" };
            comboBoxCauseDetail.DataSource = causeDetail;

            string[] secCause = new[] { "NEW/EXT/RBO", "PAY/HOL/PIC", "Deposit", "Debt", "Cash Debt Payment", "Non-Cash Debt Payment", "Non-Cash Deferred Payment", "Collateral Information",
            "Customer Information", "Voided NEW/EXT/RBO", "2nd Return", "Other" };
            comboBoxSecCause.DataSource = secCause;

            setForm();
            if (table.getDT().Rows.Count - 1 > table.getCurrentEDC())
            {
                buttonNext.Enabled = true;
            }

            else buttonNext.Enabled = false;
            buttonPrevious.Enabled = false;


        }

        /// <summary>
        /// Queries the EDC table for any "In Progress" EDCs, clears the form of any current info, then sets the form with info from the first EDC in the returned list, if any
        /// </summary>
        public void setForm()
        {
            table.getEDC("'In Progress'");
            table.setCurrentEDC(0);
            clearForm();
            showEDC();
            checkButtons();
        }

        /// <summary>
        /// Checks to see if any "In Progress" EDCs were pulled, and if any were then it gives the necessary information to each respective control
        /// </summary>
        public void showEDC()
        {
            if (table.getDT().Rows.Count > 0)
            {
                DataRow currentRow = table.getDT().Rows[table.getCurrentEDC()];

                textBoxReqDate.Text = currentRow["Creqdt"].ToString();
                textBoxStoreNum.Text = currentRow["Storenum"].ToString();
                textBoxCustName.Text = currentRow["CustName"].ToString();
                textBoxCustSSN.Text = currentRow["Custssn"].ToString();
                textBoxContNum.Text = currentRow["Contractno"].ToString();
                textBoxReqBy.Text = currentRow["Creqby"].ToString();
                textBoxExt.Text = currentRow["Creqext"].ToString();
                checkBoxUrgent.Checked = (bool)currentRow["Urgent"];
                textBoxCheckNum.Text = currentRow["Checkno"].ToString();
                textBoxProb.Text = currentRow["Creqinfo"].ToString();
                textBoxStartDate.Text = currentRow["Cstartdt"].ToString();
                textBoxStartBy.Text = currentRow["Cstartby"].ToString();
                
            }

            else
            {
                MessageBox.Show("No EDCs in progress!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Sets the controls to their default, empty position
        /// </summary>
        public void clearForm()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }

            checkBoxBackdating.Checked = false;
            checkBoxUrgent.Checked = false;

            comboBoxPrimCause.SelectedIndex = 4;
            comboBoxCauseDetail.SelectedIndex = 5;
            comboBoxSecCause.SelectedIndex = 11;

            buttonSave.Enabled = false;
            buttonComplete.Enabled = false;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sets the current state of the next/previous buttons based on how the current EDC's position in the list of EDCs being worked on
        /// </summary>
        private void checkButtons()
        {
            if (table.getDT().Rows.Count - 1 <= table.getCurrentEDC())
            {
                buttonNext.Enabled = false;
            }

            else buttonNext.Enabled = true;

            if (table.getCurrentEDC() <= 0)
            {
                buttonPrevious.Enabled = false;
            }

            else buttonPrevious.Enabled = true;
        }

        /// <summary>
        /// Resets the form, moves to the next edc in the list, repopulates the form with the new info, then checks if the button status should change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            table.setCurrentEDC(table.getCurrentEDC() + 1);
            clearForm();
            showEDC();
            checkButtons();
        }

        /// <summary>
        /// Resets the form, moves to the previous edc in the list, repopulates the form with the new info, then checks if the button status should change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            table.setCurrentEDC(table.getCurrentEDC() - 1);
            clearForm();
            showEDC();
            checkButtons();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            setForm();
        }
        
        private void buttonComplete_Click(object sender, EventArgs e)
        {
            UserPrincipal uPrincipal = UserPrincipal.Current;
            textBoxCompBy.Text = uPrincipal.DisplayName;

                
        }

        private void buttonBeginCorr_Click(object sender, EventArgs e)
        {
            buttonComplete.Enabled = true;

            UserPrincipal uPrincipal = UserPrincipal.Current;
            textBoxStartBy.Text = uPrincipal.DisplayName;
            textBoxStartDate.Text = DateTime.Now.ToString();


        }
    }
}