using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeliveryPage : ContentPage
    {
        public IList<DeliveryCompany> DeliveryCompanies { get; private set; }
        public DeliveryPage(int resutrantId)
        {
            InitializeComponent();
            DeliveryCompanies = new List<DeliveryCompany>();
            DeliveryCompanies.Add(new DeliveryCompany
            {
                Id = 1,
                Name = "هنقرستيشن",
                Price = "سعر التوصيل: " + "20 - 25",
                DeliveryTime = "وقت التوصيل: " + "40-45",
                ImageUrl = ImageSource.FromResource("App3.Images.Hunger.png")


            });
            DeliveryCompanies.Add(new DeliveryCompany
            {
                Id = 2,
                Name = "وصل",
                Price = "سعر التوصيل: " + "22 - 25",
                DeliveryTime = "وقت التوصيل: " + "50-55",
                ImageUrl = ImageSource.FromResource("App3.Images.Wassel.png")


            });
            DeliveryCompanies.Add(new DeliveryCompany
            {
                Id = 3,
                Name = "اوبر ايتس",
                Price = "سعر التوصيل: " + "27 - 30",
                DeliveryTime = "وقت التوصيل: " + "30-35",
                ImageUrl = ImageSource.FromResource("App3.Images.Uber.png")


            });
            BindingContext = this;

        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var supportUri = await Launcher.CanOpenAsync("photos.app.goo.gl://");
            //if (supportUri)
            //{
            //await Launcher.OpenAsync(new Uri("uber://"));
            //await Launcher.OpenAsync(new Uri("https://play.google.com/store/apps/details?id=com.whatsapp"));

           //}
        }

        private async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                DeliveryCompany tappedItem = e.Item as DeliveryCompany;
                int companyId = tappedItem.Id;
                //await Launcher.OpenAsync(new Uri("twitter://compose?text=Hello"));
                string platform = Device.RuntimePlatform;
                if (platform == "iOS")
                {
                    await DependencyService.Get<IOpenAppService>().Launch("maps://");
                }
                else
                {
                    if(companyId == 1)//Open Hunger
                    {
                        await DependencyService.Get<IOpenAppService>().Launch("com.hungerstation.android.web");
                    }
                    else if(companyId == 2) //Open Wassel
                    {
                        await DependencyService.Get<IOpenAppService>().Launch("com.w99l.customer.app");
                    }
                    else if (companyId == 2) //Open Uber eats
                    {
                        await DependencyService.Get<IOpenAppService>().Launch("com.ubercab.eats");
                    }

                }

            }
            catch (Exception ex)
            {

                await DisplayAlert("D", ex.Message, "Ok");
            }
        }
    }
}