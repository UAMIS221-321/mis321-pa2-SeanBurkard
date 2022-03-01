namespace mis321_pa2_SeanBurkard
{
    public class DavyJones : Character
    {
        public DavyJones() {
            Name = "Davy Jones";
            AttackBehavior = new CannonFire();
        }
    }
}