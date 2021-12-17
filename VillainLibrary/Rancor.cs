using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace VillainLibrary
{
    public class Rancor : Villain
    {
        

        public Rancor()
        {
            
            MaxLife = 100;
            MaxDamage = 25;
            Name = ("Rancor");
            Life = 100;
            HitChance = 25;
            Dodge = 2;
            MinDamage = 1;
            Description = ("Oh no. . . Its a Rancor!!");
           
        }//end default ctor
    }
}
