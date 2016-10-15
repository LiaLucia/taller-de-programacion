using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Evaluador Concreto por antiguedad laboral minima
    /// </summary>
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }
        /// <summary>
        /// Verificacion de la solicitud segun el evaluador
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if ((DateTime.Today-pSolicitud.Cliente.Empleo.FechaIngreso).TotalDays >= this.iAntiguedadMinima*12)
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
