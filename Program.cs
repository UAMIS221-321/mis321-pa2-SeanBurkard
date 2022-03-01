using System;

namespace mis321_pa2_SeanBurkard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Battle of Calypso's Maelstrom\n\nPress any key to advance");
            Console.ReadKey();
            Console.Clear();
            
            //Player selection 1
            Player playerOne = new PlayerCreation().Create();
            Console.WriteLine($"{playerOne.Name} is {playerOne.MyCharacter.Name}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            //Player selection 2
            Player playerTwo = new PlayerCreation().Create();
            Console.WriteLine($"{playerTwo.Name} is {playerTwo.MyCharacter.Name}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Gameplay.Game(playerOne, playerTwo);
            Console.WriteLine("Game Over");
        }
    }
}
