using System;

namespace Warrior_Game
{
    public class Warrior
    {
        public string WarriorName { get; set; } = "No Name";
        public double Health { get; set; } = 0;
        public double AttackValue{ get; set; } = 0;
        public double BlockValue{ get; set;}  = 0;

    
//-----------User inputs Warrior name--------------

        //TODO

//-----------Get random values for Attack and Block--------------
        
        Random rnd = new Random();
        
        //Generate a random attack value from 1 to warrior's max attack value
        public double Attack()
        {
            double attackRnd = 0;
            attackRnd = rnd.Next(1, (int)AttackValue);
            return attackRnd;
        }

        //Generate a random block value from 1 to warrior's max block value
        public double Block()
        {
            //double blockRnd = 0;
            return rnd.Next(1, (int)BlockValue);
        }


//-----------Add a constructor--------------
        public Warrior(string warriorName, double health, double attackValue, double blockValue)
            {
                WarriorName = warriorName;
                Health = health;
                AttackValue = attackValue;
                BlockValue = blockValue;
            }

    }
}