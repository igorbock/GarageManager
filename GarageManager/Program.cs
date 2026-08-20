using System;
using System.Windows.Forms;
using GarageManager.Data;
using GarageManager.Forms;

namespace GarageManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AppDomain.CurrentDomain.SetData("DataDirectory", AppContext.BaseDirectory);

            GarageDb.EnsureCreated();

            Application.Run(new Home());
        }
    }
}