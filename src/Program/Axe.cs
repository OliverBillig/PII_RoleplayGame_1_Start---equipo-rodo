using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Axe
    {
        public int AtackValue = 8;
        public int DefenseValue = 3;
        public Axe(int atackvalue)
        {
            this.AtackValue = atackvalue;
        }
    }
}