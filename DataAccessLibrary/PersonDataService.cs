using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace DataAccessLibrary
{
    public class PersonDataService : IPersonDataService
    {
        // DI
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "sqlserver";

        public PersonDataService(IConfiguration config)
        {
            _config = config;
        }


        /**
         * Get People as a list
         */
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection sqlConnection = new SqlConnection(connectionString))
            {
                var data = await sqlConnection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }

        /**
         * Save the data
         */
        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.ExecuteAsync(sql, parameters);
            }
        }

        /**
         * Own Implementation
         */
        public async Task UpdatePerson<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.ExecuteAsync(sql, parameters);
            }
        }

        /**
         * This took me a while to get this to work.  But ths returns
         * a single person from the database.
         */
        public async Task<PersonModel> GetSinglePerson(int id)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection sqlConnection = new SqlConnection(connectionString))
            {
                return await sqlConnection.QuerySingleAsync<PersonModel>("SELECT * FROM people WHERE Id=@id",
                    new {Id = id});
            }
        }


        /**
         * Own Implentation !
         */
        public async Task DeletePerson(string sql)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.ExecuteAsync(sql);
            }
        }
    }
}