using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inventory
    {
        private Items details;
        private int qunatity;
        public Items Details { get; set; }
        public int Quantity { get; set; }
        public Inventory(Items details,int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
