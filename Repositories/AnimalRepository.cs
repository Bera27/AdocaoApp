using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AdocaoApp.Repositories
{
    public class AnimalRepository
    {
        private readonly SqlConnection _connection;

        public AnimalRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<Animal> GetBreedAndDonorName()
        {
            const string sql = @"
                    SELECT
                        a.Id,
                        a.BreedId,
                        a.DonorId,
                        a.AgeMonths,
                        a.AdmissionDate,
                        b.Name AS BreedName,
                        b.CategoryId AS BreedCategoryId,
                        c.Name AS CategoryName,
                        d.Name AS DonorName,
                        d.Phone AS DonorPhone
                    FROM Animal a
                    INNER JOIN Breed b ON a.BreedId = b.Id
                    INNER JOIN Category c ON b.CategoryId = c.Id
                    INNER JOIN Donor d ON a.DonorId = d.Id;";

            return _connection.Query<Animal>(sql);
        }
    }
}