using System;

namespace Warrior_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior smash = new Warrior("Smash", 1000, 120, 20);
            Warrior bash = new Warrior("Bash", 1000, 120, 60);

            Battle.StartFight(smash, bash);
        }
    }
}
