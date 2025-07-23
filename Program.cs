using System;
using System.Windows.Forms;

namespace ClinicaMedica
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Manager.FRMMenuPrincipal());
        }
    }
}