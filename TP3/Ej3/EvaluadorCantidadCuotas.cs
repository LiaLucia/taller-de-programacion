using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {

            if (pSolicitud.CantidadCuotas <= this.iCantidadMaximaCuotas)
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
