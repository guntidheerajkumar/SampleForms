
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class PersonListPage : ContentPage
	{
		public PersonListPage()
		{
			InitializeComponent();

			var toolbarItem = new ToolbarItem {
				Text = "+"
			};

			toolbarItem.Clicked += async (sender, e) => {
				await Navigation.PushAsync(new PersonPage() { BindingContext = new Person() });
			};

			ToolbarItems.Add(toolbarItem);
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			PersonListView.ItemsSource = await App.Database.GetPersonsAsync();
		}

		async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null) {
				await Navigation.PushAsync(new PersonPage() { BindingContext = e.SelectedItem as Person });
			}
		}
	}
}
