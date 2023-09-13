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
using TextBox = System.Windows.Forms.TextBox;
///using System.Reflection.Emit;

namespace pathfinder
{
    public partial class mainformbox : Form
    {
        public static string savelocationstring = "";
        public static string datastring = "";
        public System.Windows.Forms.TextBox savelocationtextbox = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textboxforItinitem = new System.Windows.Forms.TextBox();
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
        public void onclickaddItinITEM(object sender, EventArgs e)
        {
            itinerlist.Items.Add(textboxforItinitem.Text, 0);
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

        public void testAddItineraryItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //itinerlist.Items.Add("Here is Belladonna, the Lady of the Rocks,", 0);
            Form itineraryAddDialog = new Form();
            itineraryAddDialog.Text = "Add Itinerary item";
            //label for IAD
            Label inputlabel = new Label();
            inputlabel.Name = "inputlabel0";
            inputlabel.Dock = System.Windows.Forms.DockStyle.Top;
            inputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inputlabel.Location = new System.Drawing.Point(1, 1);
            inputlabel.TabIndex = 3;
            inputlabel.TextAlign = ContentAlignment.TopCenter;
            inputlabel.Size = new System.Drawing.Size(20, 60);
            inputlabel.Text = "pearance of Cargo 200 is unknown, except that it came into use in the mid-1980s duri";
            //textbox thingy
            System.Windows.Forms.TextBox textboxforItinitem = new System.Windows.Forms.TextBox();
            textboxforItinitem.AcceptsReturn = true;
            textboxforItinitem.AcceptsTab = true;
            textboxforItinitem.Multiline = true;
            textboxforItinitem.Location = new System.Drawing.Point(35, 35);
            textboxforItinitem.Size = new Size(200, 100);
            textboxforItinitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // submit button
            System.Windows.Forms.Button submititinitembutton = new System.Windows.Forms.Button();
            submititinitembutton.Location = new System.Drawing.Point(10, 10);
            submititinitembutton.Size = new Size(20, 40);
            submititinitembutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            submititinitembutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            submititinitembutton.Text = "Submit";
            submititinitembutton.Click += new System.EventHandler(this.onclickaddItinITEM);

            itineraryAddDialog.Controls.Add(inputlabel);
            itineraryAddDialog.Controls.Add(textboxforItinitem);
            itineraryAddDialog.Controls.Add(submititinitembutton);
            inputlabel.BringToFront();
            textboxforItinitem.BringToFront();
            submititinitembutton.BringToFront();
            itineraryAddDialog.ShowDialog();

        }
        public void onclick_submit_datastring(object sender, EventArgs e)
        {
            itinerlist.Items.Add(datastring, 0);
            Program.saveitinerary(datastring);
        }
        private void addDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        { // itinerlist.Items.Add("",0);
            Form addDestDialog = new Form();
            addDestDialog.Text = "Add Destination to your trip";
            //desitination name label
            Label destinationnamelabel = new Label();
            destinationnamelabel.Name = "Savelocationlabel";
            destinationnamelabel.Dock = System.Windows.Forms.DockStyle.Top;
            destinationnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            destinationnamelabel.Location = new System.Drawing.Point(1, 10);
            destinationnamelabel.TabIndex = 3;
            destinationnamelabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            destinationnamelabel.Text = "Enter the name of your destination: ";
            destinationnamelabel.Size = new Size(20, 40);
            // textbox to input basic destination data
            TextBox desttextnametextbox = new TextBox();
            desttextnametextbox.Name = "Savelocationlabel";
            desttextnametextbox.Dock = System.Windows.Forms.DockStyle.Top;
            desttextnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desttextnametextbox.Location = new System.Drawing.Point(10, 10);
            desttextnametextbox.TabIndex = 3;
            desttextnametextbox.TextAlign = (HorizontalAlignment)ContentAlignment.TopLeft;//BADBADBADBABDBDBAD ---JS 20230910
            desttextnametextbox.Text = "";
            desttextnametextbox.Size = new Size(20, 40);
            //submit button
            System.Windows.Forms.Button submitsavelocation = new System.Windows.Forms.Button();
            submitsavelocation.Location = new System.Drawing.Point(10, 10);
            submitsavelocation.Size = new Size(20, 40);
            submitsavelocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            submitsavelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            submitsavelocation.Text = "Submit";
            datastring = desttextnametextbox.Text;
            submitsavelocation.Click += onclick_submit_datastring; //like........... legally? ---JS 20230910

            
            //do not alter the order of these control adds, make break function  ---JS 20230910
            addDestDialog.Controls.Add(desttextnametextbox);
            addDestDialog.Controls.Add(destinationnamelabel);
            addDestDialog.Controls.Add(submitsavelocation);

            desttextnametextbox.BringToFront();
            destinationnamelabel.BringToFront();
            submitsavelocation.BringToFront();

            addDestDialog.ShowDialog();
        }
    }
}
