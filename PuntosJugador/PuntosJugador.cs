using System;

namespace SistemaPuntos
{
    // Clase PuntosJugador
    class PuntosJugador
    {
        // Atributos privados
        private string nombreJugador;
        private int puntos;
        private int nivel;

        // Sobrecarga de constructores

        // Constructor de inicialización completa y validaciones
        public PuntosJugador(string nombreJugador, int puntos, int nivel)
        {
            this.nombreJugador = nombreJugador;

            // Validación: Los puntos no pueden ser negativos
            if (puntos < 0)
            {
                this.puntos = 0;
            }
            else
            {
                this.puntos = puntos;
            }

            // Validación: El nivel debe ser mayor o igual a 1
            if (nivel < 1)
            {
                this.nivel = 1;
            }
            else
            {
                this.nivel = nivel;
            }
        }

        // Constructor 1: Sin parámetros
        public PuntosJugador() : this("Jugador Anónimo", 0, 1)
        {
        }

        // Constructor 2: Solo Nombre
        public PuntosJugador(string nombreJugador) : this(nombreJugador, 0, 1)
        {
        }

        // Constructor 3: Nombre y Puntos
        public PuntosJugador(string nombreJugador, int puntos) : this(nombreJugador, puntos, 1)
        {
        }

        // Sobrecarga del método AgregarPuntos

        // Versión 1: Agregar puntos básicos
        public void AgregarPuntos(int puntos)
        {
            if (puntos > 0)
            {
                this.puntos = this.puntos + puntos;
                Console.WriteLine(this.nombreJugador + " sumó " + puntos + " puntos.");
            }
            else
            {
                Console.WriteLine("La cantidad de puntos a agregar debe ser mayor a 0.");
            }
        }

        // Versión 2: Agregar puntos con motivo
        public void AgregarPuntos(int puntos, string motivo)
        {
            if (puntos > 0)
            {
                this.AgregarPuntos(puntos);
                Console.WriteLine("Motivo: " + motivo);
            }
        }

        // Versión 3: Agregar puntos, motivo y bonificación
        
        public void AgregarPuntos(int puntos, string motivo, bool bonificacion)
        {
            if (puntos > 0)
            {
                int puntosFinales = puntos;

                if (bonificacion == true)
                {
                    puntosFinales = puntos * 2;
                    Console.WriteLine("¡BONIFICACIÓN APLICADA! Se otorgó el doble de puntos.");
                }

                this.AgregarPuntos(puntosFinales, motivo);
            }
        }

        // Método MostrarInformacion
        public void MostrarInformacion()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Jugador: " + this.nombreJugador);
            Console.WriteLine("Puntos: " + this.puntos);
            Console.WriteLine("Nivel: " + this.nivel);
            Console.WriteLine("----------------------------------");
        }
         
        // Operador +
        public static PuntosJugador operator +(PuntosJugador j1, PuntosJugador j2)
        {
            string nuevoNombre = j1.nombreJugador + " y " + j2.nombreJugador;
            int nuevosPuntos = j1.puntos + j2.puntos;

            return new PuntosJugador(nuevoNombre, nuevosPuntos, 1);
        }

        // Operador -
        public static PuntosJugador operator -(PuntosJugador j1, PuntosJugador j2)
        {
            int resultadoPuntos = j1.puntos - j2.puntos;

            if (resultadoPuntos < 0)
            {
                resultadoPuntos = 0;
            }

            return new PuntosJugador("Diferencia de " + j1.nombreJugador, resultadoPuntos, 1);
        }

        // Operador ==
        public static bool operator ==(PuntosJugador j1, PuntosJugador j2)
        {
            if (j1.puntos == j2.puntos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Operador !=
        public static bool operator !=(PuntosJugador j1, PuntosJugador j2)
        {
            if (j1.puntos != j2.puntos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Conversión explícita (PuntosJugador -> int)
        public static explicit operator int(PuntosJugador j)
        {
            return j.puntos;
        }

        // Conversión implícita (int -> PuntosJugador)
        public static implicit operator PuntosJugador(int puntosEntrada)
        {
            return new PuntosJugador("Jugador Nuevo", puntosEntrada, 1);
        }


    }
}