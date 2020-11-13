using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; }

        public int RetailerId { get; }

        public string Name { get; }

        public string Location { get; }


        public Manufacturer(int manufacturerId, int retailerId, string name, string location)
        {
            ManufacturerId = manufacturerId;
            RetailerId = retailerId;
            Name = name;
            Location = location;
        }
    }
}
