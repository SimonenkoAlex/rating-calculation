using BusinessLogicLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAUniversityRankingTests
{
    public class TeacherTests
    {
        [Test]
        public void ScoresCalculationTest()
        {
            Teacher teacher = new Teacher("Убалехт", "Иван", "Павлович", 12, "старший преподаватель", " ");
            teacher.CountOfGuidelines = 45;
            teacher.CountOfPublications = 23;
            Assert.AreEqual(19.8, teacher.ScoresCalculation());
        }

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 2.4)]
        [TestCase(123, 341, 179.3)]
        public void ScoresCalculationTest(int firstValue, int secondValue, double expected)
        {
            Teacher teacher = new Teacher("Убалехт", "Иван", "Павлович", 12, "старший преподаватель", " ");
            teacher.CountOfGuidelines = firstValue;
            teacher.CountOfPublications = secondValue;
            var actualResult = teacher.ScoresCalculation();
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void getSurnameAndInitialsTest()
        {
            Teacher teacher = new Teacher("Убалехт", "Иван", "Павлович", 12, "старший преподаватель", " ");
            Assert.AreEqual("Убалехт И.П.", teacher.getSurnameAndInitials());
        }
    }
}
