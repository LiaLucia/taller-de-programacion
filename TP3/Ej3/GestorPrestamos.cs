using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class GestorPrestamos
    {
        private IEvaluador iEvaluadorPorcliente;

        public GestorPrestamos(IEvaluador pEvaluador)
        {
            this.iEvaluadorPorcliente = pEvaluador;
        }
        public Boolean EsValida(SolicitudPrestamo pSolicitud)
        {
            return this.iEvaluadorPorcliente.EsValida(pSolicitud);
        }
    }
}
