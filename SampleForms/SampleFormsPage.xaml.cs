using System;
using Xamarin.Forms;

#if __IOS__
using UIKit;
#elif __ANDROID__
using Android.OS;
#elif WINDOWS_APP || WINDOWS_PHONE_APP || WINDOWS_UWP
using Windows.Security.ExchangeActiveSyncProvisioning;
#endif

namespace SampleForms
{
	public partial class SampleFormsPage : ContentPage
	{
		public SampleFormsPage()
		{
			InitializeComponent();

#if __IOS__
		 UIDevice device = new UIDevice();
		 modelLabel.Text = device.Model.ToString();
		 versionLabel.Text = String.Format("{0} {1}", device.SystemName,
			device.SystemVersion);
#endif

			//TapGestureRecognizer gesture = new TapGestureRecognizer();
			//gesture.Tapped += (sender, e) =>
			//{
			//	DisplayAlert("Sample", "Clicked", "Ok");
			//};
			//box.GestureRecognizers.Add(gesture);

			//Device.StartTimer(TimeSpan.FromSeconds(1), HandleFunc);

		}

		//bool HandleFunc()
		//{
		//	DateTime dt = DateTime.Now;
		//	DateLabel.Text = dt.ToString("R");
		//	return true;
		//}

		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine(switchbtn.IsToggled);
		}
	}
}
