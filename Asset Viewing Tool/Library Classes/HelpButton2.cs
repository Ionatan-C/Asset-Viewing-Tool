//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Viewing_Tool.Library_Classes
{
    public class HelpButton2: ISimpleButtonFunctions
    {
        public void BtnFunction()
        {
            //just a message to help the user out
            MessageBox.Show("If you wish to add an image into the gallary outside of the ones that are already in there then please inut the image Directory in the dropdown box below the load button, and then click load.");
        }
    }
}
