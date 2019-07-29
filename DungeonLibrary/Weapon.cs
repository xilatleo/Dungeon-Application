using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private bool _isTwoHanded;
        private int _bonusHitChance;
        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= _maxDamage ? value : 1;
            }//end set
        }//end Mindamage

        //ctors, ctor tab tab
        public Weapon(string name, int minDamage, int maxDamage, bool isTwoHanded,
            int bonusHitChance)
        {
            Name = name;
            MaxDamage = maxDamage;
            IsTwoHanded = isTwoHanded;
            BonusHitChance = bonusHitChance;
            MinDamage = minDamage;
        }//end FQCTOR

        //methods
        public override string ToString()
        {
            //return base.ToString();
            // THe base class for all classes in C# is Object.
            //We dont want Object's version of the ToString()
            //so we override it to display complex data how we want.

            return string.Format("{0}\n{1} to {2} damage\nBonus Hit: {3}%\t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                // Mini lab
                // Write a ternary operator that outputs whether or not
                //the weapon is two handed
                IsTwoHanded ? "Two-handed" : "One-handed");
        }//end Tostring()
    }//end Class
}
