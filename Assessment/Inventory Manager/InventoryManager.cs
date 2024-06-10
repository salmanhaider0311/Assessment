using Assessment.Invnetory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Inventory_Manager
{
    
    public class InventoryManager
    {
        public delegate void StockChangeHandler(InventoryItem<object> item, int changeAmount);
        public static event StockChangeHandler StockChange;

        private List<InventoryItem<object>> _items;
       public void AddInventoryItem(InventoryItem<object> inventoryItem, int quantity)
        {
            inventoryItem.AddStock(quantity);
        }

        public void ProcessOrder(Order order)
        {
            var inventoryItem = new InventoryItem<object>()
            {
                Data = "Any Type",
                ItemId = 1,
                ItemName="Item",
                StockLevel=2
            };
            StockChange += (item, count) =>
            {
                item = new InventoryItem<object>();
                Console.WriteLine("Item added");
                AddInventoryItem(item, count);
                
            };
            StockChange.Invoke(inventoryItem, 2);

            _items = order.items;


            //Parallel.Invoke(
            //() =>
            //{
            //    StockLevelChanged(inventoryItem, 2);
            //},
            //()=>
            //{
            //    StockLevelChanged(inventoryItem, 3);
            //}
            //);
        }
        static void StockLevelChanged(InventoryItem<object> inventoryItem, int quantity)
        {

            var Order = new Order();
            inventoryItem.RemoveStock(quantity);
            Order.TotalCost -= 1;
        }
    }
}
