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
        Window caller;

        public WithdrawWindow(Window window) {
            InitializeComponent();
            caller = window;
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Close();
        }

        private void ExitButtonPress(object sender, MouseButtonEventArgs e) {
            MainWindow window = new MainWindow(this);
            window.Show();
        }
    }
}
