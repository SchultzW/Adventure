using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        private Quest details;
        private bool isComplete;
        public Quest Details { get; set; }
        public bool IsComplete { get; set; }
        public PlayerQuest(Quest details)
        {
            this.Details = details;
            IsComplete = false;
        }
    }
}
