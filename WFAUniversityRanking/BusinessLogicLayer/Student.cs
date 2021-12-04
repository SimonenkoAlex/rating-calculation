using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Student : Person
    {
        private string nameOfGroup;
        private int course;
        private List<int> scoresFotTestWeek;

        public Student() { }

        public Student(string surname, string name, string middleName, int id, string nameOfGroup, int course)
            : base(surname, name, middleName, id)
        {
            this.nameOfGroup = nameOfGroup;
            this.course = course;
        }

        public override void ScoresCalculation()
        {
            int rating = 0;
            foreach (int score in scoresFotTestWeek)
            {
                rating = rating + score;
            }
        }
    }
}
