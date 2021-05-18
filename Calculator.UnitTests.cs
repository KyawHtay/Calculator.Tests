using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        StringCalculator stringCalculator = new StringCalculator();
        [TestMethod]
       // [ExpectedException(typeof(ArgumentNullException))]
        public void Add_TestTestAddWithNullString_ThrowsNULLExceptionMethod()
        {
            Assert.ThrowsException<ArgumentNullException>(() => stringCalculator.Add(null));
        }
        [TestMethod]
        
        public void Add_TestAddWithEmptyString_ReturnsZero()
        {
            string numbers = string.Empty;
            int result = stringCalculator.Add(numbers);
            Assert.AreEqual(0,
                            result);
        }
        [TestMethod]
        public void Add_TestAddWithSingleNumberInString_ReturnsTheNumber()
        {
            string numbers = "1";
            int result = stringCalculator.Add(numbers);
            Assert.AreEqual(1,
                            result);
        }
        [TestMethod]
       
        public void Add_TestAddWithMultipleNumbersInString_ReturnsTheTotal()
        {
            string inputNumbers = "1,2,3,4,5\n6,7,8\n9,10";
            int result = stringCalculator.Add(inputNumbers);
            Assert.AreEqual(55,
                            result);
        }
        [TestMethod]
        
        public void Add_TestAddWithMultipleNumbersInString_ReturnZeroForEmptyNumbers()
        {
            string inputNumbers = "1,2,3,4,\n6,7,\n9,10";
            int result = stringCalculator.Add(inputNumbers);
            Assert.AreEqual(42,
                            result);
        }
        [TestMethod]
        public void Add_TestAddWithMultipleNumbersInStringUsingDifferentDelimeter_Return3()
        {
            string inputNumbers = "//;\n1;2";
            int result = stringCalculator.Add(inputNumbers);
            Assert.AreEqual(3,
                            result);
        }
        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void Add_TestAddWithNegativeNumbersWillThrowException()
        {
            string inputNumbers = "//;\n1;-2";
            Assert.ThrowsException<ArgumentException>(() => stringCalculator.Add(inputNumbers));
        
        }
        [TestMethod]
    
        public void Add_TestAddWithMultipleNumber_WillReturn6()
        {
            string inputNumbers = "1\n2,3";
            int result = stringCalculator.Add(inputNumbers);
            Assert.AreEqual(6,
                            result);
        }


    }
}
