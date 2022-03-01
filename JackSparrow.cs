namespace mis321_pa2_SeanBurkard
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            Name = "Jack Sparrow";
            AttackBehavior = new SneakAttack();
        }
    }
}