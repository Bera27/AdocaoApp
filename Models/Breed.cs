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
        public Category CategoryId { get; set; }
        public string Name { get; set; }
    }
}