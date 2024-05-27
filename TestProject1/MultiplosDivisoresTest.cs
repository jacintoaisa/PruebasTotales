using PruebasInicial.Services;

namespace TestProject1
{
    [TestClass]
    public class MultiplosDivisoresTest
    {
        MultiplosYDivisoresUno miCalculadora = new MultiplosYDivisoresUno();
        [TestMethod]
        public void MaximoComunDivisor()
        {
            var resultado = miCalculadora.MaximoComunDivisor(14, 4);
            Assert.AreEqual(2,resultado);
        }

        [TestMethod]
        public void MinimoComunMultiplo()
        {
            var resultado = miCalculadora.MinimoComunMultiplo(2,3);
            Assert.AreEqual(6,resultado);
        }

       
    }
}