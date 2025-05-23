using System;
using Generics.library;

namespace Generics.tests.Classes.Integer_tests
{
    public class Stack_tests
    {
        private Generics.library.Stack<int> stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new();
        }

        [TestMethod]
        public void Push_AddsElementToStack()
        {
            // Arrange
            int element = 10;

            // Act
            stack.Push(element);

            // Assert
            Assert.AreEqual(element, stack.Pop());
        }

        [TestMethod]
        public void Pop_RemovesAndReturnsTopElement()
        {
            // Arrange
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            int topElement = stack.Pop();

            // Assert
            Assert.AreEqual(3, topElement);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_ThrowsExceptionWhenStackIsEmpty()
        {
            // Act
            stack.Pop();
        }

        [TestMethod]
        public void IsEmpty_FilledStackIsNotEmpty()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.IsEmpty;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsFull_PartiallyFilledStackIsNotFull()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.IsFull;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Push_StackIncreasesSize()
        {
            // Arrange
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
            }

            // Assert
            Assert.AreEqual(stack.Pop(), 999);
        }
    }
}
