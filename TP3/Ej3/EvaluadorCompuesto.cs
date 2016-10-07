using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCompuesto : IEvaluador
    {
        private List<IEvaluador> evaluadores;

        public EvaluadorCompuesto()
        {
            this.evaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool resultado = true;
            foreach(IEvaluador evaluador in evaluadores)
            {
                if (evaluador.EsValida(pSolicitud)==false)
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        public void AgregarEvaluador(IEvaluador pEvaulador)
        {
            this.evaluadores.Add(pEvaulador);
        }

    }
}
