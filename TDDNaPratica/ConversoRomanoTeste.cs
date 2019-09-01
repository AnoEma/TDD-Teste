using NUnit.Framework;
using TDDNaPratrica;

namespace Tests
{
    [TestFixture]
    public class ConversoRomanoTeste
    {
        [Test]
        public void DeveEntenderOSimbloloXXII()
        {
            ConversoRomano romano = new ConversoRomano();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderOSimbloloIX()
        {
            ConversoRomano romano = new ConversoRomano();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }
    }
}