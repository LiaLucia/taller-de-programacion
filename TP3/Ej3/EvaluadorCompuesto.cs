using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Evaluador Compuesto, contiene evaluadores en una lista.
    /// Utiliza patron Composite
    /// </summary>
    class EvaluadorCompuesto : IEvaluador
    {
        private List<IEvaluador> evaluadores;

        public EvaluadorCompuesto()
        {
            this.evaluadores = new List<IEvaluador>();
        }

        /// <summary>
        /// Verifica la solicitud mediante los distintos evaluadores simples de la lista de evaluadores
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Añade un nuevo evaluador a la lista
        /// </summary>
        /// <param name="pEvaulador"></param>
        public void AgregarEvaluador(IEvaluador pEvaulador)
        {
            this.evaluadores.Add(pEvaulador);
        }

    }
}
