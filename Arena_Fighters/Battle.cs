using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_Fighters
{
    class Battle
    {
        //Startfight()
        //Character Player and Character Opponent
        
        public static void StartFight(Character Player, Character Opponent)
        {


            bool isAlive = true;
            while (isAlive)
            {
                
                if (GetAttackResult(Player, Opponent)
                    == "Game over")
                {
                    Console.WriteLine("Game is over");
                    break;
                }
                if (GetAttackResult(Opponent, Player) == "Game over")
                {
                    Console.WriteLine("Game is over");
                    break;
                }

                Console.WriteLine();
            }








        }








        //GetAttackResult
        //CharacterA(can be Player or Opponent in this position)
        //CharacterB(can be Opponent or Playerin this position)
        private static string GetAttackResult(Character characterA, Character characterB)
        {
            //loop giving each character a chance to attack and block until 1 dies
            double warAttackAmount = characterA.Attack();
           
            double warBlockAmount = characterB.Block();
           
            Console.WriteLine();

            //substract attack from block
            //calculate player's attack and opponent's block
            double dmgAmount = warAttackAmount - warBlockAmount;

            if (dmgAmount > 0)
            {

                //if there was a damage substract that from health
                characterB.Health = characterB.Health - dmgAmount;
            }
            else
                dmgAmount = 0;

            //print out info on who attacked who and how much damage
            Console.WriteLine("{0} attacks {1} deals and {2} damages",characterA.Name, characterB.Name, dmgAmount);

            //provide output on the change in health
            Console.WriteLine("{0} Has {1} health:\n", characterB.Name,characterB.Health);


            //check if the character health felt below 0 and print the message and end the loop or game
            if (characterB.Health <= 0)
            {
                Console.WriteLine("{0} has lost the game and {1} is victorious\n", characterB.Name, characterA.Name);
                return "Game over";

            }
            else return "fight again";
        }

        //print the static of player and opponent
        public void DisplayAllStats(Character Player, Character Opponent)
        {
            
            
            Console.WriteLine("Name\t\tScore\tAttacks/Blocks");
            Console.WriteLine("{0}\t\t   {1}\t\t   {2}", Player.Name, Player.Health, Player.TotalDamage);
            Console.WriteLine("{0}\t\t   {1}\t\t   {2}", Opponent.Name, Opponent.Health, Opponent.TotalDamage);
        }

        

       

        

       


       

        

        

    }
}
