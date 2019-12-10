using System;
using GodisKalkylatorn;
using System.Collections.Generic;
using System.IO;
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

namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CandyCalculator candyCalculator = new CandyCalculator();
       
        List<Person> peoplelist = new List<Person>();


        public MainWindow()
        {
            InitializeComponent();

        }

        private void ÖppnaKnapp_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("peoplelist.bin"))
            {
                //List<Person> peoplelist = new List<Person>();
                peoplelist = (List<Person>)FileOperations.Deserialize("peoplelist.bin");
                for (int j = 0; j < peoplelist.Count; j++)
                {
                    candyCalculator.AddPerson(peoplelist[j]);
                }
                for (int i = 0; i < peoplelist.Count; i++)
                {
                    List1.Items.Add($"{peoplelist[i].Firstname} ({peoplelist[i].Age} år) ");
                }

            }
        }

        private void Läggtillpersonknapp_Click(object sender, RoutedEventArgs e)
        {
            Person person1 = new Person();
            person1 = person1.SkapaPerson(namnbox.Text, int.Parse(ålderbox.Text));
            candyCalculator.AddPerson(person1);
            List1.Items.Add($"{namnbox.Text} ({ålderbox.Text} år)");
        }

        private void Fördelagodisknapp_Click(object sender, RoutedEventArgs e)
        {
            
            peoplelist = candyCalculator.GetPeople();
            List1.Items.Clear();
            if (Åldersknapp.IsChecked == true)
            { peoplelist = candyCalculator.DivideCandyByAge(peoplelist); }
            if (Bokstavsordningsknapp.IsChecked == true)
            { peoplelist = candyCalculator.DivideCandyByName(peoplelist); }
            candyCalculator.DivideCandy(peoplelist, double.Parse(Antalgodisbox.Text));
            for (int i = 0; i < peoplelist.Count; i++)
            {
                List1.Items.Add($"{peoplelist[i].Firstname} ({peoplelist[i].Age} år): ---> {(peoplelist[i].Candies)} godisar");
            }

        }

        private void Sparaknapp_Click(object sender, RoutedEventArgs e)
        {
          
            peoplelist = candyCalculator.GetPeople();
            FileOperations.Serialize(peoplelist, "peoplelist.bin");
           
        }


    }
}
