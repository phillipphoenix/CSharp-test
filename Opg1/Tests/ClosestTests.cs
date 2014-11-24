using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Opg1
{
    [TestFixture]
    public class ClosestTests
    {
        [Test]
        public void Closest_ExactMatch_ReturnMatch()
        {
            // Arrange
            var list = new List<int> { 1, 6, 9, 3 };

            // Act
            var found = list.Nearest(3);

            // Assert
            Assert.AreEqual(3, found);
        }

        [Test]
        public void Closest_MatchLowerBound_ReturnLowerMatch()
        {
            // Arrange
            var list = new List<int> { 1, 3, 6, 9 };

            // Act
            var found = list.Nearest(4);

            // Assert
            Assert.AreEqual(3, found);
        }

        [Test]
        public void Closest_MatchUpperBound_ReturnUpperMatch()
        {
            // Arrange
            var list = new List<int> { 1, 3, 6, 9 };

            // Act
            var found = list.Nearest(5);

            // Assert
            Assert.AreEqual(6, found);
        }

        [Test]
        public void Closest_MultipleMatches_ReturnFirstMatch()
        {
            // Arrange
            var list = new List<int> { 1, 6, 3, 9 };
            
            // Act
            var found = list.Nearest(5);

            // Assert
            Assert.AreEqual(6, found);
        }

        [Test]
        public void Closest_RoundUp_ReturnMatch()
        {
            // Arrange
            var list = new List<double> { 1, 6, 3, 5 };

            // Act
            var found = list.Nearest(5.5);

            // Assert
            Assert.AreEqual(6, found);
        }

        [Test]
        public void Closest_RoundDown_ReturnMatch()
        {
            // Arrange
            var list = new List<double> { 1, 6, 3, 5 };

            // Act
            var found = list.Nearest(5.4);

            // Assert
            Assert.AreEqual(5, found);
        }
    }
}
