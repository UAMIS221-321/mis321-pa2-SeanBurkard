using System;

namespace mis321_pa2_SeanBurkard
{
    public class Menu
    {
        //Menu for a a players turn
        public int PlayerTurn()
        {
            Console.WriteLine("Choose a command:\n1. Attack\n2. View Stats");
            int userInput = -1;
            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
                throw e;
            }

            if (userInput >= 1 && userInput <= 2)
            {
                return userInput;
            }
            userInput = new Menu().PlayerTurn();

            return userInput;
        }
    }
}