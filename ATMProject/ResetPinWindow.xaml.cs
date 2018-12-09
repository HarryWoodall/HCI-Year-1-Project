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
    /// Interaction logic for ResetPinWindow.xaml
    /// </summary>
    public partial class ResetPinWindow : Window {

        private Window caller;
        private Customer customer;

        private string firstAttempt = "";
        private string secondAttempt = "";
        private bool onSecondAttempt;

        public ResetPinWindow(Window caller, Customer customer) {
            InitializeComponent();
            this.caller = caller;
            this.customer = customer;
            onSecondAttempt = false;
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }

        private void confirmButtonPress(object sender, MouseButtonEventArgs e) {
            if (authenticatorOutput.Text.Length == 4) {
                confirmButton.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xB6, 0xB6, 0xB6));
                authenticatorOutput.Clear();

                if (!onSecondAttempt) {
                    onSecondAttempt = true;

                    firstBorder.Background = secondBorder.Background;
                    firstBorder.BorderBrush = secondBorder.BorderBrush;
                    firstLabel.Background = secondLabel.Background;
                    firstLabel.Foreground = secondLabel.Foreground;

                    secondBorder.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x4B, 0xC9, 0x37));
                    secondBorder.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));
                    secondLabel.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                    secondLabel.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));
                } else {
                    ResetPinPopup popUp;
                    if (firstAttempt == secondAttempt) {
                        popUp = new ResetPinPopup(this, true);
                        popUp.Show();
                        customer.setPIN(firstAttempt);
                        Console.WriteLine(customer.getPIN());
                    } else {
                        onSecondAttempt = false;
                        firstAttempt = "";
                        secondAttempt = "";
                        Console.WriteLine("PIN missmatch");
                        popUp = new ResetPinPopup(this, false);

                        secondBorder.Background = firstBorder.Background;
                        secondBorder.BorderBrush = secondBorder.BorderBrush;
                        secondLabel.Background = firstLabel.Background;
                        secondLabel.Foreground = firstLabel.Foreground;

                        firstBorder.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x4B, 0xC9, 0x37));
                        firstBorder.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));
                        firstLabel.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                        firstLabel.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));

                        popUp.Show();
                    }
                }
            }
        }

        private void numericButtonPress(object sender, MouseButtonEventArgs e) {
            if (authenticatorOutput.Text.Length < 4) {
                Label label = (Label)sender;
                if (!onSecondAttempt) {
                    firstAttempt += label.Content;
                    authenticatorOutput.Text += "•";
                } else {
                    secondAttempt += label.Content;
                    authenticatorOutput.Text += "•";
                }

                if (authenticatorOutput.Text.Length == 4) {
                    confirmButton.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x4B, 0xC9, 0x37));
                    confirmButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
                    confirmButton.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x1B, 0x99, 0x07));
                }
            }
        }

        private void cancelButtonPress(object sender, MouseButtonEventArgs e) {
            confirmButton.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xB6, 0xB6, 0xB6));
            confirmButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xC9, 0xC9, 0xC9));
            confirmButton.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x64, 0x64, 0x64));

            authenticatorOutput.Clear();
            if (!onSecondAttempt) {
                firstAttempt = "";
            } else {
                secondAttempt = "";
            }
        }

        public Window getCaller() {
            return caller;
        }

        private void exitButtonPush(object sender, MouseButtonEventArgs e) {
            ExitWindow exit = new ExitWindow(this, false, customer);
            exit.Show();
        }

        private void backButtonPush(object sender, MouseButtonEventArgs e) {
            caller.Show();
            this.Close();
        }
    }
}
