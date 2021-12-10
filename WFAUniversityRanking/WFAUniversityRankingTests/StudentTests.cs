using BusinessLogicLayer;
using NUnit.Framework;

namespace WFAUniversityRankingTests
{
    public class StudentTests
    {
        [Test]
        public void ScoresCalculationTest()
        {
            Student student = new Student("Симоненко", "Александр", "Евгеньевич", 22, "ИВТм-212", 1);
            student.ScoresFotTestWeek.AddRange(new int[] { 12, 15, 5, 8 });
            Assert.AreEqual(40, student.ScoresCalculation());
        }

        [Test]
        public void getSurnameAndInitialsTest()
        {
            Student student = new Student("Симоненко", "Александр", "Евгеньевич", 22, "ИВТм-212", 1);
            Assert.AreEqual("Симоненко А.Е.", student.getSurnameAndInitials());
        }
    }
}
