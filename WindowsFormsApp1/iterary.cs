using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pathfinder
{
    public class iterary
	{
        public static void additeraryitems(string input, mainformbox mainformbox) // class as of 20230827 should add a test item into the Current Iterary's Item Field ---JS 20230827
        { // iterlist is the ref for the listview box fyi ---JS 20230827
            ListViewItem itineraryitem0;
            itineraryitem0 = mainformbox.iterlist.Items.Add(input);

        }
	}
}