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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        

        private async void OnOpenServiceClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync( new Resturants());
        }
    }
}