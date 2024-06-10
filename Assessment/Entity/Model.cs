using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Entity
{
    public class Model
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int StockLevel { get; set; }
        public Model()
        {
            ItemId = 0;
            ItemName = "";
            StockLevel = 0; 
        }
    }
}
