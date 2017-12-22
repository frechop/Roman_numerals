using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman_Numerals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_Numerals_Tests
{
    [TestClass]
    public class ReplaceInStringTests
    {
        [TestMethod]
        public void ReplaceIntegerInString_1st_Example()
        {
            // Arrange
            String text = "Lorem ipsum 2 dolor sit amet.";

            // Act & Assert
            Assert.AreEqual(Roman.ReplaceIntegersInText(text), new Tuple<string, int>("Lorem ipsum I I dolor sit amet.", 1));
        }

        [TestMethod]
        public void ReplaceIntegerInString_2nd_Example()
        {
            // Arrange
            String text = "Consectetur 5 adipiscing elit 9.";

            // Act & Assert
            Assert.AreEqual(Roman.ReplaceIntegersInText(text), new Tuple<string, int>("Consectetur V adipiscing elit IX.", 2));
        }

        [TestMethod]
        public void ReplaceIntegerInstring_3rd_Example()
        {
            // Arrange
            String text = "Ut enim quis nostrum 1904 qui.";

            // Act & Assert
            Assert.AreEqual(Roman.ReplaceIntegersInText(text), new Tuple<string, int>("Ut enim quis nostrum M CM IV qui.", 1));
        }
    }
}
