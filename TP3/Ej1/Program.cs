using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales = new Animal[2];
            animales[0] = new Perro();
            animales[1] = new Gato();
            Veterinaria vet = new Veterinaria();
            vet.AceptarAnimal(animales);
            Console.ReadLine();
        }
    }
}
