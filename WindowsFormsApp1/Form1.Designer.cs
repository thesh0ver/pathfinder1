namespace pathfinder
{
    public partial class mainformbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainformbox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.curiterary = new System.Windows.Forms.Label();
            this.iterarycalendar = new System.Windows.Forms.MonthCalendar();
            this.itinerlist = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSaveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIteraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadIteraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iteraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testAddItineraryItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureItOutYourselfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testlabel = new System.Windows.Forms.Label();
            this.testsubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Destlabelpanel = new System.Windows.Forms.Label();
            this.nameofdestlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.typeofdestinationlabel = new System.Windows.Forms.Label();
            this.weblinklabeltarget = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weblinklabel = new System.Windows.Forms.Label();
            this.coordlocationofdestlabel = new System.Windows.Forms.Label();
            this.coordlocationofdestlabeltarget = new System.Windows.Forms.Label();
            this.destimage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destimage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.curiterary);
            this.groupBox1.Controls.Add(this.iterarycalendar);
            this.groupBox1.Controls.Add(this.itinerlist);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 710);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iterary List";
            // 
            // curiterary
            // 
            this.curiterary.AutoSize = true;
            this.curiterary.Location = new System.Drawing.Point(6, 187);
            this.curiterary.Name = "curiterary";
            this.curiterary.Size = new System.Drawing.Size(81, 13);
            this.curiterary.TabIndex = 2;
            this.curiterary.Text = "Current Itinerary";
            // 
            // iterarycalendar
            // 
            this.iterarycalendar.Location = new System.Drawing.Point(6, 25);
            this.iterarycalendar.MaxDate = new System.DateTime(3999, 12, 31, 0, 0, 0, 0);
            this.iterarycalendar.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.iterarycalendar.Name = "iterarycalendar";
            this.iterarycalendar.TabIndex = 1;
            this.iterarycalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // itinerlist
            // 
            this.itinerlist.AllowColumnReorder = true;
            this.itinerlist.HideSelection = false;
            this.itinerlist.Location = new System.Drawing.Point(6, 203);
            this.itinerlist.Name = "itinerlist";
            this.itinerlist.Size = new System.Drawing.Size(227, 501);
            this.itinerlist.TabIndex = 0;
            this.itinerlist.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(261, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 710);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.iteraryToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSaveLocationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setSaveLocationToolStripMenuItem
            // 
            this.setSaveLocationToolStripMenuItem.Name = "setSaveLocationToolStripMenuItem";
            this.setSaveLocationToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.setSaveLocationToolStripMenuItem.Text = "Set Save Location";
            this.setSaveLocationToolStripMenuItem.Click += new System.EventHandler(this.setSaveLocationToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveIteraryToolStripMenuItem,
            this.loadIteraryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveIteraryToolStripMenuItem
            // 
            this.saveIteraryToolStripMenuItem.Name = "saveIteraryToolStripMenuItem";
            this.saveIteraryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveIteraryToolStripMenuItem.Text = "Save Itinerary";
            // 
            // loadIteraryToolStripMenuItem
            // 
            this.loadIteraryToolStripMenuItem.Name = "loadIteraryToolStripMenuItem";
            this.loadIteraryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadIteraryToolStripMenuItem.Text = "Load Itinerary";
            // 
            // iteraryToolStripMenuItem
            // 
            this.iteraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTravelToolStripMenuItem,
            this.addDestinationToolStripMenuItem,
            this.removeTravelToolStripMenuItem,
            this.removeDestinationToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.groupDestinationToolStripMenuItem,
            this.groupOptionsToolStripMenuItem,
            this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem,
            this.testAddItineraryItemToolStripMenuItem});
            this.iteraryToolStripMenuItem.Name = "iteraryToolStripMenuItem";
            this.iteraryToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.iteraryToolStripMenuItem.Text = "Itinerary";
            // 
            // addTravelToolStripMenuItem
            // 
            this.addTravelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.busToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.testToolStripMenuItem});
            this.addTravelToolStripMenuItem.Name = "addTravelToolStripMenuItem";
            this.addTravelToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.addTravelToolStripMenuItem.Text = "Add Travel";
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.flightToolStripMenuItem.Text = "Flight";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.trainToolStripMenuItem.Text = "Train";
            // 
            // busToolStripMenuItem
            // 
            this.busToolStripMenuItem.Name = "busToolStripMenuItem";
            this.busToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.busToolStripMenuItem.Text = "Bus";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // addDestinationToolStripMenuItem
            // 
            this.addDestinationToolStripMenuItem.Name = "addDestinationToolStripMenuItem";
            this.addDestinationToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.addDestinationToolStripMenuItem.Text = "Add Destination";
            this.addDestinationToolStripMenuItem.Click += new System.EventHandler(this.addDestinationToolStripMenuItem_Click);
            // 
            // removeTravelToolStripMenuItem
            // 
            this.removeTravelToolStripMenuItem.Name = "removeTravelToolStripMenuItem";
            this.removeTravelToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.removeTravelToolStripMenuItem.Text = "Remove Travel";
            // 
            // removeDestinationToolStripMenuItem
            // 
            this.removeDestinationToolStripMenuItem.Name = "removeDestinationToolStripMenuItem";
            this.removeDestinationToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.removeDestinationToolStripMenuItem.Text = "Remove Destination";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.groupToolStripMenuItem.Text = "Group Travel";
            // 
            // groupDestinationToolStripMenuItem
            // 
            this.groupDestinationToolStripMenuItem.Name = "groupDestinationToolStripMenuItem";
            this.groupDestinationToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.groupDestinationToolStripMenuItem.Text = "Group Destination";
            // 
            // groupOptionsToolStripMenuItem
            // 
            this.groupOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeGroupToolStripMenuItem,
            this.refreshGroupToolStripMenuItem});
            this.groupOptionsToolStripMenuItem.Name = "groupOptionsToolStripMenuItem";
            this.groupOptionsToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.groupOptionsToolStripMenuItem.Text = "Group Options";
            // 
            // removeGroupToolStripMenuItem
            // 
            this.removeGroupToolStripMenuItem.Name = "removeGroupToolStripMenuItem";
            this.removeGroupToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removeGroupToolStripMenuItem.Text = "Remove Group";
            // 
            // refreshGroupToolStripMenuItem
            // 
            this.refreshGroupToolStripMenuItem.Name = "refreshGroupToolStripMenuItem";
            this.refreshGroupToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refreshGroupToolStripMenuItem.Text = "Refresh Group";
            // 
            // theNuclearOptionDONOTUSETESTONLYToolStripMenuItem
            // 
            this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem.Name = "theNuclearOptionDONOTUSETESTONLYToolStripMenuItem";
            this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem.Text = "The Nuclear Option DO NOT USE TEST ONLY";
            this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem.Click += new System.EventHandler(this.theNuclearOptionDONOTUSETESTONLYToolStripMenuItem_Click);
            // 
            // testAddItineraryItemToolStripMenuItem
            // 
            this.testAddItineraryItemToolStripMenuItem.Name = "testAddItineraryItemToolStripMenuItem";
            this.testAddItineraryItemToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.testAddItineraryItemToolStripMenuItem.Text = "Test - Add Itinerary Item";
            this.testAddItineraryItemToolStripMenuItem.Click += new System.EventHandler(this.testAddItineraryItemToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.calendarToolStripMenuItem.Text = "Calendar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureItOutYourselfToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // figureItOutYourselfToolStripMenuItem
            // 
            this.figureItOutYourselfToolStripMenuItem.Name = "figureItOutYourselfToolStripMenuItem";
            this.figureItOutYourselfToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.figureItOutYourselfToolStripMenuItem.Text = "Figure It out yourself";
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.BackColor = System.Drawing.SystemColors.Control;
            this.testlabel.Location = new System.Drawing.Point(805, 52);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(46, 13);
            this.testlabel.TabIndex = 3;
            this.testlabel.Text = "testlabel";
            // 
            // testsubmit
            // 
            this.testsubmit.Location = new System.Drawing.Point(923, 126);
            this.testsubmit.Name = "testsubmit";
            this.testsubmit.Size = new System.Drawing.Size(75, 23);
            this.testsubmit.TabIndex = 4;
            this.testsubmit.Text = "submit";
            this.testsubmit.UseVisualStyleBackColor = true;
            this.testsubmit.Click += new System.EventHandler(this.testsubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(808, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Destlabelpanel
            // 
            this.Destlabelpanel.AutoSize = true;
            this.Destlabelpanel.Location = new System.Drawing.Point(-3, 0);
            this.Destlabelpanel.Name = "Destlabelpanel";
            this.Destlabelpanel.Size = new System.Drawing.Size(60, 13);
            this.Destlabelpanel.TabIndex = 0;
            this.Destlabelpanel.Text = "Destination";
            // 
            // nameofdestlabel
            // 
            this.nameofdestlabel.AutoSize = true;
            this.nameofdestlabel.Location = new System.Drawing.Point(19, 38);
            this.nameofdestlabel.Name = "nameofdestlabel";
            this.nameofdestlabel.Size = new System.Drawing.Size(109, 13);
            this.nameofdestlabel.TabIndex = 1;
            this.nameofdestlabel.Text = "Name of Destination: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "A rat crept softly through the vegetation";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(130, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // typeofdestinationlabel
            // 
            this.typeofdestinationlabel.AutoSize = true;
            this.typeofdestinationlabel.Location = new System.Drawing.Point(19, 90);
            this.typeofdestinationlabel.Name = "typeofdestinationlabel";
            this.typeofdestinationlabel.Size = new System.Drawing.Size(105, 13);
            this.typeofdestinationlabel.TabIndex = 4;
            this.typeofdestinationlabel.Text = "Type of Destination: ";
            // 
            // weblinklabeltarget
            // 
            this.weblinklabeltarget.AutoSize = true;
            this.weblinklabeltarget.Location = new System.Drawing.Point(105, 230);
            this.weblinklabeltarget.Name = "weblinklabeltarget";
            this.weblinklabeltarget.Size = new System.Drawing.Size(303, 13);
            this.weblinklabeltarget.TabIndex = 5;
            this.weblinklabeltarget.TabStop = true;
            this.weblinklabeltarget.Text = "SHADOWMONEYWIZARDGANGWELOVECASTINGSPELLS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.destimage);
            this.panel1.Controls.Add(this.coordlocationofdestlabeltarget);
            this.panel1.Controls.Add(this.coordlocationofdestlabel);
            this.panel1.Controls.Add(this.weblinklabel);
            this.panel1.Controls.Add(this.weblinklabeltarget);
            this.panel1.Controls.Add(this.Destlabelpanel);
            this.panel1.Controls.Add(this.typeofdestinationlabel);
            this.panel1.Controls.Add(this.nameofdestlabel);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 441);
            this.panel1.TabIndex = 6;
            // 
            // weblinklabel
            // 
            this.weblinklabel.AutoSize = true;
            this.weblinklabel.Location = new System.Drawing.Point(19, 230);
            this.weblinklabel.Name = "weblinklabel";
            this.weblinklabel.Size = new System.Drawing.Size(76, 13);
            this.weblinklabel.TabIndex = 2;
            this.weblinklabel.Text = "Relevant Link:";
            // 
            // coordlocationofdestlabel
            // 
            this.coordlocationofdestlabel.AutoSize = true;
            this.coordlocationofdestlabel.Location = new System.Drawing.Point(22, 325);
            this.coordlocationofdestlabel.Name = "coordlocationofdestlabel";
            this.coordlocationofdestlabel.Size = new System.Drawing.Size(84, 13);
            this.coordlocationofdestlabel.TabIndex = 6;
            this.coordlocationofdestlabel.Text = "Exact Location: ";
            // 
            // coordlocationofdestlabeltarget
            // 
            this.coordlocationofdestlabeltarget.AutoSize = true;
            this.coordlocationofdestlabeltarget.Location = new System.Drawing.Point(105, 325);
            this.coordlocationofdestlabeltarget.Name = "coordlocationofdestlabeltarget";
            this.coordlocationofdestlabeltarget.Size = new System.Drawing.Size(172, 13);
            this.coordlocationofdestlabeltarget.TabIndex = 7;
            this.coordlocationofdestlabeltarget.Text = "Dragging its slimy belly on the bank";
            // 
            // destimage
            // 
            this.destimage.Image = ((System.Drawing.Image)(resources.GetObject("destimage.Image")));
            this.destimage.Location = new System.Drawing.Point(310, 16);
            this.destimage.Name = "destimage";
            this.destimage.Size = new System.Drawing.Size(436, 313);
            this.destimage.TabIndex = 8;
            this.destimage.TabStop = false;
            // 
            // mainformbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.testsubmit);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainformbox";
            this.Text = "Talisha\'s Tentative Travel Planning System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Set any public items here from private => public ---JS 20230828
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView itinerlist;
        public System.Windows.Forms.MonthCalendar iterarycalendar;
        public System.Windows.Forms.Label curiterary;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem iteraryToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveIteraryToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loadIteraryToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addTravelToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addDestinationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeTravelToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeDestinationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem groupDestinationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem groupOptionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeGroupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem refreshGroupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem figureItOutYourselfToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem theNuclearOptionDONOTUSETESTONLYToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        public System.Windows.Forms.Label testlabel;
        public System.Windows.Forms.Button testsubmit;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ToolStripMenuItem setSaveLocationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem testAddItineraryItemToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Destlabelpanel;
        private System.Windows.Forms.Label nameofdestlabel;
        private System.Windows.Forms.LinkLabel weblinklabeltarget;
        private System.Windows.Forms.Label typeofdestinationlabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weblinklabel;
        private System.Windows.Forms.Label coordlocationofdestlabeltarget;
        private System.Windows.Forms.Label coordlocationofdestlabel;
        private System.Windows.Forms.PictureBox destimage;
    }
}

