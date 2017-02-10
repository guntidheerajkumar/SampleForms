
using System;
using System.Collections.ObjectModel;

namespace SampleForms
{
	public class SchoolViewModel
	{
		public ObservableCollection<SchoolModel> SchoolList {
			get;
			set;
		}

		public SchoolViewModel()
		{
			
		}

		public ObservableCollection<SchoolModel> GetData()
		{
			SchoolList = new ObservableCollection<SchoolModel>();
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			SchoolList.Add(new SchoolModel() { FirstName="Dheeraj",LastName ="Gunti", MiddleName="Kumar", Sex="Male" });
			return SchoolList;
		}
	}
}
