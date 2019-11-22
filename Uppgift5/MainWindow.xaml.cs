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

namespace Uppgift5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int a = int.Parse(summa.Content);

        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void beräknaknapp_Click(object sender, RoutedEventArgs e)
        {
            int Tal1 = int.Parse(Tal1värde.Text);

            int Tal2 = int.Parse(tal2värde.Text);

            int Summa = Tal1 + Tal2;

            Resultat.Text = $"{ Summa}";
        }

        private void rensaknapp_Click(object sender, RoutedEventArgs e)
        {
            Resultat.Clear();
            Tal1värde.Clear();
            tal2värde.Clear();
            

        }
    }
}
