using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
   public class Staff
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Staff(int attackValue, int defenseValue)
        {
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }
    }
}