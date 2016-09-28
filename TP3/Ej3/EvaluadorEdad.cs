using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }
        public override Boolean EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Cliente.FechaNacimiento.Year>=this.iEdadMinima & pSolicitud.Cliente.FechaNacimiento.Year <= this.iEdadMinima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
