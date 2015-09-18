using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WarmUps;

namespace WarmUpstests
{
    [TestFixture]
    public class WarmUpstests
    {
        private WarmUps.WarmUps _warmUpsfunctionality;

        [SetUp]
        public void Before_Each_Test()
        {
            _warmUpsfunctionality = new WarmUps.WarmUps();
        }

        [TestCase("Rocco", "Hello Rocco!")]
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("x", "Hello x!")]
        public void SayHiTest(string name, string expectedResult)
        {
            // Arrange (in setup)
            // Act
            string actual = _warmUpsfunctionality.SayHi(name);
            // Assert
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string stringA, string stringB, string expectedResult)
        {
            string actual = _warmUpsfunctionality.Abba(stringA, stringB);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("i", "Yay", "<i>Yay<i>")]
        [TestCase("i", "Hello", "<i>Hello<i>")]
        [TestCase("cite", "Yay", "<cite>Yay<cite>")]
        public void MakeTagsTest(string tag, string content, string expectedResult)
        {
            string actual = _warmUpsfunctionality.MakeTags(tag, content);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "Woohoo", "<<Woohoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string container, string word, string expectedResult)
        {
            string actual = _warmUpsfunctionality.InsertWord(container, word);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.MultipleEndings(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Woohoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.FirstHalf(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        [TestCase("ab", "")]
        public void TrimOneTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.TrimOne(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "Hi", "HiHelloHi")]
        [TestCase("Hi", "Hello", "HiHelloHi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddleTest(string a, string b, string expectedResult)
        {
            string actual = _warmUpsfunctionality.LongInMiddle(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotatLeft2Test(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.RotateLeft2(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        [TestCase("This is a long string", "ngThis is a long stri")]
        public void RotateRight2Test(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.RotateRight2(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOneTest(string str, bool fromFront, string expectedResult)
        {
            string actual = _warmUpsfunctionality.TakeOne(str, fromFront);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwoTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.MiddleTwo(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLy(string str, bool expectedResult)
        {
            bool actual = _warmUpsfunctionality.EndsWithLy(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBackTest(string str, int n, string expectedResult)
        {
            string actual = _warmUpsfunctionality.FrontAndBack(str, n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPositionTest(string str, int n, string expectedResult)
        {
            string actual = _warmUpsfunctionality.TakeTwoFromPosition(str, n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbad", false)]
        [TestCase("bad", true)]
        [TestCase("", false)]
        [TestCase("xxx", false)]
        public void HasBadTest(string str, bool expectedResult)
        {
            bool actual = _warmUpsfunctionality.HasBad(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("hello", "he")]
        [TestCase("h", "h@")]
        [TestCase("hi", "hi")]
        [TestCase("", "@@")]
        public void AtFirstTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.AtFirst(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        [TestCase("", "Yay", "@y")]
        [TestCase("", "", "@@")]
        public void LastCharsTest(string a, string b, string expectedResult)
        {
            string actual = _warmUpsfunctionality.LastChars(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        [TestCase("", "", "")]
        public void ConCatTest(string a, string b, string expectedResult)
        {
            string actual = _warmUpsfunctionality.ConCat(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ad", "da")]
        [TestCase("a", "a")]
        [TestCase("","")]
        public void SwapLastTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.SwapLast(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgainTest(string str, bool expectedResult)
        {
            bool actual = _warmUpsfunctionality.FrontAgain(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        [TestCase("", "", "")]
        public void MinCatTest(string a, string b, string expectedResult)
        {
            string actual = _warmUpsfunctionality.MinCat(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        [TestCase("ibis", "bis")]
        [TestCase("", "")]
        [TestCase("c", "")]
        [TestCase("a","a")]
        public void TweakFrontTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.TweakFront(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        [TestCase("Hix", "Hi")]
        public void StripXTest(string str, string expectedResult)
        {
            string actual = _warmUpsfunctionality.StripX(str);
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
