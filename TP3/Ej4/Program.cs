using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    /// <summary>
    /// Menu de consola con los distintos encriptadores para aplicarlos a una cadena
    /// </summary>
    class Program
    {
        static Fachada fachada = new Fachada();
        static void Main(string[] args)
        {
            int opc = 10;
            string cadena = null;
            int opcCadena;
            do
            {
                do
                {
                    Console.WriteLine("Elija un algoritmo de encriptación");
                    Console.WriteLine("1- Cesar");
                    Console.WriteLine("2- AES");
                    Console.WriteLine("3- Nulo");
                    Console.WriteLine("4- Triple DES");
                    Console.WriteLine("0- Salir");
                    int.TryParse(Console.ReadLine(), out opc);
                }
                while (opc > 3 && opc < 0);

                Console.Clear();
                if (opc != 0)
                {
                    if (cadena != null)
                    {
                        Console.WriteLine("Presione 0 para continuar con la cadena anterior o 1 para elegir una nueva");
                        int.TryParse(Console.ReadLine(), out opcCadena);
                        if (opcCadena == 1)
                        {
                            Console.WriteLine("Inserte Cadena a encriptar");
                            cadena = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inserte Cadena a encriptar");
                        cadena = Console.ReadLine();
                    }
                }
                string encriptada;
                switch (opc)
                {
                    case 1:
                        encriptada = fachada.EncriptarCesar(cadena);
                        Console.WriteLine("La cadena encriptada es: " + encriptada);
                        cadena = fachada.DesencriptarCesar(encriptada);
                        Console.WriteLine("Y la cadena desencriptada es: " + cadena);
                        break;
                    case 2:
                        encriptada = fachada.EncriptarAES(cadena);
                        Console.WriteLine("La cadena encriptada es: " + encriptada);
                        cadena = fachada.DesencriptarAES(encriptada);
                        Console.WriteLine("Y la cadena desencriptada es: " + cadena);
                        break;
                    case 3:
                        encriptada = fachada.EncriptarNulo(cadena);
                        Console.WriteLine("La cadena encriptada es: " + encriptada);
                        cadena = fachada.DesencriptarNulo(encriptada);
                        Console.WriteLine("Y la cadena desencriptada es: " + cadena);
                        break;
                    case 4:
                        encriptada = fachada.EncriptarTripleDES(cadena);
                        Console.WriteLine("La cadena encriptada es: " + encriptada);
                        cadena = fachada.DesencriptarTripleDES(encriptada);
                        Console.WriteLine("Y la cadena desencriptada es: " + cadena);
                        break;
                    default:
                        break;
                }
            }
            while (opc != 0);
        }
    }
}
