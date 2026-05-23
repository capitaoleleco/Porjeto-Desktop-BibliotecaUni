using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUni
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin telaDeLogin = new FormLogin();

            if (telaDeLogin.ShowDialog() == DialogResult.OK)
            {

                Application.Run(new FormInicio());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}