
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class PersonPage : ContentPage
	{
		public PersonPage()
		{
			InitializeComponent();
		}
		
		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (this.BindingContext != null) {
				var personItem = (Person)BindingContext;
				this.Title = personItem.Name;
			}
		}

		async void Save_Clicked(object sender, System.EventArgs e)
		{
			var personItem = (Person)BindingContext;
			await App.Database.SavePersonAsync(personItem);
			await Navigation.PopAsync();
		}
	}
}
