using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Shield
    {
        public int DefenseValue { get; }

        public Shield(int defenseValue)
        {
            DefenseValue = defenseValue;
        }
    }
}