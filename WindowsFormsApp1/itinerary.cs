<<<<<<< HEAD
using System;
=======
﻿using System;
>>>>>>> 564517ce94d797aeada06523f9a53234519bce97
using System.Collections.Generic;
using System.Windows.Forms;

namespace pathfinder
{
    public class itinerary
	{
        public String listeditems = "";
        public static void additeraryitems(string input, mainformbox mainformbox) // class as of 20230827 should add a test item into the Current Iterary's Item Field ---JS 20230827
        { // iterlist is the ref for the listview box fyi ---JS 20230827
            ListViewItem itineraryitem0;
            itineraryitem0 = mainformbox.itinerlist.Items.Add(input);

        }

        public virtual void testAddItinerListItem()
        { // target itinerlist to add GUI elements
            //.mainformbox mainformbox;

            /*ListViewItem testitemtoadd;
            testitemtoadd = itinerlist.Items.Add("Here is Belladonna, the Lady of the Rocks,", 0);*/
        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 564517ce94d797aeada06523f9a53234519bce97
