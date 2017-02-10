
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class CollectionPages : ContentPage
	{
		public CollectionPages()
		{
			InitializeComponent();
			Title = "Collection View Sample";
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			CreateGrid();
		}

		private void CreateGrid()
		{
			Random rnd = new Random();
			for (int rowIndex = 0; rowIndex < 100; rowIndex++) {
				for (int columnIndex = 0; columnIndex < 2; columnIndex++) {
					var boxView = new BoxView();
					boxView.HeightRequest = 200;
					boxView.BackgroundColor = Color.FromRgb(244, 10 + rnd.Next(1, 100), 22 + rnd.Next(1, 100));
					SampleGrid.Children.Add(boxView, columnIndex, rowIndex);
				}
			}
		}
	}
}
