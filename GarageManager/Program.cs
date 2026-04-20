using GarageManager;
using GarageManager.Forms;
using System;
using System.Windows.Forms;
using Ninject;

namespace Data
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var module_principal = new GMModule();
            StandardKernel kernel = new StandardKernel(module_principal);

            Application.Run(new FrmGM(kernel));
        }
    }
}
