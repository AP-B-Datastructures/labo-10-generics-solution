using System;
using Generics.library;

namespace Generics.tests.Classes.String_tests
{
    public class Queue_tests
    {
        private Generics.library.Queue<string> queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            queue = new();
        }

        [TestMethod]
        public void Enqueue_AddsElementToQueue()
        {
            // Arrange
            string element = "test";

            //Act
            queue.Enqueue(element);

            // Assert
            Assert.AreEqual(element, queue.Dequeue());
        }

        [TestMethod]
        public void Dequeue_RemovesElementFromQueue()
        {
            // Act
            queue.Enqueue("test1");
            queue.Enqueue("test2");
            queue.Enqueue("test3");

            // Arrange
            string firstElement = queue.Dequeue();

            // Assert
            Assert.AreEqual(firstElement, "test1");
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
            queue.Enqueue("test1");
            queue.Enqueue("test2");
            queue.Enqueue("test3");

            var result = queue.IsEmpty;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsFull_PartiallyFilledQueueIsNotFull()
        {
            queue.Enqueue("test1");
            queue.Enqueue("test2");
            queue.Enqueue("test3");

            var result = queue.IsFull;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Push_StackIncreasesSize()
        {
            string lorem = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Itaque, ab ut ullam optio voluptatem non ipsam quas qui, nisi molestias dicta veritatis, ea tempore illum ipsum amet beatae sequi esse?";
            string[] words = lorem.Split(" ");
            // Arrange
            for (int i = 0; i < words.Length; i++)
            {
                queue.Enqueue(words[i]);
            }

            // Assert
            Assert.AreEqual(queue.Length, words.Length);
        }
    }
}
