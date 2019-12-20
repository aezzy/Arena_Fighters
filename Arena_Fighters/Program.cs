using System;

namespace Arena_Fighters
{
    class Program
    {
        static void Main(string[] args)

        {

            string userInput = "";
            bool Alive = true;

           
            Character Player = new Character("Hero", 200, 120, 120);
            Character Opponent = new Character("Maximus", 200, 120, 120);

            while (Alive)
            { 
            Console.WriteLine("--------Welcome to Arena");
            Console.WriteLine();
            Console.WriteLine("choose your character:\n1:{0}\n2:{1}", Player.Name,Opponent.Name);
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Today {0} will battle against {1}!", Player.Name,Opponent.Name);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Today {0} will battle against {1}!",Opponent.Name,Player.Name);
            }

           

            Console.WriteLine("Let the battle begin...");
            Console.WriteLine("press enter to start the game");

            Console.ReadKey();
            Battle.StartFight(Player, Opponent);


            Battle b1 = new Battle();
                b1.DisplayAllStats(Player, Opponent);
            
               

            Console.WriteLine("press enter to continue the game or press Q/q to quit the game");
            userInput = Console.ReadLine();
                if(userInput == "Q" || userInput == "q")
                {
                    Alive = false;
                    Console.WriteLine("Quit the game", userInput);
                }
            Console.ReadKey();
            }

        }
    }
}
