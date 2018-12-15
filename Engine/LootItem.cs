using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class LootItem
    {
        private Items details;
        private int dropPercent;
        private bool isDeafultItem;

        public Items Details { get; set; }
        public int DropPercent { get; set; }
        public bool IsDeafult { get; set; }
        public LootItem(Items details,int dropPercentage,bool isDeafultItem)
        {
            this.Details = details;
            this.DropPercent = dropPercent;
            this.IsDeafult = isDeafultItem;
        }
    }
}
