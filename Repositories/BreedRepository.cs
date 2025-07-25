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

        public IEnumerable<Breed> GetCategoryName()
        {
            const string sql = @"
            SELECT 
                b.Id,
                b.Name,
                b.CategoryId,
                c.Id,
                c.Name
            FROM Breed b
            INNER JOIN Category c 
                ON b.CategoryId = c.Id";

            return _connection.Query<Breed, Category, Breed>(sql,
            (breed, category) =>
            {
                breed.Category = category;
                return breed;
            }, splitOn: "Id");
        }
    }
}