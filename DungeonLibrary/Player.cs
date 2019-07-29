using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary 
{
    public class Player : Characters
    {
        //fields
        //private string _name;
        //private int _life;
        //private int _maxLife;
        private Race _playerRace;
        //private int _block;
        //private int _hitChance;
        private Weapon _equippedWeapon;
        //properties
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //public int MaxLife
        //{
        //    get { return _maxLife; }
        //    set { _maxLife = value; }
        //}

        public Race PlayerRace
        {
            get { return _playerRace; }
            set { _playerRace = value; }
        }

        //public int Block
        //{
        //    get { return _block; }
        //    set { _block = value; }
        //}

        //public int HitChance
        //{
        //    get { return _hitChance; }
        //    set { _hitChance = value; }
        //}

        public Weapon EquippedWeapon
        {
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }

        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        _life = value <= _maxLife ? value : MaxLife;
        //    }//end sets
        //}//end Life

        //Only make a FQTOR. We dont want an incomplete Player
        //ctors
        public Player(string name, int life, int maxLife, Race playerRace,
            int block, int hitChance, Weapon equippedWeapon)
        {
            Name = name;
            MaxLife = maxLife;
            PlayerRace = playerRace;
            Block = block;
            HitChance = hitChance;
            EquippedWeapon = equippedWeapon;
            Life = life;
        }
        //methods

        public override string ToString()
        {
            //return base.ToString();
            string description = "";
            switch (PlayerRace)
            {
                case Race.Elf:
                    description = "The Elves have their own labours and their own sorrows, and they are little concerned with the ways of hobbits, or of any other creatures upon earth.";
                    break;
                case Race.Dwarf:
                    description = " the Dwarves are described as shorter and stockier than Elves and Men, able to withstand both heat and cold. They prefer to live underground, especially in cities under mountains";
                    break;
                case Race.Knight:
                    description = "A knight is a man granted an honorary title of knighthood by a monarch, bishop or other political or religious leader for service to the monarch or a Christian church, especially in a military capacity.";
                    break;
                case Race.Goblin:
                    description = "A redcap is a type of goblin who dyes its hat in human blood in Anglo-Scottish border folklore. Hobgoblins are friendly trickster goblins from English, Scottish, and Pilgrim folklore and literature. The Erlking is a malevolent goblin from German legend.";
                    break;
                case Race.Maze:
                    description = "Live in plain sight, disguised as normal women, but their hatred of children (who smell to them of dogs' droppings) is all-powerful.";
                    break;
                case Race.Human:
                    description = "You are human being. Boring.";
                    break;
                
            }//end switch
            return string.Format(" === {0} ===\nLife: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon: {4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description);
        }//end ToString()

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }//end CalcDamage()

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }


    }
}
