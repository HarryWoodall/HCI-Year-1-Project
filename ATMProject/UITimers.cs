using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace ATMProject {

    class UITimers {

        private DispatcherTimer timer = new DispatcherTimer();
        private int timerTickCount;
        private int timerTickTarget;
        private Control control;

        private SolidColorBrush targetColor;
        private SolidColorBrush naturalColor;


        public UITimers() {
            timer.Tick += colorTimerTick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
        }

        private void colorTimerTick(object sender, EventArgs e) {
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
            timer.Start();
        }
    }
}
