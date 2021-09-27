using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {

        private readonly IPersonDataService _db;

        public PeopleData(IPersonDataService db)
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

        public Task UpdatePerson(PersonModel person)
        {
            string sql =
                @"UPDATE People SET firstname = @FirstName, lastname=@LastName, emailaddress=@EmailAddress WHERE id=@Id";
            // We don't use await here, execute directly without cluttering the stack
            return _db.UpdatePerson(sql, person);
        }

        public Task<PersonModel> GetSinglePerson(int id)
        {
            string sql = $"SELECT * FROM People WHERE id={id}";
            return _db.GetSinglePerson(sql);
        }
    }
}
