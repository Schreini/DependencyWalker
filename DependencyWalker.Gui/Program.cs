using System;
using System.Windows.Forms;

namespace DependencyWalker.Gui
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            var depResolver = new Services.DependencyResolver();
            var mfController = new Controller.MainFormController(mainForm, depResolver);
            Application.Run(mainForm);
        }
    }
}
