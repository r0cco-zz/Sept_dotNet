using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WarmUps_Arrays;

namespace WarmUpsArraysTests
{

    [TestFixture]
    public class WarmUpsArraysTests
    {
        private WarmUpsArrays _warmUpsFunctionality;

        [SetUp]
        public void BeforeEachTest()
        {
            _warmUpsFunctionality = new WarmUpsArrays();
        }

        [TestCase(new int[] {1, 2, 6}, true)]
        [TestCase(new int[] {6, 1, 2, 3}, true)]
        [TestCase(new int[] {13, 6, 1, 2, 3}, false)]
        public void FirstLast6Test(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.FirstLast6(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1 }, true)]
        public void SameFirstLastTest(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.SameFirstLast(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(3, new int[] { 3, 1, 4 })]
        [TestCase(4, new int[] { 3, 1, 4, 1 })]
        [TestCase(5, new int[] { 3, 1, 4, 1, 5 })]
        public void MakePiTest(int n, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.MakePi(n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, true)]
        public void commonEndTest(int[] a, int[] b, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.commonEnd(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7, 0, 0 }, 7)]
        public void SumTest(int[] numbers, int expectedResult)
        {
            int actual = _warmUpsFunctionality.Sum(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        public void RotateLeftTest(int[] numbers, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.RotateLeft(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 9, 11, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        public void ReverseTest(int[] numbers, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.Reverse(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [TestCase(new int[] { 11, 5, 9 }, new int[] { 11, 11, 11 })]
        [TestCase(new int[] { 2, 11, 3 }, new int[] { 3, 3, 3 })]
        public void HigherWinsTest(int[] numbers, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.HigherWins(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }, new int[] { 7, 8 })]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4 })]
        public void GetMiddleTest(int[] a, int[] b, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.GetMiddle(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 2, 5 }, true)]
        [TestCase(new int[] { 4, 3 }, true)]
        [TestCase(new int[] { 7, 5 }, false)]
        public void HasEvenTest(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.HasEven(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]
        public void KeepLastTest(int[] numbers, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.KeepLast(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]
        public void Double23Test(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Double23(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 })]
        public void Fix23Test(int[] numbers, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.Fix23(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1, 1, 1 }, false)]
        public void Unlucky1Test(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Unlucky1(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4 }, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] { }, new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void Make2Test(int[] a, int[] b, int[] expectedResult)
        {
            int[] actual = _warmUpsFunctionality.Make2(a, b);
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
