using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Ej4
{
    /// <summary>
    /// Triple Digital Encryption Standard, Encriptador Concreto 
    /// </summary>
    class EncriptadorTripleDES : Encriptador
    {
        /// <summary>
        /// Clave del encriptador
        /// </summary>
        string key = "ABCDEFG54669525PQRSTUVWXYZabcdef852846opqrstuvwxyz";

        public EncriptadorTripleDES(): base("TripleDES")  {  }
    
        /// <summary>
        /// Algoritmo de encriptacion, utiliza Algoritmo MD5 Para encriptar la clave
        /// </summary>
        /// <param name="pCadena">cadena a encriptar</param>
        /// <returns>cadena encriptada</returns>
        public override string Encriptar(string pCadena)

	        {
	            byte[] keyArray;

	            byte[] Arreglo_a_Cifrar =UTF8Encoding.UTF8.GetBytes(pCadena);
            
	            //se utilizan las clases de encriptación provistas por el Framework  Algoritmo MD5

	            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

	            //se guarda la llave para que se le realice  hashing

	            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
	            hashmd5.Clear();

	            //Algoritmo 3DAS
	            TripleDESCryptoServiceProvider tdes =new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
	            tdes.Mode = CipherMode.ECB;
	            tdes.Padding = PaddingMode.PKCS7;

	            //se empieza con la transformación de la cadena
	            ICryptoTransform cTransform =tdes.CreateEncryptor();
            
	            //arreglo de bytes donde se guarda la cadena cifrada

	            byte[] ArrayResultado =cTransform.TransformFinalBlock(Arreglo_a_Cifrar,0, Arreglo_a_Cifrar.Length);
                tdes.Clear();
	            //se regresa el resultado en forma de una cadena

	            return Convert.ToBase64String(ArrayResultado,0, ArrayResultado.Length);
        }

	 
            /// <summary>
            /// Algoritmo de desencriptacion, debe desencriptar la clave con el algoritmo MD5 usado en la encriptacion
            /// </summary>
            /// <param name="pCadena">clave encriptada</param>
            /// <returns>cadena original</returns>
	        public override string Desencriptar(string pCadena)

	        {
                byte[] keyArray;

	             //convierte el texto en una secuencia de bytes

	             byte[] Array_a_Descifrar =Convert.FromBase64String(pCadena);

	             //se llama a las clases que tienen los algoritmos de encriptación se le aplica hashing algoritmo MD5

	             MD5CryptoServiceProvider hashmd5 =new MD5CryptoServiceProvider();
                 keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
	             hashmd5.Clear();
	             TripleDESCryptoServiceProvider tdes =new TripleDESCryptoServiceProvider();
                 tdes.Key = keyArray;
	             tdes.Mode = CipherMode.ECB;
	             tdes.Padding = PaddingMode.PKCS7;
	             ICryptoTransform cTransform =tdes.CreateDecryptor();
	             byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar,0, Array_a_Descifrar.Length);
	             tdes.Clear();
	             //se regresa en forma de cadena
	             return UTF8Encoding.UTF8.GetString(resultArray);
	        }
	    }
    }
