using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace EDC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PrincipalContext context = new PrincipalContext(ContextType.Domain, "TCSDomain.local");
            UserPrincipal uPrincipal = UserPrincipal.Current;

            if (uPrincipal.IsMemberOf(context, IdentityType.Name, "EDCUser"))
            {
                Application.Run(new FormMenu());
            }

            else MessageBox.Show("Please log in to the PC as a valid EDC user", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
