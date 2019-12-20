using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_Fighters
{
    class Character
    {
        //variables: Name, health, AttackMax, BlockMax
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double BlockMax { get; set; }
        public double MaxHealth { get; set; }
        public double TotalDamage { get; set; }

        //Constructor
        public Character(string name, double health,double attackMax,double blockMax)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
            MaxHealth = health;
        }

        //Random number for attacks and blocks
        Random rnd = new Random();

        //Attack()
        //Generate a random attack from 1 to maximum attack
        public double Attack()
        {
            //return rnd.Next(1, (int)AttackMax);
            double damage = rnd.Next(1, (int)AttackMax);

            TotalDamage += damage;
            //Maximus.Health -= damage;
            //player.Health -= damage;
            
            return damage;
           

        }

        //Block()
        //Generate a random block from 1 to maximum block
        public double Block()
        {
            //return rnd.Next(1, (int)BlockMax);
            double damage = rnd.Next(1, (int)BlockMax);

            TotalDamage += damage;
            //Maximus.Health -= damage;
            //player.Health -= damage;
            return damage;

        }

        public bool Alive()
        {
            return Health > 0;
         
        }
        //public string HealthBar()
        //{
        //    string s = "[";
        //    int total = 10;
           
        //    double count = (double)Health / MaxHealth  * total;
        //    if ((count == 0) && (Alive()))
        //        count = 1;
        //    for (int i = 0; i < count; i++)
        //        s += "#";
        //    s = s.PadRight(total + 1);
        //    s += "]";
        //    return s;
        //}
    }
}
