using ConroleAcesso.Forms;
using System;
using System.Windows.Forms;

namespace ConroleAcesso
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}

//--*****Projeto replicado do Bootcamp Everis New talents 3 MADS1974 * ****--//
