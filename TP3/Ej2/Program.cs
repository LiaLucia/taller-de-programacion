using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales = new Animal[6];
            animales[0] = new Perro();
            animales[1] = new Gato();
            animales[2] = new Pato();
            animales[3] = new Pollito();
            animales[4] = new Cerdo();
            animales[5] = new Gallo();
            Veterinaria vet = new Veterinaria();
            vet.AceptarAnimal(animales);
            Console.ReadLine();
        }
    }
}
