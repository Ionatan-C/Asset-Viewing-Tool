//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Viewing_Tool.Library_Classes
{
    public class FormMovement: IFormFeatures
    {
        public void Function(Library pLibrary, MouseEventArgs pE,bool pMouseDown, Point pLastLocation)
        {
            //this will make it so the form is moved to the mouses current location as long as the mouse is pressed
            if (pMouseDown)
            {
                pLibrary.Location = new Point((pLibrary.Location.X - pLastLocation.X) + pE.X, (pLibrary.Location.Y - pLastLocation.Y) + pE.Y);

                pLibrary.Update();
            }
        }
    }
}
