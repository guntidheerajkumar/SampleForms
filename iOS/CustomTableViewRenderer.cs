//
// TableViewRenderer.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using CoreGraphics;
using SampleForms.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(ListView), typeof(CustomTableViewRenderer))]
namespace SampleForms.iOS
{
	public class CustomTableViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);

			if (Control != null) {
				Control.TableFooterView = new UIView();
			}
		}
	}
}
