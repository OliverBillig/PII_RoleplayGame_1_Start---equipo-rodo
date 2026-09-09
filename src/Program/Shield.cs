using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Shield
    {
        public int DefenseValue { get; }
        public string Nombre { get; }
        public Shield(string nombre, int defenseValue)
        {
            Nombre = nombre;
            DefenseValue = defenseValue;
        }
    }
}