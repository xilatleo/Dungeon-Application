using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //The abstract keyword indicated that the thing being mofified is an
    //incomplete implementation. It's used in class signatures to indicate
    //that the class is only intended to be a base class for other classes
    //and will never be instantiated on its own.
    public abstract class Characters
    {
        private string _name;
        private int _life;
        private int _maxLife;
        private int _block;
        private int _hitChance;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= _maxLife ? value : MaxLife;
            }//end sets
        }//end Life

        //We are not going to have a ctor here because we cn never instantiate
        //a character class object. For the same reason we will not perform a 
        //Tostring() override. The ToString() is stil here but we won't use it
        //becauwswe there will be no character objects.

        // Below are the methods we want to be inherited by Player and Monster,
        //We will create default version here and override in the child classes
        //(if neccessary).

        public virtual int CalcBlock()
        {
            return Block;
        }
        // mini lab
        // Build the CalcHitChance() AND make it return HitChance and make it overriable

        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            //Because player and Monster calculate damage differently
            //We will start by setting the return to 0, then override
            //it in the derived classes.
            return 0;
        }


    }
}
