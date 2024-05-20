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
    public class Minimize: IMinimize
    {
        public Minimize() 
        {
           
        }

        public void Function(Library pLibrary, int pX)
        {

            if (pX % 2 == 0)
            {
                pLibrary.Size = new Size(50, 55);
                pX++;
            }
            else
            {
                pLibrary.Size = new Size(1477, 642);
                pX = 0;
            }
        }
    }
}
