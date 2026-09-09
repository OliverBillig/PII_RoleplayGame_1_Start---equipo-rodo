using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace Ucu.Poo.RolePlayGame
{
    public class Elfos
    {
        public string Nombre { get ;  set; }
        public int Vida { get ;  set; }

        public Elfos(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public int AtaqueElfico()
        {
            
        }
    }
}