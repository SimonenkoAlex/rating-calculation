using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Engineer : Person
    {
        private int countOfTestedComputers;
        private double totalWorkingHours;

        public Engineer() { }

        public Engineer(string surname, string name, string middleName, int id)
            : base(surname, name, middleName, id)
        {
        }

        public int CountOfTestedComputers { get => countOfTestedComputers; set => countOfTestedComputers = value; }
        public double TotalWorkingHours { get => totalWorkingHours; set => totalWorkingHours = value; }

        public override double ScoresCalculation()
        {
            return Math.Round(countOfTestedComputers * 0.34 / totalWorkingHours, 1);
        }
    }
}
