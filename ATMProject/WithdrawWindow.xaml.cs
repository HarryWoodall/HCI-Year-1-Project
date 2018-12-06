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
    /// Interaction logic for WithdrawWindow.xaml
    /// </summary>
    public partial class WithdrawWindow : Window {
        private Window caller;
        private Customer customer;
        private int amount;

        public WithdrawWindow(Window window, Customer customer) {
            InitializeComponent();
            caller = window;
            this.customer = customer;
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }

        private void WithdrawButtonPush(object sender, MouseButtonEventArgs e) {
            Label label = (Label)sender;
            int ammount = Convert.ToInt32(label.Content.ToString().Split('£')[1]);

            if (customer.withdraw(ammount)) {
                Console.WriteLine("Success");
            } else {
                Console.WriteLine("Not Enough Funds");
            }
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(this);
            exit.Show();
        }

        private void backButtonPush(object sender, MouseButtonEventArgs e) {
            caller.Show();
            this.Close();
        }

        private void customAmountButtonPush(object sender, MouseButtonEventArgs e) {
            WithdrawAmmountPopup popup = new WithdrawAmmountPopup(this, customer);
            popup.ShowDialog();
        }

        public void setAmount(int amount) {
            this.amount = amount;
        }
    }
}
