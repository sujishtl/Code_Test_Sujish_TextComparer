using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Test_Sujish_TextComparer;
using System.Collections.Generic;
using System.Linq;
// Have used Roy Osherove’s Naming convention
namespace TextComparer.Test
{
    [TestClass]
    public class TextComparerTests
    {
        #region FunctionCompareusingLegacyMethod
        [TestMethod]
        public void LegacyComparison_Strings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {1, 26, 51};
            ICompare comparer = new LegacyComparer();

            //Act
            var actual=comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "polly");

            //Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void LegacyComparison_CaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {1, 26, 51};
            ICompare comparer = new LegacyComparer();

            //Act        
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polly");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void LegacyComparison_TwoCharSubtextStrings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {3, 28, 53, 78, 82};
            ICompare comparer = new LegacyComparer();

            //Act
            
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "ll");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void LegacyComparison_TwoCharCaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {3, 28, 53, 78, 82};
            ICompare comparer = new LegacyComparer();
            //Act
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Ll");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void LegacyComparison_NotMatchingStrings_ReturnsNothing()
        {
            //Arrange
            var expected = new List<int>();
            ICompare comparer = new LegacyComparer();
            //Act
  
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "X");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void LegacyComparison_NotMatchingStringswithSingleChar_ReturnsNothing()
        {
            //Arrange
            var expected = new List<int>();
            ICompare comparer = new LegacyComparer();
            //Act
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polx");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        #endregion

        #region FunctionCompareWithYield
        [TestMethod]
        public void CompareWithYield_Strings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {1, 26, 51};
            ICompare comparer = new YieldComparer();
            //Act
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "polly");

            //Assert

            //CollectionAssert.AreEqual(expected, actual);
            Assert.IsTrue(expected.SequenceEqual(actual));
      

        }
        [TestMethod]
        public void CompareWithYield_CaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {1, 26, 51};
            ICompare comparer = new YieldComparer();
            //Act
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polly");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CompareWithYield_TwoCharSubtextStrings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {3, 28, 53, 78, 82};
            ICompare comparer = new YieldComparer();

            //Act
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "ll");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CompareWithYield_TwoCharCaseSensitiveStrings_ReturnsMatchingPositions()
        {
            //Arrange
            var expected = new List<int> {3, 28, 53, 78, 82};
            ICompare comparer = new YieldComparer();
            //Act
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Ll");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CompareWithYield_NotMatchingStrings_ReturnsNothing()
        {
            //Arrange
            var expected = new List<int>();
            ICompare comparer = new YieldComparer();

            //Act           
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "X");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CompareWithYield_NotMatchingStringswithSingleChar_ReturnsNothing()
        {
            //Arrange
            var expected = new List<int>();
            ICompare comparer = new YieldComparer();
            //Act         
            var actual = comparer.Compare("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polx");

            //Assert

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        #endregion
    }
}
