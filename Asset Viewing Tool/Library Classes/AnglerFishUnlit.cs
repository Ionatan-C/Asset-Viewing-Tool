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
    public class AnglerFishUnlit : ITypes
    {

        public AnglerFishUnlit()
        {

        }
        public void Type(Library pLibrary, PictureBox pPicBox)
        {

            try
            {
                pPicBox.Image = Image.FromFile("..\\..\\..\\FishAssets\\AnglerFish_Unlit.png"); // Replace with your image path
                //this line below will turn the images by 90 degrees clockwise
                pPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                pPicBox.Location = new Point(650, 225);
                pPicBox.Size = new Size(200, 200);

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
