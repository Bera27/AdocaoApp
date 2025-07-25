using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace AdocaoApp.Models
{
    [Table("[Breed]")]
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }


        [Write(false)]
        public Category Category { get; set; }
    }
}