using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.RolePlayGame
{
    public class Enanos
    {
        public string Nombre { get ;  set; }
        public int Vida { get ;  set; }

        public Enanos(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public int RecibirAtaque()
        {
            
        }
    }
}