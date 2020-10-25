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

namespace VisorDeFuentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fuenteComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          if (fuenteComboBox.SelectedItem != null)
            {
                string fuente = (string)(fuenteComboBox.SelectedItem as ComboBoxItem).Content;
                LeyendaTextblock.FontFamily = new FontFamily(familyName: fuente);
            }
        }

        private void cursivaCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            LeyendaTextblock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            LeyendaTextblock.FontStyle = FontStyles.Normal;
        }

        private void negritasCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            LeyendaTextblock.FontWeight = FontWeights.Bold;
        }

        private void negritasCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            LeyendaTextblock.FontWeight = FontWeights.Normal;
        }

        private void smallRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void tamanioRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (smallRadioButton.IsChecked == true)
            {
                LeyendaTextblock.FontSize = 12;
            }
            else if (mediumRadioButton.IsChecked == true)
            {
                LeyendaTextblock.FontSize = 18;
            }
            else
            {
                LeyendaTextblock.FontSize = 24;
            }
        }
    }
}
