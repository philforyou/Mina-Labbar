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

namespace Uppgift8
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Tal1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tal2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Resultat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double talett = Double.Parse(Tal1.Text);
            Double taltvå = Double.Parse(Tal2.Text);

            if (plusknapp.IsChecked == true) 
            { Double summa = talett + taltvå;
                Resultat.Text = $"{summa}";
               
            }

            if (minusknapp.IsChecked == true)
            {
                Double summa = talett - taltvå;
                Resultat.Text = $"{summa}";

            }

            if (gångerknapp.IsChecked == true)
            {
                Double summa = talett * taltvå;
                Resultat.Text = $"{summa}";

            }

            if (delatknapp.IsChecked == true)
            {
                Double summa = talett / taltvå;
                Resultat.Text = $"{summa}";

            }


        }
    }
}
