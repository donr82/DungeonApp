using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using DungeonLibrary;
using VillainLibrary;


namespace Dungeon
{
    class DungeonApp
    {
        static void Main(string[] args)
        {

            string txt = "Jabbas Palace";
            Console.Title = string.Format("{0," + ((Console.WindowWidth / 2) + txt.Length / 2) + "}", txt);
            Console.WriteLine(@"       
                 ________   ___   ____
                / __   __| / _ \ |  _ \
          ______> \ | |   |  _  ||    /_____________________________
         / _______/ |_|   |_| |_||_|\______________________________ \
        / /                                                        \ \
        | |                                                         | |
        | |                                                         | |
        | |           Escape from Jabbas Palace!!                   | |
        | |                                                         | | 
        | |                                                         | |
        \ \____________________________   _   ___   ____   _________/ /
         \___________________________ |  | | / _ \ |  _ \ / _________/
                                    | |/\| ||  _  ||    / > \        
                                     \_/\_/ |_| |_||_ \_\|__/
        ");
            

            Console.Beep(392, 350);
            Thread.Sleep(100);
            Console.Beep(392, 350);
            Thread.Sleep(100);
            Console.Beep(392, 350);
            Thread.Sleep(100);
            Console.Beep(311, 250);
            Thread.Sleep(100);
            Console.Beep(466, 25);
            Thread.Sleep(100);
            Console.Beep(392, 350);
            Thread.Sleep(100);
            Console.Beep(311, 250);
            Thread.Sleep(100);
            Console.Beep(466, 25);
            Thread.Sleep(100);
            Console.Beep(392, 700);
            Thread.Sleep(100);
            Console.Beep(587, 350);
            Thread.Sleep(100);
            Console.Beep(587, 350);
            Thread.Sleep(100);
            Console.Beep(587, 350);
            Thread.Sleep(100);
            Console.Beep(622, 250);
            Thread.Sleep(100);
            Console.Beep(466, 25);
            Thread.Sleep(100);
            Console.Beep(369, 350);
            Thread.Sleep(100);
            Console.Beep(311, 250);
            Thread.Sleep(100);
            Console.Beep(466, 25);
            Thread.Sleep(100);
            Console.Beep(392, 700);



            int score = 0;
            //TODO 1. Score
            //TODO 2. Create Player
            Console.WriteLine("Select your hero");
            //TODO set up choice to select character
            Weapon lightsaber = new Weapon(1, 10, "A lightsaber! The weapon of a Jedi, an elegant weapon for a more civilized age", 20);
            Console.WriteLine("Enter a name for your hero");
            string heroName = Console.ReadLine();
            Hero hero = new Hero(heroName, 50, 5, 50, 50, Race.Jedi, lightsaber, "Do or Do Not, there is no try.");
            Console.Clear();
            Console.WriteLine("Use the below list to attack, retreat, view stats on apponent or your hero. When the force is no longer strong with you select exit.\n");

            bool exit = false;
            do
            {
                //TODO 6. Get a room description from a custom method that generates them
                Console.WriteLine(GetRoom());
                //TODO 7. Create Apponents in the room for players to fight

                Rancor r1 = new Rancor();
                BobaFett bf1 = new BobaFett();
                Bossk b1 = new Bossk();
                GamoreanGuard g1 = new GamoreanGuard();
                IG88 ig1 = new IG88();
                Villain[] villains = { r1, bf1, bf1, bf1, b1, b1, b1, ig1, ig1, ig1, g1, g1, g1, g1, g1, g1, g1};
                int randomIndex = new Random().Next(villains.Length);
                Villain villain = villains[randomIndex];

                Console.WriteLine("\nIn this room: " + villain.Name);
                //TODO 8. Create loop for user choice  menu (inner loop)
                bool reload = false;
                do
                {
                    Console.WriteLine(@"
Please Choose an Action:
A) Attack
R) Retreat
H) Hero Info
V) Villain Info
X) Exit
");

                    string userChoice = Console.ReadKey(true).Key.ToString();

                    Console.Clear();
                    switch (userChoice)
                    {
                        case "A":
                            Combat.DoBattle(hero, villain);

                           
                            if (villain.Life <= 0)
                            {
                                hero.Life += 5;
                                Console.WriteLine($"\nYou gained +5 health for defeating {villain.Name}!");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nYou killed {0}!\n", villain.Name);
                                Console.ResetColor();
                                reload = true;
                                score++;
                            }
                            break;

                        case "R":
                            Console.WriteLine("Thats no moon. We never should have come here.");
                            Console.WriteLine();
                            reload = true;
                            break;

                        case "H":
                            Console.WriteLine("Heroes Info:\n");
                            //14. Display Player info
                            Console.WriteLine(hero);
                            Console.WriteLine("Villains Defeated: " + score);
                            break;

                        case "V":
                            Console.WriteLine("Villain Info:");
                            //15. Display Monster info
                            Console.WriteLine(villain);
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.WriteLine("You rebel scum!\n");
                            exit = true;
                            break;
                    }//end switch

                    if (hero.Life <= 0)
                    {
                        Console.WriteLine("\nYou have been encased in carbonite and added to Jabba's collection.\n");
                        exit = true;
                    }
                } while (!reload && !exit);
            } while (!exit);

            Console.WriteLine($"\nCongratulations young padawan! You have defeated {score:0} of Jabba's goons!\n");


        }//end svm

        private static string GetRoom()
        {
            string[] rooms =
            {
                "You arrived at the front gat to Jabba's palace. Sand is blowing in your face with the eerie feeling that you are being watched.",
                "You find yourself in Jabba's throne room. Jabba is staring at you with his fist hovering over the trapdoor button. All of his minions are waiting for the signal to attack or for the music to start back up.",
                "The sign on the wall says 'Motor Pool' and you are surrounded by the scrapped vehicles of Jabbs's visitors who never made it out.",
                "You fall through the trap door and find yourself in a dark pit with bones scattered about. In the back is a large door holding back Jabba's pet. I have a bad feeling about this.",
                "You thought things could not get any worse but you are now in the Jabba's dungeon. The echos of screams fill the air. Better move fast to not join the echos.",
                "You walk down the main passage leading to the throne room, a vast and cavernous place that was filled with an eerie silence"
            };
            return rooms[new Random().Next(rooms.Length)];
        }
    }//end class
}//end namespace
