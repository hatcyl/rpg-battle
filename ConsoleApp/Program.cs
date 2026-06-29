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

    while (monster1.IsDead == false && monster2.IsDead == false)
        {
            monster1.AttackMonster(monster2);
            if (monster2.IsDead == true) break;
            monster2.AttackMonster(monster1);
            if (monster1.IsDead == true) break;
        }
    }
}
