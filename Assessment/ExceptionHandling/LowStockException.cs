using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.ExceptionHandling
{
    public class LowStockException : Exception
    {
        public LowStockException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}
