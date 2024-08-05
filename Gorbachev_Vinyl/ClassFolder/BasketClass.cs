using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorbachev_Vinyl.ClassFolder
{
     public class BasketItem
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Format { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
