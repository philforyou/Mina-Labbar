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

namespace Uppgift10
{

    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        int slump = new Random().Next(0,1000);

      

       

        public MainWindow()
        {
            

            InitializeComponent();

            //slumpatal.IsEnabled = false;
          // if (slumpatal.IsEnabled == true)
          //  {
            //    int Y = Slumpattal(true);
             //   test.Content = $"{Y}";
           // }
        }


        

        private void Userinput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Gissa_Click(object sender, RoutedEventArgs e)
        {
            int Gissning = int.Parse(Userinput.Text);

           // if (Gissning == slump) ;
        }

        private void slumpatal_Click(object sender, RoutedEventArgs e)
        {
           

            test.Content = $"{slump}";





        }
    }
}
