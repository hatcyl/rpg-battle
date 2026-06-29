using System;
using System.Diagnostics.CodeAnalysis;
using System.Resources;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp;

public class Monster(int hp, int attack, int defense, string name)
{
    public string Name { get; } = name;
    public int Hp { get; private set; } = hp;
    public int Attack { get; } = attack;
    private int attackCount = 0;
    public int Defense { get; } = defense;
    public bool Determination { get; set; }
    public int DefendCharge { get; set; }
    public bool HealCharge { get; set; } // i want healing to recover 30 health points (HPs)
    public bool IsDead { get; set; }
    public void AttackMonster(Monster opponent)
    {
        attackCount++;
        if (Hp > 0 && opponent.IsDead == false)
            opponent.TakeDamage(Attack);
        else
            return;
        if (attackCount % 3 == 0)
            DefendCharge++;
        else if (attackCount % 5 == 0)
            HealCharge = true;
    } 

    private void TakeDamage(int attack)
    {
        int newHp = Hp - (attack - (Defense + DefendCharge));
        {
            if (Determination == true && Hp > 1 && newHp < 1 && HealCharge == true)
                Hp = 31;
            else if (Determination == true && Hp > 1 && newHp < 1 && HealCharge == false)
                Hp = newHp;
            else if (newHp > 0)
                Hp = newHp;
            else if (newHp <= 0)
                Hp = newHp;
                IsDead = true;
                Console.WriteLine($"{Name} is now dead");
        }
        DefendCharge = 0;
        HealCharge = false;
    }   
}
