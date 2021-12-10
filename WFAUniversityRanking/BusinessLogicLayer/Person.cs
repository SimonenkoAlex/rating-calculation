using System;

namespace BusinessLogicLayer
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string secondName;
        private string patronymic;
        private DateTime birthday;
        private int id;

        public Person() { }

        public Person(string surname, string name, string middleName, int id)
        {
            firstName = surname;
            secondName = name;
            patronymic = middleName;
            this.id = id;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Id { get => id; set => id = value; }

        public string getSurnameAndInitials()
        {
            return firstName + " " + secondName.Substring(0, 1) + "." + patronymic[0] + ".";
        }

        public virtual double ScoresCalculation()
        {
            Console.WriteLine("У вневузовского человека нет рейтинга!");
            return 0;
        }
    }
}
