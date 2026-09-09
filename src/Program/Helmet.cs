using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Helmet
    {
        public int DefenseValue { get; }

        public Helmet(int defenseValue)
        {
            DefenseValue = defenseValue;
        }
    }
}