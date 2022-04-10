using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikasiETS.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListFilm : ContentPage
    {
        public ObservableCollection<Film> Films { get; set; }
        public ListFilm()
        {
            InitializeComponent();
            Films = new ObservableCollection<Film>()
            {
                new Film() {FilmID=1, Title = "SpiderMan : HomeComing",Year="2021", Price=20000, ImageUrl="spider.jpg",Rating="9.5",Duration="2h 30m",
                    Description="Identitas Spider-Man sekarang sudah terungkap, dan Peter meminta bantuan Doctor Strange." +
                    " namun sebuah kesalahan terjadi, dan itu justru mengundang musuh berbahaya dari dunia lain, mereka mulai bermunculan. " +
                    "Hal itu memaksa Peter mencari apa makna sebenarnya menjadi Spider-Man.",VideoUrl="https://youtu.be/JfVOs4VSpmA"
                    ,PlayDate="14 Desember 2021", PlayingTime="8.30", Genre="Action/Science Fiction"},
                new Film() {FilmID=2,Title = "Sonic the Hedgehog 2",Year="2022", Price=20000, ImageUrl="sonic.jpg",Rating="8.5",Duration="1h 30m",
                    Description="Dr. Robotnik kembali ke bumi dengan sekutu baru, Knuckles. Sonic dan teman barunya " +
                    "Tails akan berjuang melawan mereka.",VideoUrl="https://youtu.be/47r8FXYZWNU" ,PlayDate="20 November 2022", PlayingTime="8.30",
                    Genre="Adventure/Science Fiction"},
                new Film() {FilmID=3,Title = "Ben 10: The Movie",Year="2022", Price=20000, ImageUrl="ben.jpg",Rating="8.9",Duration="2h 22m",
                    Description="ISetelah musim panas penuh aksi, Ben harus menyesuaikan diri dengan kehidupan kota kelahirannya yang tenang. " +
                    "Tapi ketika alien jahat menyerang, ia harus berdiri dan menjadi seorang pahlawan sejati.",VideoUrl="https://youtu.be/JsnzZF0_13I"
                    ,PlayDate="14 November 2022", PlayingTime="10.30", Genre="Advanture/Science Fiction"},
                new Film() {FilmID=4,Title = "MORBIUS",Year="2022", Price=20000, ImageUrl="mor.jpg",Rating="9.2",Duration="1h 45m",
                    Description="Ahli biokimia Michael Morbius (Jared Leto) mencoba menyembuhkan dirinya sendiri dari penyakit darah langka, " +
                    "namun secara tidak sengaja ia menginfeksi tubuhnya dan berubah jadi mahluk yang menyerupai vampir.",VideoUrl="https://youtu.be/oZ6iiRrz1SY"
                    ,PlayDate="15 Maret 2022", PlayingTime="15.30",Genre="Action/Science Fiction"},
                new Film() {FilmID=5,Title = "Doctor Strange in the Multiverse of Madness ",Year="2022", Price=20000, ImageUrl="dr.jpg",Rating="9.9",Duration="3h 30m",
                    Description="Doctor Strange in the Multiverse of Madness adalah film superhero Amerika yang akan datang " +
                    "berdasarkan karakter Marvel Comics Doctor Strange.",VideoUrl="https://youtu.be/aWzlQ2N6qqg" ,PlayDate="20 Oktober 2022", PlayingTime="11.30", Genre="Action/Science Fiction"}
                
            };
            FilmListView.ItemsSource = Films;
        }

        private async void ImgBack_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void FilmListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item == null)
            {
                return;
            }
            await Navigation.PushModalAsync(new FilmDetail(e.Item as Film));
        }
    }
}