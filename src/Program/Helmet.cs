using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Helmet
    {
        public int DefenseValue = 4;
        public Helmet(int defensevalue)
        {
            this.DefenseValue = defensevalue;
        }
    }
}