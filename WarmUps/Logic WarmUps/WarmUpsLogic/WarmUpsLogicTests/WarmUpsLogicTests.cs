using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarmUpsLogic;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace WarmUpsLogicTests
{
    [TestFixture]
    public class WarmUpsLogicTests
    {
        private WarmUpsLogic.WarmUpsLogic _warmUpsFunctionality;

        [SetUp]
        public void Before_Each_Test()
        {
            _warmUpsFunctionality = new WarmUpsLogic.WarmUpsLogic();
        }

        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatPartyTest(int cigars, bool isWeekend, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.GreatParty(cigars, isWeekend);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        [TestCase(10, 1, 0)]
        public void CanHazTableTest(int yourStyle, int dateStyle, int expectedResult)
        {
            int actual = _warmUpsFunctionality.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutsideTest(int temp, bool isSummer, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.PlayOutside(temp, isSummer);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeedingTest(int speed, bool isBirthday, int expectedResult)
        {
            int actual = _warmUpsFunctionality.CaughtSpeeding(speed, isBirthday);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        [TestCase(-10, -1, -11)]
        public void SkipSumTest(int a, int b, int expectedResult)
        {
            int actual = _warmUpsFunctionality.SkipSum(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        [TestCase(0, true, "off")]
        public void AlarmClockTest(int day, bool vacation, string expectedResult)
        {
            string actual = _warmUpsFunctionality.AlarmClock(day, vacation);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        [TestCase(-1, -5, false)]
        public void LoveSixTest(int a, int b, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.LoveSix(a, b);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        [TestCase(-1, true, true)]
        public void InRangeTest(int n, bool outsideMode, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.InRange(n, outsideMode);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        [TestCase(0, false)]
        public void SpecialElevenTest(int n, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.SpecialEleven(n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20Test(int n, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Mod20(n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35Test(int n, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.Mod35(n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCellTest(bool isMorning, bool isMom, bool isAsleep, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.AnswerCell(isMorning, isMom, isAsleep);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, false)]
        [TestCase(3, 2, 2, false)]
        [TestCase(45, 55, 100, true)]
        public void TwoIsOneTest(int a, int b, int c, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.TwoIsOne(a, b, c);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        [TestCase(1, -1234, 100, true, true)]
        public void AreInOrderTest(int a, int b, int c, bool bOK, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.AreInOrder(a, b, c, bOK);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        [TestCase(1, -1234, 100, true, false)]
        public void InOrderEqualTest(int a, int b, int c, bool equalOk, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.InOrderEqual(a, b, c, equalOk);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        [TestCase(1, -1234, 100, false)]
        public void LastDigitTest(int a, int b, int c, bool expectedResult)
        {
            bool actual = _warmUpsFunctionality.LastDigit(a, b, c);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6)]
        public void RollDiceTest(int die1, int die2, bool noDoubles, int expectedResult)
        {
            int actual = _warmUpsFunctionality.RollDice(die1, die2, noDoubles);
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
