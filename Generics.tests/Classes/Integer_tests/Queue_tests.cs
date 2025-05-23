using System;
using Generics.library;

namespace Generics.tests.Classes.Integer_tests
{
    public class Queue_tests
    {
        private Queue queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            queue = new Queue();
        }

        [TestMethod]
        public void Enqueue_AddsElementToQueue()
        {
            // Arrange
            int element = 10;

            //Act
            queue.Enqueue(element);

            // Assert
            Assert.AreEqual(element, queue.Dequeue());
        }

        [TestMethod]
        public void Dequeue_RemovesElementFromQueue()
        {
            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Arrange
            int firstElement = queue.Dequeue();

            // Assert
            Assert.AreEqual(firstElement, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_ThrowsExceptionWhenQueueIsEmpty()
        {
            // Act
            queue.Dequeue();
        }

        [TestMethod]
        public void IsEmpty_FilledQueueIsNotEmpty()
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.IsEmpty;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsFull_PartiallyFilledQueueIsNotFull()
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.IsFull;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Push_StackIncreasesSize()
        {
            // Arrange
            for (int i = 0; i < 1000; i++)
            {
                queue.Enqueue(i);
            }

            // Assert
            Assert.AreEqual(queue.Length, 1000);
        }
    }
}
