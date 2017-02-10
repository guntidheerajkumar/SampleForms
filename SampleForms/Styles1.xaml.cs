
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class Styles1 : ContentPage
	{
		public Styles1()
		{
			InitializeComponent();
		}
		
		protected override void OnAppearing()
		{
			base.OnAppearing();

			var a = Resources;
			Resources["kkk"] = Resources["ABC"];
			
		}
	}
}
