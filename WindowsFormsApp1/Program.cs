﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pathfinder.stupidfuckingbullshitevents;
using System.Runtime;
using System.Drawing;
using System.Globalization;
using System.Data;
using System.Data.OleDb;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

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
        public static int countloadfromdataset(string connectionString77)
        { // copied from the internet to count items in a dataset, slightly modified by me ---JS 20231013
                string queryString = "SELECT ccodes FROM iso3166ccodes";
                int countitemsindataset = 0;
                using (OleDbConnection connection = new OleDbConnection(connectionString77))
                { // I have no actual clue how this functions though in full disclosure ---JS 20231013
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        countitemsindataset++;
                    }
                    // always call Close when done reading. also returns count of stuff
                    reader.Close();
                    return countitemsindataset;
                }
        }
        public static string[] loadfromdataset(string connectionString77)
        { // copied from the internet to count items in a dataset, slightly modified by me ---JS 20231013
            string queryString = "SELECT ccodes FROM iso3166ccodes";
            string[] itemsindataset = new string[] { };
            using (OleDbConnection connection = new OleDbConnection(connectionString77))
            { // I have no actual clue how this functions though in full disclosure ---JS 20231013
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    for (global::System.Int32 i = 0; i < reader.FieldCount; i++)
                    {

                        itemsindataset.Append<string>($"\n{reader.GetValue(i)}");
                    }
                }
                // always call Close when done reading. also returns count of stuff
                reader.Close();
                return itemsindataset;
            }
        }
        public static void savingitertake1(string connectionString77, string[] queryString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString77))
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(); ///string[] queryString
                
                //ds.
                //adapter.Update();
            }
        }
        public static void saveitinerary( string itinerary) // function that would save a itinerary 
        { // the var usersavepath needs to be a retargetable function that would easily changable, but not easily unmutatble IYKWIM ---JS 20230828
            string usersavepath = "";
            string usersavepath0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            try // Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            {                
                string specificFolder = Path.Combine("%APPDATA%", "pathfinder");
                Directory.CreateDirectory(specificFolder);
                //usersavepath += specificFolder;
            }
            catch (Exception) // does so much ---JS2023-10-23
            {
            }
            finally
            {
                //mainformbox.
                string dynamicname = System.DateTime.Today.ToString();
                dynamicname=dynamicname.Trim();
                dynamicname=dynamicname.Replace(" ", "");
                dynamicname = dynamicname.Remove(11);
                usersavepath ="%APPDATA%\\pathfinder\\"+ dynamicname+ ".txt";//"\\" +
            }

             // to save to current path, could also do :System.Reflection.Assembly.GetExecutingAssembly().Location;
            if (!File.Exists(usersavepath)) // should be deprecated ---JS 20230904
            {
                try
                {
                    //File.Create(usersavepath);
                    //var filewip = File.OpenWrite(usersavepath);
                    using (StreamWriter writer = File.CreateText(usersavepath))
                    {
                        writer.Write(itinerary);
                        writer.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    //no issues ---JS 20230920
                    Form failuredialog = new Form();
                    Label locationofdestlabel = new Label
                    {
                        Name = "nameofdestlabelondialog",
                        Dock = System.Windows.Forms.DockStyle.Top,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        Location = new System.Drawing.Point(1, 10),
                        TabIndex = 3,
                        TextAlign = System.Drawing.ContentAlignment.TopLeft,
                        Text = ex.ToString(),
                        Size = new Size(20, 40)
                    };
                    failuredialog.Controls.Add(locationofdestlabel);
                    failuredialog.ShowDialog();
                    failuredialog.AutoSize = true;
                    failuredialog.PerformAutoScale();
                    failuredialog.Refresh();
                }
                // Create a file to write to.             
            }/**/
            else
            {
                
            }
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
                    dataloaded += (string)srbinary.ReadToEnd(); 
                }
            }

            return dataloaded;
        }
    }
    public partial class stupidfuckingbullshitevents
    {
       /* public event stupidfuckingbullshitevents SFBSE
        {
            add
            {
                //mainformbox.onclick_submit_datastring(mainformbox.datastring);
            }
            remove
            {
            }
        } //(object sender, stupidfuckingbullshitevents e)
        public delegate void sfbse.SFBSE(object sender, stupidfuckingbullshitevents e);
        public event EventHandler datapasstime;
        public string textboxdata { get; set; }
        public virtual void ondatapasstime(EventArgs e)
        {
            datapasstime?.Invoke(this, e);
        }*/
    }
    public partial class CurrencyConverter
    {
        public string[] GetCurrencyTags()
        {
            string[] currenytags = { "eur", "usd", "jpy", "bgn", "czk", "dkk", "gbp", "huf", "ltl", "lvl", "pln", "ron", "sek", "chf", "nok", "hrk", "rub", "try", "aud", "brl", "cad", "cny", "hkd", "idr", "ils", "inr", "krw", "mxn", "myr", "nzd", "php", "sgd", "zar" };
            return currenytags;
        }
        public static float GetCurrencyRateInUSD(string currency)
        {
            if (currency.ToLower() == "")
                throw new ArgumentException("Invalid Argument! Currency parameter cannot be empty!");
            if (currency.ToLower() == "usd")
                throw new ArgumentException("Invalid Argument! Cannot get exchange rate from USD to USD");
            try
            {
                string rssUrl = string.Concat("https://www.calculator.net/currency-calculator.html" + ".html");
            }
            catch { return 0; }
            return 0;
        }

        public string ToLower()
        {
            throw new NotImplementedException();
        }

        public static float GetExchangeRate(string from, string to, float amount = 1)
        {
            if (from == null || to == null)
                return 0;
            if (from.ToLower() == "usd" && to.ToLower() == "usd")
                return amount;
            try
            {
                float toRate = GetCurrencyRateInUSD(to);
                float fromRate = GetCurrencyRateInUSD(from);
                if (from.ToLower() == "usd")
                {
                    return (amount * toRate);
                }
                else if (to.ToLower() == "usd")
                {
                    return (amount * fromRate);
                }

            }
            catch { return 0; }
            return 0;
        }

        /*private float GetCurrencyRateInUSD(string from)
    {
        throw new NotImplementedException();

    }*/
    }
}
