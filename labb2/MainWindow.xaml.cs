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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BankAccount checkingAccount;
            BankAccount retirementAccount;
            BankAccount savingsaccount;
            BankAccount savingsaccount2;

            Customer customer = new Customer()
            {
                Addres = "jaktstigen",
                Cellphone = 0703490317,
                Firstname = "Cicki",
                Lastname = "Jacobson"
            };
            Customer customer2 = new Customer()
            {
                Addres = "prästgatan",
                Cellphone = 0703291230,
                Firstname = "philip",
                Lastname = "Jacobson"
            };
            checkingAccount = Customer.CreateAccount("CheckingAccount");
            customer.bankAccounts.Add(checkingAccount);
            //metod test
            checkingAccount.Insättning(1000M);
           ((CheckingAccount)checkingAccount).SetCredit(0.3M);
            bool y = checkingAccount.Uttag(130M);
            bool w = checkingAccount.Uttag(1300M);
            decimal z = checkingAccount.TillgängligtSaldo();
            //slut på test----------------------------------
            retirementAccount = Customer.CreateAccount("RetirementAccount");
            customer.bankAccounts.Add(retirementAccount);
            //metod test:
           retirementAccount.Insättning(100M);
           bool x = retirementAccount.Uttag(91M);
            bool v = retirementAccount.Uttag(90M);
            //slut på test----------------------------------
            savingsaccount2 = Customer.CreateAccount("SavingAccount");
            customer2.bankAccounts.Add(savingsaccount2);
            //metod test:
           savingsaccount2.Insättning(200000M);
           decimal q = savingsaccount2.TillgängligtSaldo();
            //slut på test--------------------------------
            //test för flera konton av samma klass
            savingsaccount = Customer.CreateAccount("SavingAccount");
            customer.bankAccounts.Add(savingsaccount);
        }
    }
}
