//@
//Author: Ionatan Cegodari
//@

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Viewing_Tool.Library_Classes
{
    public partial class Library : Form, IDisposable
    {
        //picture box to load images in and reshape to my own liking
        private PictureBox _pictureBox;
        //simple bool to state when the mouse is pressed
        private bool _mouseDown = false;
        //private point to store the last known location of the mouse
        private Point _lastLocation;
        //number to use for while loops and check if form is minimized
        int _x = 0;
        //number to store if there was an error or not
        int _numberOfErrors = 0;
        //list to store images
        List<string> _imageList = new List<string>();

        public Library()
        {
            InitializeComponent();

            _pictureBox = new PictureBox();

            _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            ImageGalleryLoad();
        }
        //this method is just adding the default images to the image list
        public void ImageGalleryLoad()
        {
            IGallery feature = new DefaultGallery();
            feature.Function(this, DropDownBox);
        }

        private void LibraryCloseBtn_Click(object sender, EventArgs e)
        {
            //this will close the library using Dispose so that we can use the IDisposable to check if its disposed or not and if the user should be able to open the form
            this.Dispose();
        }

        private void AquariumBackground_Click(object sender, EventArgs e)
        {

            ITypes type = new Aquarium();
            type.Type(this, _pictureBox);

        }

        private void AnglerFishLit_Click(object sender, EventArgs e)
        {

            // Load and set the image
            ITypes type = new AnglerFishLit();
            type.Type(this, _pictureBox);

        }

        private void AnglerFishUnlit_Click(object sender, EventArgs e)
        {
            // Load and set the image
            ITypes type = new AnglerFishUnlit();
            type.Type(this, _pictureBox);

        }

        private void JavaFish_Click(object sender, EventArgs e)
        {
            // Load and set the image
            ITypes type = new JavaFish();
            type.Type(this, _pictureBox);
        }

        private void OrangeFish_Click(object sender, EventArgs e)
        {
            // Load and set the image
            ITypes type = new OrangeFish();
            type.Type(this, _pictureBox);

        }

        private void PiranhaGreen_Click(object sender, EventArgs e)
        {
            // Load and set the image
            ITypes type = new PiranhaGreen();
            type.Type(this, _pictureBox);
        }

        private void PiranhaRed_Click(object sender, EventArgs e)
        {

            // Load and set the image
            ITypes type = new PiranhaRed();
            type.Type(this, _pictureBox);

        }

        private void SeaHorse_Click(object sender, EventArgs e)
        {

            // Load and set the image
            ITypes type = new SeaHorse();
            type.Type(this, _pictureBox);

        }

        private void Urchin_Click(object sender, EventArgs e)
        {
            ITypes type = new Urchin();
            type.Type(this, _pictureBox);

        }

        private void RemoveImgBtn_Click(object sender, EventArgs e)
        {
            //this will "remove" the image by making it hidden, and it will appear when user clicks to load an image
            _pictureBox.Visible = false;

        }

        private void Library_MouseMove(object sender, MouseEventArgs e)
        {
            IFormFeatures feature = new FormMovement();
            feature.Function(this, e, _mouseDown, _lastLocation);
        }

        private void Library_MouseUp(object sender, MouseEventArgs e)
        {
            //this says that the mouse is not being pressed, to prevent from the form constatly moving where the mouse is
            _mouseDown = false;

        }

        private void Library_MouseDown(object sender, MouseEventArgs e)
        {
            //this is stating that the mouse is pressed and the last location of the mouse is equal to the current location
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            //if button is clicked then the form size will be changed affectively minimizing it and if clicked again then it will maximize again
            IMinimize features = new Minimize();
            features.Function(this, _x++);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            ILoadingImage loadingImage = new LoadImageBtn();
            loadingImage.LoadImage(this, _pictureBox, DropDownBox, _imageList);
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            ISimpleButtonFunctions btnFunc = new HelpButton1();
            btnFunc.BtnFunction();
        }

        private void HelpBtn2_Click(object sender, EventArgs e)
        {
            ISimpleButtonFunctions btnFunc = new HelpButton2();
            btnFunc.BtnFunction();
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }
    }
}