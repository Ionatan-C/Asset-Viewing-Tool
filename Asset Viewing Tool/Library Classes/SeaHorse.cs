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
    public class SeaHorse : ITypes
    {
        public SeaHorse() 
        {

        }
        
        public void Type(Library pLibrary, PictureBox pPicBox)
        {
            
            try
            {

                pPicBox.Image = Image.FromFile("..\\..\\..\\FishAssets\\Seahorse.png");
                //The seahorse is upside down, so unlike the others we will use the flip Y instead of None
                pPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipY);

                pPicBox.Location = new Point(650, 225);
                pPicBox.Size = new Size(200, 200);

                pLibrary.Controls.Add(pPicBox);

                pPicBox = new PictureBox();

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
