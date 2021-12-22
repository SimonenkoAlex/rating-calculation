using System;

namespace BusinessLogicLayer
{
    public class Teacher : Person
    {
        private string position;
        private string degree;
        private int countOfPublications;
        private int countOfGuidelines;

        public Teacher() : base() { }

        public Teacher(string surname, string name, string middleName,
            int id, string position, string degree)
            : base(surname, name, middleName, id)
        {
            this.position = position;
            this.degree = degree;
        }

        public int CountOfPublications { get => countOfPublications; set => countOfPublications = value; }
        public int CountOfGuidelines { get => countOfGuidelines; set => countOfGuidelines = value; }

        public override double ScoresCalculation()
        {
            return Math.Round(countOfPublications * 0.45 + countOfGuidelines * 0.21, 1);
        }
    }
}
