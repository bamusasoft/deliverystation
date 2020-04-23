using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App3.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAppService))]
namespace App3.Droid
{

    public class OpenAppService : Activity, IOpenAppService
    {
		public Task<bool> Launch(string uri)
        {
			try
			{
				Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage(uri);
				if(intent != null)
				{
					intent.AddFlags(ActivityFlags.NewTask);
					Forms.Context.StartActivity(intent);
					
					
				}
				else
				{
					intent = new Intent(Intent.ActionView);
					intent.AddFlags(ActivityFlags.NewTask);
					intent.SetData(Android.Net.Uri.Parse("market://details?id=" + uri));
					//intent.SetData(Android.Net.Uri.Parse("market://details?id=com.udemy.android"));

					Forms.Context.StartActivity(intent);
				}
				return Task.FromResult(true);


			}
			catch( Exception ex)
			{

			}
			return Task.FromResult(false);
			
        }
    }
}