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
    /// Interaction logic for SelectCurrencyWindow.xaml
    /// </summary>
    public partial class SelectCurrencyWindow : Window {

        private Customer customer;
        private Window caller;

        public SelectCurrencyWindow(Window caller, Customer customer) {
            InitializeComponent();
            this.customer = customer;
            this.caller = caller;
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(this);
            exit.Show();
        }

        private void cultureButtonPush(object sender, MouseButtonEventArgs e) {

            if (sender == buttonUK) {
                customer.setCulture(Customer.Culture.UK);
            } else if (sender == buttonUS) {
                customer.setCulture(Customer.Culture.US);
            } else if (sender == buttonAUD) {
                customer.setCulture(Customer.Culture.AUD);
            } else if (sender == buttonEU) {
                customer.setCulture(Customer.Culture.EUR);
            } else if (sender == buttonPOL) {
                customer.setCulture(Customer.Culture.POL);
            } else if (sender == buttonUAE) {
                customer.setCulture(Customer.Culture.UAE);
            } else if (sender == buttonCH) {
                customer.setCulture(Customer.Culture.CH);
            } else if (sender == buttonJP) {
                customer.setCulture(Customer.Culture.JP);
            }

            MainWindow window = new MainWindow(this, customer);
            window.Show();
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }
    }
}
