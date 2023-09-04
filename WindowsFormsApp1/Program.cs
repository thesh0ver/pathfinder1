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

        public static void saveitinerary( string itinerary) // function that would save a itinerary 
        { // the var usersavepath needs to be a retargetable function that would easily changable, but not easily unmutatble IYKWIM ---JS 20230828
            string usersavepath = @"C:\Users\james\source\repos\WindowsFormsApp1\WindowsFormsApp1\test.txt";
            if(!File.Exists(usersavepath)) // should be deprecated ---JS 20230904
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(usersavepath))
                {
                    sw.WriteLine(itinerary);
                }
            }/**/
        }
        public static void binarysave(int date, string data) // saves user data in a binary format b/c i dont know how to implement shtuff properly ---JS 20230904
        { // may not work properly when theres already a existing file, but thats a later problem---JS 20230904
            char[] datacast = data.ToCharArray();
            byte[] bytearray = new byte[datacast.Length];
            for (int i = 0; i < datacast.Length; i++)
            {
                bytearray[i] = (byte)datacast[i];
            }

            Stream datastream = new MemoryStream(bytearray);
            string filesavelocation = mainformbox.savelocationstring + date + ".txt"; // should create a filename for 
            if (!File.Exists(filesavelocation))
            {
                using (StreamWriter swbinary  = File.CreateText(filesavelocation)) 
                {
                    foreach (var item in bytearray)
                    {
                        swbinary.WriteLine(datacast);
                    }
                }
            }
        }
        public static string binaryload(string filetoloadlocation, StreamReader bytes) // reading from a file is a bit easier than writing i think ---JS 20230904
        {
            string dataloaded="";
            if (File.Exists(filetoloadlocation))
            {
                using( StreamReader srbinary = bytes)//File.OpenRead(filetoloadlocation)
                { 
                    dataloaded = (string)srbinary.ReadToEnd(); 
                }
            }

            return dataloaded;
        }
    }
    
}
