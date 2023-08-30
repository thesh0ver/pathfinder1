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

namespace pathfinder
{
    public partial class mainformbox : Form
    {
        public mainformbox()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void loaddatafordate()
        {

        }
        public void curiterary_Click(object sender, EventArgs e)
        {
            
        }

        private void iterlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void theNuclearOptionDONOTUSETESTONLYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iterlist.Items.Clear();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void testsubmit_Click(object sender, EventArgs e)
        { // passes information from the textbox to save function under testing --- JS 20230828
            string itinerary = textBox1.Text;
            Program.saveitinerary(itinerary);
        }

        private void shouldOpenConsoleButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { /* functions function opens a console on button press
           * !& Bug Notice: When the console is closed, the form also closes, 
           * must be changed so console can be closed without losing the
           * main applications concurrency, IE: so the console can be
           * closed with out closing the main application or anything else
           * https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
           * ---JS 20230830
           */

            AllocConsole();
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();
        }
    }
}
