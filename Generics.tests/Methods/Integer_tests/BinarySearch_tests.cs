using System;
using Generics.library;

namespace Generics.tests.Methods.Integer_tests
{
    [TestClass]
    public class BinarySearch_tests
    {
        [TestMethod]
        public void BinarySearch_TargetExistsInMiddle_ShouldReturnCorrectIndex()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 30;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BinarySearch_TargetExistsAtStart_ShouldReturnZero()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 10;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinarySearch_TargetExistsAtEnd_ShouldReturnLastIndex()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 50;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void BinarySearch_TargetDoesNotExist_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 60;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_ArrayHasSingleElement_TargetExists_ShouldReturnZero()
        {
            // Arrange
            int[] array = { 10 };
            int target = 10;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinarySearch_ArrayHasSingleElement_TargetDoesNotExist_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { 10 };
            int target = 20;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_TargetIsSmallerThanAllElements_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 5;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_TargetIsLargerThanAllElements_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 100;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_ArrayIsEmpty_ShouldReturnNegativeOne()
        {
            // Arrange
            int[] array = { };
            int target = 10;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_ArrayWithNegativeNumbers_ShouldFindTarget()
        {
            // Arrange
            int[] array = { -50, -40, -30, -20, -10 };
            int target = -30;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BinarySearch_ArrayWithMixedNumbers_ShouldFindPositiveTarget()
        {
            // Arrange
            int[] array = { -50, -40, 0, 10, 20, 30 };
            int target = 20;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void BinarySearch_ArrayWithMixedNumbers_ShouldFindNegativeTarget()
        {
            // Arrange
            int[] array = { -50, -40, 0, 10, 20, 30 };
            int target = -40;

            // Act
            int result = BinarySearch.Search(array, target);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
