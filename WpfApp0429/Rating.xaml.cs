using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp0429
{
    /// <summary>
    /// Interaction logic for Rating.xaml
    /// </summary>
    public partial class Rating : UserControl
    {

        void Rate(int count,Image myImg)
        {
            if (count >= 1)
            {
                image1.Source = myImg.Source;
                RatingTxtb.Text = count.ToString();
            }
            if (count >= 2)
            {
                image2.Source = myImg.Source;
                RatingTxtb.Text = count.ToString();
            }
            if (count >= 3)
            {
                image3.Source = myImg.Source;
                RatingTxtb.Text = count.ToString();
            }
            if (count >= 4)
            {
                image4.Source = myImg.Source;
                RatingTxtb.Text = count.ToString();
            }
            if (count >= 5)
            {
                image5.Source = myImg.Source;
                RatingTxtb.Text = count.ToString();
            }
        }

        public int RatingText
        {
            get { return (int)GetValue(RatingTextProperty); }
            set { SetValue(RatingTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RatingText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RatingTextProperty =
            DependencyProperty.Register("RatingText", typeof(int), typeof(Rating));


        public Rating()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string stringPath = "Images/filledstar.png";
                Uri imageUri = new Uri(stringPath, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                Image myImage = new Image();
                myImage.Source = imageBitmap;
                //image1.Source = myImage.Source;
                //RatingText = 1;
                if (btn.Name == "Button1") Rate(1, myImage);
                else if (btn.Name == "Button2") Rate(2, myImage);
                else if (btn.Name == "Button3") Rate(3, myImage);
                else if (btn.Name == "Button4") Rate(4, myImage);
                else if (btn.Name == "Button5") Rate(5, myImage);

            }
        }
    }
}
