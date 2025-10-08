namespace OopGame.Characters.Ranged
{
    public class Mage
    {
        // Fields
        private string? name;
        private string? faction;
        private int abilityPoints;
        private int healthPoints;
        private int level;

        // Properties

        // Methods
        public void FireBall()
        {
            Console.WriteLine("Mage is using a Fire Ball");
        }
        public void ThunderMagic()
        {
            Console.WriteLine("Mage is using Thunder Magic");
        }
        public void IceMagic()
        {
            Console.WriteLine("mage is using Ice Magic");
        }
    }
}