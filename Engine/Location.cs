using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        #region properties and setters/getters
        private int id;
        private string name;
        private string description;
        public int ID
        {
            get;
            set;
         }
        public string Name
        {
            get;
            set;

        }
        public string Description
        {
            get;
            set;
        }
        public Items ItemRequired { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }
        #endregion

        public Location(int id,string name,string desciption, Items itemRequired=null,Quest questAvailable=null,Monster monsterLivinghere=null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = desciption;
            this.ItemRequired = itemRequired;
            this.QuestAvailableHere = questAvailable;
            this.MonsterLivingHere = monsterLivinghere;
        }
        
    }
}
