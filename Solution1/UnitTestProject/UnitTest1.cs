using ClassLibrary1;
using NUnit.Framework;

namespace UnitTestProject
{
    public class Tests
    {
        Calculator calculator; 

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void test_additon()
        {
            //arrange
            int num1 = 100;
            int num2 = 250;
            var result = calculator.Add(num1, num2);
            Assert.AreEqual(result, (num1+num2));
        }

        [Test]
        public void test_substraction()
        {
            //arrange
            int num1 = 400;
            int num2 = 250;
            var result = calculator.substract(num1, num2);
            Assert.AreEqual(result, (num1 - num2));
        }

        [Test]
        public void test_multiply()
        {
            //arrange
            int num1 = 100;
            int num2 = 250;
            var result = calculator.multiple(num1, num2);
            Assert.AreEqual(result, (num1 * num2));
        }

        [Test]
        public void test_divide()
        {
            //arrange
            int num1 = 1000;
            int num2 = 250;
            var result = calculator.divide(num1, num2);
            Assert.AreEqual(result, (num1 / num2));
        }

        [Test]
        public void test_divide_failed()
        {
            //arrange
            int num1 = 1000;
            int num2 = 0;
            var result = calculator.divide(num1, num2);
            Assert.AreEqual(result, (num1 / num2));
        }
    }
}