namespace pathfinder
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
            this.curiterary = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.curiterary);
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
            this.listView1.Location = new System.Drawing.Point(6, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 501);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Talisha\'s Tentative Travel Planning System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MonthCalendar iterarycalendar;
        private System.Windows.Forms.Label curiterary;
    }
}

