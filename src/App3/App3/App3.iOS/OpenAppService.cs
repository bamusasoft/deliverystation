using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAppService))]
namespace App3.iOS
{
    public class OpenAppService : IOpenAppService
    {
        public Task<bool> Launch(string uri)
        {
			try
			{
				NSUrl request = new NSUrl(uri);
				bool canOpen = UIApplication.SharedApplication.CanOpenUrl(request);

				if(canOpen)
				{
				   bool isOpened = UIApplication.SharedApplication.OpenUrl(new NSUrl(uri));
					if( isOpened == false)
					{
						isOpened = UIApplication.SharedApplication.OpenUrl(new NSUrl(uri));
					}
					return Task.FromResult(true);
				}
				else
				{
					request = new NSUrl("https://apps.apple.com/us/app/uber/id368677368");

					UIApplication.SharedApplication.OpenUrl(request);
					return Task.FromResult(true);
				}

			}
			catch (Exception)
			{

				return Task.FromResult(false);
			}
        }
    }
}