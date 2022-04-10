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
    
    public partial class ProductListPage : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }
        public ProductListPage()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>
            {
                new Product{Name ="Spiderman",Price=20},
                new Product{Name ="Spiderman and Batman",Price=20},
                new Product{Name ="Spiderman tuja mila",Price=40},
                new Product{Name ="Spiderman loho",Price=20}
            };
            ProductListView.ItemsSource = Products;
        }
    }
}