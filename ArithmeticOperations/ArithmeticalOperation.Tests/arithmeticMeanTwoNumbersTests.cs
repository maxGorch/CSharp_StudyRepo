using NUnit.Framework;


namespace ArithmeticOperations.ArithmeticalOperation.Tests
{
    [TestFixture]
    public class ArithmeticMeanTwoNumbersTests
    {
        private ArithmeticMeanTwoNumbers testFormulSolver;

        [SetUp]
        public void SetUp()
        {
            testFormulSolver = new ArithmeticMeanTwoNumbers();
        }

        [Test]
        public void correctedSolve()
        //Проверка на корректность выполнения метода Solve

        {
            testFormulSolver.setA(25);
            testFormulSolver.setB(15);
            var result = testFormulSolver.Solve();
            Assert.That(20, Is.EqualTo(result));
        }

        [Test]
        public void correctedSetterAndGetterArgumentA()
        //Проверка на корректность заполнения Сеттером и получение Геттером по аргументу A

        {
            testFormulSolver.setA(25);
            Assert.That(25, Is.EqualTo(testFormulSolver.getA()));
        }

        [Test]
        public void correctedSetterAndGetterArgumentB()
        //Проверка на корректность заполнения Сеттером и получение Геттером по аргументу B

        {
            testFormulSolver.setB(15);
            Assert.That(15, Is.EqualTo(testFormulSolver.getB()));
        }
    }
}
