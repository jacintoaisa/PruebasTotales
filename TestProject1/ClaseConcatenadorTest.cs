using PruebasInicial.Services; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{


    [TestClass]
    public class ClaseConcatenadorTest
    {

        ConcatenadorUno miConcatenador = new ConcatenadorUno();

        [TestMethod]
        public void concatena01()
        {
            var resultado = miConcatenador.contatena("jacinto", "hola");
            Assert.AreEqual("jacintohola",resultado.ToString(),true);
        }
        [TestMethod]
        public void concatena02()
        {
            var resultado = miConcatenador.contatena(null, "hola");
            Assert.AreNotEqual("jacintohola", resultado.ToString(), true);
        }

        [TestMethod]
        public void diferencia1()
        {
            var resultado = miConcatenador.diferenciaContaje("jacinto", "hola");
            Assert.AreEqual(3, resultado);
        }

    }
}
