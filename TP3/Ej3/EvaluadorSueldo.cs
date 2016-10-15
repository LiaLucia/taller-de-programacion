using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Evaluador Simple segun el sueldo del cliente
    /// </summary>
    class EvaluadorSueldo : IEvaluador
    {
        private double iSuledoMinimo;
        
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSuledoMinimo = pSueldoMinimo;
        }

        /// <summary>
        /// Evalua el sueldo minimo que debe tener el cliente de la solicitud
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida (SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Cliente.Empleo.Sueldo>=this.iSuledoMinimo)
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
