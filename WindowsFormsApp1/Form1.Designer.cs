namespace pathfinder
{
    partial class mainformbox
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
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("april is the cruellest month");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("breeding lilacs out of the dead land");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("mixing memory and desire");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("stirring dull roots with spring rain");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.curiterary = new System.Windows.Forms.Label();
            this.iterarycalendar = new System.Windows.Forms.MonthCalendar();
            this.iterlist = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIteraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadIteraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iteraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureItOutYourselfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.curiterary);
            this.groupBox1.Controls.Add(this.iterarycalendar);
            this.groupBox1.Controls.Add(this.iterlist);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 710);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iterary List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // curiterary
            // 
            this.curiterary.AutoSize = true;
            this.curiterary.Location = new System.Drawing.Point(6, 187);
            this.curiterary.Name = "curiterary";
            this.curiterary.Size = new System.Drawing.Size(73, 13);
            this.curiterary.TabIndex = 2;
            this.curiterary.Text = "Current Iterary";
            this.curiterary.Click += new System.EventHandler(this.curiterary_Click);
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
            // iterlist
            // 
            this.iterlist.HideSelection = false;
            this.iterlist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.iterlist.Location = new System.Drawing.Point(6, 203);
            this.iterlist.Name = "iterlist";
            this.iterlist.Size = new System.Drawing.Size(227, 501);
            this.iterlist.TabIndex = 0;
            this.iterlist.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(261, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 710);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
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
            this.saveIteraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveIteraryToolStripMenuItem.Text = "Save Iterary";
            // 
            // loadIteraryToolStripMenuItem
            // 
            this.loadIteraryToolStripMenuItem.Name = "loadIteraryToolStripMenuItem";
            this.loadIteraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadIteraryToolStripMenuItem.Text = "Load Iterary";
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
            this.groupOptionsToolStripMenuItem});
            this.iteraryToolStripMenuItem.Name = "iteraryToolStripMenuItem";
            this.iteraryToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.iteraryToolStripMenuItem.Text = "Iterary";
            // 
            // addTravelToolStripMenuItem
            // 
            this.addTravelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.busToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.addTravelToolStripMenuItem.Name = "addTravelToolStripMenuItem";
            this.addTravelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // addDestinationToolStripMenuItem
            // 
            this.addDestinationToolStripMenuItem.Name = "addDestinationToolStripMenuItem";
            this.addDestinationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDestinationToolStripMenuItem.Text = "Add Destination";
            // 
            // removeTravelToolStripMenuItem
            // 
            this.removeTravelToolStripMenuItem.Name = "removeTravelToolStripMenuItem";
            this.removeTravelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeTravelToolStripMenuItem.Text = "Remove Travel";
            // 
            // removeDestinationToolStripMenuItem
            // 
            this.removeDestinationToolStripMenuItem.Name = "removeDestinationToolStripMenuItem";
            this.removeDestinationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeDestinationToolStripMenuItem.Text = "Remove Destination";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupToolStripMenuItem.Text = "Group Travel";
            // 
            // groupDestinationToolStripMenuItem
            // 
            this.groupDestinationToolStripMenuItem.Name = "groupDestinationToolStripMenuItem";
            this.groupDestinationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupDestinationToolStripMenuItem.Text = "Group Destination";
            // 
            // groupOptionsToolStripMenuItem
            // 
            this.groupOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeGroupToolStripMenuItem,
            this.refreshGroupToolStripMenuItem});
            this.groupOptionsToolStripMenuItem.Name = "groupOptionsToolStripMenuItem";
            this.groupOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.calendarToolStripMenuItem.Text = "Calendar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureItOutYourselfToolStripMenuItem,
            this.exampleToolStripMenuItem});
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
            // exampleToolStripMenuItem
            // 
            this.exampleToolStripMenuItem.Name = "exampleToolStripMenuItem";
            this.exampleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exampleToolStripMenuItem.Text = "example";
            // 
            // mainformbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainformbox";
            this.Text = "Talisha\'s Tentative Travel Planning System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView iterlist;
        private System.Windows.Forms.MonthCalendar iterarycalendar;
        private System.Windows.Forms.Label curiterary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iteraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveIteraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadIteraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureItOutYourselfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exampleToolStripMenuItem;
    }
}

