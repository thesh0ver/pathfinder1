using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pathfinder
{
    public static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainformbox());
        }

        public static void saveitinerary() // function that would save a itinerary 
        {
            /*string usersavepath = @"C:\Users\james\source\repos\WindowsFormsApp1\WindowsFormsApp1\test.txt";
            if(!File.Exists(usersavepath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(usersavepath))
                {
                    sw.WriteLine("Doubled the flames of sevenbranched candelabra");
                }
            }*/
        }
    }
    
}
