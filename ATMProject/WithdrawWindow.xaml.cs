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
            setUpAmounts();
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }

        private void WithdrawButtonPush(object sender, MouseButtonEventArgs e) {
            Label label = (Label)sender;
            int ammount = Convert.ToInt32(label.Content.ToString().Split('£')[1]);

            if (customer.withdraw(ammount)) {
                Console.WriteLine("Success");
                WithdrawConfirmPopup confirm = new WithdrawConfirmPopup(this, label.Content.ToString(), customer);
                confirm.Show();
            } else {
                Console.WriteLine("Not Enough Funds");
                UITimers timer = new UITimers();
                WithdrawErrorPopup errorPopup = new WithdrawErrorPopup();
                errorPopup.Show();
                timer.popUpWindowTimer(errorPopup, 15);
            }
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(this, false, customer);
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

        private void setUpAmounts() {
            foreach(object control in contentGrid.Children) {
                if (control is Border) {
                    Border border = (Border)control;
                    Label label = (Label)border.Child;
                    string content = customer.getSymbol();

                    if (label.Content.ToString().Contains('£')) {

                        switch (customer.GetCulture()) {
                            case Customer.Culture.AUD:
                                content += (Convert.ToInt32(label.Content.ToString().Split('£')[1]) * 2).ToString();
                                break;
                            case Customer.Culture.POL:
                                content += (Convert.ToInt32(label.Content.ToString().Split('£')[1]) * 5).ToString();
                                break;
                            case Customer.Culture.UAE:
                                content += (Convert.ToInt32(label.Content.ToString().Split('£')[1]) * 5).ToString();
                                break;
                            case Customer.Culture.CH:
                                content += (Convert.ToInt32(label.Content.ToString().Split('£')[1]) * 10).ToString();
                                break;
                            case Customer.Culture.JP:
                                content += (Convert.ToInt32(label.Content.ToString().Split('£')[1]) * 150).ToString();
                                break;
                            default:
                                content += label.Content.ToString().Split('£')[1];
                                break;
                        }

                        label.Content = content;
                    }
                }
            }
        }

        private void changeCurrencyButtonPush(object sender, MouseButtonEventArgs e) {
            SelectCurrencyWindow currency = new SelectCurrencyWindow(this, customer);
            currency.Show();
        }
    }
}
