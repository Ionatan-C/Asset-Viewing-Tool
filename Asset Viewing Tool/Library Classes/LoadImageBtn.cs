//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Single responsibility 
namespace Asset_Viewing_Tool.Library_Classes
{
    public class LoadImageBtn: ILoadingImage
    {
        int _x = 0;
        public void LoadImage(Library pLibrary, PictureBox pPicBox, ComboBox pDropDownBox, List<string> pImgList)
        {
            

            IImageLoad gallery = new Gallery();

            gallery.CallImages(pImgList);

            while (_x >= pImgList.Count)
            {
                pImgList.Add(pImgList[_x]);
                _x++;
            }

            //this line 327 has been added to make sure that the errors reset each time the button is pressed, to determine if the image is found and should be added to the list
            int _numberOfErrors = 0;
            string answer = pDropDownBox.Text;
            try
            {
                pPicBox.Image = Image.FromFile(answer);

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
                //te number or errors will go up by one
                _numberOfErrors++;


            }
            //if the error is more than 0 than it means the image was not found therefor should not be loaded in the library as an image
            if (_numberOfErrors == 0)
            {
                //this will determine if the image already exists if so than it shall not be added to the library, to avoid duplicates
                if (pImgList.Contains(answer))
                {
 
                }
                else
                {
                    //the image is found and it is not in the library so it is added in the image list and the dropdown box so that user can select it again
                    pImgList.Add(answer);
                    pDropDownBox.Items.Add(answer);
                }
            }
        }
    }
}
