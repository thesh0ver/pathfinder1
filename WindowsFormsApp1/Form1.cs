using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
//using System.Reflection.Emit;

namespace pathfinder
{
    
    public partial class mainformbox : Form
    {
        public static string savelocationstring = "";
        public System.Windows.Forms.TextBox savelocationtextbox = new System.Windows.Forms.TextBox();
        
        public mainformbox()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Form itineraryitemdialog = new Form();
        }
        private void theNuclearOptionDONOTUSETESTONLYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itinerlist.Items.Clear();
        }
        public void testsubmit_Click(object sender, EventArgs e)
        { // passes information from the textbox to save function under testing --- JS 20230828
            string itinerary = textBox1.Text;
            Program.saveitinerary(itinerary);
        }                
        public void onclick(object sender, EventArgs e)
        {
            savelocationstring = savelocationtextbox.Text;
        }
        public void setSaveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form savelocationdialog = new Form();
            savelocationdialog.Text = "Set Save Location";
            // create label for dialog
            Label locationsetlabel = new Label();
            locationsetlabel.Name = "Savelocationlabel";
            locationsetlabel.Dock = System.Windows.Forms.DockStyle.Top;
            locationsetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationsetlabel.Location = new System.Drawing.Point(1, 10);
            locationsetlabel.TabIndex = 3;
            locationsetlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            locationsetlabel.Text = "Save location for data: ";
            locationsetlabel.Size = new Size(20,40);
            // create textbox
            // moved savelocationtextbox generator outside function to validate onclick funtcion
            savelocationtextbox.AcceptsReturn = true;
            savelocationtextbox.AcceptsTab = true;
            savelocationtextbox.Multiline = true;
            savelocationtextbox.Location = new System.Drawing.Point(35, 35);
            savelocationtextbox.Size = new Size(200, 100);
            //savelocationtextbox.Dock = System.Windows.Forms.DockStyle.None;
            savelocationtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //create button
            System.Windows.Forms.Button submitsavelocation = new System.Windows.Forms.Button();
            submitsavelocation.Location = new System.Drawing.Point(10, 10);
            submitsavelocation.Size = new Size(20, 40);
            submitsavelocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            submitsavelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            submitsavelocation.Text = "Submit";
            submitsavelocation.Click += new System.EventHandler(this.onclick);
            //attachment issues ami right hahahahahahha
            savelocationdialog.Controls.Add(locationsetlabel);
            locationsetlabel.BringToFront();
            savelocationdialog.Controls.Add(savelocationtextbox);
            savelocationtextbox.BringToFront();
            savelocationdialog.Controls.Add(submitsavelocation);
            submitsavelocation.BringToFront();
            savelocationdialog.ShowDialog();
        }

        private void testAddItineraryItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itinerlist.Items.Add("Here is Belladonna, the Lady of the Rocks,", 0);
        }

 
    }
}
