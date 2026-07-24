using System;
using System.Windows.Forms;

namespace PharmacyDrugStoreManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}