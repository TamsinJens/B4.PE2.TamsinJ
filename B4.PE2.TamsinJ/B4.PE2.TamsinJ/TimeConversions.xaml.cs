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
        ConversionService cs = new ConversionService();
        public TimeConversions()
        {
            InitializeComponent();
        }
        private async void btnHoursToDays_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Result", $"{HoursToDays.Text} hours = {cs.HoursToDays(Int32.Parse(HoursToDays.Text))} days.", "ok");
        }

        private async void btnDaysToHours_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Result", $"{DaysToHours.Text} Days = {cs.DaysToHours(Int32.Parse(DaysToHours.Text))} hours.", "ok");
        }

        private async void btnMinutesToHours_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Result", $"{DaysToHours.Text} Days = {cs.DaysToHours(Int32.Parse(DaysToHours.Text))} hours.", "ok");
            cs.MinutesToHours(Int32.Parse(MinutesToHours.Text));
        }

        private async void btnHoursToMinutes_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Result", $"{HoursToMinutes.Text} Days = {cs.HoursToMinutes(Int32.Parse(HoursToMinutes.Text))} hours.", "ok");
        }

        private async void btnSecondsToMinutes_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Result", $"{SecondsToMinutes.Text} Days = {cs.SecondsToMinutes(Int32.Parse(SecondsToMinutes.Text))} hours.", "ok");
        }

        private async void btnMinutesToSeconds_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Result", $"{MinutesToSeconds.Text} Days = {cs.MinutesToSeconds(Int32.Parse(MinutesToSeconds.Text))} hours.", "ok");
        }
    }
}