namespace OopGame.Characters.Ranged
{
    public class Necromancer
    {
        // Fields
        private string? name;
        private string? faction;
        private int abilityPoints;
        private int healthPoints;
        private int level;

        // Properties

        // Methods
        public void ShadowTouch()
        {
            Console.WriteLine("Necromancer used shadow touch");
        }
        public void VampireBite()
        {
            Console.WriteLine("Necromancer bit as a vampire");
        }
        public void BoneShield()
        {
            Console.WriteLine("Necromancer used a bone shield");
        }
    }
}