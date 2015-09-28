using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WarmUpsConditionals;

namespace WarmUpsConditionalsTests
{
    [TestFixture]
    public class WarmUpsConditionsTests
    {
        private WarmUpsConditionals.WarmUpsConditionals _warmUpsFunctionality;

        [SetUp]
        public void Before_Each_Test()
        {
            _warmUpsFunctionality = new WarmUpsConditionals.WarmUpsConditionals();
        }

        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.AreWeInTrouble(aSmile, bSmile);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepInTest(bool isWeekday, bool isVacation, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.CanSleepIn(isWeekday, isVacation);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expectedResult)
        {
            int actual = _warmUpsFunctionality.SumDouble(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21Test(int n, int expectedResult)
        {
            int actual = _warmUpsFunctionality.Diff21(n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTroubleTest(bool isTalking, int hour, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10Test(int a, int b, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Makes10(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        [TestCase("", "")]
        public void FrontBackTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.FrontBack(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        [TestCase("", "")]
        public void Front3Test(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.Front3(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAroundTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.BackAround(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        [TestCase(0, false)]
        public void Multiple3Or5Test(int number, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Multiple3Or5(number);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        [TestCase("HI THERE", true)]
        public void StartHiTest(string str, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.StartHi(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHotTest(int temp1, int temp2, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.IcyHot(temp1, temp2);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10And20Test(int a, int b, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Between10And20(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeenTest(int a, int b, int c, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.HasTeen(a, b, c);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        [TestCase(99, 99, false)]
        public void SoAloneTest(int a, int b, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.SoAlone(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDelTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.RemoveDel(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStartTest(string str, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.IxStart(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("ox", "o")]
        public void SartOzTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.StartOz(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void MaxTest(int a, int b, int c, int expectedResult)
        {
            int actual = _warmUpsFunctionality.Max(a, b, c);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void CloserTest(int a, int b, int expectedResult)
        {
            int actual = _warmUpsFunctionality.Closer(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heellele", false)]
        [TestCase("eeeeeeeeeee", false)]
        [TestCase("falalala", false)]
        public void GotETest(string str, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.GotE(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        [TestCase("", "")]
        public void EndUpTest(string str, string expectedResult)
        {
            string actual = _warmUpsFunctionality.EndUp(str);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        [TestCase("", 6, "")]
        public void EveryNthTest(string str, int n, string expectedResult)
        {
            string actual = _warmUpsFunctionality.EveryNth(str, n);
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
