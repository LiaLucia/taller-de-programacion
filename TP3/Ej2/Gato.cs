using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{/// <summary>
/// Subclase de la clase Animal
/// </summary>
    class Gato : Animal
    { /// <summary>
      /// Sonido característico del animal
      /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }
}
