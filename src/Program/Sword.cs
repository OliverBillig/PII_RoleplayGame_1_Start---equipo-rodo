using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Sword
    {
        public int AttackValue { get; }

        public Sword(int attackValue)
        {
            AttackValue = attackValue;
        }
    }
}