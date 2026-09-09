using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Armor
    {
        public int DefenseValue { get; }

        public Armor(int defenseValue)
        {
            DefenseValue = defenseValue;
        }
    }
}