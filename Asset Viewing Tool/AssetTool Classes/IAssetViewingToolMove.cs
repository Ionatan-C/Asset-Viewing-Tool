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
    public interface IAssetViewingToolMove
    {
        void Function(AssetViewingTool pAssetTool, MouseEventArgs pE, bool pMouseDown, Point pLastLocation);

    }
}
