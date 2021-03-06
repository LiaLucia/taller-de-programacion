﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    /// <summary>
    /// Encriptador Concreto, utiliza un desplazamiento que se aplica a las letras y numeros de la cadena 
    /// </summary>
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento) : base("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }
        /// <summary>
        /// Algoritmo de encriptacion
        /// </summary>
        /// <param name="pCadena"></param>
        /// <returns></returns>
        public override string Encriptar(string pCadena)
        {
            string cadena = "";
            int ascii;
            foreach (char caracter in pCadena)
            {
                //Convierte el caracter en codigo ascii y luego le agrega o no desplazamiento, lo reconvierte en caracter y lo concatena a una nueva cadena
                 ascii = Encoding.ASCII.GetBytes(caracter.ToString())[0];
                if (ascii >= 65 && ascii <= 90)
                {
                    // Si el caracter sale del rango de letras vuelve al comienzo. Ej: z-->c
                    if (ascii + this.iDesplazamiento > 90)
                    {
                        ascii = 91+65- ascii -this.iDesplazamiento;
                    }
                    else
                    {
                        ascii += this.iDesplazamiento;
                    }
                    cadena+= (char)ascii;
                }
                else
                {
                    if (ascii >= 97 && ascii <= 122)
                    {
                        if (ascii + this.iDesplazamiento > 122)
                        {
                            ascii = 97 + 123 - ascii - this.iDesplazamiento;
                        }
                        else
                        {
                            ascii += this.iDesplazamiento;
                        }
                        cadena+= (char)ascii;
                    }
                
                    else
                    {
                        if (ascii >= 48 && ascii <= 57)
                        {
                            if (ascii + this.iDesplazamiento > 57)
                            {
                                ascii = 48+ 58 - ascii -this.iDesplazamiento;
                            }
                            else
                            {
                                ascii += this.iDesplazamiento;
                            }
                            cadena+= (char)ascii;
                        }
                        else
                        {
                            cadena += (char)ascii;
                        }
                    }
                }
            }
                return cadena;
        }


        public override string Desencriptar(string pCadena)
        {
            string cadena = "";
            foreach (char caracter in pCadena)
            {
                int ascii = Encoding.ASCII.GetBytes(caracter.ToString())[0];
                if (ascii >= 65 && ascii <= 90)
                {
                    if (ascii - this.iDesplazamiento <65)
                    {
                        ascii = 91 - (65 -ascii + this.iDesplazamiento);
                    }
                    else
                    {
                        ascii -= this.iDesplazamiento;
                    }
                    cadena += (char)ascii;
                }
                else
                {
                    if (ascii >= 97 && ascii <= 122)
                    {
                        if (ascii - this.iDesplazamiento < 97)
                        {
                            ascii = 123 - (97- ascii + this.iDesplazamiento);
                        }
                        else
                        {
                            ascii -= this.iDesplazamiento;
                        }
                        cadena += (char)ascii;
                    }
                    else
                    {
                        if (ascii >= 48 && ascii <= 57)
                        {
                            if (ascii - this.iDesplazamiento < 48)
                            {
                                ascii = 58 - (48 - ascii + this.iDesplazamiento);
                            }
                            else
                            {
                                ascii -= this.iDesplazamiento;
                            }
                            cadena += (char)ascii;
                        }
                        else
                        {
                            cadena += (char)ascii;
                        }
                    }
         
                }
            }
            return cadena;
        }

    }
}
