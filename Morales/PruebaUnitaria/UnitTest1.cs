using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sebastian;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaSave()
        {
            //Organizar
            string Nombre = "Prueba";
            double Monto = 500;
            double Montoahorrado = 400;
            Company ObjetoPrueba = new Company(Nombre, Monto);
            //Actuar
            ObjetoPrueba.Save(Montoahorrado);
            double Montoobtenido = ObjetoPrueba.SaveProject;
            //Afirmar
            double Montoesperado = 900;
            Assert.AreEqual(Montoesperado, Montoobtenido);
        }

        [TestMethod]
        public void PruebaSpend()
        {
            //Organizar
            string Nombre = "Prueba";
            double Monto = 500;
            double Montogastado = 400;
            Company ObjetoPrueba = new Company(Nombre, Monto);
            //Actuar
            ObjetoPrueba.Spend(Montogastado);
            double Montoobtenido = ObjetoPrueba.SaveProject;
            //Afirmar
            double Montoesperado = 100;
            Assert.AreEqual(Montoesperado, Montoobtenido);
        }

        [TestMethod]
        public void PruebaChangeName()
        {
            //Organizar
            string Nombre = "Nombre1";
            double Monto = 500;
            Company ObjetoPrueba = new Company(Nombre, Monto);
            //Actuar
            string Nombre2 = "Nombre2";
            ObjetoPrueba.ChangeName(Nombre2);
            string Nombreobtenido = ObjetoPrueba.Name;
            //Afirmar          
            Assert.AreEqual(Nombre2, Nombreobtenido);
        }
    }
}
