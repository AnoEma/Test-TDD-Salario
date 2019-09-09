using calculaSalario;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeveCalcular()
        {
            CalculadoreDeSalario calculadora = new CalculadoreDeSalario();
            Funcionario dba = new Funcionario
                ("Arnoboys", 500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(500.0 * 0.85, salario, 0.0001);
        }
    }
}