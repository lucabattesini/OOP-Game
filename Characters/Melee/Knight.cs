namespace OopGame.Characters.Melee
{
    public class Knight
    {
        // Fields
        private string? name;
        private string? faction;
        private int abilityPoints;
        private int healthPoints;
        private int level;

        // Properties

        // Methods
        public void HolyBlow()
        {
            Console.WriteLine("Knight used explosion");
        }
        public void PurifySoul()
        {
            Console.WriteLine("Knight Purified a soul");
        }
        public void RighteousWing()
        {
            Console.WriteLine("Knight used righteous wing");
        }
    }
}