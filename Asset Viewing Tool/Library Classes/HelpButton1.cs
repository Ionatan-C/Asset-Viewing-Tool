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
    public class HelpButton1: ISimpleButtonFunctions
    {
        public void BtnFunction()
        {
            //just a message to help the user out
            MessageBox.Show("Please use the buttons to the left for the default images as they have been adjusted to the best quality, however if you wish to input your own images into the gallary image library then follow the instructions on the right side.");
        }
    }
}
