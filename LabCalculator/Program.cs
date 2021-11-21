using System;
using System.Windows.Forms;

namespace LabCalculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Debug.WriteLine("Result: " + Calculator.Evaluate("9+1").ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
