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

    class Fachada
    {
        public Cliente CrearCliente(string Pnombre, string pApellido, DateTime pFechaNacimiento, TipoCliente pTipoCliente,Empleo pEmpleo)
        {
            return new Cliente(Pnombre, pApellido, pFechaNacimiento, pTipoCliente, pEmpleo);
        }
        public Empleo CrearEmpleo(float pSueldo, DateTime pFechaIngreso)
        {
            return new Empleo(pSueldo, pFechaIngreso);
        }
        public SolicitudPrestamo CrearSolicitud (Cliente pCliente, float pMonto, int pCantidadCuotas)
        {
            return new SolicitudPrestamo(pCliente, pMonto, pCantidadCuotas); 
        }
        public GestorPrestamos CrearGestor()
        {
            return new GestorPrestamos();
        }
        public bool VerificarSolicitud(GestorPrestamos pgestor, SolicitudPrestamo pSolicitud)
        {
            return pgestor.EsValida(pSolicitud);
        }
    }
}
