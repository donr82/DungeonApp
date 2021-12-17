using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace VillainLibrary
{
    public class BobaFett : Villain
    {


        public BobaFett()
        {

            MaxLife = 50;
            MaxDamage = 5;
            Name = ("Boba Fett");
            Life = 50;
            HitChance = 30;
            Dodge = 15;
            MinDamage = 1;
            Description = ("The most dangerous bounty hunter in the galaxy");

        }//end default ctor
    }
}
