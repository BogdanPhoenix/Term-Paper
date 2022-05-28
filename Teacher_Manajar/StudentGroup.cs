using System.Collections.Generic;
using System.Linq;

namespace Teacher_Manajar
{
    //Реалізація класу, який описує дані студента в групі
    public class StudentGroup : IPerson, IStudent
    {
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string University { get; set; }
        public uint Course { get; set; }
        public string Group { get; set; }
        public List<string> Evaluation { get; set; }
        //Копіювання об'єкта
        public object Clone()
        {
            return new StudentGroup
            {
                Id = this.Id,
                First_Name = this.First_Name,
                Name  = this.Name,
                Surname = this.Surname,
                Email = this.Email,
                University = this.University,
                Course = this.Course,
                Group = this.Group,
                Evaluation = this.Evaluation
            };
        }
        //Перевірка чи однакові об'єкти за публічними ознаками
        public bool Equals(IPerson other)
        {
            return Email.Equals(other.Email);
        }

        public bool Equals(IStudent other)
        {
            return Evaluation.SequenceEqual(other.Evaluation);
        }
    }
}
