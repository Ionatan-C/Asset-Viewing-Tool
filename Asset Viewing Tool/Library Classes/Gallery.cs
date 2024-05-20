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
    public class Gallery: IImageLoad
    {
        public void CallImages(List<string> pImageList)
        {
            pImageList.Add("..\\..\\..\\FishAssets\\AnglerFish_Lit.png");
            pImageList.Add("..\\..\\..\\FishAssets\\AnglerFish_Unlit.png");
            pImageList.Add("..\\..\\..\\FishAssets\\\\JavaFish.png");
            pImageList.Add("..\\..\\..\\FishAssets\\\\OrangeFish.png");
            pImageList.Add("..\\..\\..\\FishAssets\\\\PiranhaGreen.png");
            pImageList.Add("..\\..\\..\\FishAssets\\PiranhaRed.png");
            pImageList.Add("..\\..\\..\\FishAssets\\Seahorse.png");
            pImageList.Add("..\\..\\..\\FishAssets\\Urchin.png");
            pImageList.Add("..\\..\\..\\FishAssets\\AquariumBackground.png");
        }
    }
}
