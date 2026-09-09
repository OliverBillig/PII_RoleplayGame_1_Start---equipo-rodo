using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class SpellsBook
    {
        public int AtackValue = 5;
        public int DefenseValue = 4;
        public SpellsBook(int atackvalue, int defensevalue)
        {
            this.AtackValue = atackvalue;
            this.DefenseValue = defensevalue;
        }
    }
}
