using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Caballero
    {
        public string Nombre { get ;  set; }
        public int Vida { get ;  set; }

        public Caballero(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public int AtaqueSagrado()
        {
            
        }
    }
}