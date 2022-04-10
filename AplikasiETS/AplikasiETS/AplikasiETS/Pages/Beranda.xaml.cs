using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikasiETS.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Beranda : ContentPage
    {
        public ObservableCollection<Information> Informs { get; set; }
        public Beranda()
        {
            InitializeComponent();

            List<Image> images = new List<Image>()
            {
                new Image(){Title="SpiderMan : HomeComing",Url="spider.jpg"},
                new Image(){Title="Ben 10: The Movie",Url="ben.jpg"},
                new Image(){Title="MORBIUS",Url="mor.jpg"},
            };
            Carousel.ItemsSource = images;

            List<Banner> banners = new List<Banner>()
            {
                new Banner(){Title="Diskon",ImageUrl="banner1.jpg"},
                new Banner(){Title="Diskon1",ImageUrl="banner2.jpg"},
                new Banner(){Title="Diskon",ImageUrl="banner3.jpg"},
            };
            Banner.ItemsSource = banners;

            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                Banner.Position = (Banner.Position + 1) % banners.Count;
                return true;
            }));

            Informs = new ObservableCollection<Information>()
            {
                new Information(){ImageUrl="pic1.jpg",Description="Lorem ipsum, atau ringkasnya lipsum, " +
                "adalah teks standar yang ditempatkan untuk mendemostrasikan elemen grafis atau presentasi" +
                " visual seperti font, tipografi, dan tata letak.", Seen=500, Like=10030,Uploaded="101 hari yang lalu"},
                 new Information(){ImageUrl="pic2.jpg",Description="Lorem ipsum, atau ringkasnya lipsum, " +
                "adalah teks standar yang ditempatkan untuk mendemostrasikan elemen grafis atau presentasi" +
                " visual seperti font, tipografi, dan tata letak.", Seen=5020, Like=10300,Uploaded="13 hari yang lalu"},
                 new Information(){ImageUrl="pic3.jpg",Description="Lorem ipsum, atau ringkasnya lipsum, " +
                "adalah teks standar yang ditempatkan untuk mendemostrasikan elemen grafis atau presentasi" +
                " visual seperti font, tipografi, dan tata letak.", Seen=5200, Like=10300,Uploaded="1 hari yang lalu"},
                 new Information(){ImageUrl="pic1.jpg",Description="Lorem ipsum, atau ringkasnya lipsum, " +
                "adalah teks standar yang ditempatkan untuk mendemostrasikan elemen grafis atau presentasi" +
                " visual seperti font, tipografi, dan tata letak.", Seen=1500, Like=10300,Uploaded="5 hari yang lalu"},
                 new Information(){ImageUrl="pic2.jpg",Description="Lorem ipsum, atau ringkasnya lipsum, " +
                "adalah teks standar yang ditempatkan untuk mendemostrasikan elemen grafis atau presentasi" +
                " visual seperti font, tipografi, dan tata letak.", Seen=5500, Like=21000,Uploaded="15 hari yang lalu"},
                new Information(){ImageUrl="pic3.jpg",Description="Lorem ipsum, atau ringkasnya lipsum, " +
                "adalah teks standar yang ditempatkan untuk mendemostrasikan elemen grafis atau presentasi" +
                " visual seperti font, tipografi, dan tata letak.", Seen=3500, Like=11000,Uploaded="5 hari yang lalu"},

            };
                InfoListView.ItemsSource=Informs;

        }
        
        private async void ImgList_Tapped(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new ListFilm());
        }

        private void InforList_Tapped(object sender, EventArgs e)
        {

        }
    }
}