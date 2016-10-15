using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Veterinaria
    {/// <summary>
    /// Clase que instancia objetos de la clase Animal
    /// </summary>
    /// <param name="pAnimales"> Vector donde se encuentran los animales </param>

        public void AceptarAnimal(Animal[] pAnimales)
        {
            
            foreach (Animal animal in pAnimales)
            {
                animal.HacerRuido();
            }
        }
    }
}
