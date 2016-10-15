using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Fachada
    {
        /// <summary>
        /// Instancia de la fabrica de encriptadores que utiliza el patron singleton
        /// </summary>
        static FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

        /// <summary>
        /// Obtiene el encriptador Cesar de la fabrica y realiza la encriptacion
        /// </summary>
        /// <param name="pCadena">cadena a encriptar</param>
        /// <returns>cadena encriptada</returns>
        public string EncriptarCesar(string pCadena)
        {
            IEncriptador eCesar = instancia.GetEncriptador("Cesar");
            return eCesar.Encriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador Cesar de la fabrica y realiza la desencriptacion
        /// </summary>
        /// <param name="pCadena">cadena encriptada</param>
        /// <returns>cadena original</returns>
        public string DesencriptarCesar(string pCadena)
        {
            IEncriptador eCesar = instancia.GetEncriptador("Cesar");
            return eCesar.Desencriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador AES de la fabrica y realiza la encriptacion
        /// </summary>
        /// <param name="pCadena">cadena a encriptar</param>
        /// <returns>cadena encriptada</returns>
        public string EncriptarAES(string pCadena)
        {
            IEncriptador eAES = instancia.GetEncriptador("AES");
            return eAES.Encriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador AES de la fabrica y realiza la desencriptacion
        /// </summary>
        /// <param name="pCadena">cadena encriptada</param>
        /// <returns>cadena original</returns>
        public string DesencriptarAES(string pCadena)
        {
            IEncriptador eAES = instancia.GetEncriptador("AES");
            return eAES.Desencriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador Null de la fabrica y realiza la encriptacion
        /// </summary>
        /// <param name="pCadena">cadena a encriptar</param>
        /// <returns>cadena encriptada</returns>
        public string EncriptarNulo(string pCadena)
        {
            IEncriptador eNull = instancia.GetEncriptador("Null");
            return eNull.Encriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador Null de la fabrica y realiza la desencriptacion
        /// </summary>
        /// <param name="pCadena">cadena encriptada</param>
        /// <returns>cadena original</returns>
        public string DesencriptarNulo(string pCadena)
        {
            IEncriptador eNull = instancia.GetEncriptador("Null");
            return eNull.Desencriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador TripleDES de la fabrica y realiza la encriptacion
        /// </summary>
        /// <param name="pCadena">cadena a encriptar</param>
        /// <returns>cadena encriptada</returns>
        public string EncriptarTripleDES(string pCadena)
        {
            IEncriptador tripleDES = instancia.GetEncriptador("TripleDES");
            return tripleDES.Encriptar(pCadena);
        }
        /// <summary>
        /// Obtiene el encriptador TripleDES de la fabrica y realiza la desencriptacion
        /// </summary>
        /// <param name="pCadena">cadena encriptada</param>
        /// <returns>cadena original</returns>
        public string DesencriptarTripleDES(string pCadena)
        {
            IEncriptador tripleDES = instancia.GetEncriptador("TripleDES");
            return tripleDES.Desencriptar(pCadena);
        }
    }
}
