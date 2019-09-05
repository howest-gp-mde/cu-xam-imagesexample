using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.ImagesExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var embeddedImage = new Image { Aspect = Aspect.AspectFill };
            //get the image by ResourceID
            embeddedImage.Source = ImageSource.FromResource("XrnCourse.ImagesExample.images.glider.png");
            //configure absolute layout 
            AbsoluteLayout.SetLayoutBounds(embeddedImage, new Rectangle(.4, .45, 512, 109));
            AbsoluteLayout.SetLayoutFlags(embeddedImage, AbsoluteLayoutFlags.PositionProportional);
            //add image to layout
            absLayout.Children.Add(embeddedImage);
        }
    }
}
