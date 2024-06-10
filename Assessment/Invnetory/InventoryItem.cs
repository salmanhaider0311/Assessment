using Assessment.Entity;
using Assessment.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Invnetory
{
    public class InventoryItem<T>
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int StockLevel { get; set; }
        public T Data { get; set; }


        public void AddStock(int quantity)
        {   
            StockLevel += quantity;
        }

        public void RemoveStock(int quantity)
        {
            if (quantity > StockLevel)
            {
                throw new LowStockException("Insufficient stock for item");
            }
            StockLevel -= quantity;
        }

    }
}
