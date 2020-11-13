using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Retailers
    {
       public int RetailerId { get; }
       
       public int PlatformId { get; }
        
       public string RetailerName { get; }
        
       public int Quantity { get; }
        
       public double Price { get; }
        

       public Retailers(int retailerId, int platformId, string retailerName, int quantity, double price)
        {
            RetailerId = retailerId;
            PlatformId = platformId;
            RetailerName = retailerName;
            Quantity = quantity;
            Price = price;
        } 
    }
}
