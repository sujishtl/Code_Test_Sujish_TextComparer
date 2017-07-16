using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Test_Sujish_TextComparer;
using System.Collections.Generic;
// Have used Roy Osherove’s Naming convention
namespace TextComparer.Test
{
    [TestClass]
    public class TextComparerTests
    {
        [TestMethod]
        public void LegacyComparison_Strings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(26);
            expected.Add(51);
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual=comparer.LegacyComparison("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "polly");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LegacyComparison_CaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(26);
            expected.Add(51);
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.LegacyComparison("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polly");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LegacyComparison_TwoCharSubtextStrings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(28);
            expected.Add(53);
            expected.Add(78);
            expected.Add(82);

            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.LegacyComparison("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "ll");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LegacyComparison_TwoCharCaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(28);
            expected.Add(53);
            expected.Add(78);
            expected.Add(82);
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.LegacyComparison("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Ll");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LegacyComparison_NotMatchingStrings_ReturnsNothing()
        {
            //Arrange
            List<int> expected = new List<int>();
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.LegacyComparison("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "X");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LegacyComparison_NotMatchingStringswithSingleChar_ReturnsNothing()
        {
            //Arrange
            List<int> expected = new List<int>();       
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.LegacyComparison("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polx");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        #region FunctionCompareWithField
        [TestMethod]
        public void CompareWithYield_Strings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(26);
            expected.Add(51);
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.CompareWithYield("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "polly");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
            Assert.IsTrue(expected.SequenceEqual(actual));

        }
        [TestMethod]
        public void CompareWithYield_CaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(26);
            expected.Add(51);
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.CompareWithYield("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polly");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareWithYield_TwoCharSubtextStrings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(28);
            expected.Add(53);
            expected.Add(78);
            expected.Add(82);

            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.CompareWithYield("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "ll");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareWithYield_TwoCharCaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(28);
            expected.Add(53);
            expected.Add(78);
            expected.Add(82);
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.CompareWithYield("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Ll");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareWithYield_NotMatchingStrings_ReturnsNothing()
        {
            //Arrange
            List<int> expected = new List<int>();
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.CompareWithYield("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "X");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareWithYield_NotMatchingStringswithSingleChar_ReturnsNothing()
        {
            //Arrange
            List<int> expected = new List<int>();
            //Act
            Code_Test_Sujish_TextComparer.FmTextComparer comparer = new FmTextComparer();
            var actual = comparer.CompareWithYield("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polx");

            //Assert

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
    }
}
