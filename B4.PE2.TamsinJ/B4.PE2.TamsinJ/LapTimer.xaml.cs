using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE2.TamsinJ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LapTimer : ContentPage
    {
        Stopwatch stopWatch = new Stopwatch();
        int amountOfLaps = 0;
        public LapTimer()
        {
            InitializeComponent();
        }

        public async void BtnStart_Clicked(object sender, EventArgs e)
        {
            btnLap.IsEnabled = true;
            btnStop.IsEnabled = true;
            btnStart.IsEnabled = false;
            amountOfLaps++;

            stopWatch.Restart();
            while (stopWatch.IsRunning)
            {
                lblTime.Text = stopWatch.Elapsed.ToString();
                await Task.Delay(1);
            }

        }

        public void BtnLap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Feedback());
        }

        public async void BtnStop_Clicked(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            lblTime.Text = ts.ToString();
            stopWatch.Stop();
            btnStart.IsEnabled = true;
            btnLap.IsEnabled = false;
            btnStop.IsEnabled = false;
            int elapsedTime = Int32.Parse((ts.Hours * 3600 + ts.Minutes * 60 + ts.Seconds).ToString());

            int averageTime = elapsedTime / amountOfLaps;
            int averageHours = averageTime / 3600;
            int averageMinutes = (averageTime - averageHours * 3600) / 60;
            int averageSeconds = (averageTime - averageHours * 3600) - averageMinutes * 60;
            string averageTimeString = $"{averageHours.ToString()}:{averageMinutes.ToString()}:{averageSeconds.ToString()}";
            await DisplayAlert("Results", $"Amount of laps: {amountOfLaps} \nTotal time: {ts.ToString()} \nAverage time: {averageTimeString}", "Ok");
        }
    }
}