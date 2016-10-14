using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Veterinaria
    {/// <summary>
     /// Clase que instancia objetos de la clase animal
     /// </summary>
     /// <param name="pAnimales"> Vector donde se encuentran los animales </param>
        public void AceptarAnimal(Animal[] animales)
        {

            foreach (Animal animal in animales)
            {
                animal.HacerRuido();
            }
        }
    }
}
