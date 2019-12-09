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

        public string Jibberish(string strängen)
        {
            char[] sträng = strängen.ToCharArray();
            char[] vokal = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä' };
            string tillbaka="";

            foreach (char bokstav in sträng)
            {
                for (int i = 0; i < vokal.Length; i++)
                {
                    if (bokstav == vokal[i])
                    {  tillbaka=strängen.ToString().Replace(bokstav, 'ö'); }
                }

            }

            return tillbaka;

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
        public int NumberOfVowels(string Vowls)
        {
            char[] strängen = Vowls.ToCharArray();
            char[] vokal = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä' };
            int j = 0;
            foreach (char bokstav in strängen)
            {
                for (int i = 0; i < vokal.Length; i++)
                {
                    if (bokstav==vokal[i])
                    j++;
                }
            }
            return j;
        }
        private void konventeraknapp_Click(object sender, RoutedEventArgs e)
        {
           
            string gtext = grundtext.Text;



            string bytbokstav = "";
            int antalvokaler = 0;
           // nytext.Content = bytbokstav;

            antalvokaler = NumberOfVowels(gtext);
            bytbokstav = Jibberish(gtext);
            nytext.Content = bytbokstav;
            /* foreach (char bokstav in gtext)
             {
                 bool vokal = isVowel(bokstav);
                 bytbokstav = Jibberish(gtext);
                 nytext.Content = bytbokstav;

                 antalvokaler = NumberOfVowels(gtext);
                 */
            //if (vokal == true)
            //{
            //    bytbokstav = Jibberish(gtext);
            //    nytext.Content = bytbokstav;

            //    antalvokaler = NumberOfVowels(gtext);

            //}

            //else
            //{
            //    nytext.Content = gtext.ToString();

            //}
            gånger.Content = $"{antalvokaler}";
            





        }
    }
}
