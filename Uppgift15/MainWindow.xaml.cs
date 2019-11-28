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

namespace Uppgift15
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

        public string Jibberish(char bytee)
        {
            string onödigt = "";

           onödigt += bytee.ToString().Replace(bytee, 'ö');

            return onödigt;
        }
        public bool isVowel(char kontroll)
        {
            char[] vokal = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä'};

            for (int i = 0; i < vokal.Length; i++)
            {

                if (kontroll == vokal[i])
                { 
                    return true; 
                }
               
            }
            return false;
        }
        public int NumberOfVowels(string kaffe)
        {
            // char[] vokal = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä' };
            int antal = 0;
            antal++;
            return antal;
        }
        private void konventeraknapp_Click(object sender, RoutedEventArgs e)
        {
            string gtext = grundtext.Text;
          
            string ord = "";
            int siffra = 0;
            foreach (char item in gtext)
            {
                bool bjas = isVowel(item);

                if (bjas == true)
                {


                    ord = Jibberish(item);
                    nytext.Content += ord;

                    siffra += NumberOfVowels(item.ToString());
                    gånger.Content = $"{siffra}";
                }

                else
                {
                    nytext.Content += item.ToString();

                }
            }
           

           
            

        }
    }
}
