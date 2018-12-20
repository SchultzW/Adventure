using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : Character
    {
        private int id;
        private string name;
        private int maxDmg;
        private int rewardEXP;
        private int rewardGold;

        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public int MaxDMG
        {
            get; set;
        }
        public int RewardEXP
        {
            get; set;
        }
        public int RewardGold
        {
            get; set;
        }
        public List<LootItem> LootTable { get; set; }


        public Monster(int id, string name, int currentHP, int maxHP, int maxDmg, int rewardExp, int rewardGold) : base(currentHP, maxHP)
        {
            this.ID = id;
            this.Name = name;
            this.MaxDMG = maxDmg;
            this.RewardEXP = rewardEXP;
            this.RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }


    }
}
