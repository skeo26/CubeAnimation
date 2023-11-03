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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void color_set(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            difMat.Color = difMat.AmbientColor = Color.FromArgb(255, (byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            Slider slider = sender as Slider;

            if (slider == sliderX)
            {
                scaleTransform.ScaleX = slider.Value;
            }
            else if (slider == sliderY)
            {
                scaleTransform.ScaleY = slider.Value;
            }
            else if (slider == sliderZ)
            {
                scaleTransform.ScaleZ = slider.Value;
            }

        }

        private void AnimateButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                To = 2,
                Duration = TimeSpan.FromSeconds(1) 
            };
            scaleTransform.BeginAnimation(ScaleTransform3D.ScaleXProperty, animation);
            scaleTransform.BeginAnimation(ScaleTransform3D.ScaleYProperty, animation);
            scaleTransform.BeginAnimation(ScaleTransform3D.ScaleZProperty, animation);
        }

    }
}
