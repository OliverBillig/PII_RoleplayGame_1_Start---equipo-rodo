using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Bow
    {
        public int AttackValue { get; }
        public string Nombre { get; }
        public Bow(string nombre, int attackValue)
        {
            Nombre = nombre;
            AttackValue = attackValue;
        }
    }
}