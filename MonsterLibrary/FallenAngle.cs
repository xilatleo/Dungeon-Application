using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class FallenAngle : Monster
    {
        public bool IsBlessed { get; set; }

        public FallenAngle(string name, int life, int maxLife, int hitChance,
            int block, int minDamage, int maxDamage, string description,
            bool isBlessed)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsBlessed = isBlessed;
        }
        public override string ToString()
        {
            return base.ToString() + (IsBlessed ? "The Fallen Angle received Blessing from Sin Devil, you will deal less damage to it"
                : "Piece of Cake");
        }

        public override int CalcBlock()
        {
            if (IsBlessed)
            {
                return Block * 2;
            }
            else
            {
                return Block;
            }
        }
    }
}
