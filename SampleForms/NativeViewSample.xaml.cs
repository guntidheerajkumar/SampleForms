//
// NativeViewSample.xaml.cs
//
// Author: Dheeraj Kumar Gunti <dheeraj.gunti@neudesic.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleForms
{
	public partial class NativeViewSample : ContentPage
	{
		public NativeViewSample()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

#if __IOS__
        var wrapper = (Xamarin.Forms.Platform.iOS.NativeViewWrapper)contentViewButtonParent.Content;
        var field = (UIKit.UITextField)wrapper.NativeView;
       field.BorderStyle = UITextBorderStyle.RoundedRect;
#endif
		}
	}
}
