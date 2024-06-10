using Assessment.Inventory_Manager;
using Assessment.Invnetory;
using System;

class Program
{
    static void Main(string[] args)
    {
        var inventoryItem = new InventoryItem<object>();
        var inventoryManager = new InventoryManager();
        do
        {
            Console.Write("Enter Stock Number: ");
            inventoryManager.AddInventoryItem(inventoryItem, int.Parse(Console.ReadKey().KeyChar.ToString()));

            Console.Write("Press Y to enter another person, other key to finish.");
        } while (Console.ReadKey().Key == ConsoleKey.Y);

        var stockLevel = inventoryItem.StockLevel;

        var order = new Order()
        {
            Id=1,
            TotalCost =0,
            items =new List<InventoryItem<object>>
            {
                new InventoryItem<object>
                {
                    Data="Data",
                    ItemId=1,
                    ItemName="Item Order",
                    StockLevel = 3
                },
                 new InventoryItem<object>
                {
                    Data="Data",
                    ItemId=2,
                    ItemName="Item Order",
                    StockLevel = 4
                }
            }
        };

        inventoryManager.ProcessOrder(order);
        Console.WriteLine("Stock Level is {0}: ", stockLevel);


        Console.ReadLine();
    }
}
