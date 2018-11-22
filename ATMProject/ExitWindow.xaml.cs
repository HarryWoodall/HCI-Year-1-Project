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

        public ExitWindow(Window caller) {
            InitializeComponent();
            this.caller = caller;
            UITimers timer = new UITimers();
            timer.exitTimer(this, 50);
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Close();
        }
    }
}
