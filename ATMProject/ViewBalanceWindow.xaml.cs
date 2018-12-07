using System;
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
using System.Windows.Shapes;

namespace ATMProject {
    /// <summary>
    /// Interaction logic for ViewBalanceWindow.xaml
    /// </summary>
    public partial class ViewBalanceWindow : Window {

        private Window caller;
        private Customer customer;

        public ViewBalanceWindow(Window caller, Customer customer) {
            InitializeComponent();
            this.caller = caller;
            this.customer = customer;
            balanceLabel.Content = customer.getSymbol(customer.GetCulture()) + (customer.getBalance() / customer.getRate(customer.GetCulture())).ToString("0.00");
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }

        private void backButtonPush(object sender, MouseButtonEventArgs e) {
            caller.Show();
            this.Close();
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(this);
            exit.Show();
        }
    }
}
