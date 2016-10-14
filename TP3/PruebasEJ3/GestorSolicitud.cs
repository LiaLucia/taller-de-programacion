using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej3;
namespace PruebasEJ3
{
    [TestClass]
    public class GestorSolicitud
    {
        [TestMethod]
        public void ClienteValido()
        {
            Empleo Cajero = new Empleo(10000, new DateTime(2005, 10, 20));
            Cliente Cliente_1 = new Cliente("Juan", "Perez", new DateTime(1980, 04, 15), TipoCliente.Cliente, Cajero);
            SolicitudPrestamo SolPrestamo_1 = new SolicitudPrestamo(Cliente_1, 50000, 30);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperadoTrue = true;
            bool resultadoTrue = Gestor.EsValida(SolPrestamo_1);

            Assert.AreEqual(resEsperadoTrue, resultadoTrue);

        }


        [TestMethod]
        public void ClienteInvalido()
        {
            Empleo Maestro = new Empleo(10000, new DateTime(2005, 10, 20));
            Cliente Cliente = new Cliente("Juan", "Perez", new DateTime(1980, 04, 15), TipoCliente.Cliente, Maestro);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 150000, 33);
            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = false;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);
        }
    

        [TestMethod]
        public void NoClienteValido()
        {
            Empleo Farmaceutico = new Empleo(12000, new DateTime(2015, 10, 20));
            Cliente Cliente = new Cliente("Maria", "Lopez", new DateTime(1985, 04, 15), TipoCliente.NoCliente, Farmaceutico);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 12000, 5);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = true;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);


        }


        [TestMethod]
        public void NoClienteInvalido()
        {
            Empleo Farmaceutico = new Empleo(12000, new DateTime(2015, 10, 20));
            Cliente Cliente = new Cliente("Maria", "Lopez", new DateTime(1985, 04, 15), TipoCliente.NoCliente, Farmaceutico);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 21000, 5);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = false;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);


        }

        [TestMethod]
        public void ClienteGoldValido()
        {
            Empleo Doctor = new Empleo(19000, new DateTime(2016, 01, 15));
            Cliente Cliente = new Cliente("Mario", "Gonzalez", new DateTime(1985, 04, 15), TipoCliente.ClienteGold, Doctor);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 140000, 50);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = true;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);


        }


        [TestMethod]
        public void ClienteGoldInvalido()
        {
            Empleo Doctor = new Empleo(19000, new DateTime(2016, 01, 15));
            Cliente Cliente = new Cliente("Mario", "Gonzalez", new DateTime(1985, 04, 15), TipoCliente.ClienteGold, Doctor);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 100000, 61);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = false;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);


        }

        [TestMethod]
        public void ClientePlatinumValido()
        {
            Empleo Veterinaria = new Empleo(19000, new DateTime(2000, 12, 19));
            Cliente Cliente = new Cliente("Agustina", "Benitez", new DateTime(1991, 7, 7), TipoCliente.ClientePlatinum, Veterinaria);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 190000, 53);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = true;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);


        }


        [TestMethod]
        public void ClientePlatinumInvalido()
        {
            Empleo Veterinaria = new Empleo(19000, new DateTime(2000, 12, 19));
            Cliente Cliente = new Cliente("Agustina", "Benitez", new DateTime(1991, 7, 7), TipoCliente.ClientePlatinum, Veterinaria);
            SolicitudPrestamo SolPrestamo = new SolicitudPrestamo(Cliente, 200001, 53);

            GestorPrestamos Gestor = new GestorPrestamos();
            bool resEsperado = false;
            bool resultado = Gestor.EsValida(SolPrestamo);

            Assert.AreEqual(resEsperado, resultado);


        }

           }
}
