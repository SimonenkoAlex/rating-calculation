using BusinessLogicLayer;
using NUnit.Framework;
using System;

namespace WFAUniversityRankingTests
{
    public class EngineerTests
    {
        [Test]
        public void ScoresCalculationTest()
        {
            Engineer engineer = new Engineer("Мещеряков", "Глеб", "Олегович", 7, 3);
            engineer.CountOfTestedComputers = 15;
            engineer.TotalWorkingHours = 48;
            Assert.AreEqual(0.1, engineer.ScoresCalculation());
        }

        [TestCase(3, 4, 0.3)]
        [TestCase(123, 341, 0.1)]
        public void ScoresCalculationTest(int firstValue, int secondValue, double expected)
        {
            Engineer engineer = new Engineer("Мещеряков", "Глеб", "Олегович", 7, 3);
            engineer.CountOfTestedComputers = firstValue;
            engineer.TotalWorkingHours = secondValue;
            var actualResult = engineer.ScoresCalculation();
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void getSurnameAndInitialsTest()
        {
            Engineer engineer = new Engineer("Мещеряков", "Глеб", "Олегович", 7, 3);
            Assert.AreEqual("Мещеряков Г.О.", engineer.getSurnameAndInitials());
        }

        [TestCase(34, 0)]
        public void ExceptionTest(int firstValue, int secondValue)
        {
            Engineer engineer = new Engineer("Мещеряков", "Глеб", "Олегович", 7, 3);
            engineer.CountOfTestedComputers = firstValue;
            engineer.TotalWorkingHours = secondValue;
            Assert.Throws<Exception>(() => engineer.ScoresCalculation());
        }
    }
}
