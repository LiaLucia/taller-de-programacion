using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Menu por consola que permite realizar solicitudes
    /// </summary>
    class Program
    {
        static Fachada fachada = new Fachada();
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Ingrese espacio 1 para generar una solicitud o 0 para salir");
            int.TryParse(Console.ReadLine(), out opcion);
            while (opcion != 0)
            {
                    Dictionary<int, Cliente> listaCliente = new Dictionary<int, Cliente>();

                    Empleo maestroMayorObra = fachada.CrearEmpleo(20000, new DateTime(2005, 8, 12));
                    Empleo teleMarketing = fachada.CrearEmpleo(12000, new DateTime(2016, 7, 5));
                    Empleo juez = fachada.CrearEmpleo(35000, new DateTime(2003, 1, 1));
                    Empleo futbolista = fachada.CrearEmpleo(1000000, new DateTime(2004, 4, 15));

                    Cliente cliente1 = fachada.CrearCliente("Estaban", "Quito", new DateTime(1984, 11, 12), TipoCliente.Cliente, maestroMayorObra);
                    Cliente cliente2 = fachada.CrearCliente("Maxi", "Rodriguez", new DateTime(1978, 1, 15), TipoCliente.NoCliente, teleMarketing);
                    Cliente cliente3 = fachada.CrearCliente("Jose", "Klose", new DateTime(1969, 2, 20), TipoCliente.ClienteGold, juez);
                    Cliente cliente4 = fachada.CrearCliente("Leonel", "Messi", new DateTime(1990, 4, 8), TipoCliente.ClientePremium, futbolista);
                    listaCliente.Add(1, cliente1);
                    listaCliente.Add(2, cliente2);
                    listaCliente.Add(3, cliente3);
                    listaCliente.Add(4, cliente4);
                    int opc;
                    do
                    {
                        Console.WriteLine("Ingrese ID del cliente que quiera solicitar un prestamo");
                        int.TryParse(Console.ReadLine(), out opc);
                    }
                    while (opc < 0 && opc > 5);
                    Cliente clienteSeleccionado = listaCliente[opc];
                    Console.WriteLine(clienteSeleccionado.Nombre + "   " + clienteSeleccionado.Apellido+"   "+clienteSeleccionado.TipoCliente);
                    Console.WriteLine("Ingrese Monto deseado del prestamo");
                    float monto;
                    float.TryParse(Console.ReadLine(), out monto);
                    Console.WriteLine("Ingrese Cantidad de cuotas deseada del prestamo");
                    int cantCuotas;
                    int.TryParse(Console.ReadLine(), out cantCuotas);
                    SolicitudPrestamo solicitud = fachada.CrearSolicitud(clienteSeleccionado, monto, cantCuotas);

                    GestorPrestamos gestorPrestamos = fachada.CrearGestor();

                    bool respuesta = fachada.VerificarSolicitud(gestorPrestamos,solicitud);
                    if (respuesta)
                    {
                        Console.WriteLine("El Prestamo es Valido");
                    }
                    else
                    {
                        Console.WriteLine("El Prestamo es Invalido");
                    }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingrese espacio 1 para generar una solicitud o 0 para salir");
                int.TryParse(Console.ReadLine(), out opcion);
            }

        }
    }
}
