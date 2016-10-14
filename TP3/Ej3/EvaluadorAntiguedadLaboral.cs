using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }
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
