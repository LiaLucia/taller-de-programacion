using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Fachada
    {
        static FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;
        public string EncriptarCesar(string pCadena)
        {
            IEncriptador eCesar = instancia.GetEncriptador("Cesar");
            return eCesar.Encriptar(pCadena);
        }
        public string DesencriptarCesar(string pCadena)
        {
            IEncriptador eCesar = instancia.GetEncriptador("Cesar");
            return eCesar.Desencriptar(pCadena);
        }
        public string EncriptarAES(string pCadena)
        {
            IEncriptador eAES = instancia.GetEncriptador("AES");
            return eAES.Encriptar(pCadena);
        }
        public string DesencriptarAES(string pCadena)
        {
            IEncriptador eAES = instancia.GetEncriptador("AES");
            return eAES.Desencriptar(pCadena);
        }
        public string EncriptarNulo(string pCadena)
        {
            IEncriptador eNull = instancia.GetEncriptador("Null");
            return eNull.Encriptar(pCadena);
        }
        public string DesencriptarNulo(string pCadena)
        {
            IEncriptador eNull = instancia.GetEncriptador("Null");
            return eNull.Desencriptar(pCadena);
        }
    }
}
