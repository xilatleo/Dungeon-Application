using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dungeon quests!";
            Console.WriteLine("You journey begin...\n");

            Weapon crowbar = new Weapon("Rusty Crowbar", 1, 6, false, 5);
            Player player = new Player("Leeroy Jenkins!", 40, 40, Race.Human,
                10, 70, crowbar);
            Zombie z1 = new Zombie("Regular Zomzom", 10, 10, 40, 5, 1, 4, "weakest zomzom on the world.", false);
            Zombie z2 = new Zombie("Armor Zomzom", 10, 10, 50, 10, 6, 2, "Zomzom with chain vest on", true);

            FallenAngle f1 = new FallenAngle("1 wing Angle", 30, 30, 30, 50, 20, 50, "Regular Fallen Angle", false);
            FallenAngle f2 = new FallenAngle("2 wing Angle", 40, 40, 40, 60, 20, 50, "Regular Fallen Angle", false);

            Goblin g1 = new Goblin("Teen Gob", 5, 5, 10, 2, 3, 5, "Amature", false);
            Goblin g2 = new Goblin("Adult Gob", 10, 10, 10, 5, 3, 5, "Awaaa", true);

            bool exit = false;
            do
            {

                //TODO Create the GetRoom()
                Console.WriteLine(GetRoom());
                List<Monster> monsters = new List<Monster>
                {
                    z1,z1,z2,z2,z1,f1,f2,f1,g1,g1,g1,g2

                };

                Monster monster = monsters[new Random().Next(monsters.Count)];

                Console.WriteLine("In this room you see a " + monster.Name + "!");

                bool reload = false;
                do
                {
                    Console.WriteLine("\nChoose an action:\n" +
                        "A) Attack\n" +
                        "R) RUNAWAY!\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack functionality goes here");
                            Combat.DoBattle(player, monster);
                            if (monster.Life <1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed" + monster.Name + "!");
                                Console.ResetColor();
                                reload = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.WriteLine("RUNAWAY!");
                            Console.WriteLine(monster.Name + " attacks you as you flee!");
                            Combat.DoAttack(monster, player);//Free attack
                            
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player stats go here");
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("Monster stats go here");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Thou doth flee from the dungeon in horror. Such dishonour");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Input not recognized. Please try again!");
                            break;
                    }

                    if (player.Life <1)
                    {
                        Console.WriteLine("\nYou have been slain by " + monster.Name + "!");
                        exit = true;
                    }

                } while (!reload && !exit);

            } while (!exit);

            Console.WriteLine("\nGAME OVER");
        }//end main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "A cluster of low crates surrounds a barrel in the center of this chamber. Atop the barrel lies a stack of copper coins and two stacks of cards, one face up. Meanwhile, atop each crate rests a fan of five face-down playing cards. A thin layer of dust covers everything. Clearly someone meant to return to their game of cards.",
                "You open the door and a gout of flame rushes at your face. A wave of heat strikes you at the same time and light fills the hall. The room beyond the door is ablaze! An inferno engulfs the place, clinging to bare rock and burning without fuel.",
                "You've opened the door to a torture chamber. Several devices of degradation, pain, and death stand about the room, all of them showing signs of regular use. The wood of the rack is worn smooth by struggling bodies, and the iron maiden appears to be occupied by a corpse.",
                "A skeleton dressed in moth-eaten garb lies before a large open chest in the rear of this chamber. The chest is empty, but you note two needles projecting from the now-open lock. Dust coats something sticky on the needles' points.",
                "This hall stinks with the wet, pungent scent of mildew. Black mold grows in tangled veins across the walls and parts of the floor. Despite the smell, it looks like it might be safe to travel through. A path of stone clean of mold wends its way through the hallway.",
                "Huge rusted metal blades jut out of cracks in the walls, and rusting spikes project down from the ceiling almost to the floor. This room may have once been trapped heavily, but someone triggered them, apparently without getting killed. The traps were never reset and now seem rusted in place.",
                "Three low, oblong piles of rubble lie near the center of this small room. Each has a weapon jutting upright from one end -- a longsword, a spear, and a quarterstaff. The piles resemble cairns used to bury dead adventurers.",
                "A chill wind blows against you as you open the door. Beyond it, you see that the floor and ceiling are nothing but iron grates. Above and below the grates the walls extend up and down with no true ceiling or floor within your range of vision. It's as though the chamber is a bridge through the shaft of a great well. Standing on the edge of this shaft, you feel a chill wind pass down it and over your shoulder into the hall beyond.",
                "The manacles set into the walls of this room give you the distinct impression that it was used as a prison and torture chamber, although you can see no evidence of torture devices. One particularly large set of manacles -- big enough for an ogre -- have been broken open.",
                
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;

        }
    }//end class
}//end namespace
