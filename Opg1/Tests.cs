using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Opg1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Find_TextSearchFlatStructure_Found()
        {
            // Arrange
            const string needle = "Orange";
            var haystack = new[] {"Banna", needle, "Apple"};
            
            // Act
            var found = haystack.Find(needle);

            // Assert
            Assert.AreEqual(needle, found);
        }

        [Test]
        public void Find_TextSearchFlatStructureWithoutNeedle_NotFound()
        {
            // Arrange
            const string needle = "Orange";
            var haystack = new[] { "Banna", "Apple" };

            // Act
            var found = haystack.Find(needle);

            // Assert
            Assert.IsNull(found);
        }

        [Test]
        public void Find_ObjectSearchFlatStructure_Found()
        {
            // Arrange
            var needle = new Tuple<int>(13);
            var haystack = new[] { new Tuple<int>(7), new Tuple<int>(9), needle };

            // Act
            var found = haystack.Find(needle);

            // Assert
            Assert.AreEqual(needle, found);
        }
        
        [Test]
        public void Find_TextSearchTreeStructure_Found()
        {
            // Arrange
            const string needle = "Ford";
            var fruits = new List<string> {"Banna", "Orange", "Apple"};
            var cars = new List<string> {"SAAB", "VW", "Audi", "Volve", needle};
            var haystack = new List<List<string>> {fruits, cars};
            
            // Act
            var found = haystack.Find(needle);

            // Assert
            Assert.AreEqual(needle, found);
        }

        [Test]
        public void Find_ObjectSearchTreeStructure_Found()
        {
            // Arrange
            var needle = new Tuple<int>(13);
            var a = new List<Tuple<int>> {new Tuple<int>(7), new Tuple<int>(9), needle};
            var b = new List<Tuple<int>> {new Tuple<int>(1), new Tuple<int>(2)};
            var haystack = new List<List<Tuple<int>>> {a, b};

            // Act
            var found = haystack.Find(needle);

            // Assert
            Assert.AreEqual(needle, found);
        }

        [Test]
        public void Find_TextSearchTreeStructure_FoundMultiple()
        {
            // Arrange
            const string needle = "Ford";
            var fruits = new List<string> { "Banna", needle, "Orange", "Apple" };
            var cars = new List<string> { "SAAB", "VW", "Audi", "Volve", needle };
            var haystack = new List<List<string>> { fruits, cars };

            // Act
            var found = haystack.Find(needle);

            // Assert
            Assert.That(found.Count() == 2);
        }
    }
}
