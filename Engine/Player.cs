using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player:Character
    {
        private int currentHP;
        private int maxHP;
        private int gold;
        private int exp;
        private int level;
        private List<Inventory> inventories;
        private List<PlayerQuest> quests;
        private Location currentLocation;

        public Location CurrentLocation { get; set; }
        public List<Inventory> Inventories { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public int Gold
        {
            get;
            set;

        }
        public int Exp
        {
            get;
            set;
        }
        public int Level
        {
            get;
            set;
        }

        public Player(int currentHP, int maxHP, int gold, int exp, int level):base(currentHP,maxHP)
        {
            this.CurrentHP = currentHP;
            this.MaxHP = maxHP;
            this.Gold = gold;
            this.Exp = exp;
            this.Level = level;
            Inventories = new List<Inventory>();
            Quests = new List<PlayerQuest>();
        }
    }
}
