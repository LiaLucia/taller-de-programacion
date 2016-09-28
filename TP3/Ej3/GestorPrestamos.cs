using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class GestorPrestamos
    {
        private IDictionary<TipoCliente,IEvaluador> iEvaluadorPorcliente;

        public GestorPrestamos()
        {
            EvaluadorCompuesto pEvaluadorCompuesto = new EvaluadorCompuesto();
            EvaluadorAntiguedadLaboral pEvaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad pEvaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo pEvaluadorSueldo = new EvaluadorSueldo(5000);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorAntiguedadLaboral);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorEdad);
            pEvaluadorCompuesto.AgregarEvaluador(pEvaluadorSueldo);
            //No Cliente
            EvaluadorCompuesto pEvaluador0 = pEvaluadorCompuesto;
            EvaluadorMonto pEvaluadorMonto = new EvaluadorMonto(20000);
            EvaluadorCantidadCuotas pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(12);
            pEvaluador0.AgregarEvaluador(pEvaluadorMonto);
            pEvaluador0.AgregarEvaluador(pEvaluadorCantidadCuotas);
            this.iEvaluadorPorcliente.Add(TipoCliente.NoCliente,pEvaluador0);
            //Cliente
            EvaluadorCompuesto pEvaluador1 = pEvaluadorCompuesto;
            pEvaluadorMonto = new EvaluadorMonto(100000);
            pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(32);
            pEvaluador1.AgregarEvaluador(pEvaluadorMonto);
            pEvaluador1.AgregarEvaluador(pEvaluadorCantidadCuotas);
            this.iEvaluadorPorcliente.Add(TipoCliente.Cliente, pEvaluador1);
            //Cliente Gold
            EvaluadorCompuesto pEvaluador2 = pEvaluadorCompuesto;
            pEvaluadorMonto = new EvaluadorMonto(150000);
            pEvaluadorCantidadCuotas = new EvaluadorCantidadCuotas(60);
            pEvaluador1.AgregarEvaluador(pEvaluadorMonto);
            pEvaluador1.AgregarEvaluador(pEvaluadorCantidadCuotas);
            this.iEvaluadorPorcliente.Add(TipoCliente.ClienteGold, pEvaluador2);
            //Cliente Platinum
            EvaluadorCompuesto pEvaluador3 = pEvaluadorCompuesto;
            pEvaluadorMonto = new EvaluadorMonto(200000);
            pEvaluador1.AgregarEvaluador(pEvaluadorMonto);
            pEvaluador1.AgregarEvaluador(pEvaluadorCantidadCuotas);
            this.iEvaluadorPorcliente.Add(TipoCliente.ClientePlatinum, pEvaluador3);

        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return this.iEvaluadorPorcliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
