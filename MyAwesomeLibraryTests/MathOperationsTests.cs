using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeLibrary;

namespace MyAwesomeLibraryTests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void Add_Double_ReturnsCorrectSum()
        {
            Assert.AreEqual(5.0, MathOperations.Add(2.5, 2.5));
        }

        [TestMethod]
        public void Add_Int_ReturnsCorrectSum()
        {
            Assert.AreEqual(5, MathOperations.Add(2, 3));
        }

        [TestMethod]
        public void Add_String_ReturnsCorrectSum()
        {
            Assert.AreEqual(5.0, MathOperations.Add("2.5", "2.5"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_String_InvalidInput_ThrowsException()
        {
            MathOperations.Add("invalid", "2.5");
        }

        [TestMethod]
        public void Subtract_Double_ReturnsCorrectDifference()
        {
            Assert.AreEqual(1.0, MathOperations.Subtract(3.5, 2.5));
        }

        [TestMethod]
        public void Subtract_Int_ReturnsCorrectDifference()
        {
            Assert.AreEqual(2, MathOperations.Subtract(5, 3));
        }

        [TestMethod]
        public void Subtract_String_ReturnsCorrectDifference()
        {
            Assert.AreEqual(1.0, MathOperations.Subtract("3.5", "2.5"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Subtract_String_InvalidInput_ThrowsException()
        {
            MathOperations.Subtract("invalid", "2.5");
        }

        [TestMethod]
        public void Multiply_Double_ReturnsCorrectProduct()
        {
            Assert.AreEqual(6.25, MathOperations.Multiply(2.5, 2.5));
        }

        [TestMethod]
        public void Multiply_Int_ReturnsCorrectProduct()
        {
            Assert.AreEqual(6, MathOperations.Multiply(2, 3));
        }

        [TestMethod]
        public void Multiply_String_ReturnsCorrectProduct()
        {
            Assert.AreEqual(6.25, MathOperations.Multiply("2.5", "2.5"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Multiply_String_InvalidInput_ThrowsException()
        {
            MathOperations.Multiply("invalid", "2.5");
        }

        [TestMethod]
        public void Divide_Double_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(2.0, MathOperations.Divide(5.0, 2.5));
        }

        [TestMethod]
        public void Divide_Int_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(2, MathOperations.Divide(6, 3));
        }

        [TestMethod]
        public void Divide_String_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(2.0, MathOperations.Divide("5.0", "2.5"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_Double_ByZero_ThrowsException()
        {
            MathOperations.Divide(5.0, 0.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_String_InvalidInput_ThrowsException()
        {
            MathOperations.Divide("invalid", "2.5");
        }

        [TestMethod]
        public void Power_Double_ReturnsCorrectResult()
        {
            Assert.AreEqual(8.0, MathOperations.Power(2.0, 3.0));
        }

        [TestMethod]
        public void Power_Int_ReturnsCorrectResult()
        {
            Assert.AreEqual(8, MathOperations.Power(2, 3));
        }

        [TestMethod]
        public void Power_String_ReturnsCorrectResult()
        {
            Assert.AreEqual(8.0, MathOperations.Power("2.0", "3.0"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Power_String_InvalidInput_ThrowsException()
        {
            MathOperations.Power("invalid", "3.0");
        }

        [TestMethod]
        public void SquareRoot_Double_ReturnsCorrectResult()
        {
            Assert.AreEqual(2.0, MathOperations.SquareRoot(4.0), 0.0001);
        }

        [TestMethod]
        public void SquareRoot_Int_ReturnsCorrectResult()
        {
            Assert.AreEqual(2.0, MathOperations.SquareRoot(4), 0.0001);
        }

        [TestMethod]
        public void SquareRoot_String_ReturnsCorrectResult()
        {
            Assert.AreEqual(2.0, MathOperations.SquareRoot("4.0"), 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_Double_NegativeNumber_ThrowsException()
        {
            MathOperations.SquareRoot(-4.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_String_InvalidInput_ThrowsException()
        {
            MathOperations.SquareRoot("invalid");
        }
    }
}