using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Teacher : Person
    {
        private string position;
        private string degree;
        private int countOfPublications;
        private int countOfGuidelines;

        public Teacher() { }

        public Teacher(string surname, string name, string middleName,
            int id, string position, string degree)
            : base(surname, name, middleName, id)
        {
            this.position = position;
            this.degree = degree;
        }

        public override void ScoresCalculation()
        {

        }
    }
}
