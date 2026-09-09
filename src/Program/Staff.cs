using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
   public class Staff
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }
        public string Nombre { get; }
        public Staff(string nombre, int attackValue, int defenseValue)
        {
            Nombre = nombre;
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }
    }
}