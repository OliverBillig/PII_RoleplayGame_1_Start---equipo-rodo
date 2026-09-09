using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Helmet
    {
        public int DefenseValue { get; }
        public string Nombre { get; }
        public Helmet(string nombre, int defenseValue)
        {
            Nombre = nombre;
            DefenseValue = defenseValue;
        }
    }
}