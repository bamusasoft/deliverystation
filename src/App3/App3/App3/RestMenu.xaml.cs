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
    public partial class RestMenu : ContentPage
    {
        public IList<Menu> Menus { get; set; }

        public RestMenu(string restName)
        {
            InitializeComponent();
            if(restName == "كنتاكي")
            {

            }
            Menus = new List<Menu>();
            Menus.Add(new Menu
            {
                Name = "دجاج",
                Price = 10.5,
                ImageUrl = ImageSource.FromResource("App3.Images.KFC.png")

            });
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

        }

        private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}