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

namespace labb2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        private List<Customer> Customers { get; set; } = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
            BankAccount checkingAccount;
            BankAccount retirementAccount;
            BankAccount savingsaccount;
            BankAccount savingsaccount2;

            Customer customer = new Customer()
            {
                Addres = "jaktstigen",
                Cellphone = 0703490317.ToString(),
                Firstname = "Cicki",
                Lastname = "Jacobson"
            };
          
            Customer customer2 = new Customer()
            {
                Addres = "prästgatan",
                Cellphone = 0703291230.ToString(),
                Firstname = "philip",
                Lastname = "Jacobson"
            };
            
            checkingAccount = customer.CreateAccount("CheckingAccount");
           
            customer.BankAccounts.Add(checkingAccount);
        

            //metod test
            checkingAccount.Insättning(1000M);
            ((CheckingAccount)checkingAccount).SetCredit(300M);
            //bool y = checkingAccount.Uttag(130M);
            //bool w = checkingAccount.Uttag(1300M);
            decimal z = checkingAccount.TillgängligtSaldo();
            //slut på test----------------------------------
            retirementAccount = customer.CreateAccount("RetirementAccount");
            customer.BankAccounts.Add(retirementAccount);
      
            //metod test:
            retirementAccount.Insättning(100M);
            //bool x = retirementAccount.Uttag(91M);
            //bool v = retirementAccount.Uttag(90M);
            //slut på test----------------------------------
            savingsaccount2 = customer.CreateAccount("SavingAccount");
            customer2.BankAccounts.Add(savingsaccount2);
            //metod test:
            savingsaccount2.Insättning(200000M);
            decimal q = savingsaccount2.TillgängligtSaldo();
            //slut på test--------------------------------
            //test för flera konton av samma klass
            savingsaccount = customer.CreateAccount("SavingAccount");
            customer.BankAccounts.Add(savingsaccount);
            Customers.Add(customer);
            Customers.Add(customer2);
            Customers = GetCustomer();
            CboCustomer.ItemsSource = Customers;

            string standard = 0.ToString();
            kreditbox.Text = standard;
        }

        private void CboCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        


        }

        public List<Customer> AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            return Customers;
        }

        public List<Customer> GetCustomer()
        {
            return Customers;
        }

        public void sparakund_Click(object sender, RoutedEventArgs e)
        {   Customer customer = new Customer();
            customer = customer.CreateCustomer(förnamntxt.Text, efternamntxt.Text, telefontxt.Text);
            Customers.Add(customer);
            CboCustomer.ItemsSource = Customers;
            rensa();
        }

        public void rensa()
        {   förnamntxt.Clear();
            efternamntxt.Clear();
            telefontxt.Clear();
        }

        private void UpdateUI()
        {
            Customer customer = CboCustomer.SelectedItem as Customer;
            kontouppgifterbox.ItemsSource = null;
            List<BankAccount> bankAccounts;
            bankAccounts = customer.GetBankAccounts();
            kontouppgifterbox.ItemsSource = bankAccounts;
            string standard = 0.ToString();
            kreditbox.Text = standard;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BankAccount bankaccount = kontouppgifterbox.SelectedItem as BankAccount;
            if (insättningsradioknapp.IsChecked == true)
            {
                bankaccount.Insättning(decimal.Parse(Beloppbox.Text));
                kontoutdragbox.Items.Add($"{DateTime.Now} - insättning   {Beloppbox.Text}");
            }

            else if (uttagradioknapp.IsChecked == true)
            {
                if (bankaccount.Uttaggodkänt(decimal.Parse(Beloppbox.Text)) == true)
                { kontoutdragbox.Items.Add($"{DateTime.Now} - uttag    {Beloppbox.Text}"); }

                else
                   if (bankaccount.AccountType == "ReterimentAccount")
                { MessageBox.Show("Du saknar täckning på ditt konto, vänligen notera att täckning för en uttagningsavgift på 10% behövs för ReterimentAccounts "); }
                    
                else 
                    MessageBox.Show("Du saknar täckning på ditt konto");
            }
            UpdateUI();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Customer customer = CboCustomer.SelectedItem as Customer;
            List<BankAccount> BankAccounts = new List<BankAccount>();
            BankAccount bankAccount = new BankAccount();
            if (checkingaccradio.IsChecked == true)
            { bankAccount = customer.CreateAccount("CheckingAccount");
                bankAccount.SetCredit(Convert.ToDecimal(kreditbox.Text));
            }
        
            if (savingaccradio.IsChecked == true)
            { bankAccount = customer.CreateAccount("SavingsAccount");}

            if (retirmentaccradio.IsChecked == true)
            { bankAccount = customer.CreateAccount("ReterimentAccount"); }

            UpdateUI();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Customer customer = CboCustomer.SelectedItem as Customer;
           kontouppgifterbox.ItemsSource =  customer.BankAccounts;
           UpdateUI();
        }

    }
}
