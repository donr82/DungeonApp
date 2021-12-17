using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        static void DoAttack(Character attacker, Character Defender)
        {
            int diceRoll = new Random().Next(1, 101);
            System.Threading.Thread.Sleep(50);
            if (diceRoll <= (attacker.CalcHitChance() - Defender.CalcDodge()))
            {
                int damageDealt = attacker.CalcDamage();
                Defender.Life -= damageDealt;

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} attacked {Defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack
        public static void DoBattle(Hero hero, Villain villain)
        {
            //player attacks first
            DoAttack(hero, villain);

            //monster attacks second, if they're not dead
            if (villain.Life > 0)
            {
                DoAttack(villain, hero);
            }//end if
        }//end DoBattle
    }//end class
}//end namespace
