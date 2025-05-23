using System;
using Generics.library;

namespace Generics.tests.Classes.String_tests
{
    public class Hashtable_tests
    {
        private Generics.library.Hashtable<int> hashtable;

        [TestInitialize]
        public void Setup()
        {
            // Initialize a new list to simulate a string-only hashtable
            hashtable = new(10);
        }

        [TestMethod]
        public void Add_ShouldAddStringValue()
        {
            // Arrange
            int value = 17;

            // Act
            hashtable.Add(value);

            // Assert
            Assert.IsTrue(hashtable.Contains(value));
        }

        [TestMethod]
        public void Add_DuplicateValues_CollisionShouldNotThrowException()
        {
            // Arrange
            int value = 17;

            // Act
            hashtable.Add(value);
            hashtable.Add(value);

            //Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Remove_ShouldRemoveStringValue()
        {
            // Arrange
            int value = 17;
            hashtable.Add(value);

            // Act
            hashtable.Remove(value);

            // Assert
            Assert.IsFalse(hashtable.Contains(value));
        }

        [TestMethod]
        public void Remove_NonExistentValue_ShouldNotThrowError()
        {
            // Arrange
            int nonExistentValue = -1;

            // Act
            hashtable.Remove(nonExistentValue);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Contains_ShouldReturnTrueForExistingValue()
        {
            // Arrange
            int value = 17;
            hashtable.Add(value);

            // Act
            bool containsValue = hashtable.Contains(value);

            // Assert
            Assert.IsTrue(containsValue);
        }

        [TestMethod]
        public void Contains_ShouldReturnFalseForNonExistentValue()
        {
            // Arrange
            int value = -1;

            // Act
            bool containsValue = hashtable.Contains(value);

            // Assert
            Assert.IsFalse(containsValue);
        }

        [TestMethod]
        public void Length_ShouldReturnCorrectNumberOfItems()
        {
            // Arrange
            hashtable.Add(17);
            hashtable.Add(23);

            // Act
            int length = hashtable.Length;

            // Assert
            Assert.AreEqual(2, length);
        }

        [TestMethod]
        public void Clear_ShouldRemoveAllValues()
        {
            // Arrange
            hashtable.Add(17);
            hashtable.Add(23);

            // Act
            hashtable.Clear();

            // Assert
            Assert.AreEqual(0, hashtable.Length);
        }
    }
}
