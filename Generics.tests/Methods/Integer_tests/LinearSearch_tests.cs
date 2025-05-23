using System;
using Generics.library;
using Generics.library.SinglyLinkedList;

namespace Generics.tests.Methods.Integer_tests
{
    [TestClass]
    public class LinearSearch_tests
    {
        [TestMethod]
        public void LinearSearch_SLL_TargetExistsInList_ShouldReturnCorrectIndex()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            int target = 30;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(2, result, "The index of the target value should be correct.");
        }

        [TestMethod]
        public void LinearSearch_SLL_TargetDoesNotExistInList_ShouldReturnNegativeOne()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int target = 60;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the target value is not found.");
        }

        [TestMethod]
        public void LinearSearch_SLL_TargetIsAtTheBeginning_ShouldReturnZero()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int target = 10;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(0, result, "The index of the first element should be 0.");
        }

        [TestMethod]
        public void LinearSearch_SLL_TargetIsAtTheEnd_ShouldReturnLastIndex()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int target = 50;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(4, result, "The index of the last element should be returned.");
        }

        [TestMethod]
        public void LinearSearch_SLL_ArrayHasDuplicateTargets_ShouldReturnFirstIndex()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(20);
            list.Add(50);
            int target = 20;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(1, result, "The index of the first occurrence of the target should be returned.");
        }

        [TestMethod]
        public void LinearSearch_SLL_ArrayIsEmpty_ShouldReturnNegativeOne()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            int target = 10;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the array is empty.");
        }

        [TestMethod]
        public void LinearSearch_SLL_ArrayHasSingleElement_TargetExists_ShouldReturnZero()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            int target = 10;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(0, result, "The function should return 0 if the single element matches the target.");
        }

        [TestMethod]
        public void LinearSearch_SLL_ArrayHasSingleElement_TargetDoesNotExist_ShouldReturnNegativeOne()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(10);
            int target = 20;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the single element does not match the target.");
        }

        [TestMethod]
        public void LinearSearch_SLL_NegativeTarget_ShouldWorkCorrectly()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(-10);
            list.Add(-20);
            list.Add(-30);
            list.Add(-40);
            list.Add(-50);
            int target = -30;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(2, result, "The function should handle negative numbers correctly.");
        }

        [TestMethod]
        public void LinearSearch_SLL_MixedPositiveAndNegativeNumbers_ShouldFindTarget()
        {
            // Arrange
            Generics.library.SinglyLinkedList.List<int> list = new();
            list.Add(-10);
            list.Add(20);
            list.Add(-30);
            list.Add(40);
            list.Add(-50);
            int target = 40;

            // Act
            int result = LinearSearch.Search(list, target);

            // Assert
            Assert.AreEqual(3, result, "The function should find the target among mixed positive and negative numbers.");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////// ARRAY //////////////////////////////////////////////// 
        ///////////////////////////////////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void LinearSearch_Array_TargetExistsInArray_ShouldReturnCorrectIndex()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 30;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(2, result, "The index of the target value should be correct.");
        }

        [TestMethod]
        public void LinearSearch_Array_TargetDoesNotExistInArray_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 60;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the target value is not found.");
        }

        [TestMethod]
        public void LinearSearch_Array_TargetIsAtTheBeginning_ShouldReturnZero()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 10;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(0, result, "The index of the first element should be 0.");
        }

        [TestMethod]
        public void LinearSearch_Array_TargetIsAtTheEnd_ShouldReturnLastIndex()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 50;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(4, result, "The index of the last element should be returned.");
        }

        [TestMethod]
        public void LinearSearch_Array_ArrayHasDuplicateTargets_ShouldReturnFirstIndex()
        {
            // Arrange
            int[] array = { 10, 20, 30, 20, 50 };
            int target = 20;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(1, result, "The index of the first occurrence of the target should be returned.");
        }

        [TestMethod]
        public void LinearSearch_Array_ArrayIsEmpty_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { };
            int target = 10;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the array is empty.");
        }

        [TestMethod]
        public void LinearSearch_Array_ArrayHasSingleElement_TargetExists_ShouldReturnZero()
        {
            // Arrange
            int[] array = { 10 };
            int target = 10;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(0, result, "The function should return 0 if the single element matches the target.");
        }

        [TestMethod]
        public void LinearSearch_Array_ArrayHasSingleElement_TargetDoesNotExist_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { 10 };
            int target = 20;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the single element does not match the target.");
        }

        [TestMethod]
        public void LinearSearch_Array_NegativeTarget_ShouldWorkCorrectly()
        {
            // Arrange
            int[] array = { -10, -20, -30, -40, -50 };
            int target = -30;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(2, result, "The function should handle negative numbers correctly.");
        }

        [TestMethod]
        public void LinearSearch_Array_MixedPositiveAndNegativeNumbers_ShouldFindTarget()
        {
            // Arrange
            int[] array = { -10, 20, -30, 40, 50 };
            int target = 40;

            // Act
            int result = LinearSearch.Search(array, target);

            // Assert
            Assert.AreEqual(3, result, "The function should find the target among mixed positive and negative numbers.");
        }
    }
}
