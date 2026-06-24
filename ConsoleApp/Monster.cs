using System;

namespace ConsoleApp;

public class Monster(int hp, int attack, int defense)
{
    public int Hp { get; private set; } = hp;
    public int Attack { get; } = attack;
    public int Defense { get; } = defense;
    public bool Determination { get; set; }

    public void AttackMonster(Monster opponent)
    {
        if (Hp > 0)
            opponent.TakeDamage(Attack);
        else
            return;
    } 

    private void TakeDamage(int attack)
    {
        int newHp = Hp - (attack - Defense);
        {
            if (Determination == true && Hp > 1 && newHp < 1)
                Hp = 1;
            else
                Hp = newHp;
        }
    }
}
