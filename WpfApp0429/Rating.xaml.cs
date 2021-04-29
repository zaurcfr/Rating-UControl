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
                image1.Source = myImage.Source;
                RatingText = 1;
                //if (btn.Content == "Button1") image1.Source = myImage.Source;
                //else if (btn.Content == "Button2") image2.Source = myImage.Source;
                //else if (btn.Content == "Button3") image3.Source = myImage.Source;
                //else if (btn.Content == "Button4") image4.Source = myImage.Source;
                //else if (btn.Content == "Button5") image5.Source = myImage.Source;
                
            }
        }
    }
}
