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
    public partial class Feedback : ContentPage
    {
        public Feedback()
        {
            InitializeComponent();
        }

        public async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            if (SubmitControl())
            {
                //email form
                await DisplayAlert("Succes", "Your form was succesfully sent to us.", "ok.");
            }
            else
            {
                await DisplayAlert("Oops", "You didn't fill in the form properly. Check the form and change where necessary." , "Return");
            }
        }

        public bool SubmitControl()
        {
            if(inputNaam.Text.Length > 0)
            {
                if(inputVoornaam.Text.Length > 0)
                {
                    if(inputemail.Text.Length > 0) //betere controle nodig
                    {
                        if(inputtel.Text.Length == 10)
                        {
                            if(inputdate != null)
                            {
                                if(picker != null)
                                {
                                    if(inputbericht.Text.Length > 0)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}