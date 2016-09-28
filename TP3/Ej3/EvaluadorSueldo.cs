using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorSueldo : IEvaluador
    {
        private double iSuledoMinimo;
        
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSuledoMinimo = pSueldoMinimo;
        }
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
