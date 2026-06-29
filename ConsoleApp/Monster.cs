using System;
using System.Resources;

namespace ConsoleApp;

public class Monster(int hp, int attack, int defense)
{
    public int Hp { get; private set; } = hp;
    public int Attack { get; } = attack;
    private int attackCount = 0;
    public int Defense { get; } = defense;
    public bool Determination { get; set; }
    public int DefendCharge { get; set; }

    public void AttackMonster(Monster opponent)
    {
        attackCount++;
        if (Hp > 0)
            opponent.TakeDamage(Attack);
        else
            return;
        if (attackCount % 3 == 0)
            DefendCharge++;
    } 

    private void TakeDamage(int attack)
    {
        int newHp = Hp - (attack - (Defense + DefendCharge));
        {
            if (Determination == true && Hp > 1 && newHp < 1)
                Hp = 1;
            else
                Hp = newHp;
        }
        DefendCharge = 0;
    }   
}
