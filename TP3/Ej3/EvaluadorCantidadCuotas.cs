using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Evaluador concreto segun cantidad de cuotas en que puede pagar un cliente
    /// </summary>
    class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }
        /// <summary>
        /// Verificacion de la solicitud segun cantidad de cuotas maximas
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
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
