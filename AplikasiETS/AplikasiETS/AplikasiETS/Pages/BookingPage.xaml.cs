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
    public partial class BookingPage : ContentPage
    {
        private int ticketPrice;
        private Film film;
        public BookingPage(Film film)
        {
            InitializeComponent();
            //LblMovieName.Text = film.Title;
            //LblGenre.Text = film.Genre;
            //LblRating.Text = film.Rating.ToString();
            //ImgMovie.Source = film.ImageUrl;
            //LblDuration.Text = film.Duration;
            
            SpanTotalPrice.Text = SpanPrice.Text = "20000";
            ticketPrice = Convert.ToInt16(20000);
        }

        private async void ImgBack_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void PickerQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qty = PickerQty.Items[PickerQty.SelectedIndex];
            SpanQty.Text = qty;
            int totalPrice = Convert.ToInt16(SpanQty.Text) * ticketPrice;
            SpanTotalPrice.Text = totalPrice.ToString();
        }
        private void ImgReserve_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("", "Your Ticket has been reserved", "Alright");
            EntPhone.Text = String.Empty;
            PickerQty.SelectedIndex = 0;

        }
    }
}