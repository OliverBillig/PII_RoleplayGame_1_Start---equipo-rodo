using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Armor
    {
        public int DefenseValue { get; }
        public string Nombre { get; }
        public Armor(string nombre, int defenseValue)
        {
            Nombre = nombre;
            DefenseValue = defenseValue;
        }
    }
}