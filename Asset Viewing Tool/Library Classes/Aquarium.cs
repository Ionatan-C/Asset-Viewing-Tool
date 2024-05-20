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
    public class Aquarium: ITypes
    {
        public Aquarium()
        {

        }
        public void Type(Library pLibrary, PictureBox pPicBox)
        {

            // Load and set the image
            try
            {
                pPicBox.Image = Image.FromFile("..\\..\\..\\FishAssets\\AquariumBackground.png");

                pPicBox.Location = new Point(300, 25);
                pPicBox.Size = new Size(800, 600);
                pLibrary.Controls.Add(pPicBox);

                pPicBox.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("The image asset was not found");
                //This will prevent memory dump from stacking up and crashing eventually
                GC.Collect();
            }
        }
    }
}
