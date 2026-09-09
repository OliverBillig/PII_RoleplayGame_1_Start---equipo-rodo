using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Mago
    {
        public string Nombre { get ;  set; }
        public int Vida { get ;  set; }

        public Mago(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public int AtaqueMagico()
        {
            
        }
    }
}