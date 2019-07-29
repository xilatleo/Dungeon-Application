using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //We can't add an enum through Visual Studio's interface, so to make one
    //we create a class then change the class keyword to enum.
    public enum Race
    {
        //Single values, comma seperated, no spaces
        Elf,
        Dwarf,
        Knight,
        Goblin, 
        Maze,
        Human
    }
}
