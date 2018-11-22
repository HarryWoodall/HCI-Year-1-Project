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

        public ViewBalanceWindow(Window caller) {
            InitializeComponent();
            this.caller = caller;

            string[] token = new string[3];
            try {
                using (StreamReader sr = new StreamReader("../../Assests/Token.txt")) {
                    for (int i = 0; i < token.Length; i++) {
                        token[i] = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }

            balanceLabel.Content = token[0];
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }

        private void backButtonPush(object sender, MouseButtonEventArgs e) {
            caller.Show();
            this.Close();
        }
    }
}
