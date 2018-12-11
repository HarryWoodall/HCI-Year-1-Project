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
using System.Windows.Shapes;

namespace ATMProject
{
    /// <summary>
    /// Interaction logic for WithdrawConfirmPopup.xaml
    /// </summary>
    public partial class WithdrawConfirmPopup : Window {

        private string amount;
        private Customer customer;
        private WithdrawWindow caller;

        public WithdrawConfirmPopup(WithdrawWindow caller, string amount, Customer customer) {
            InitializeComponent();
            this.amount = amount;
            this.customer = customer;
            this.caller = caller;

            outputLabel.Content = amount;
        }

        private void confirmButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(caller, true, customer);
            exit.Show();
            this.Close();
        }

        private void cancelButtonPress(object sender, MouseButtonEventArgs e) {
            this.Close();
        }
    }
}
