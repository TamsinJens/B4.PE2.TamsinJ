using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE2.TamsinJ
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnGoToLapTimer_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
        public async void btnGoToTimeConversions_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
        public async void btnGiveFeedback_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
    }
}
