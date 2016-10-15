using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Evaluador concreto segun el monto solicitado
    /// </summary>
    class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }
        /// <summary>
        /// Evalua la solicitud segun el maximo que puede solicitar
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Monto <= this.iMontoMaximo)
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
