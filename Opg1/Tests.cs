using System.Collections.Generic;
using NUnit.Framework;

namespace Opg1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Find_SearchFlatStructure_Found()
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
        public void Find_SearchFlatStructureWithoutNeedle_NotFound()
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
        public void Find_SearchTreeStructure_FoundElement()
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
    }
}
