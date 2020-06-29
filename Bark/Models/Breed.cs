using System;
using Bark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Bark.Models
{
    public class Breed
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Temperment { get; set; }
        public string Life_Expectancy { get; set; }
        public string Hair_Type { get; set; }
    }
}
