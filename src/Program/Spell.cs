using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Spell
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Spell(int attackValue, int defenseValue)
        {
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }
    }
}
