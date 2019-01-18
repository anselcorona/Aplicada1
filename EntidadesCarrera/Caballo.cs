using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarrera
{
    public class Caballo
    {
        #region "Atributos"
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public float VelocidadInicial { get; set; }
        public float AceleracionX { get; set; }
        public float TiempoInicial { get; set; }
        #endregion

        #region "Comportamientos"
        public void Correr()
        {

        }

        public bool Llego(int meta)
        {
            return false;
        }

        public void Detener()
        {

        }
        #endregion

    }
}
