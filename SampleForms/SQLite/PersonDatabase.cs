
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace SampleForms
{
	public class PersonDatabase
	{
		readonly SQLiteAsyncConnection database;

		public PersonDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Person>().Wait();
		}

		public Task<List<Person>> GetPersonsAsync()
		{
			return database.Table<Person>().ToListAsync();
		}
 

		public Task<Person> GetPersonAsync(int id)
		{
			return database.Table<Person>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SavePersonAsync(Person item)
		{
			if (item.ID != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeletePersonAsync(Person item)
		{
			return database.DeleteAsync(item);
		}
	}
}
