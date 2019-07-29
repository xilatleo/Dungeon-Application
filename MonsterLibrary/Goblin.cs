using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Goblin : Monster
    {
        public bool IsArmed { get; set; }

        public Goblin(string name, int life, int maxLife, int hitChance,
            int block, int minDamage, int maxDamage, string description,
            bool isArmed)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsArmed = isArmed;
        }

        public override string ToString()
        {
            return base.ToString() + (IsArmed ? "Your attack penetration is weak and Goblin armor is too high. You will deal less damage to Goblin with Armor Vest on."
                : "Piece of Cake");
        }

        public override int CalcBlock()
        {
            if (IsArmed)
            {
                return Block + 5;
            }
            else
            {
                return Block;
            }
        }
    }
}
