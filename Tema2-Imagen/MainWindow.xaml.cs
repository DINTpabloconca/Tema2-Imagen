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

namespace Tema2_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (opAltaRadioButton.IsChecked == true)
            {
                starImage.Opacity = 0.9;
            }
            else if (opMediaRadioButton.IsChecked == true)
            {
                starImage.Opacity = 0.5;
            }
            else if (opBajaRadioButton.IsChecked == true)
            {
                starImage.Opacity = 0.1;
            }

            if (rellenoRadioButton.IsChecked == true)
            {
                starImage.Stretch = Stretch.Fill;
            }
            else if (uniformeRadioButton.IsChecked == true)
            {
                starImage.Stretch = Stretch.Uniform;
            }
            else if (rellenoUniformeRadioButton.IsChecked == true)
            {
                starImage.Stretch = Stretch.UniformToFill;
            }
            else if (noneRadioButton.IsChecked == true)
            {
                starImage.Stretch = Stretch.None;
            }
        }
    }
}
