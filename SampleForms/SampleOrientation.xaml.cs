
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class SampleOrientation : ContentPage
	{
		private SchoolViewModel viewModel = new SchoolViewModel();
		public SampleOrientation()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			var a = viewModel.GetData();
			listView.ItemsSource = a;
		}


		void Handle_SizeChanged(object sender, System.EventArgs e)
		{
			if (Width < Height) {
				mainGrid.ColumnDefinitions[0].Width = new GridLength(1, GridUnitType.Star);
				mainGrid.ColumnDefinitions[1].Width = new GridLength(0);
				mainGrid.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
				mainGrid.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
				Grid.SetRow(detailLayout, 1);
				Grid.SetColumn(detailLayout, 0);
			} else {
				mainGrid.ColumnDefinitions[0].Width = new GridLength(1, GridUnitType.Star);
				mainGrid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
				mainGrid.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
				mainGrid.RowDefinitions[1].Height = new GridLength(0);
				Grid.SetRow(detailLayout, 0);
				Grid.SetColumn(detailLayout, 1);
			}
		}
	}
}
