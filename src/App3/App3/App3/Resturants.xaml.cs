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
                Name = "كنتاكي",
                Description = "مأكولات سريعة",
                //ImageUrl = "App3.Images.KFC.png"
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"

            }) ;
            //Rests.Add(new Resturant
            //{
            //    Name = "ماكدونالدز",
            //    Description = "مأكولات سريعة",
            //    ImageUrl = ImageSource.FromResource("App3.Images.shik.png").ToString()

            //});
            BindingContext = this;
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Resturant selectedItem = e.SelectedItem as Resturant;
        }

        private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Resturant tappedItem = e.Item as Resturant;
        }
    }
}