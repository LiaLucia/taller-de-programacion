using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{ 
    /// <summary>
    /// Evaluador Concreto simple segun la edad del solicitante
    /// </summary>
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }
        /// <summary>
        /// Verifica la edad del solicitante cumpla con los requisitos
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edad = DateTime.Today.Year-pSolicitud.Cliente.FechaNacimiento.Year;
            if (edad>=this.iEdadMinima && edad<= this.iEdadMaxima)
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
