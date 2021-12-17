using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Villain : Character
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end MinDamage

        public Villain() { }
        public Villain(string name, int life, int maxLife, int hitChance, int dodge, int minDamage, int maxDamage, string description)
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            Dodge = dodge;
            HitChance = hitChance;
            Description = description;
            MinDamage = minDamage;
        }//end FQ CTOR

        public override string ToString()
        {
            return $"\n********** Villain **********\n" +
                $"{Name}\n" +
                $"Life: {Life} / {MaxLife}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Dodge: {Dodge}\n" +
                $"description: {Description}\n";
        }//end ToString()

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }//end CalcDamage()
    }//end class
}//end namespace
