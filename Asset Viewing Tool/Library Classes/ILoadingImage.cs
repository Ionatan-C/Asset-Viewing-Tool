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
    public interface ILoadingImage
    {
        void LoadImage(Library pLibrary, PictureBox pPicBox, ComboBox pDropDownBox, List<string> pImageList);
    }
}
