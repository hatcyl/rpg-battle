namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Battle Start!");

        Monster monster1 = new Monster(50, 10, 50, "monster1");
        monster1.Determination = true;
        Monster monster2 = new Monster(50, 5, 50, "monster2");

        Console.WriteLine("monster1 stats:");
        Console.WriteLine($"HP: {monster1.Hp}");
        Console.WriteLine($"Attack: {monster1.Attack}");
        Console.WriteLine($"Defense: {monster1.Defense}");

        monster1.AttackMonster(monster2);
        monster1.AttackMonster(monster2);
        monster1.AttackMonster(monster2);

        Console.WriteLine("monster1 attacked monster2 3 times.");
        Console.WriteLine($"monster2 HP is now {monster2.Hp}");
    }
}
