using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MedicalScheduler.Data;

namespace MedicalScheduler
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
            
            // Initialize database
            using (var context = new ClinicContext())
            {
                context.Database.EnsureCreated();
            }
            
            Application.Run(new MainForm());
        }
    }
}
