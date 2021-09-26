using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISqlDataAccess
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

        Task DeletePerson(string sql);
    }
}