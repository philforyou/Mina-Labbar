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

namespace Uppgift6
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

        private void tal2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tal1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int taltvå = int.Parse(tal2.Text);
            int talett = int.Parse(tal1.Text);
            int Resultat = talett + taltvå;
            
            summa.Text=$"{Resultat}";

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            int taltvå = int.Parse(tal2.Text);
            int talett = int.Parse(tal1.Text);
            int Resultat = talett - taltvå;

            summa.Text = $"{Resultat}";
        }

        private void Dela_Click(object sender, RoutedEventArgs e)
        {
            int taltvå = int.Parse(tal2.Text);
            int talett = int.Parse(tal1.Text);
            int Resultat = talett / taltvå;

            summa.Text = $"{Resultat}";
        }

        private void gånger_Click(object sender, RoutedEventArgs e)
        {
            int taltvå = int.Parse(tal2.Text);
            int talett = int.Parse(tal1.Text);
            int Resultat = talett * taltvå;

            summa.Text = $"{Resultat}";
        }

        private void Rensa_Click(object sender, RoutedEventArgs e)
        {
            summa.Clear();
            tal2.Clear();
            tal1.Clear();

        }

        private void summa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
