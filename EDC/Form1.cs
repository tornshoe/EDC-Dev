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

namespace EDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pWordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalContext context = new PrincipalContext(ContextType.Domain, "TCSDomain.local");
            UserPrincipal uPrincipal = UserPrincipal.Current;
            
            if (uPrincipal.IsMemberOf(context, IdentityType.Name, "EDCUser"))
            {
                this.userNameBox.Text = "You did it!";
            }

            else this.userNameBox.Text = "Wamp wamp";

            //this.userNameBox.Text = uPrincipal.UserPrincipalName;

        }
    }
}