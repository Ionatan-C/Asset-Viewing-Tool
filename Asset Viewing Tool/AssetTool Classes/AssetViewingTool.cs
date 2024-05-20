//@
//Author: Ionatan Cegodari
//@

using Asset_Viewing_Tool.AssetTool_Classes;
using Asset_Viewing_Tool.Library_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asset_Viewing_Tool

{
    public partial class AssetViewingTool : Form, IDisposable
    {
        //this refrences the library form
        Form _Library;
        //picture box to load images in and reshape to my own liking
        private PictureBox _PictureBox;
        //simple bool to state when the mouse is pressed
        private bool _MouseDown = false;
        //private point to store the last known location of the mouse
        private Point _LastLocation;
        //number to use for while loops and check if form is minimized
        int x = 0;

        public AssetViewingTool()
        {

            InitializeComponent();
            _PictureBox = new PictureBox();

            ILoadImage func = new LoadImage();
            func.Function(_PictureBox, this);

            


        }

        private void MainCloseBtn_Click(object sender, EventArgs e)
        {
            //this will close the library using Dispose so that we can use the IDisposable to check if its disposed or not and if the user should be able to open the form
            this.Dispose();
        }

        private void LibraryBtn_Click(object sender, EventArgs e)
        {
            //this checks if the library form is disposed and  if it is then it can be opened if not than user cannot open another till its closed
            if ((_Library == null) || (_Library.IsDisposed))
            {

                _Library = new Library();
                _Library.Show();
            }
        }

        private void AssetViewingTool_MouseMove(object sender, MouseEventArgs e)
        {
            //if button is clicked then the form size will be changed affectively minimizing it and if clicked again then it will maximize again
            IAssetViewingToolMove features = new AssetMovement();
            features.Function(this, e, _MouseDown, _LastLocation);
        }

        private void AssetViewingTool_MouseUp(object sender, MouseEventArgs e)
        {
            //this says that the mouse is not being pressed, to prevent from the form constatly moving where the mouse is
            _MouseDown = false;
        }

        private void AssetViewingTool_MouseDown(object sender, MouseEventArgs e)
        {
            //this is stating that the mouse is pressed and the last location of the mouse is equal to the current location
            _MouseDown = true;
            _LastLocation = e.Location;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            //if button is clicked then the form size will be changed affectively minimizing it and if clicked again then it will maximize again
            IToolMinimize features = new MinimizeAssetTool();
            features.Function(this, x++);
        }


    }
}
