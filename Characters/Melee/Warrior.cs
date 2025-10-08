public class Warrior
{ 
    // Fields
    private string? name;
    private string? faction;
    private int abilityPoints;
    private int healthPoints;
    private int level;

    // Properties

    // Methods
    public void Strike()
    {
        Console.WriteLine("Warrior is striking");
    }
    public void Execute()
    {
        Console.WriteLine("Warrior Executed");
    }
    public void SkinHarden()
    {
        Console.WriteLine("Warrior is skin harder");
    }
}