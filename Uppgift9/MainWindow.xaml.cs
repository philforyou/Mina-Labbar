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

namespace Uppgift9
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

     

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string namn = namnbox.Text;
            int age = int.Parse(ålderbox.Text);


            if (age >= 15)
            {
                display.Content = $"Hej {namn} Du är {age} år gammal och får se alla filmer";
            }

            if (age >= 11 && age < 15 && Uvuxen.IsChecked == true)
            { 
                display.Content = $"Hej {namn} Du är {age} år gammal och får se filmer med en åldersgräns upp till 11 år";
            }

            if (age >= 11 && age < 15 && Mvuxen.IsChecked == true)
            {
                display.Content = $"Hej {namn} Du är {age} år gammal och får se filmer med en åldersgräns upp till 11 år. " +
                    $"Det spelar inge roll att du har en vuxen med dig";
            }

            if (age >= 7 && age < 11 && Uvuxen.IsChecked == true)
            { 
                display.Content = $"Hej {namn} Du är {age} år gammal och får se filmer med en åldersgräns uppmot 7 år"; 
            }

            if (age >= 7 && age < 11 && Mvuxen.IsChecked == true)
            {
                display.Content = $"Hej {namn} Du är {age} år gammal och får se filmer med en åldersgräns uppmot 11 år i sällskap av en vuxen";
            }

            if (age < 7 & Uvuxen.IsChecked == true)
            {
              display.Content = $"Hej {namn} Du är {age} år gammal och får enbart se barntillåtna filmer";
            }

            if (age < 7 & Mvuxen.IsChecked == true)
            {
                display.Content = $"Hej {namn} Du är {age} år gammal och får se filmer tillåtna för 7 år i sällskap med en vuxen";
            }



        }

        private void Uvuxen_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Mvuxen_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

}
