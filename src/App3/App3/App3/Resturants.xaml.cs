using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public IList<ServiceType> Rests { get; set; }
        
        private IList<ServiceType> _internalRests = new List<ServiceType>(); //Cach the services to use it later in filtering
        public Resturants()
        {
            InitializeComponent();

            Rests = new List<ServiceType>();
            Rests.Add(new ServiceType
            {
                Id = 1,
                Name = "ماكدونالدز",
                Description = "مأكولات سريعة",
                ImageUrl = ImageSource.FromResource("App3.Images.Mac.png"),
                Cateogry = "مطاعم"

            });
            Rests.Add(new ServiceType
            {
                Id = 2,
                Name = "كنتاكي",
                Description = "مأكولات سريعة",
                ImageUrl = ImageSource.FromResource("App3.Images.KFC.png"),
                Cateogry = "مطاعم"


            });
            Rests.Add(new ServiceType
            {
                Id = 3,
                Name = "شيك شاك",
                Description = "مأكولات سريعة",
                ImageUrl = ImageSource.FromResource("App3.Images.shik.png"),
                Cateogry = "مطاعم"


            });
            Rests.Add(new ServiceType
            {
                Id = 4,
                Name = "هايبر بندة",
                Description = "سوبر ماركت",
                ImageUrl = ImageSource.FromResource("App3.Images.Panda.png"),
                Cateogry = "سوبر ماركت"


            });
            Rests.Add(new ServiceType
            {
                Id = 4,
                Name = "النهدي",
                Description = "صيدلية",
                ImageUrl = ImageSource.FromResource("App3.Images.Nahdi.png"),
                Cateogry = "صيدليات"


            });


            _internalRests = Rests;
            BindingContext = this;
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ServiceType selectedItem = e.SelectedItem as ServiceType;
        }

        private async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ServiceType tappedItem = e.Item as ServiceType;
            int restId = tappedItem.Id;
            await App.Current.MainPage.Navigation.PushAsync( new DeliveryPage(restId));
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = pickerCategory.SelectedItem as string;
            if (!string.IsNullOrEmpty(selected))
            {
                Rests = _internalRests.Where(x => x.Cateogry == selected).ToList();
                OnPropertyChanged(nameof(Rests));
            }
        }
    }
}