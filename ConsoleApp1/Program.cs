using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EntidadesCarrera;

namespace ConsoleApp1
{
    class Program
    {
        public static Juego Juego { get; set; }

        static void Main(string[] args)
        {
            Juego = new Juego();
            Juego.Iniciar();

            while(Juego.Estado!= Juego.eEstadoJuego.Terminado) {
                Juego.Actualizar();
                Juego.Dibujar();
                Thread.Sleep(42);
            }

            Juego.Finalizar();
        }
    }
}
