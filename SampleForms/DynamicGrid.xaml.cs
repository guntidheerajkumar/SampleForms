
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class DynamicGrid : ContentPage
	{
		public DynamicGrid()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			MessagingCenter.Send<DynamicGrid, string>(this, "Welcome to Message Center", null);
			var tapGesture = new TapGestureRecognizer();
			tapGesture.Tapped += (sender, e) => {
				MessagingCenter.Subscribe<DynamicGrid, string>(this, "Hi", (arg1, arg2) => {
					DisplayAlert("Message Center", arg2, "Ok");
				});
			};
			for (int rowIndex = 0; rowIndex < 10; rowIndex++) {
				for (int columnIndex = 0; columnIndex < 2; columnIndex++) {
					var box = new BoxView() { BackgroundColor = Color.FromRgb(0, 0, 0), HeightRequest = 200 };
					box.GestureRecognizers.Add(tapGesture);
					myGrid.Children.Add(box, columnIndex, rowIndex);
				}
			}
		}
	}
}
