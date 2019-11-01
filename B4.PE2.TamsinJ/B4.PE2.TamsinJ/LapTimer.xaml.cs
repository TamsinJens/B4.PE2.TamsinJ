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
    public partial class LapTimer : ContentPage
    {
        public LapTimer()
        {
            InitializeComponent();
        }

        public async void btnStart_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Feedback());
        }

        public async void btnLap_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Feedback());
        }

        public async void btnStop_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Feedback());
        }
    }
}