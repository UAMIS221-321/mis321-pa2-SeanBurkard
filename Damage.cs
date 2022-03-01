namespace mis321_pa2_SeanBurkard
{
    public class Damage
    {
        //Method to calculate damage, returns 1 if defender is stronger than attacker
        static public int DamageDealt(int attackPow, int defendPow, double typeBonus) {
            int damageDealt = (int)((attackPow - defendPow) * (typeBonus)); 

            if(damageDealt < 0) {
                return 1;
            }

            return damageDealt;
        }
    }
}