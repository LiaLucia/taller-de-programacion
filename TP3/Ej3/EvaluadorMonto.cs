using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }
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
