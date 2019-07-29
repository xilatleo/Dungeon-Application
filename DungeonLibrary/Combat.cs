using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Characters attacker, Characters defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(30);
            if (diceRoll <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damagedDeal = attacker.CalcDamage();
                defender.Life -= damagedDeal;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name,
                    defender.Name,
                    damagedDeal);
                Console.ResetColor();
            }//end of
            else
            {
                Console.WriteLine(attacker.Name + " missed!");
            }
        }//end doAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//end if
        }//end DoBattle()


    }
}
