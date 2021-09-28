using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IPersonDataService
    {
        string ConnectionStringName { get; set; }

        /**
         * Get the data from the database 
         */
        Task<List<T>> LoadData<T, U>(string sql, U parameters);

        /**
         * Save the data
         */
        Task SaveData<T>(string sql, T parameters);

        // Own Implementation
        Task DeletePerson(string sql);
        Task UpdatePerson<T>(string sql, T parameters);
        Task<PersonModel> GetSinglePerson(int id);
    }
}