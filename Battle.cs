using System;

namespace Warrior_Game
{
    public class Battle
    {
        //Recieve both warrior objects
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            //Loop. Each warrior attacks and blocks until one dies
            while(true)
            {
                //Warrior 1 attacks warrior 2. Check result

                //if warrior 2 is dead then break
                if(CheckResult(warrior1, warrior2) == "dead")
                {
                    break;
                }
                //break;

                //Warrior 2 attacks warrior 1. Check result

                //if warrior 1 is dead then break
                if(CheckResult(warrior2, warrior1) == "dead")
                {
                    break;
                }
                //break;
            }
        }

        public static string CheckResult(Warrior attacker, Warrior defender)
        {
            //get the damage
            double attackValue = attacker.Attack();
            double blockValue = defender.Block();

            double damageToDefender = attackValue - blockValue;
            
            if(damageToDefender > 0)
            {
                defender.Health -= damageToDefender;
            }
            else
            {
                damageToDefender = 0;
            }

            Console.WriteLine("{0} attacks {1} and does {2} damage.", attacker.WarriorName, defender.WarriorName, damageToDefender);
            Console.WriteLine("{0} has {1} health left.", defender.WarriorName, defender.Health);

            //check if the health is less than zero
            if(defender.Health <= 0)
            {
                Console.WriteLine("{0} has beaten {1} and is victorious!", attacker.WarriorName, defender.WarriorName);
                return "dead";
            }

            return "keep fighting";
        }
    }
}