using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej4;
namespace PruebasEJ4
{
    [TestClass]
    public class Encriptadores
    {
        static FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;
        [TestMethod]
        public void EncriptarAES()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "ingenieria en sistemas";
            IEncriptador eAES = instancia.GetEncriptador("AES");
            string resultadoEsperado = "uXh9ebFzzEzh8ZGOBGv8cvnc7Eakthfru75xslqRWdnCtIfAoYotXRC4sfGis0tC";
            string resultado = eAES.Encriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);
            
        }

        [TestMethod]
        public void DesencriptarAES()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "uXh9ebFzzEzh8ZGOBGv8cvnc7Eakthfru75xslqRWdnCtIfAoYotXRC4sfGis0tC";
            IEncriptador eAES = instancia.GetEncriptador("AES");
            string resultadoEsperado = "ingenieria en sistemas";
            string resultado=eAES.Desencriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void EncriptarCesar()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "ingenieria en sistemas";
            IEncriptador eCesar = instancia.GetEncriptador("Cesar");
            string resultadoEsperado = "lqjhqlhuld hq vlvwhpdv";
            string resultado = eCesar.Encriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void DesencriptarCesar()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "lqjhqlhuld hq vlvwhpdv";
            IEncriptador eCesar = instancia.GetEncriptador("Cesar");
            string resultadoEsperado = "ingenieria en sistemas";
            string resultado = eCesar.Desencriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void EncriptarNulo()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "ingenieria en sistemas";
            IEncriptador eNulo = instancia.GetEncriptador("Null");
            string resultadoEsperado = "ingenieria en sistemas";
            string resultado = eNulo.Encriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void EncriptarTripleDes()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "ingenieria en sistemas";
            IEncriptador eDes = instancia.GetEncriptador("TripleDES");
            string resultadoEsperado = "RtnRvAL7+ikViuMmIjUeSiMUfXWV0aHa";
            string resultado = eDes.Encriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);

        }


        [TestMethod]
        public void desencriptarTripleDES()
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia;

            String pCadena = "ingenieria en sistemas";
            IEncriptador eDes = instancia.GetEncriptador("TripleDES");
            string resultadoEsperado = "RtnRvAL7+ikViuMmIjUeSiMUfXWV0aHa";
            string resultado = eDes.Desencriptar(pCadena);

            Assert.AreEqual(resultadoEsperado, resultado);

        }

    }
}
