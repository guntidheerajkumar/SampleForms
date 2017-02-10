
using System;
using SQLite;

namespace SampleForms
{
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public int Age { get; set; }
	}
}
