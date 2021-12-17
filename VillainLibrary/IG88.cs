using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace VillainLibrary
{
    public class IG88 : Villain
    {


        public IG88()
        {

            MaxLife = 50;
            MaxDamage = 5;
            Name = ("Bounty Hunter Droid ID: IG-88");
            Life = 50;
            HitChance = 35;
            Dodge = 10;
            MinDamage = 1;
            Description = ("A robot thats here to shoot womp rats and bounty hunt, and hes all out of rats");

        }//end default ctor
    }
}