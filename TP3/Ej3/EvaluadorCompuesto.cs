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
            IEnumerator<IEvaluador> enumerador = this.evaluadores.GetEnumerator();
            while (resultado && enumerador.MoveNext())
            {
                resultado = enumerador.Current.EsValida(pSolicitud);

            }
            return resultado;
        }

        public void AgregarEvaluador(IEvaluador pEvaulador)
        {
            this.evaluadores.Add(pEvaulador);
        }

    }
}
