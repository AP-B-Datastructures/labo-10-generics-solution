using System;
using Generics.library;

namespace Generics.tests.Classes.String_tests
{
    public class Stack_tests
    {
        private Stack stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new Stack();
        }

        // [TestMethod]
        // public void Push_AddsElementToStack()
        // {
        //     // Arrange
        //     string element = "test";

        //     // Act
        //     stack.Push(element);

        //     // Assert
        //     Assert.AreEqual(element, stack.Pop());
        // }

        // [TestMethod]
        // public void Pop_RemovesAndReturnsTopElement()
        // {
        //     // Arrange
        //     stack.Push("test1");
        //     stack.Push("test2");
        //     stack.Push("test3");

        //     // Act
        //     string topElement = stack.Pop();

        //     // Assert
        //     Assert.AreEqual("test3", topElement);
        // }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_ThrowsExceptionWhenStackIsEmpty()
        {
            // Act
            stack.Pop();
        }

        // [TestMethod]
        // public void IsEmpty_FilledStackIsNotEmpty()
        // {
        //     stack.Push("test1");
        //     stack.Push("test2");
        //     stack.Push("test3");

        //     var result = stack.IsEmpty;

        //     Assert.AreEqual(false, result);
        // }

        // [TestMethod]
        // public void IsFull_PartiallyFilledStackIsNotFull()
        // {
        //     stack.Push("test1");
        //     stack.Push("test2");
        //     stack.Push("test3");

        //     var result = stack.IsFull;

        //     Assert.AreEqual(false, result);
        // }

        // [TestMethod]
        // public void Push_StackIncreasesSize()
        // {
        //     string lorem = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Itaque, ab ut ullam optio voluptatem non ipsam quas qui, nisi molestias dicta veritatis, ea tempore illum ipsum amet beatae sequi esse?";
        //     string[] words = lorem.Split(" ");
        //     // Arrange
        //     for (int i = 0; i < words.Length; i++)
        //     {
        //         stack.Push(words[i]);
        //     }

        //     // Assert
        //     Assert.AreEqual(stack.Length, words.Length);
        // }
    }
}
