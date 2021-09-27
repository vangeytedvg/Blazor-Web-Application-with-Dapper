using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Models;

//using Microsoft.Data.Sqlite;
//using Microsoft.Data.Sqlite;
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

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }
        
        /**
         * Save the data
         */
        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
        
        /**
         * Own Implementation
         */
        public async Task UpdatePerson<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<PersonModel> GetSinglePerson(string sql)
        {string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var person = await connection.QuerySingleAsync(sql);
                var pModel = new PersonModel();
                pModel.Id = person.Id;
                pModel.FirstName = person.FirstName;
                pModel.LastName = person.LastName;
                pModel.EmailAddress = person.EmailAddress;
                return pModel;

            }
            throw new NotImplementedException();
        }

        /**
         * Own Implentation !
         */
        public async Task DeletePerson(string sql)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql);
            }
        }
    }
}