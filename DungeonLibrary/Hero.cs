using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Hero : Character
    {
        public Race CharacterRace { get; set; }
        
        public Weapon EquippedWeapon { get; set; }

        public Hero(string name, int hitChance, int dodge, int life, int maxLife, Race characterType, Weapon equippedWeapon, string description)
        {
           
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Life = life;
            CharacterRace = characterType;
            EquippedWeapon = equippedWeapon;
            Dodge = dodge;


            switch (CharacterRace)
            {
                case Race.Jedi:
                    HitChance += 15;
                    break;

                case Race.Smuggler:
                    HitChance += 10;
                    break;

                case Race.Wookie:
                    HitChance += 5;
                    break;

            }
        }//end of fq ctor

        //money / methods
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Jedi:
                    description = "Do or Do Not, there is no try.";
                    break;

                case Race.Smuggler:
                    description = "Need to get through an imperial blockade? Look no further!";
                    break;

                case Race.Wookie:
                    description = "Might rip your arms off if you dont let them win.";
                    break;

                
            }//end switch

            return $"-=-= {Name} =-=-\n" +
                $"Life: {Life} / {MaxLife}\n" +
                $"Hit Chance: {CalcHitChance()}%\n" +
                $"Weapon:\n{EquippedWeapon}\n" +
                $"Dodge: {Dodge}\n" +
                $"Description: {description}";

        }//end ToString override

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1); 
            return damage;
        }//end CalcDamage()

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }//end CalcHitChance()
    }//end class
}//end namespace
