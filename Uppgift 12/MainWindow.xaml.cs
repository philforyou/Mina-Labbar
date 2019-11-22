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

namespace Uppgift_12
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

        private void listboxValues_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        public bool Empty ()
        {


            listBoxValues.Items.Clear();
            medelvärde.Text = String.Empty;
            inputTal.Text = String.Empty;
            okKnapp.IsEnabled = true;

            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBoxValues.Items.Add(inputTal.Text);

            Double Summering = 0;

            for (int i = 0; i < listBoxValues.Items.Count; i++)
            {
                Summering += Convert.ToDouble(listBoxValues.Items[i]);

                Double Medelvärdet = Summering / 5;

                medelvärde.Text = $"{Medelvärdet}";

                if (i < 4)
                { medelvärde.Text = null; }

                if (i == 4)
                { okKnapp.IsEnabled = false; }
                
            }

        }

        private void Nollställarknappen_Click(object sender, RoutedEventArgs e)
        {
            if (Nollställarknappen.IsEnabled == true)
            { Empty(); }
        }
    }
}
