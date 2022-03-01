namespace mis321_pa2_SeanBurkard
{
    public class AttackBonus
    {
        //Method to determine if an attacker has a bonus on the defender
        public double GetAttackBonus(string playerOne, string playerTwo) {
            if(playerOne == "Jack Sparrow") {
                if(playerTwo == "Will Turner") {
                    return 1.2;
                }
            }
            else if(playerOne == "Will Turner") {
                if(playerTwo == "Davy Jones") {
                    return 1.2;
                }
            }
            else{
                if(playerTwo == "Jack Sparrow") {
                    return 1.2;
                }
            }

            return 1;
        }
    }
}