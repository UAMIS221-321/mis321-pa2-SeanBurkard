using System;

namespace mis321_pa2_SeanBurkard
{
    public class Gameplay
    {
        //Method which runs gameplay
        static public void Game(Player playerOne, Player playerTwo) {
            
            Player attacker = new Player();
            Player defender = new Player();

            //Randomly decides which player has the first turn
            Random rand = new Random();
            if(rand.Next(0, 2) == 0) {
                Console.WriteLine($"Player One: {playerOne.Name}, has the first move");
                attacker = playerOne;
                defender = playerTwo;
            }
            else {
                Console.WriteLine($"Player Two: {playerTwo.Name}, has the first move");
                attacker = playerTwo;
                defender = playerOne;
            }

            
        
            while(defender.MyCharacter.Health > 0 && attacker.MyCharacter.Health > 0) {
                
                Console.WriteLine($"It is now {attacker.Name}'s turn");
                double typeBonus = new AttackBonus().GetAttackBonus(attacker.MyCharacter.Name, defender.MyCharacter.Name);
                int userInput = new Menu().PlayerTurn();

                //Re-randomization of attack and defense stats to prevent repetitive attacks
                attacker.MyCharacter.SetAttackStats();
                defender.MyCharacter.SetAttackStats();

                while(userInput != -1) {
                    if(userInput == 1) {
                        int damageDealt = Damage.DamageDealt(attacker.MyCharacter.AttackStrength, defender.MyCharacter.DefensePower, typeBonus);
                        attacker.MyCharacter.AttackBehavior.Attack();
                        Console.WriteLine($"{attacker.MyCharacter.Name}'s attack, with {attacker.MyCharacter.AttackStrength} power deals {damageDealt} damage to {defender.MyCharacter.Name}");
                        defender.MyCharacter.Health -= damageDealt;

                        userInput = -1;
                    }
                    else {
                        Console.WriteLine($"{attacker.Name}'s Stats\n");
                        Console.WriteLine(attacker.MyCharacter.ToString());
                        Console.WriteLine("\nPress any key to continue");

                        Console.ReadKey();
                        Console.Clear();
                        userInput = new Menu().PlayerTurn();
                    }
                }

                if(defender.MyCharacter.Health < 0) {
                    defender.MyCharacter.Health = 0;
                }

                Console.WriteLine("\nDefender stats after attack\n" + defender.MyCharacter.ToString());
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();

                //Swaps attack/defense roles at the end of a turn
                Swap(ref attacker, ref defender);
            }

            if(attacker.MyCharacter.Health <= 0){
                Console.WriteLine($"{defender.Name} wins as {defender.MyCharacter.Name}");
            }
        }

        //Swap method to switch attack and defense roles
        static private void Swap(ref Player playerOne, ref Player playerTwo) {
            Player temp = playerOne;
            playerOne = playerTwo;
            playerTwo = temp;
        }
    }
}