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
            defpicture.BringToFront();
            destpanel.SendToBack();
            //insert panel here . send to back ()
        }
        public void loadDefaultScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defpicture.BringToFront();
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
            locationsetlabel.Size = new Size(20, 40);
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

        /*public void testAddItineraryItemToolStripMenuItem_Click(object sender, EventArgs e)
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

        }*/
        public void onclick_submit_datastring(string destnamestring, string combostring, string weblinkstring, string coordstring)
        { // for value jfsgnkjdfsnkjj, sets itinerlist's to have that value added to the list ---JS 20230918
            itinerlist.Items.Add(destnamestring, 0);
            nameofdestlabeltarget.Text = destnamestring;
            typeofdestcombobox.SelectedItem = combostring;
            //Select(combostring); //= combostring;// typeofdestcombobox
            weblinklabeltarget.Text = weblinkstring;
            coordlocationofdestlabeltarget.Text = coordstring;
            string savestring = destnamestring + combostring + weblinkstring + coordstring;
            Program.saveitinerary(savestring);
        }
        public void onclick_submit_destination()
        {
            //jnfdjn
        }
        private void addDestinationToolStripMenuItem_Click(object sender, EventArgs e) // add overnight destination ---JS 2023-10-01
        { // itinerlist.Items.Add("",0);
            defpicture.SendToBack();
            destpanel.BringToFront();
            //typeofdestcombobox.Items.Clear();
            typeofdestcombobox.Items.AddRange(travel.overnightdestinationtypes);
            
            //var exactlocation = travel.coord;
            Form addDestDialog = new Form();
            addDestDialog.Text = "Add Destination to your trip";
            
            //desitination name label
            Label destinationnamelabel = new Label
            {
                Name = "Savelocationlabel",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(1, 10),
                TabIndex = 3,
                TextAlign = System.Drawing.ContentAlignment.TopLeft,
                Text = "Enter the name of your destination: ",
                Size = new Size(20, 40)
            };
            // textbox to input basic destination data
            TextBox desttextnametextbox = new TextBox
            {
                Name = "Savelocationlabel",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(10, 10),
                TabIndex = 3,
                TextAlign = (HorizontalAlignment)ContentAlignment.TopLeft,//BADBADBADBABDBDBAD ---JS 20230910 //Update: less bad, just mediocre ---JS 20230918
                Text = "",
                Size = new Size(20, 40)
            };
            //selection of type of destination + relevant label

            Label typesofdestlabel = new Label
            {
                Name = "typesofdestlabel",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(1, 10),
                TabIndex = 3,
                TextAlign = System.Drawing.ContentAlignment.TopLeft,
                Text = "Select the type of destination: ",
                Size = new Size(20, 40)
            };
            System.Windows.Forms.ComboBox typeofdestcomboboxondialog = new System.Windows.Forms.ComboBox
            {
                Name = "typeofdestcomboboxondialog",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(1, 10),
                TabIndex = 3,
                Size = new Size(20, 40)
            };
            for (int k=0; travel.overnightdestinationtypes.Length > k; k++ )
            { // adds items into the combo box ---JS 2023-10-03
                typeofdestcomboboxondialog.Items.Add(travel.overnightdestinationtypes[k] );
            }
            //weblink label and textbox
            Label weblinkintakelabel = new Label
            {
                Name = "nameofdestlabelondialog",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(1, 10),
                TabIndex = 3,
                TextAlign = System.Drawing.ContentAlignment.TopLeft,
                Text = "Enter a relevant web link of your destination: ",
                Size = new Size(20, 40)
            };
            TextBox weblinktextbox = new TextBox
            {
                Name = "nameofdestlabeltargetondialog",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(10, 10),
                TabIndex = 3,
                TextAlign = (HorizontalAlignment)ContentAlignment.TopLeft,
                Text = "",
                Size = new Size(20, 40)
            };
            //for destination coordinates and label: needs to also take in data
            Label locationofdestlabel = new Label
            {
                Name = "nameofdestlabelondialog",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(1, 10),
                TabIndex = 3,
                TextAlign = System.Drawing.ContentAlignment.TopLeft,
                Text = "Enter a the exact location of your destination: ",
                Size = new Size(20, 40)
            };
            TextBox locationofdesttextbox = new TextBox
            {
                Name = "nameofdestlabeltargetondialog",
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(10, 10),
                TabIndex = 3,
                TextAlign = (HorizontalAlignment)ContentAlignment.TopLeft,
                Text = "",
                Size = new Size(20, 40)
            };
            //submit button
            System.Windows.Forms.Button submitsavelocation = new System.Windows.Forms.Button();
            submitsavelocation.Location = new System.Drawing.Point(10, 10);
            submitsavelocation.Size = new Size(20, 40);
            submitsavelocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            submitsavelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            submitsavelocation.Text = "Submit";
            datastring = desttextnametextbox.Text;
            //submitsavelocation.Click += onclick_submit_datastring; //like........... legally? ---JS 20230910
            submitsavelocation.Click += textBox_Leave;
            //do not alter the order of these control adds, may break function  ---JS 20230910
            addDestDialog.Controls.Add(destinationnamelabel);
            addDestDialog.Controls.Add(desttextnametextbox);
            addDestDialog.Controls.Add(typesofdestlabel);
            addDestDialog.Controls.Add(typeofdestcomboboxondialog);
            addDestDialog.Controls.Add(weblinkintakelabel);
            addDestDialog.Controls.Add(weblinktextbox);
            addDestDialog.Controls.Add(locationofdestlabel);
            addDestDialog.Controls.Add(locationofdesttextbox);
            addDestDialog.Controls.Add(submitsavelocation);

            destinationnamelabel.BringToFront();
            desttextnametextbox.BringToFront();
            typesofdestlabel.BringToFront();
            typeofdestcomboboxondialog.BringToFront();
            weblinkintakelabel.BringToFront();
            weblinktextbox.BringToFront();
            locationofdestlabel.BringToFront();
            locationofdesttextbox.BringToFront();
            submitsavelocation.BringToFront();

            addDestDialog.ShowDialog();
            addDestDialog.AutoSize = true;
            addDestDialog.PerformAutoScale();
            addDestDialog.Refresh();
            void textBox_Leave(object sender, EventArgs e)
            {
                if (desttextnametextbox.Text.Length > 0)
                {
                    onclick_submit_datastring(desttextnametextbox.Text, typeofdestcomboboxondialog.Text, weblinktextbox.Text, locationofdesttextbox.Text); // hopefully this bypasses events, also thank that SFBS bing ai for suggesting this ---JS 20230918
                }
            }
        }

    

    }

    }