namespace OopGame.Equipment.Weapons
{
    public class Sword
    {
        // Fields
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The damage must be bigger than 0");
                }
            }
        }
        public Sword()
        {
            
        }
    }
}