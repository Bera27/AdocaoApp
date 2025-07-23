using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace AdocaoApp.Models
{
    [Table("[Animal]")]
    public class Animal
    {
        public int Id { get; set; }
        public int BreedId { get; set; }
        public int DonorId { get; set; }
        public int AgeMonths { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}