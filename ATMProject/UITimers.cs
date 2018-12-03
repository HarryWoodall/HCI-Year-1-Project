using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace ATMProject {

    class UITimers {

        private DispatcherTimer timer = new DispatcherTimer();
        private int timerTickCount;
        private int timerTickTarget;
        private object control;

        private SolidColorBrush targetColor;
        private SolidColorBrush naturalColor;


        public UITimers() {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
        }

        public DispatcherTimer getTimer() {
            return timer;
        }

        private void colorTimerTick(object sender, EventArgs e) {
            Control control = (Control)this.control;
            if (timerTickCount >= 2 && control.Background == naturalColor) {
                timerTickCount = 0;
                control.Background = targetColor;
            } else {
                timerTickCount++;
            }

            if (timerTickCount >= timerTickTarget && control.Background == targetColor) {
                timer.Stop();
                timerTickCount = 0;
                control.Background = naturalColor;
            } else {
                timerTickCount++;
            }
        }

        public void colorTimer(Control control, SolidColorBrush brush, int time) {
            this.control = control;
            naturalColor = (SolidColorBrush)control.Background;
            targetColor = brush;
            timerTickTarget = time;
            timer.Tick += colorTimerTick;
            timer.Start();
        }


        private void exitTimerTick(object sender, EventArgs e) {
            Window window = (Window)control;
            AuthenticationWindow authWindow = new AuthenticationWindow();

            if (timerTickCount == timerTickTarget - 10) {
                authWindow.Show();
            }

            if (timerTickCount >= timerTickTarget) {
                window.Close();
                timer.Stop();
            } else {
                timerTickCount++;
            }
        }

        public void exitTimer(object control, int time) {
            this.control = control;
            timerTickTarget = time;
            timer.Tick += exitTimerTick;
            timer.Start();
        }


        private void popUpWindowTimer(object sender, EventArgs e) {
            Window window = (Window)control;

            if (timerTickCount >= timerTickTarget) {
                window.Close();
                timer.Stop();
            } else {
                timerTickCount++;
            }
        }

        public void popUpWindowTimer(object window, int time) {
            this.control = window;
            timerTickTarget = time;
            timer.Tick += popUpWindowTimer;
            timer.Start();
        }
    }
}
