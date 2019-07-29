using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Zombie : Monster//Crlt + "."
    {
        public bool IsBloated { get; set; }

        public Zombie(string name, int life, int maxLife, int hitChance,
            int block, int minDamage, int maxDamage, string description,
            bool isBloated)
            : base(name,life,maxLife,hitChance,block,minDamage,maxDamage,description)
        {
            IsBloated = isBloated;
        }

        public override string ToString()
        {
            return base.ToString() + (IsBloated ? "The zombie's corpse is bloatedand gassy. It looks like it will be hard to damage." : "It looks as if it died recently.");
        }

        public override int CalcBlock()
        {
            if (IsBloated)
            {
                return Block + Block / 2;
            }
            else
            {
                return Block;
            }//end block
        }//end CalcBlock() 

        //Build 2 more monsters 
    }
}
