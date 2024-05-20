//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Viewing_Tool.Library_Classes
{
    public class DefaultGallery: IGallery
    {
        public DefaultGallery() 
        {

        }
        public void Function(Library pLibrary, ComboBox pDropDownBox)
        {
            List<string> imageList = new List<string>();

            int x = 0;
            int f = 0;

            IImageLoad gallery = new Gallery();

            gallery.CallImages(imageList);

            while (f >= imageList.Count)
            {
                imageList.Add(imageList[f]);
                f++;
            }

            //this will make sure that each of the default images are actually added to the dropdown box
            while (x != imageList.Count)
            {

                pDropDownBox.Items.Add(imageList[x]);

                x++;

            }
        }
    }
}
