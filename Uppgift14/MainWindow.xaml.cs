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

namespace Uppgift14
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

       

        public bool Undersök(char[] artext)
        {

            int count = 0;

            for (int i = 0; i < artext.Length; i++)
            {
                if (!char.IsDigit(artext[i]) == true)
                {
                    count++;
                }
               

                
            }
            if (count >= 1)
            { return false; }

            else
            {return true; }



            //if (char.IsDigit(artext) == true)
           // { }

               // return false;
        }

        public int ålder(int år)
        {
           
         int dagensår =  DateTime.Now.Year;

          int uträknat = dagensår - år;
          

            return uträknat;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)

            
        {
            string årtextt = ange.Text;
            char[] årtext = årtextt.ToCharArray();
            
            bool Undersökt;
            Undersökt = Undersök(årtext);




            if (Undersökt == false)
                { MessageBox.Show("Du måste mata in enbart siffror"); }

                else
                {
                    int årr = ålder(int.Parse(ange.Text));
                    ;
                    MessageBox.Show($"Du är {årr} år gammal");
                }
            

        }
    }
}
