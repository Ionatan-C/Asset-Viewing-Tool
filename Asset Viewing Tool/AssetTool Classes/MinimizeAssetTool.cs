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
    public class MinimizeAssetTool: IToolMinimize
    {
        public void Function(AssetViewingTool pAssetTool, int pX) 
        {
            if (pX % 2 == 0)
            {
                pAssetTool.Size = new Size(50, 55);
                pX++;
            }
            else
            {
                pAssetTool.Size = new Size(1477, 642);
                pX = 0;
            }
        }
    }
}
