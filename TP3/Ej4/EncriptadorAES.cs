using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ej4
{
    class EncriptadorAES : Encriptador
    {

        public EncriptadorAES() : base("AES") { }



        public override string Encriptar(string pCadena)
        {
            using (Aes pAes = Aes.Create())
            {
               return EncryptStringToBytes_Aes(pCadena, pAes.Key, pAes.IV);
            }

        }
        public override string Desencriptar(string pCadena)
        {
            using (Aes pAes = Aes.Create())
            {
                return DecryptStringFromBytes_Aes(pCadena, pAes.Key, pAes.IV);
            }
        }

        static string EncryptStringToBytes_Aes(string plainText, byte[] Key,byte[] IV)
        {
            string encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }

        static string DecryptStringFromBytes_Aes(string cipherText, byte[] Key, byte[] IV)
        {
            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                int integer;
                int.TryParse(cipherText,out integer);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(integer))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                                                        // and place them in a string.
                                                        plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
   
    }
}
