//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Viewing_Tool.AssetTool_Classes
{
    public class LoadImage: ILoadImage
    {
        public void Function(PictureBox pPictureBox, AssetViewingTool pAssetTool)
        {
            try
            {
                // Load and set the image
                pPictureBox.Image = Image.FromFile("..\\..\\..\\Other Images\\FolderIMG.png"); // Replace with your image path#

                pPictureBox.Location = new Point(295, 100);

                pPictureBox.Size = new Size(200, 200);
                pPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                // Initially, the picture is hidden
                pPictureBox.Visible = true;

                // Add the PictureBox to the form's Controls
                pAssetTool.Controls.Add(pPictureBox);
            }
            catch (Exception x)
            {

            }
        }
    }
}
