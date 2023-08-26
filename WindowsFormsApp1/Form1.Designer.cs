namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iterarycalendar = new System.Windows.Forms.MonthCalendar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTravelPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTravelPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDestinationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iterarycalendar);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 710);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iterary List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // iterarycalendar
            // 
            this.iterarycalendar.Location = new System.Drawing.Point(6, 16);
            this.iterarycalendar.MaxDate = new System.DateTime(3999, 12, 31, 0, 0, 0, 0);
            this.iterarycalendar.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.iterarycalendar.Name = "iterarycalendar";
            this.iterarycalendar.TabIndex = 1;
            this.iterarycalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 514);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.menuItem0ToolStripMenuItem,
            this.test0ToolStripMenuItem,
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.test3ToolStripMenuItem,
            this.test4ToolStripMenuItem,
            this.test5ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem0ToolStripMenuItem
            // 
            this.menuItem0ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTravelPlansToolStripMenuItem,
            this.loadTravelPlansToolStripMenuItem});
            this.menuItem0ToolStripMenuItem.Name = "menuItem0ToolStripMenuItem";
            this.menuItem0ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.menuItem0ToolStripMenuItem.Text = "Options";
            // 
            // saveTravelPlansToolStripMenuItem
            // 
            this.saveTravelPlansToolStripMenuItem.Name = "saveTravelPlansToolStripMenuItem";
            this.saveTravelPlansToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveTravelPlansToolStripMenuItem.Text = "Save Travel Plans";
            // 
            // loadTravelPlansToolStripMenuItem
            // 
            this.loadTravelPlansToolStripMenuItem.Name = "loadTravelPlansToolStripMenuItem";
            this.loadTravelPlansToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadTravelPlansToolStripMenuItem.Text = "Load Travel Plans";
            // 
            // test0ToolStripMenuItem
            // 
            this.test0ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTravelToolStripMenuItem,
            this.addDestinationToolStripMenuItem,
            this.removeTravelToolStripMenuItem,
            this.removeDestinationToolStripMenuItem,
            this.groupItemsToolStripMenuItem});
            this.test0ToolStripMenuItem.Name = "test0ToolStripMenuItem";
            this.test0ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.test0ToolStripMenuItem.Text = "Iterary";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test2ToolStripMenuItem.Text = "Test 2";
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test3ToolStripMenuItem.Text = "Test 3";
            // 
            // test4ToolStripMenuItem
            // 
            this.test4ToolStripMenuItem.Name = "test4ToolStripMenuItem";
            this.test4ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test4ToolStripMenuItem.Text = "Test 4";
            // 
            // test5ToolStripMenuItem
            // 
            this.test5ToolStripMenuItem.Name = "test5ToolStripMenuItem";
            this.test5ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test5ToolStripMenuItem.Text = "Test 5";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // addTravelToolStripMenuItem
            // 
            this.addTravelToolStripMenuItem.Name = "addTravelToolStripMenuItem";
            this.addTravelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTravelToolStripMenuItem.Text = "Add Travel";
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
            // groupItemsToolStripMenuItem
            // 
            this.groupItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupTravelToolStripMenuItem,
            this.groupDestinationsToolStripMenuItem});
            this.groupItemsToolStripMenuItem.Name = "groupItemsToolStripMenuItem";
            this.groupItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupItemsToolStripMenuItem.Text = "Group Items";
            // 
            // groupTravelToolStripMenuItem
            // 
            this.groupTravelToolStripMenuItem.Name = "groupTravelToolStripMenuItem";
            this.groupTravelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupTravelToolStripMenuItem.Text = "Group Travel";
            // 
            // groupDestinationsToolStripMenuItem
            // 
            this.groupDestinationsToolStripMenuItem.Name = "groupDestinationsToolStripMenuItem";
            this.groupDestinationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupDestinationsToolStripMenuItem.Text = "Group Destinations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTravelPlansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTravelPlansToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MonthCalendar iterarycalendar;
        private System.Windows.Forms.ToolStripMenuItem test0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupDestinationsToolStripMenuItem;
    }
}

