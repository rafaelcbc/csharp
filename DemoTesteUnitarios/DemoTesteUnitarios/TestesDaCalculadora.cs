using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTesteUnitarios
{
    /// <summary>
    /// Inicializando uma classe de teste
    /// </summary>
    [TestClass]
    public class TestesDaCalculadora
    {
        private Calculadora calculadora;

        /// <summary>
        /// Inicializando o objeto da classe de teste
        /// </summary>
        [TestInitialize]
        public void IniciarTestes()
        {
            calculadora = new Calculadora();
        }

        /// <summary>
        /// Finalizando o objeto da classe de teste
        /// </summary>
        [TestCleanup]
        public void FinalizarTestes()
        {
            Debug.WriteLine("Teste Finalizado!");
        }

        /// <summary>
        /// Método de teste
        /// </summary>
        [TestMethod]
        public void Soma_deve_retornar_10_quando_passar_9_e_1()
        {
            var retorno = calculadora.Soma(9, 1);

            //A classe "Assert" é a classe para utilização dos métodos de teste
            //Testando o método Soma da classe Calculadora
            Assert.AreEqual(10, retorno);
        }

        /// <summary>
        /// Método de teste
        /// </summary>
        [TestMethod]
        public void Soma_deve_retornar_63_quando_passar_40_e_23()
        {
            var retorno = calculadora.Soma(40, 23);

            Assert.AreEqual(63, retorno);
        }
    }
}
