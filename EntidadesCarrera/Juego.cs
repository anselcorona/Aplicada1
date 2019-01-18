using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EntidadesCarrera
{
    public class Juego
    {
        #region "Atributos"

        public Carrera Carrera { get; set; }
        public eEstadoJuego Estado { get; set; }
        int _opcionMenu = -1;
        Thread _procesoCaptura;
        #endregion

        #region "Enums"
        public enum eEstadoJuego
        {
            Iniciado,
            EnProceso,
            Apostando,
            Terminado
        }
        #endregion

        #region "Comportamientos"
        public void Iniciar()
        {
            Estado = eEstadoJuego.Iniciado;
            _procesoCaptura = new Thread(CapturarTeclado);
            _procesoCaptura.Start();
        }


        public void Actualizar()
        {
            switch (Estado)
            {
                case eEstadoJuego.Iniciado:
                    if (_opcionMenu != -1 && 
                    _opcionMenu == 1)
                    {
                        Estado = eEstadoJuego.Apostando;
                    }
                    else if(_opcionMenu!=-1 && _opcionMenu == 0)
                    {
                        Estado = eEstadoJuego.Terminado;
                    }
                    break;
            }

        }

        public void Dibujar()
        {
            Console.Clear();
            switch (Estado)
            {
                case eEstadoJuego.Iniciado:
                    MostrarMenu();
                    break;
            }
        }
        public void Finalizar() {
            _procesoCaptura.Abort();
            _procesoCaptura.Join();
        }

        private void MostrarMenu()
        {
            Console.WriteLine("Bienvenido a Carrera de Caballos.");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1: Iniciar partida");
            Console.WriteLine("0: Salir");
        }
        public void CapturarTeclado()
        {
            switch (Estado)
            {
                case eEstadoJuego.Iniciado:
                    Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out _opcionMenu);

                    if (_opcionMenu < 0 || _opcionMenu > 1)
                        _opcionMenu = -1;
                    break;
            }
        }

        #endregion
    }
}
