using System;

using Xamarin.Forms;

namespace SampleForms
{
	public class ColorView : ContentView
	{
		string colorName;
		ColorTypeConverter colorTypeConv = new ColorTypeConverter();

		public ColorView()
		{
			
		}

		public string ColorName
		{
			get {
				return colorName;
			}
			set
			{
				colorName = value;

			}
		}
	}
}

