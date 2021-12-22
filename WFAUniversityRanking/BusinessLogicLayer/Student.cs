using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class Student : Person
    {
        private string nameOfGroup;
        private int course;
        private List<int> scoresFotTestWeek;

        public Student() : base() { }

        public Student(string surname, string name, string middleName, 
            int id, string nameOfGroup, int course)
            : base(surname, name, middleName, id)
        {
            this.nameOfGroup = nameOfGroup;
            this.course = course;
            this.scoresFotTestWeek = new List<int>();
        }

        public List<int> ScoresFotTestWeek { get => scoresFotTestWeek; set => scoresFotTestWeek = value; }

        public override double ScoresCalculation()
        {
            int rating = 0;
            foreach (int score in ScoresFotTestWeek)
            {
                rating = rating + score;
            }
            return rating;
        }
    }
}
