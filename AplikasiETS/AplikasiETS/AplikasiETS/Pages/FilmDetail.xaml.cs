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
    public partial class FilmDetail : ContentPage
    {
        private Film film;
        public FilmDetail(Film film)
        {
            InitializeComponent();
            ImgMovie.Source = film.ImageUrl;
            LblDescription.Text = film.Description;
            LblRating.Text = film.Rating;
            LblhargaTiket.Text = film.Price.ToString();
            LblMovieName.Text = film.Title;
            LblPlayingTime.Text = film.Duration.ToString();
            ImgMovieCover.Source = film.ImageUrl;
            LblPlayingDate.Text = film.PlayDate;
            LblGenre.Text = film.Genre;

        }

        private async void ImgBack_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void ImgBookTicket_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BookingPage(film));
        }
    }
}