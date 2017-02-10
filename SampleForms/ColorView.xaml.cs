using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SampleForms
{
	public partial class ColorView : ContentView
	{
		string colorName;
		ColorTypeConverter colorTypeConv = new ColorTypeConverter();

		public ColorView()
		{
			InitializeComponent();
		}

		public string ColorName
		{
			get
			{
				return colorName;
			}
			set
			{
				colorName = value;
				colorNameLabel.Text = value;

				Color color = (Color)colorTypeConv.ConvertFromInvariantString(colorName);
				boxView.Color = color;
				colorValueLabel.Text = string.Format("{0:X2}-{0:X2}-{0:X2}", (int)(255 * color.R), (int)(255 * color.G), (int)(255 * color.B));

			}
		}
	}
}
