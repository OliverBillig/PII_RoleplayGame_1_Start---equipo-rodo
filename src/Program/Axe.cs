using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Axe
    {
        public int AttackValue { get; }

        public Axe(int attackValue)
        {
            AttackValue = attackValue;
        }
    }
}