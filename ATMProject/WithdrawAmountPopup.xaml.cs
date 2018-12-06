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
    /// Interaction logic for WithdrawAmmountWindow.xaml
    /// </summary>
    public partial class WithdrawAmmountPopup : Window {

        private string output;
        private WithdrawWindow caller;
        private Customer customer;

        public WithdrawAmmountPopup(WithdrawWindow caller, Customer customer) {
            InitializeComponent();
            this.caller = caller;
            this.customer = customer;
        }

        private void numericButtonPress(object sender, MouseButtonEventArgs e) {
            Label label = (Label)sender;
            UITimers timer = new UITimers();
            timer.colorTimer(label, new SolidColorBrush(Color.FromArgb(255, 78, 123, 220)), 5);

            if (amountOutput.Text.Length == 0) {
                if (label.Content.ToString() != "0") {
                    amountOutput.Text = "£" + label.Content;
                }
            } else {
                amountOutput.Text += label.Content;
            }
            output += label.Content;
        }

        private void confirmButtonPress(object sender, MouseButtonEventArgs e) {
            int amount = Convert.ToInt32(output);
            UITimers timer = new UITimers();
            if (amount != 0 && amount % 5 == 0 && amount < customer.getBalance()) {
                caller.setAmount(amount);
                this.Close();
            } else if (amount > customer.getBalance()){
                WithdrawErrorPopup errorPopup = new WithdrawErrorPopup();
                errorPopup.Show();
                timer.popUpWindowTimer(errorPopup, 15);
            } else if (amount == 0 || amount % 5 != 0) {
                timer.colorTimer(amountOutput, new SolidColorBrush(Color.FromArgb(0xFF, 0xF3, 0x5A, 0x5A)), 20);
            }
        }

        private void cancelButtonPress(object sender, MouseButtonEventArgs e) {
            output = "";
            amountOutput.Text = "";
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            this.Close();
        }
    }
}
