using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;
        private char[] letras = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z'};
        private char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public override string Encriptar(string pCadena)
        {
            string cadena="";
            int j;
            string unaCadena = pCadena.ToLower();
            foreach (char letra in unaCadena)
            {
                if (letra==' ')
                {
                    cadena +=' ';
                }
                else
                {
                    for (int t = 0; t < numeros.Length; t++)
                    {
                        if (letra == numeros[t])
                        {
                            if (t + this.iDesplazamiento > numeros.Length)
                            {
                                j = t + this.iDesplazamiento - numeros.Length;
                            }
                            else
                            {
                                j = t + this.iDesplazamiento;
                            }
                            cadena += letras[j];
                        }
                    }
                    for (int i = 0; i < letras.Length; i++)
                    {
                        if (letra == letras[i])
                        {
                            if (i + this.iDesplazamiento > letras.Length)
                            {
                                j = i + this.iDesplazamiento - letras.Length;
                            }
                            else
                            {
                                j = i + this.iDesplazamiento;
                            }
                            cadena += letras[j];
                        }
                    }
                }
            }
            return cadena;
        }


        public override string Desencriptar(string pCadena)
        {
            string cadena = "";
            int j;
            string unaCadena = pCadena.ToLower();
            foreach (char letra in unaCadena)
            {
                if (letra == ' ')
                {
                    cadena += ' ';
                }
                else
                {
                    for (int t = 0; t < numeros.Length; t++)
                    {
                        if (letra == numeros[t])
                        {
                            if (t - this.iDesplazamiento < 0)
                            {
                                j = numeros.Length +( t - this.iDesplazamiento);
                            }
                            else
                            {
                                j = t - this.iDesplazamiento;
                            }
                            cadena += letras[j];
                        }
                    }
                    for (int i = 0; i < letras.Length; i++)
                    {
                        if (letra == letras[i])
                        {
                            if (i + this.iDesplazamiento > letras.Length)
                            {
                                j = i + this.iDesplazamiento - letras.Length;
                            }
                            else
                            {
                                j = i + this.iDesplazamiento;
                            }
                            cadena += letras[j];
                        }
                    }
                }
            }
            return cadena;
        }


        public EncriptadorCesar(int pDesplazamiento): base("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }
    }
}
