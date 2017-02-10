using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

using System.Runtime.CompilerServices;

namespace SampleForms
{
	public partial class MyPage : ContentPage, INotifyPropertyChanged
	{
		private bool isLoading;
		public bool IsLoading
		{
			get
			{
				return this.isLoading;
			}

			set
			{
				this.isLoading = value;
				RaisePropertyChanged("IsLoading");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged(string propName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}

		public MyPage()
		{
			InitializeComponent();
			IsLoading = false;
			BindingContext = this;
		}
		
		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			IsLoading = true;
			Device.StartTimer(TimeSpan.FromSeconds(10), () => IsLoading = false);
		} 
	}
}
