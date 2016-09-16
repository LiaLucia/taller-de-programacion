using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Veterinaria
    {
        public void AceptarAnimal(Animal[] animales)
        {

            foreach (Animal animal in animales)
            {
                animal.HacerRuido();
            }
        }
    }
}
