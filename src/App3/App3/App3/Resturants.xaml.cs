using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resturants : ContentPage
    {
        public IList<Resturant> Rests { get; set; }
        public Resturants()
        {
            InitializeComponent();

            Rests = new List<Resturant>();
            Rests.Add(new Resturant
            {
                Id = 1,
                Name = "ماكدونالدز",
                Description = "مأكولات سريعة",
                ImageUrl = ImageSource.FromResource("App3.Images.Mac.png")

            });
            Rests.Add(new Resturant
            {
                Id = 2,
                Name = "كنتاكي",
                Description = "مأكولات سريعة",
                ImageUrl = ImageSource.FromResource("App3.Images.KFC.png")

            });
            Rests.Add(new Resturant
            {
                Id = 3,
                Name = "شيك شاك",
                Description = "مأكولات سريعة",
                ImageUrl = ImageSource.FromResource("App3.Images.shik.png")

            });
            BindingContext = this;
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Resturant selectedItem = e.SelectedItem as Resturant;
        }

        private async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Resturant tappedItem = e.Item as Resturant;
            int restId = tappedItem.Id;
            await App.Current.MainPage.Navigation.PushAsync( new DeliveryPage(restId));
        }
    }
}