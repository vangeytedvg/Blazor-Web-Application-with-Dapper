using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {

        private readonly ISqlDataAccess _db;
        
        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        // A thread that returns a list<> of PersonModel
        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "select * from People order by LastName";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            // Don't mind the error on emailaddress, it works
            string sql =
                @"insert into People (firstname, lastname, emailaddress) VALUES (@FirstName, @LastName, @EmailAddress)";
            // We don't use await here, execute directly without cluttering the stack
            return _db.SaveData(sql, person);
        }
        
        // Added by me
        public Task DeletePerson(int id)
        {
            // Don't mind the error on emailaddress, it works
            var sql = $"delete People where Id = {id}";
            // We don't use await here, execute directly without cluttering the stack
            return _db.DeletePerson(sql);
        }
    }
}