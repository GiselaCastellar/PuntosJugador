using System;

namespace SistemaPuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INGRESO DE JUGADORES POR CONSOLA ===\n");

            // Constructor sin parámetros
            Console.WriteLine("Creación jugador por defecto:");
            PuntosJugador jugador1 = new PuntosJugador();
            jugador1.MostrarInformacion();

            // Constructor con Nombre
            Console.Write("Ingrese el nombre del Jugador 2: ");
            string nombre2 = Console.ReadLine()!;
            PuntosJugador jugador2 = new PuntosJugador(nombre2);
            jugador2.MostrarInformacion();

            // Constructor con Nombre y Puntos
            Console.Write("Ingrese el nombre del Jugador 3: ");
            string nombre3 = Console.ReadLine()!;
            Console.Write("Ingrese los puntos iniciales para " + nombre3 + ": ");
            int puntos3 = int.Parse(Console.ReadLine()!);
            PuntosJugador jugador3 = new PuntosJugador(nombre3, puntos3);
            jugador3.MostrarInformacion();

            // Constructor con Nombre, Puntos y Nivel
            Console.Write("Ingrese el nombre del Jugador 4: ");
            string nombre4 = Console.ReadLine()!;
            Console.Write("Ingrese los puntos iniciales para " + nombre4 + ": ");
            int puntos4 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el nivel inicial para " + nombre4 + ": ");
            int nivel4 = int.Parse(Console.ReadLine()!);
            PuntosJugador jugador4 = new PuntosJugador(nombre4, puntos4, nivel4);
            jugador4.MostrarInformacion();

            Console.WriteLine("\n=== PRUEBA DE AGREGAR PUNTOS ===");

            // Versión 1
            Console.WriteLine("\n-> Sumando 50 puntos a " + nombre2 + ":");
            jugador2.AgregarPuntos(50);

            // Versión 2
            Console.WriteLine("\n-> Sumando 100 puntos a " + nombre3 + ":");
            jugador3.AgregarPuntos(100, "Superó el nivel de práctica");

            // Versión 3

            Console.Write("\n-> Ingrese la cantidad de puntos a agregar con bonificación a " + nombre4 + ": ");
            int puntosBonif = int.Parse(Console.ReadLine()!);

            jugador4.AgregarPuntos(puntosBonif, "Supero el nivel en tiempo record", true);

            Console.WriteLine("\n=== POSICIÓN FINAL DE LOS JUGADORES ===");

            jugador1.MostrarInformacion();
            jugador2.MostrarInformacion();
            jugador3.MostrarInformacion();
            jugador4.MostrarInformacion();

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }
    }
}   