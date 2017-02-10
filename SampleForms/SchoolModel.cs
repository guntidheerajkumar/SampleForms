
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleForms
{
	public class SchoolModel : INotifyPropertyChanged
	{
		private string _firstName;
		public string FirstName {
			get { return _firstName; }
			set {
				_firstName = value;
				OnPropertyChanged("FirstName");
			}
		}
		
		private string _lastName;
		public string LastName {
			get { return _lastName; }
			set {
				_lastName = value;
				OnPropertyChanged("LastName");
			}
		}
		
		private string _middleName;
		public string MiddleName {
			get { return _middleName; }
			set {
				_middleName = value;
				OnPropertyChanged("MiddleName");
			}
		}
		
		private string _sex;
		public string Sex {
			get { return _sex; }
			set {
				_sex = value;
				OnPropertyChanged("Sex");
			}
		}

		private string _fullName;
		public string FullName {
			get { return _fullName; }
			set {
				_fullName = value;
				_fullName = $"{FirstName} - {MiddleName} - {LastName}";
		    }
		} 

		public SchoolModel()
		{
		
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			if (Object.Equals(storage, value))
				return false;
			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
