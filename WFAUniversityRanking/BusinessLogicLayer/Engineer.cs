using System;

namespace BusinessLogicLayer
{
    public class Engineer : Person
    {
        private int qualificationCategory; // I, II, III-категория
        private int countOfTestedComputers;
        private double totalWorkingHours;

        public Engineer() : base() { }

        public Engineer(string surname, string name, string middleName, int id, int qualification)
            : base(surname, name, middleName, id)
        {
            this.qualificationCategory = qualification;
        }

        public int CountOfTestedComputers { get => countOfTestedComputers; set => countOfTestedComputers = value; }
        public double TotalWorkingHours { get => totalWorkingHours; set => totalWorkingHours = value; }

        public override double ScoresCalculation()
        {
            if (totalWorkingHours == 0)
                throw new Exception("Деление на 0 невозможно");
            else
                return Math.Round(countOfTestedComputers * 0.34 / totalWorkingHours, 1);
        }
    }
}
