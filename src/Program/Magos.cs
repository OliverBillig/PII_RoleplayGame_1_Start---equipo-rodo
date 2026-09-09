using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Magos
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        private int vidaInicial;

        public Magos(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.vidaInicial = vida;
        }

        public int ObtenerDefensa()
        {
            return 0;
        }

        public int ObtenerAtaque()
        {
            return 0;
        }

        public bool EsquivarAtaque()
        {
            int defensa = this.ObtenerDefensa();
            int probabilidad = 80 - (defensa * 2);
            probabilidad = Math.Clamp(probabilidad, 5, 80);

            Random rnd = new Random();
            return rnd.Next(1, 101) <= probabilidad;
        }

        public void RecibirAtaque(int valorAtaque)
        {
            if (valorAtaque <= 0) return;

            if (this.EsquivarAtaque())
            {
                Console.WriteLine($"{this.Nombre} esquivó el ataque con un conjuro!");
                return;
            }

            int danoEfectivo = valorAtaque - this.ObtenerDefensa();

            if (danoEfectivo <= 0)
            {
                danoEfectivo = 1;
            }

            this.Vida -= danoEfectivo;
            if (this.Vida < 0)
            {
                this.Vida = 0;
            }
        }

        public void Curar()
        {
            this.Vida = this.vidaInicial;
        }
    }
}