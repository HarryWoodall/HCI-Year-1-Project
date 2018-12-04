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
    public partial class WithdrawAmmountWindow : Window {

        private string output;

        public WithdrawAmmountWindow() {
            InitializeComponent();
        }

        private void numericButtonPress(object sender, MouseButtonEventArgs e) {
            Label label = (Label)sender;
            UITimers timer = new UITimers();
            timer.colorTimer(label, new SolidColorBrush(Color.FromArgb(255, 78, 123, 220)), 5);

            if (authenticatorOutput.Text.Length == 0) {
                authenticatorOutput.Text = "£" + label.Content;
            } else {
                authenticatorOutput.Text += label.Content;
            }
            output += label.Content;
        }

        private void confirmButtonPress(object sender, MouseButtonEventArgs e) {

        }

        private void cancelButtonPress(object sender, MouseButtonEventArgs e) {
            output = "";
            authenticatorOutput.Text = "";
        }
    }
}
