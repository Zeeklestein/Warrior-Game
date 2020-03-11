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
                if(CheckResult(warrior1.Health, warrior2.Health) == "dead")
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

        public static string CheckResult(double warrior1, double warrior2)
        {
            return "dead";
        }
    }
}