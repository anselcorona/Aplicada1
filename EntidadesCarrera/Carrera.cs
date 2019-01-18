using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarrera
{
    public class Carrera
    {
        #region "Atributos"

        public int Distancia { get; set; }
        public List<Caballo> Caballos{ get; set; }
        public float DineroDisponible { get; set; }
        public float DineroApostado { get; set; }
        public int IdCaballoApostado { get; set; }
        #endregion
    }
}
