using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon:Items
    {
        private int minDMG;
        private int maxDMG;
        
        public int MinDMG { get; set; }
        public int MaxDMG { get; set; }

        public Weapon(int id,string name,string namePlural,int minDmg,int maxDmg):base(id, name,namePlural)
        {
            this.MinDMG = minDmg;
            this.MaxDMG = maxDmg;
        }
        
    }
}
