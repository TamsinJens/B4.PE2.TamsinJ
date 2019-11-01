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
        public LapTimer()
        {
            InitializeComponent();
        }

        public void BtnStart_Clicked(object sender, EventArgs e)
        {
            btnLap.IsEnabled = true;
            btnStop.IsEnabled = true;
            btnStart.IsEnabled = false;

            stopWatch.Start();
            

        }

        public void BtnLap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Feedback());
        }

        public void BtnStop_Clicked(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            stopWatch.Stop();
            string elapsedTime = ts.ToString();

            lblTime.Text = elapsedTime;
        }
    }
}