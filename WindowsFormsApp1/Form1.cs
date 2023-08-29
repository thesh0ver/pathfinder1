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
        /* the following codes quality is of the same objective quality of loose, syruppy, diarrhea 
         * of a dying persons last bowel movement, but must stay for the time being, in spite of the errors
         *  --- JS 20230826
         */
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
    }
}
