using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Axe
    {
        public int AttackValue { get; }
        public string Nombre { get; }

        public Axe(string nombre, int attackValue)
        {
            Nombre = nombre;
            AttackValue = attackValue;
        }
    }
}