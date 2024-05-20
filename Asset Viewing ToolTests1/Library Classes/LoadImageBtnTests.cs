//@
//Author: Ionatan Cegodari
//@

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asset_Viewing_Tool.Library_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Asset_Viewing_Tool.Library_Classes.Tests
{
    [TestClass()]
    public class LoadImageBtnTests
    {
        //simply used to see if the test is passing or failing
        bool results = false;
        bool expectedResult = true;
        //this is here to act as a user input with a mistake in it and see if it will catch the error
        string userInput = "..\\..\\..\\FishAssets\\AnglerFish_Lit.pn";

        [TestMethod()]
        public void TestImageDetection()
        {
            List<string> imgList = new List<string>();

            int x = 0;
            //this uses an actual class from the software to get up the image list that it stores
            IImageLoad gallery = new Gallery();
            //this calls the mathod within the class that is inherited by the interface
            gallery.CallImages(imgList);
            //this makes it so that it goes through each item and adds the item to the list
            while (x >= imgList.Count)
            {
                imgList.Add(imgList[x]);
                x++;
            }
            //this makes it so that if the user input is invalid it wont save it in the img list and it wont add the same image twice, at least thats what this piece of code will be modified to be used as in the main code
            if (imgList.Contains(userInput))
            {
                results = false;
            }
            else
            {
                results = true;
            }
            // thsi simply tests if the results are true and if so then they pass the test
            Assert.IsTrue(results);
        }

        [TestMethod()]
        public void TestLoadImage()
        {
            List<string> imgList = new List<string>();

            int x = 0;
            //this uses an actual class from the software to get up the image list that it stores
            IImageLoad gallery = new Gallery();
            //this calls the mathod within the class that is inherited by the interface
            gallery.CallImages(imgList);
            //this makes it so that it goes through each item and adds the item to the list
            while (x >= imgList.Count)
            {
                imgList.Add(imgList[x]);
                x++;
            }
            //this checks that all the images are loaded in the image list by seeing if the count equals to 9, as there should be 9 images in the list if any more or less that means something is wrong
            if (imgList.Count == 9)
            {
                results = true;
            }
            else
            {
                //this simply puts out a message box with the amount of items in the list telling us if there are too many or too little items
                int counts = imgList.Count;
                string mainCount = Convert.ToString(counts);
                MessageBox.Show(mainCount);

                results = false;
            }
            // thsi simply tests if the results are equl to the expected results if so they pass the test
            Assert.AreEqual(expectedResult, results);
            
        }
    }
}