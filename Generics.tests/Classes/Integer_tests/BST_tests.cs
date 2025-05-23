using System;
using Generics.library.BST;

namespace Generics.tests.Classes.Integer_tests
{
    public class BST_tests
    {
        private Tree _bst;

        [TestInitialize]
        public void Setup()
        {
            _bst = new Tree();
        }

        [TestMethod]
        public void Insert_AddsValueToTree()
        {
            // Act
            _bst.Insert(10);

            // Assert
            Assert.IsTrue(_bst.Contains(10), "Inserted value should exist in the tree.");
        }

        [TestMethod]
        public void Contains_ReturnsTrueForExistingValue()
        {
            // Arrange
            _bst.Insert(15);

            // Act
            bool result = _bst.Contains(15);

            // Assert
            Assert.IsTrue(result, "Contains should return true for an existing value.");
        }

        [TestMethod]
        public void Contains_ReturnsFalseForNonExistingValue()
        {
            // Act
            bool result = _bst.Contains(20);

            // Assert
            Assert.IsFalse(result, "Contains should return false for a value not in the tree.");
        }

        [TestMethod]
        public void Count_ReflectsNumberOfNodes()
        {
            // Arrange
            _bst.Insert(10);
            _bst.Insert(20);
            _bst.Insert(5);

            // Act
            int count = _bst.Count;

            // Assert
            Assert.AreEqual(3, count, "Count should reflect the number of nodes in the tree.");
        }

        [TestMethod]
        public void Remove_DeletesExistingValue()
        {
            // Arrange
            _bst.Insert(10);
            _bst.Insert(20);
            _bst.Insert(5);

            // Act
            _bst.Remove(10);

            // Assert
            Assert.IsFalse(_bst.Contains(10), "Removed value should not exist in the tree.");
            Assert.AreEqual(2, _bst.Count, "Count should decrease after removal.");
        }

        [TestMethod]
        public void Remove_NonExistingValue_DoesNothing()
        {
            // Arrange
            _bst.Insert(10);

            // Act
            _bst.Remove(20);

            // Assert
            Assert.AreEqual(1, _bst.Count, "Count should remain unchanged when removing a non-existing value.");
        }

        [TestMethod]
        public void Remove_LeafNode_RemovesCorrectly()
        {
            // Arrange
            _bst.Insert(10);
            _bst.Insert(5);
            _bst.Insert(15);

            // Act
            _bst.Remove(5);

            // Assert
            Assert.IsFalse(_bst.Contains(5), "Leaf node should be removed correctly.");
        }

        [TestMethod]
        public void Remove_NodeWithOneChild_RemovesCorrectly()
        {
            // Arrange
            _bst.Insert(10);
            _bst.Insert(5);
            _bst.Insert(7);

            // Act
            _bst.Remove(5);

            // Assert
            Assert.IsFalse(_bst.Contains(5), "Node with one child should be removed correctly.");
            Assert.IsTrue(_bst.Contains(7), "Child node should remain in the tree.");
        }

        [TestMethod]
        public void Remove_NodeWithTwoChildren_RemovesCorrectly()
        {
            // Arrange
            _bst.Insert(10);
            _bst.Insert(5);
            _bst.Insert(15);
            _bst.Insert(12);
            _bst.Insert(20);

            // Act
            _bst.Remove(10);

            // Assert
            Assert.IsFalse(_bst.Contains(10), "Node with two children should be removed correctly.");
            Assert.AreEqual(4, _bst.Count, "Count should decrease after removal.");
        }

        [TestMethod]
        public void Clear_RemovesAllNodes()
        {
            // Arrange
            _bst.Insert(10);
            _bst.Insert(20);
            _bst.Insert(5);

            // Act
            _bst.Clear();

            // Assert
            Assert.AreEqual(0, _bst.Count, "Count should be 0 after clearing the tree.");
            Assert.IsFalse(_bst.Contains(10), "Tree should not contain any nodes after clearing.");
        }
    }
}
