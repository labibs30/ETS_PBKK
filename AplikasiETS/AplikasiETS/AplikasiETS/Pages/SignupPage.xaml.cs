using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikasiETS.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void ImgSignup_Tapped(object sender, EventArgs e)
        {
            if(EntName.Text == "labib")
            {
                await DisplayAlert("Hi", "Your account has been created", "Alright");
                await Navigation.PushModalAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Oops", "Something went wrong", "Cancel");
            }
        }

        private async void LblLogin_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}