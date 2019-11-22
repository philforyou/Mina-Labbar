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

namespace Uppgift7
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

        private void tal1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tal2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void heltal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Talett = int.Parse(tal1.Text);
            int Taltvå = int.Parse(tal2.Text);

            int Resultat1 = Talett / Taltvå;
            int Resultat2 = Talett % Taltvå;
           

            heltal.Text = $"{Resultat1}";
            rest.Text = $"{Resultat2}";


           


        }
    }
}
