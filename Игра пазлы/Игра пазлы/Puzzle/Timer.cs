using System;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class Timer
    {
        public string Time {  get; private set; }
        System.Windows.Forms.Timer timer;
        TimeSpan elapsedTime;
        Label time;
        public Timer(Label time) 
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            elapsedTime = new TimeSpan();
            this.time = time;
        }

        public void start() => timer.Start();

        public void stop() => timer.Stop();

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime += TimeSpan.FromSeconds(1);

            Time = elapsedTime.ToString("hh':'mm':'ss");
            time.Text = Time;
        }


    }
}
