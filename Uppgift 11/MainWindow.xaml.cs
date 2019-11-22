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

namespace Uppgift_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int slump = new Random().Next(0, 100);
        

        
        public MainWindow()
        {
            InitializeComponent();

            andel.Content = bar.Value.ToString();
        }

        private void mindre_Click(object sender, RoutedEventArgs e)
        {
            bar.Value -= 5;

            andel.Content = bar.Value.ToString();
        }

        private void mer_Click(object sender, RoutedEventArgs e)
        {
            bar.Value += 5;

            andel.Content = bar.Value.ToString();
        }

        private void starta_Click(object sender, RoutedEventArgs e)
        {
            int försök = int.Parse(inputförsök.Text);

            int[] Värde = new int[försök];

            int ned = 0;

            int upp = 0;

            for (int i = 0; i < Värde.Length; i++)
            {
                int slump = new Random().Next(0, 100);

                Värde[i] = slump;

               

                if (Värde[i] >= bar.Value)
                { ned++; }

                else
                { upp++; }




            }

            upputfall.Content = upp.ToString();
            nedutfall.Content = ned.ToString();

            
        }


      


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

      

      
    }
}
