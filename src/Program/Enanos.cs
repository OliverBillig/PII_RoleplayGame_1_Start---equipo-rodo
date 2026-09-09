using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Enanos
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        private int vidaInicial;

        public Enanos(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.vidaInicial = vida;
        }

        public int ObtenerDefensa()
        {
            // Retorna la defensa total acumulada por sus ítems (por ahora 0)
            return 0;
        }

        public int ObtenerAtaque()
        {
            // Retorna el ataque total acumulado por sus ítems (por ahora 0)
            return 0;
        }

        /// <summary>
        /// Los enanos son más pesados, por lo que tienen menor probabilidad de esquive base.
        /// A mayor defensa total, menor probabilidad de esquivar.
        /// </summary>
        public bool EsquivarAtaque()
        {
            int defensa = this.ObtenerDefensa();
            int probabilidad = 60 - (defensa * 2);
            probabilidad = Math.Clamp(probabilidad, 2, 60);

            Random rnd = new Random();
            return rnd.Next(1, 101) <= probabilidad;
        }

        /// <summary>
        /// Recibe un ataque. Si lo esquiva, no sufre daño.
        /// Si la defensa supera o empata al ataque, recibe al menos 1 de daño.
        /// </summary>
        public void RecibirAtaque(int valorAtaque)
        {
            if (valorAtaque <= 0) return;

            if (this.EsquivarAtaque())
            {
                Console.WriteLine($"{this.Nombre} esquivó el ataque!");
                return;
            }

            int danoEfectivo = valorAtaque - this.ObtenerDefensa();

            // Regla de negocio: Si el ataque es menor o igual a la defensa, recibe 1 de daño
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