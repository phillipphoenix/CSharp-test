using NUnit.Framework;

namespace Opg1.Tests
{
    [TestFixture]
    public class FindWhereTests
    {
        [Test]
        public void FindWhere_NoMatch_ReturnNull()
        {
            // Arrange
            const int valueToFind = 2;
            var root = new Node<int> { Value = 1 };
            var child = new Node<int> { Value = 1, Parent = root };
            root.Children.Add(child);

            // Act
            var found = root.FindWhere(x => x.Value == valueToFind, x => x.Children);

            // Assert
            Assert.AreEqual(null, found);
        }
        
        [Test]
        public void FindWhere_SimpleTree_ReturnMatch()
        {
            // Arrange
            const int valueToFind = 2;
            var root = new Node<int> {Value = 1};
            var child = new Node<int> {Value = valueToFind, Parent = root};
            root.Children.Add(child);

            // Act
            var found = root.FindWhere(x => x.Value == valueToFind, x => x.Children);

            // Assert
            Assert.AreEqual(child, found);
        }

        [Test]
        public void FindWhere_BinaryTree_ReturnMatch()
        {
            // Arrange
            const int valueToFind = 2;
            var root = new Node<int> { Value = 1 };
            var childA = new Node<int> { Value = 1, Parent = root };
            var childB = new Node<int> { Value = valueToFind, Parent = root };
            root.Children.Add(childA);
            root.Children.Add(childB);

            // Act
            var found = root.FindWhere(x => x.Value == valueToFind, x => x.Children);

            // Assert
            Assert.AreEqual(childB, found);
        }

        [Test]
        public void FindWhere_ComplexTree_ReturnMatch()
        {
            // Arrange
            const int valueToFind = 2;
            var root = new Node<int> { Value = 1 };
            var childA = new Node<int> { Value = 1, Parent = root };
            var childB = new Node<int> { Value = 1, Parent = root };
            var childC = new Node<int> { Value = 1, Parent = root };
            root.Children.Add(childA);
            root.Children.Add(childB);
            root.Children.Add(childC);
            var grandChildAA = new Node<int> { Value = 1, Parent = childA };
            var grandChildAB = new Node<int> { Value = 1, Parent = childA };
            var grandChildAC = new Node<int> { Value = 1, Parent = childA };
            childA.Children.Add(grandChildAA);
            childA.Children.Add(grandChildAB);
            childA.Children.Add(grandChildAC);
            var grandChildBA = new Node<int> { Value = 1, Parent = childB };
            childB.Children.Add(grandChildBA);
            var grandChildCA = new Node<int> { Value = 1, Parent = childC };
            var grandChildCB = new Node<int> { Value = 1, Parent = childC };
            var grandChildCC = new Node<int> { Value = valueToFind, Parent = childC };
            var grandChildCD = new Node<int> { Value = 1, Parent = childC };
            childC.Children.Add(grandChildCA);
            childC.Children.Add(grandChildCB);
            childC.Children.Add(grandChildCC);
            childC.Children.Add(grandChildCD);

            // Act
            var found = root.FindWhere(x => x.Value == valueToFind, x => x.Children);

            // Assert
            Assert.AreEqual(grandChildCC, found);
        }
    }
}
