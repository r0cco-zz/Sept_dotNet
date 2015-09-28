using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WarmUpsLoops;

namespace WarmUpsLoopsTests
{
    [TestFixture]
    public class WarmUpsLoopsTests
    {
        private WarmUpsLoops.WarmupsLoops _warmUpsFunctionality;

        [SetUp]
        public void Before_Each_Test()
        {
            _warmUpsFunctionality = new WarmUpsLoops.WarmupsLoops();
        }

        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expectedResult)
        {
            string actual = _warmUpsFunctionality.StringTimes(str, n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        [TestCase("hi", 2, "hihi")]
        public void FrontTimesTest(string str, int n, string expectedResult)
        {
            string actual = _warmUpsFunctionality.FrontTimes(str, n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXXTest(string str, int expectedResult)
        {
            int actual = _warmUpsFunctionality.CountXX(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        [TestCase("abcxx", true)]
        [TestCase("xxabc", true)]
        public void DoubleXTest(string str, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.DoubleX(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOtherTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.EveryOther(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "HHeHelHellHello")]
        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosionTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.StringSplosion(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("hixxxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2Test(string str, int expectedResult)
        {
            int actual = _warmUpsFunctionality.CountLast2(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] {1, 2, 9}, 1)]
        [TestCase(new int[] {1, 9, 9}, 2)]
        [TestCase(new int[] {1, 9, 9, 3, 9}, 3)]
        public void Count9Test(int[] numbers, int expectedResult)
        {
            int actual = _warmUpsFunctionality.Count9(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] {1, 2, 9, 3, 4}, true)]
        [TestCase(new int[] {1, 2, 3, 4, 9}, false)]
        [TestCase(new int[] {1, 2, 3, 4, 5}, false)]
        public void ArrayFront9Test(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.ArrayFront9(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] {1, 1, 2, 3, 1}, true)]
        [TestCase(new int[] {1, 1, 2, 4, 1}, false)]
        [TestCase(new int[] {1, 1, 2, 1, 2, 3}, true)]
        public void Array123Test(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Array123(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubstringMatchTest(string a, string b, int expectedResult)
        {
            int actual = _warmUpsFunctionality.SubStringMatch(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxxxxxc", "abc")]
        [TestCase("xabxxxxxxxxxcdx", "xabcdx")]
        public void StringX(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.StringX(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairsTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.AltPairs(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYakTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.DoNotYak(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 6, 6, 2 }, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]
        public void Array667(int[] numbers, int expectedResult)
        {
            int actual = _warmUpsFunctionality.Array667(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        public void NoTriplesTest(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.NoTriples(numbers);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1 }, true)]
        public void Pattern51Test(int[] numbers, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Pattern51(numbers);
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
