using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Animal
    {
        public virtual void HacerRuido()
        { }

        public void Correr ()
        {
            Console.WriteLine("Corriendo");
        }

        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
    }
}
