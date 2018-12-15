using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Character
    {
        private int currentHP;
        private int maxHP;
        //private int gold;
        //private int exp;
        //private int level;

        //public void Player(int CurrentHp,int MaxHP,int Gold,int Exp,int Level)
        //{

        //}
        public Character()
        {

        }
        public Character(int currentHp,int maxHP)
        {
            this.currentHP = CurrentHP;
            this.maxHP = MaxHP;
        }
        public int CurrentHP
        {
            get;
            set;
        }
        public int MaxHP
        {
            get;
            set;
        }
        //public int Gold
        //{
        //    get;
        //    set;

        //}
        //public int Exp
        //{
        //    get;
        //    set;
        //}
        //public int Level
        //{
        //    get;
        //    set;
        //}
        
        //public Character(int currentHP,int maxHP,int gold,int exp,int level)
        //{
        //    this.CurrentHP = currentHP;
        //    this.MaxHP = maxHP;
        //    this.Gold = gold;
        //    this.Exp = exp;
        //    this.Level = level;
        //}
       
    }

   

}
