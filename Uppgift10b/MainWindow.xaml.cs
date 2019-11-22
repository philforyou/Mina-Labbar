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

namespace Uppgift10b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int slump = new Random().Next(0, 1000);
        int attempt = 0;
        public MainWindow()
        {
            InitializeComponent();

            Gissa.IsEnabled = false;
            
        }

        private void Gissa_Click(object sender, RoutedEventArgs e)
        {
            
            int gissning = int.Parse(Userinput.Text);


            if (Gissa.IsEnabled == true)
            { attempt++; }

       

          


            if (slump == gissning)
            { gissningstext.Content = $" Du gissade rätt! du hade så här många {attempt} försök"; }

            if (slump > gissning && slump > gissning - 100 && slump != gissning)
            { gissningstext.Content = $" Nu är du mer än 100 under"; }

            if (slump < gissning && slump < gissning + 100 && slump != gissning)
            { gissningstext.Content = $" Nu är du mer än 100 över"; }

            if (slump < gissning && slump > gissning - 100 && slump != gissning)
            { gissningstext.Content = $"nu börjar du närma dig men är lite för högt"; }

            if (slump > gissning && slump < gissning + 100 && slump != gissning) 
            { gissningstext.Content = $"nu börjar du närma dig men är lite för lågt"; }

            
        }

        private void slumpatal_Click(object sender, RoutedEventArgs e)
        {
            

            Gissa.IsEnabled = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
