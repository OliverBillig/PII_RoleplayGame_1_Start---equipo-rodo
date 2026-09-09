using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Sword
    {
        public int AttackValue { get; }
        public string Nombre { get; }

        public Sword(string nombre, int attackValue)
        {
            Nombre = nombre;
            AttackValue = attackValue;
        }
    }
}