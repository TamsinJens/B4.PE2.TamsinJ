using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE2.TamsinJ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeConversions : ContentPage
    {
        public TimeConversions()
        {
            InitializeComponent();
        }
        private async void btnHoursToDays_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer());
        }

        private async void btnDaysToHours_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer());
        }

        private async void btnMinutesToHours_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer());
        }

        private async void btnHoursToMinutes_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer());
        }

        private async void btnSecondsToMinutes_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer());
        }

        private async void btnMinutesToSeconds_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer());
        }
    }
}