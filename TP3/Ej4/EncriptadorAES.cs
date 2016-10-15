using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ej4
{   
    /// <summary>
    /// Advanced Encryption Standard concreto que utiliza librerias del Framework
    /// </summary>
    class EncriptadorAES : Encriptador
    {

        public EncriptadorAES() : base("AES") { }


        /// <summary>
        /// Algoritmo de Encriptacion
        /// </summary>
        /// <param name="clearText">Cadena a encriptar</param>
        /// <returns>Clave encriptada</returns>
        public override string Encriptar(string pCadena)
        {
            //Se crea una clave de encriptacion y se obtienen los bytes de la cadena.
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(pCadena);

            //Usando la clase AES, se crea un ecriptador.
            using (Aes encryptor = Aes.Create())
            {
                //Utilizando la clave de encriptacion crea un conjunto de bytes aleatorios.
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                //Le asigna al encriptador los valores aleatorios (en formato byte) a la Key y al IV.
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                //Se crea un flujo de memoria.
                using (MemoryStream ms = new MemoryStream())
                {
                    //Se crea un flujo de memoria encriptado, utilizando el encriptador y se lo asigna al modo escribir.
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        //Escribe en el flujo encriptado, los bytes de la palabra.
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    //Convierte el texto encriptado en bytes a un string.
                    pCadena = Convert.ToBase64String(ms.ToArray());
                }
            }
            return pCadena;
        }
        /// <summary>
        /// Algoritmo de Desencriptacion
        /// </summary>
        /// <param name="pCadena"> Clave encriptada</param>
        /// <returns>Cadena original</returns>
        public override string Desencriptar(string pCadena)
        {
            string EncryptionKey = "abc123";
            pCadena = pCadena.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(pCadena);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    pCadena = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return pCadena;
        }
   
    }
}
