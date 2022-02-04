using Microsoft.VisualStudio.TestTools.UnitTesting;
using Instalacao_Configuracao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instalacao_Configuracao.Tests
{
    [TestClass()]
    public class ContaTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            // arrange
            var x = 5.0;
            var y = 6.0;
            var esperado = 11.0;
            var teste = new Conta();

            // act
            var resultado = teste.Soma(x, y);

            // assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            // arrange
            var x = 5.0;
            var y = 6.0;
            var esperado = -1.0;
            var teste = new Conta();

            // act
            var resultado = teste.Subtracao(x, y);

            // assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}