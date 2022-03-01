using System;
namespace mis321_pa2_SeanBurkard
{
    public class PlayerCreation
    {
        public Player Create()
        {
            Player userPlayer = new Player();
            userPlayer.Name = GetPlayerName();
            userPlayer.MyCharacter = CharacterSelect();
            return userPlayer;
        }

        static string GetPlayerName() {
            System.Console.WriteLine("Enter your name");
            string name = System.Console.ReadLine();
            return name;
        }

        static Character CharacterSelect() {
            System.Console.WriteLine("Select a character\n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones");
            int choice =  -1;

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
                throw e;
            }

            if(choice == 1){
                return new JackSparrow();
            }
            else if(choice == 2){
                return new WillTurner();
            }
            return new DavyJones();
        }
    }
}