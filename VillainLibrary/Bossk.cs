using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace VillainLibrary
{
    public class Bossk : Villain
    {


        public Bossk()
        {

            MaxLife = 50;
            MaxDamage = 4;
            Name = ("bossk");
            Life = 50;
            HitChance = 20;
            Dodge = 25;
            MinDamage = 1;
            Description = ("The second most dangerous bounty hunter in the galaxy");

        }//end default ctor
    }
}