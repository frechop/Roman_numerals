using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman_numerals;
using System;

namespace Roman_Numerals_Tests
{
    [TestClass]
    public class IntegerToRomanTests
    {
        [TestMethod]
        public void ConvertToRoman_Negative_Input_Throws_ArgumentOutOfRangeException()
        {
            // Arrange
            int negativeInput = -1;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Roman.ConvertToRoman(negativeInput));
        }

        [TestMethod]
        public void ConvertToRoman_1_I()
        {
            // Act & Assert
            Assert.AreEqual("I ", Roman.ConvertToRoman(1));
        }

        [TestMethod]
        public void ConvertToRoman_4_IV()
        {
            // Act & Assert
            Assert.AreEqual("IV ", Roman.ConvertToRoman(4));
        }

        [TestMethod]
        public void ConvertToRoman_5_V()
        {
            // Act & Assert
            Assert.AreEqual("V ", Roman.ConvertToRoman(5));
        }

        [TestMethod]
        public void ConvertToRoman_9_IX()
        {
            // Act & Assert
            Assert.AreEqual("IX ", Roman.ConvertToRoman(9));
        }

        [TestMethod]
        public void ConvertToRoman_10_X()
        {
            // Act & Assert
            Assert.AreEqual("X ", Roman.ConvertToRoman(10));
        }

        [TestMethod]
        public void ConvertToRoman_40_XL()
        {
            // Act & Assert
            Assert.AreEqual("XL ", Roman.ConvertToRoman(40));
        }

        [TestMethod]
        public void ConvertToRoman_50_L()
        {
            // Act & Assert
            Assert.AreEqual("L ", Roman.ConvertToRoman(50));
        }

        [TestMethod]
        public void ConvertToRoman_90_XC()
        {
            // Act & Assert
            Assert.AreEqual("XC ", Roman.ConvertToRoman(90));
        }

        [TestMethod]
        public void ConverToRoman_100_C()
        {
            // Act & Assert
            Assert.AreEqual("C ", Roman.ConvertToRoman(100));
        }

        [TestMethod]
        public void ConverToRoman_400_CD()
        {
            // Act & Assert
            Assert.AreEqual("CD ", Roman.ConvertToRoman(400));
        }

        [TestMethod]
        public void ConvertToRoman_500_D()
        {
            // Act & Assert
            Assert.AreEqual("D ", Roman.ConvertToRoman(500));
        }

        [TestMethod]
        public void ConvertToRoman_900_CM()
        {
            // Act & Assert
            Assert.AreEqual("CM ", Roman.ConvertToRoman(900));
        }

        [TestMethod]
        public void ConvertToRoman_1000_M()
        {
            // Act & Assert
            Assert.AreEqual("M ", Roman.ConvertToRoman(1000));
        }

        [TestMethod]
        public void ConvertToRoman_444_CDXLIV()
        {
            // Act & Assert
            Assert.AreEqual("CD XL IV ", Roman.ConvertToRoman(444));
        }

        [TestMethod]
        public void ConvertToRoman_3999_MMMCMXCIX()
        {
            // Act & Assert
            Assert.AreEqual("M M M CM XC IX ", Roman.ConvertToRoman(3999));
        }

    }
}
