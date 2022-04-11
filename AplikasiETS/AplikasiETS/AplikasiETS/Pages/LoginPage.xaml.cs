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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void ImgBack_Tapped(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new SignupPage());
            await Shell.Current.GoToAsync("//login/registration");
        }

        private async void ImgLogin_Tapped(object sender, EventArgs e)
        {
            if(EntEmail.Text == "labib")
            {
                //await Navigation.PushModalAsync(new Navigator());
                //Application.Current.MainPage = new NavigationPage(new Navigator());
                await Shell.Current.GoToAsync("//main");
            }
            else
            {
                await DisplayAlert("Oops", "Something went wrong", "Cancel");
            }
        }
    }
}