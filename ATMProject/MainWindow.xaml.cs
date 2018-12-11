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

namespace ATMProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window caller;
        private Customer customer;

        public MainWindow(Window caller, Customer customer)
        {
            InitializeComponent();
            this.caller = caller;
            this.customer = customer;
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Close();
        }

        private void viewBalanceButtonPush(object sender, MouseButtonEventArgs e) {
            ViewBalanceWindow viewBalance = new ViewBalanceWindow(this, customer);
            viewBalance.Show();
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(this, false, customer);
            exit.Show();
        }

        private void withdrawButtonPush(object sender, MouseButtonEventArgs e) {
            WithdrawWindow withdraw = new WithdrawWindow(this, customer);
            withdraw.Show();
        }

        private void resetPinButtonPush(object sender, MouseButtonEventArgs e) {
            ResetPinWindow pin = new ResetPinWindow(this, customer);
            pin.Show();
        }

        private void viewStatementButtonPush(object sender, MouseButtonEventArgs e) {
            ViewStatementWindow statementWindow = new ViewStatementWindow(this, customer);
            statementWindow.Show();
        }

        private void changeCurrencyButtonPush(object sender, MouseButtonEventArgs e) {
            SelectCurrencyWindow currency = new SelectCurrencyWindow(this, customer);
            currency.Show();
        }
    }
}
