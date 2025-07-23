using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AdocaoApp.Repositories
{
    public class BreedRepository
    {
        private readonly SqlConnection _connection;

        public BreedRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<Breed> GetByCategoryName(string categoryName)
        {
            const string sql = @"
            SELECT 
                b.Id,
                b.Name,
                b.CategoryId
            FROM Breed b
            INNER JOIN Category c 
                ON b.CategoryId = c.Id
            WHERE c.Name = @Name;";

            return _connection.Query<Breed>(sql, new { Name = categoryName });
        }
    }
}