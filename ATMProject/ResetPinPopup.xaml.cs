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
    /// Interaction logic for ResetPinPopup.xaml
    /// </summary>
    public partial class ResetPinPopup : Window {

        private UITimers timer;
        private bool isSuccessful;
        ResetPinWindow caller;

        public ResetPinPopup(ResetPinWindow caller, bool isSuccessful) {
            InitializeComponent();
            this.caller = caller;
            this.isSuccessful = isSuccessful;

            timer = new UITimers();
            timer.popUpWindowTimer(this, 100);

            if (isSuccessful) {
                successContent.Visibility = Visibility.Visible;
                failedContent.Visibility = Visibility.Hidden;
                contentBorder.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x4B, 0xC9, 0x37));
            } else {
                successContent.Visibility = Visibility.Hidden;
                failedContent.Visibility = Visibility.Visible;
            }
        }

        private void popUpPush(object sender, MouseButtonEventArgs e) {
            if (!isSuccessful) {
                if (timer.getTimer() != null) {
                    timer.getTimer().Stop();
                }

                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            if (isSuccessful) {
                caller.getCaller().Show();
                caller.Close();
            }
        }
    }
}
