using Assessment.Invnetory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Inventory_Manager
{
    public class Order
    {
        public int Id { get; set; }
        public List<InventoryItem<object>> items { get; set; }
        public int TotalCost { get; set; }
    }
}
