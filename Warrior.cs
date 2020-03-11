using System;

namespace Warrior_Game
{
    public class Warrior
    {
        // private string warriorName = "No Name";
        // private int health;
        // private int attackValue;
        // private int blockValue;

        public string WarriorName {get; set;} = "No Name";
        public double Health {get; set;}=0;
        public double AttackValue{get;set;}=0;
        public double BlockValue{get; set;}=0;

    
//-----------User enter inputs name--------------

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


// //-----------Setting up the constructors--------------
        // public Warrior()
        //     : this("No name", 0, 0, 0) {}
        // public Warrior(string warriorName)
        //     : this(warriorName, 0, 0, 0) {}
        // public Warrior(string warriorName, int health)
        //     : this(warriorName, health, 0, 0) {}
        // public Warrior(string warriorName, int health, int attackValue)
        //     : this(warriorName, health, attackValue, 0) {}
        public Warrior(string warriorName, double health, double attackValue, double blockValue)
            {
                WarriorName = warriorName;
                Health = health;
                AttackValue = attackValue;
                BlockValue = blockValue;
            }

//-----------Getter and setters for the properties--------------
        // public string WarriorName
        // {
        //     get { return warriorName; }
        //     set {warriorName = value; }
        // }
        // public int Health
        // {
        //     get { return health; }
        //     set {health = value; }
        // }
        // public int AttackValue
        // {
        //     get { return attackValue; }
        //     set {attackValue = value; }
        // }public int BlockValue
        // {
        //     get { return blockValue; }
        //     set {blockValue = value; }
        // }
    }
}