using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace ATMProject {
    /// <summary>
    /// Interaction logic for AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window {

        private String input = "";

        public AuthenticationWindow() {
            InitializeComponent();
            buttonBorder.Visibility = Visibility.Visible;
            authenticator.Visibility = Visibility.Hidden;
        }

        private void InsertTokenPress(object sender, MouseButtonEventArgs e) {
            buttonBorder.Visibility = Visibility.Hidden;
            authenticator.Visibility = Visibility.Visible;
        }

        private void numericButtonPress(object sender, MouseButtonEventArgs e) {
            Label label = (Label)sender;
            UITimers timer = new UITimers();
            timer.colorTimer(label, new SolidColorBrush(Color.FromArgb(255, 78, 123, 220)), 5);

            if (input.Length < 4) {
                input += label.Content;
                authenticatorOutput.Text += "•";

                if (input.Length == 4) {
                    confirmButton.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x4B, 0xC9, 0x37));
                    confirmButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
                }
            } else {
                SoundPlayer player = new SoundPlayer("../../Assests/Sounds/Error_Select.wav");
                player.Load();
                player.Play();
            }
        }

        private void confirmButtonPress(object sender, MouseButtonEventArgs e) {
            if (input.Length == 4) {
                Customer customer = null;
                string[] customerDetails = new string[3];
                try {
                    using (StreamReader sr = new StreamReader("../../Assests/Token.txt")) {
                        for (int i = 0; i < customerDetails.Length; i++) {
                            customerDetails[i] = sr.ReadLine();
                        }
                        customer = new Customer(customerDetails[1], customerDetails[2], Convert.ToInt32(customerDetails[0]));

                        while (!sr.EndOfStream) {
                            string data = sr.ReadLine();
                            string[] statement = data.Split(',');
                            customer.addStatement(statement);
                        }

                        sr.Close();
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error");
                    Console.WriteLine(ex.Message);
                }

                if (customer.getPIN() == input) {
                    Console.WriteLine("Authenticated");
                    MainWindow window = new MainWindow(this, customer);
                    window.Show();
                } else {
                    Console.WriteLine("Invalid Pin");
                }
            }
        }

        private void cancelButtonPress(object sender, MouseButtonEventArgs e) {
            authenticatorOutput.Text = "";
            input = "";
            confirmButton.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xB6, 0xB6, 0xB6));
            confirmButton.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xC9, 0xC9, 0xC9));
        }
    }
}
