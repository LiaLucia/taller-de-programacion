using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Hace que sea visible para el Testing
[assembly: InternalsVisibleTo("PruebasEJ3")]
namespace Ej3
{
    /// <summary>
    /// Gestor de prestamos al cual se le pide la evaluacion de la solicitud
    /// </summary>
    class GestorPrestamos
    {
        /// <summary>
        /// Diccionario de los distintos evaluadores segun el tipo de cliente
        /// </summary>
        private Dictionary<TipoCliente,IEvaluador> iEvaluadorPorcliente;

        /// <summary>
        /// constructor de la clase que genera y agrega al diccionario los distintos evaluadores por tipo de cliente
        /// </summary>
        public GestorPrestamos()
        {
            this.iEvaluadorPorcliente = new Dictionary<TipoCliente, IEvaluador>();
            this.iEvaluadorPorcliente.Add(TipoCliente.NoCliente, EvaluadorNoCliente());
            this.iEvaluadorPorcliente.Add(TipoCliente.Cliente, EvaluadorCliente());
            this.iEvaluadorPorcliente.Add(TipoCliente.ClienteGold, EvaluadorClienteGold());
            this.iEvaluadorPorcliente.Add(TipoCliente.ClientePlatinum, EvaluadorClientePremium());
        }

        /// <summary>
        /// Inicia todos los evaluadores simples con sus requerimientos para el NoCliente y los añade al Compuesto
        /// </summary>
        /// <returns></returns>
        public IEvaluador EvaluadorNoCliente()
        {
            EvaluadorCompuesto pEvaluadorCompuesto = new EvaluadorCompuesto();
            EvaluadorAntiguedadLaboral pEvaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad pEvaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo pEvaluadorSueldo = new EvaluadorSueldo(5000);
            EvaluadorMonto pEvaluadorMonto = new EvaluadorMonto(20000);
            EvaluadorCantidadCuotas pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(12);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorAntiguedadLaboral);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorEdad);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorSueldo);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorMonto);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorCantidadCuotas);
            return pEvaluadorCompuesto;
        }

        /// <summary>
        /// Inicia todos los evaluadores simples con sus requerimientos para el Cliente y los añade al Compuesto
        /// </summary>
        /// <returns></returns>
        public IEvaluador EvaluadorCliente()
        {
            EvaluadorCompuesto pEvaluadorCompuesto = new EvaluadorCompuesto();
            EvaluadorAntiguedadLaboral pEvaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad pEvaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo pEvaluadorSueldo = new EvaluadorSueldo(5000);
            EvaluadorMonto pEvaluadorMonto = new EvaluadorMonto(100000);
            EvaluadorCantidadCuotas pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(32);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorMonto);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorAntiguedadLaboral);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorEdad);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorSueldo);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorCantidadCuotas);
            return pEvaluadorCompuesto;
        }

        /// <summary>
        /// Inicia todos los evaluadores simples con sus requerimientos para el ClienteGold y los añade al Compuesto
        /// </summary>
        /// <returns></returns>
        public IEvaluador EvaluadorClienteGold()
        {
            EvaluadorCompuesto pEvaluadorCompuesto = new EvaluadorCompuesto();
            EvaluadorAntiguedadLaboral pEvaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad pEvaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo pEvaluadorSueldo = new EvaluadorSueldo(5000);
            EvaluadorMonto pEvaluadorMonto = new EvaluadorMonto(150000);
            EvaluadorCantidadCuotas pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(60);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorAntiguedadLaboral);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorEdad);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorSueldo);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorMonto);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorCantidadCuotas);
            return pEvaluadorCompuesto;
        }

        /// <summary>
        /// Inicia todos los evaluadores simples con sus requerimientos para el ClientePremium y los añade al Compuesto
        /// </summary>
        /// <returns></returns>
        public IEvaluador EvaluadorClientePremium()
        {
            EvaluadorCompuesto pEvaluadorCompuesto = new EvaluadorCompuesto();
            EvaluadorAntiguedadLaboral pEvaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad pEvaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo pEvaluadorSueldo = new EvaluadorSueldo(5000);
            EvaluadorCantidadCuotas pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(60);
            EvaluadorMonto pEvaluadorMonto = new EvaluadorMonto(200000);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorAntiguedadLaboral);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorEdad);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorSueldo);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorMonto);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorCantidadCuotas);
            return pEvaluadorCompuesto;
        }

        /// <summary>
        /// Obtiene del diccionario el evaluador para el tipo de cliente llama al metodo del evaluador compuesto
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return this.iEvaluadorPorcliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
