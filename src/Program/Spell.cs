using System;
using System.Security.Cryptography.X509Certificates;

namespace Ucu.Poo.RolePlayGame
{
    public class Spell
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }
        public string Nombre { get; }

        public Spell(string nombre, int attackValue, int defenseValue)
        {
            Nombre = nombre;
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }
    }
}
