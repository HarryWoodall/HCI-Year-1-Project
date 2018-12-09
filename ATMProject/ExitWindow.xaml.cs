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

namespace ATMProject {
    /// <summary>
    /// Interaction logic for ExitWindow.xaml
    /// </summary>
    public partial class ExitWindow : Window {

        private Window caller;
        private Boolean withdraw;
        private Customer customer;

        public ExitWindow(Window caller, bool withdraw, Customer customer) {
            InitializeComponent();
            this.caller = caller;
            this.withdraw = withdraw;
            this.customer = customer;

            if (withdraw) {
                moneyBorder.Visibility = Visibility.Visible;
                cardBorder.Visibility = Visibility.Hidden;
                confirmBorder.Visibility = Visibility.Hidden;
            }
            else {
                moneyBorder.Visibility = Visibility.Hidden;
                cardBorder.Visibility = Visibility.Visible;
                confirmBorder.Visibility = Visibility.Hidden;
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Close();
        }

        private void takeMoneyButtonPush(object sender, MouseButtonEventArgs e) {
            moneyBorder.Visibility = Visibility.Hidden;
            cardBorder.Visibility = Visibility.Visible;
            confirmBorder.Visibility = Visibility.Hidden;
        }

        private void takeCardButtonPush(object sender, MouseButtonEventArgs e) {
            moneyBorder.Visibility = Visibility.Hidden;
            cardBorder.Visibility = Visibility.Hidden;
            confirmBorder.Visibility = Visibility.Visible;

            if (customer != null) {
                customer.updateFile();
            }

            UITimers timer = new UITimers();
            timer.exitTimer(this, 50);
        }
    }
}
