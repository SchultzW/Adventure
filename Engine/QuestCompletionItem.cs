using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestCompletionItem
    {
        private Items details;
        private int quantity;
        public Items Details { get; set; }
        public int Quantity { get; set; }
        public QuestCompletionItem(Items details, int quantity)
        {
            this.Quantity = quantity;
            this.Details = details;
        }
    }
}
