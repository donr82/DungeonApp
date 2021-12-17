using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace VillainLibrary
{
    public class GamoreanGuard : Villain
    {


        public GamoreanGuard()
        {

            MaxLife = 30;
            MaxDamage = 2;
            Name = ("Gamorean Guard");
            Life = 50;
            HitChance = 5;
            Dodge = 5;
            MinDamage = 1;
            Description = ("Jabba's guards who may look slow cause they are");

        }//end default ctor
    }
}