//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Viewing_Tool.AssetTool_Classes
{
    public class AssetMovement: IAssetViewingToolMove
    {
        public void Function(AssetViewingTool pAssetTool, MouseEventArgs pE, bool pMouseDown, Point pLastLocation)
        {
            //this will make it so the form is moved to the mouses current location as long as the mouse is pressed
            if (pMouseDown)
            {
                pAssetTool.Location = new Point((pAssetTool.Location.X - pLastLocation.X) + pE.X, (pAssetTool.Location.Y - pLastLocation.Y) + pE.Y);

                pAssetTool.Update();
            }
        }
    }
}
