using System;
using Generics.library.SinglyLinkedList;

namespace Generics.tests.Classes.Integer_tests
{
    public class LinkedList_tests
    {
        private List _list;

        [TestInitialize]
        public void Setup()
        {
            _list = new List();
        }

        [TestMethod]
        public void IsEmpty_Initially_ReturnsTrue()
        {
            // Act
            bool isEmpty = _list.IsEmpty;

            // Assert
            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void Length_Initially_ReturnsZero()
        {
            // Act
            int length = _list.Length;

            // Assert
            Assert.AreEqual(0, length);
        }

        [TestMethod]
        public void Add_IncreasesLength()
        {
            // Act
            _list.Add(10);
            _list.Add(20);

            // Assert
            Assert.AreEqual(2, _list.Length);
        }

        [TestMethod]
        public void Add_AppendsToEnd()
        {
            // Act
            _list.Add(10);
            _list.Add(20);

            // Assert
            string result = _list.ToString();
            Assert.AreEqual("10 20", result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectNode()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);
            _list.Add(30);

            // Act
            Node node = _list.Find(20);

            // Assert
            Assert.IsNotNull(node);
            Assert.AreEqual(20, node.Value);
        }

        [TestMethod]
        public void Find_ReturnsNullIfNotFound()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);

            // Act
            Node node = _list.Find(30);

            // Assert
            Assert.IsNull(node);
        }

        [TestMethod]
        public void Remove_RemovesElementAtIndex()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);
            _list.Add(30);

            // Act
            Node removed = _list.RemoveAt(1);

            // Assert
            Assert.AreEqual(20, removed.Value);
            Assert.AreEqual(2, _list.Length);
            Assert.AreEqual("10 30", _list.ToString());
        }

        [TestMethod]
        public void Remove_ThrowsExceptionIfIndexOutOfRange()
        {
            // Arrange
            _list.Add(10);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _list.RemoveAt(5));
        }

        [TestMethod]
        public void RemoveFirst_RemovesFirstNode()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);

            // Act
            Node removed = _list.RemoveFirst();

            // Assert
            Assert.AreEqual(10, removed.Value);
            Assert.AreEqual("20", _list.ToString());
        }

        [TestMethod]
        public void RemoveLast_RemovesLastNode()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);

            // Act
            Node removed = _list.RemoveLast();

            // Assert
            Assert.AreEqual(20, removed.Value);
            Assert.AreEqual("10", _list.ToString());
        }

        [TestMethod]
        public void Clear_EmptiesTheList()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);

            // Act
            _list.Clear();

            // Assert
            Assert.AreEqual(0, _list.Length);
            Assert.IsTrue(_list.IsEmpty);
        }

        [TestMethod]
        public void ToString_EmptyList_ReturnsEmptyString()
        {
            // Act
            string result = _list.ToString();

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToString_NonEmptyList_ReturnsFormattedString()
        {
            // Arrange
            _list.Add(10);
            _list.Add(20);
            _list.Add(30);

            // Act
            string result = _list.ToString();

            // Assert
            Assert.AreEqual("10 20 30", result);
        }
    }
}
