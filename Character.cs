using System;
namespace mis321_pa2_SeanBurkard
{
    public class Character
    {
        public string Name {get; set;}
        public int MaxPower {get; set;}
        public int Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensePower {get; set;}
        public IAttack AttackBehavior {get; set;}

        public Character()
        {
            Health = 100;
        }

        public void SetAttackStats() {
            Random rand = new Random();
            MaxPower = rand.Next(1, 101);
            AttackStrength = rand.Next(1, MaxPower);
            DefensePower = rand.Next(1, MaxPower);
        }

        public override string ToString()
        {
            return $"Name: {Name}\nMaxPower: {MaxPower}\nHealth: {Health}\nAttack: {AttackStrength}\nDefense: {DefensePower}";
        }
    }
}