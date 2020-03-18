using System;

namespace Warrior_Game
{
    public class Warrior
    {
        public string WarriorName { get; set; } = "No Name";
        public double Health { get; set; } = 0;
        public double AttackMax{ get; set; } = 0;
        public double BlockMax{ get; set;}  = 0;

    
//-----------User inputs Warrior name--------------

        //TODO

//-----------Get random values for Attack and Block--------------
        
        Random rnd = new Random();
        
        //Generate a random attack value from 1 to warrior's max attack value
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        //Generate a random block value from 1 to warrior's max block value
        public double Block()
        {
            //double blockRnd = 0;
            return rnd.Next(1, (int)BlockMax);
        }


//-----------Add a constructor--------------
        public Warrior(string warriorName, double health, double attackMax, double blockMax)
            {
                WarriorName = warriorName;
                Health = health;
                AttackMax = attackMax;
                BlockMax = blockMax;
            }

    }
}