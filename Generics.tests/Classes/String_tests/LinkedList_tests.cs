using System;
using Generics.library.SinglyLinkedList;

namespace Generics.tests.Classes.String_tests
{
    public class LinkedList_tests
    {
        private Generics.library.SinglyLinkedList.List<string> _list;

        [TestInitialize]
        public void Setup()
        {
            _list = new();
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
            _list.Add("test1");
            _list.Add("test2");

            // Assert
            Assert.AreEqual(2, _list.Length);
        }

        [TestMethod]
        public void Add_AppendsToEnd()
        {
            // Act
            _list.Add("test1");
            _list.Add("test2");

            // Assert
            string result = _list.ToString();
            Assert.AreEqual("test1 test2", result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectNode()
        {
            // Arrange
            _list.Add("test1");
            _list.Add("test2");
            _list.Add("test3");

            // Act
            var node = _list.Find("test2");

            // Assert
            Assert.IsNotNull(node);
            Assert.AreEqual("test2", node.Value);
        }

        [TestMethod]
        public void Find_ReturnsNullIfNotFound()
        {
            // Arrange
            _list.Add("test1");
            _list.Add("test2");

            // Act
            var node = _list.Find("test3");

            // Assert
            Assert.IsNull(node);
        }

        [TestMethod]
        public void Remove_RemovesElementAtIndex()
        {
            // Arrange
            _list.Add("test1");
            _list.Add("test2");
            _list.Add("test3");

            // Act
            var removed = _list.Remove(1);

            // Assert
            Assert.AreEqual("test2", removed.Value);
            Assert.AreEqual(2, _list.Length);
            Assert.AreEqual("test1 test3", _list.ToString());
        }

        [TestMethod]
        public void Remove_ThrowsExceptionIfIndexOutOfRange()
        {
            // Arrange
            _list.Add("test1");

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _list.Remove(5));
        }

        [TestMethod]
        public void RemoveFirst_RemovesFirstNode()
        {
            // Arrange
            _list.Add("test1");
            _list.Add("test2");

            // Act
            var removed = _list.RemoveFirst();

            // Assert
            Assert.AreEqual("test1", removed.Value);
            Assert.AreEqual("test2", _list.ToString());
        }

        [TestMethod]
        public void RemoveLast_RemovesLastNode()
        {
            // Arrange
            _list.Add("test1");
            _list.Add("test2");

            // Act
            var removed = _list.RemoveLast();

            // Assert
            Assert.AreEqual("test2", removed.Value);
            Assert.AreEqual("test1", _list.ToString());
        }

        [TestMethod]
        public void Clear_EmptiesTheList()
        {
            // Arrange
            _list.Add("test1");
            _list.Add("test2");

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
            _list.Add("test1");
            _list.Add("test2");
            _list.Add("test3");

            // Act
            string result = _list.ToString();

            // Assert
            Assert.AreEqual("test1 test2 test3", result);
        }
    }
}
