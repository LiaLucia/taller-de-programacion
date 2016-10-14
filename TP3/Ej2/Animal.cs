using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{

    /// <summary>
    /// Clase abstracta
    /// </summary>
    class Animal
    {
        /// <summary>
        /// Metodo que sera sobreescrito por las subclases
        /// </summary>
        public virtual void HacerRuido()
        { }

        /// <summary>
        /// Metodo para indicar que el animal esta corriendo
        /// </summary>
        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        /// <summary>
        /// Metodo para indicar que el animal esta saltando
        /// </summary>
        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
    }
}
