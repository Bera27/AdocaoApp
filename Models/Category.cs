using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace AdocaoApp.Models
{
    [Table("[Category]")]
    public class Category
    {
        public Category()
        {
            Breeds = new List<Breed>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Write(false)]
        public List<Breed> Breeds { get; set; }
    }
}