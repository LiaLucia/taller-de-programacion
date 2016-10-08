using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public abstract class  Encriptador : IEncriptador
    {
        private string iNombre;
        public abstract string Encriptar(string pCadena);


        public abstract string Desencriptar(string pCadena);

        public string Nombre        { get; }       

        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }
    }
}
