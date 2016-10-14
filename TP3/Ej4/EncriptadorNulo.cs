using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    /// <summary>
    /// Encriptador Nulo, Devuelve la cadena original, no puede ser heredada
    /// </summary>
    sealed class  EncriptadorNulo : Encriptador
    {
        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }
        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
        public EncriptadorNulo(): base("Null") {    }
        }
    }
