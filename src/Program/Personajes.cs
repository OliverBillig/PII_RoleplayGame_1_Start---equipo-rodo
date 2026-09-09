using System;
using Ucu.Poo.RolePlayGame;

public class Personajes
{
    private Enanos enano1 = new Enanos("Jose", 100);
    private Elfos elfo1 = new Elfos("Emi", 80);
    private Caballero caballero1 = new Caballero("Joaquin", 90);
    private Magos mago1 = new Magos("Voldemort", 70);

    /// <summary>
    /// Simula un ataque del Enano hacia el Elfo.
    /// </summary>
    public void AtaqueEnanoAElfo()
    {
        int poderAtaque = enano1.ObtenerAtaque();
        elfo1.RecibirAtaque(poderAtaque);
    }
}