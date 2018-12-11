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
    /// Interaction logic for InvalidPINPopup.xaml
    /// </summary>
    public partial class InvalidPINPopup : Window {
        public InvalidPINPopup() {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            UITimers timer = new UITimers();
            timer.popUpWindowTimer(this, 15);
        }
    }
}
