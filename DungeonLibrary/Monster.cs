using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Characters
    {
        private int _minDamage;
        //propful tab tab creates a field and an associated property
        public int MaxDamage { get; set; }
        public string Description { get; set; }


        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; ; }
        }

        public Monster(string name, int life, int maxlife, int hitChance,
            int block, int minDamage, int maxDamage, string description)
        {
            MaxLife = maxlife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("{0}\nLife: {1} of {2}\nDamage: {3} to {4}]\n" +
                "Block: {5}\nDescription:\n{6}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                Description);
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage +1);
        }

    }
}
