using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.ConsoleClientSample
{
    internal class Team
    {
        public double Money { get; set; }
        public int People { get; set; }
        public float Percent { get; set; }
        public string Name { get; set; }

        public double Total { get; private set; } 
        public double Average { get; private set; } 

        public Team(string name, double money, int people)
        {
            Money = money;
            People = people;
            Name = name;
            Total = People * Money;
            Average = Total / People;
        }
    }


}
