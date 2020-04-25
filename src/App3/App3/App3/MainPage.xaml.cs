using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassword.Text == "0000")
            {
                //App.Current.MainPage = new HomePage();
                await App.Current.MainPage.Navigation.PushAsync(new Resturants());
            }
        }
    }
}
