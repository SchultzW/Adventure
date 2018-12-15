using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Items
    {
        protected int id;
        protected string name;
        protected string namePlural;

        public int ID
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public string NamePlural
        {
            get;set;
        }
        public Items(int id,string name,string namePlural)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePlural;
        }

        public Items()
        {
        }
        //public Items()
        //{

        //}
    }
}
