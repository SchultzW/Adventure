using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {

        private int id;
        private string name;
        private string description;
        private int rewardXP;
        private int rewardGold;
        private Items rewardItem;
        private List<QuestCompletionItem> questCompletionItems;


        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public Items RewardItem { get; set; }

        public Quest(int id,string name,string description, int rewardXP,int rewardGold, Items rewardItem=null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.RewardXP = rewardXP;
            this.RewardGold = rewardGold;
            this.RewardItem = rewardItem;

            QuestCompletionItems = new List<QuestCompletionItem>();
        }



    }
}
