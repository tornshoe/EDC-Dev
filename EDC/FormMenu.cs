using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDC
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes an instance of FormComplete and hides the current FormMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormComplete formComplete = new FormComplete();
            Hide();
            Cursor.Current = Cursors.Default;
            formComplete.ShowDialog();
            this.Show();
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Initializes an instance of FormRequest and hides the current FormMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void requestButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormRequest formRequest = new FormRequest();
            Hide();
            Cursor.Current = Cursors.Default;
            formRequest.ShowDialog();
            this.Show();
        }
    }
}