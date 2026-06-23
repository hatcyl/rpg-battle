namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Battle Start!");

        Monster monster1 = new Monster(20, 5, 3);
        Monster monster2 = new Monster(20, 5, 3);

        Console.WriteLine("monster1 stats:");
        Console.WriteLine($"HP: {monster1.Hp}");
        Console.WriteLine($"Attack: {monster1.Attack}");
        Console.WriteLine($"Defense: {monster1.Defense}");

        monster1.AttackMonster(monster2);
        monster1.AttackMonster(monster2);
        monster1.AttackMonster(monster2);

        Console.WriteLine("monster1 attacked monster2 3 times.");
        Console.WriteLine($"monster2 HP is now {monster2.Hp}");

        monster2.AttackMonster(monster1);
        monster2.AttackMonster(monster1);

        Console.WriteLine("monster 2 attacked monster 1.");
        Console.WriteLine($"Montster 1 is now at {monster1.Hp}.");
    }
}
