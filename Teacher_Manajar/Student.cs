using System.Collections.Generic;

namespace Teacher_Manajar
{
    //Клас для реалізації персони - студент
    public class Student : IPerson, IPrivateInfo, IStudent
    {
        public List<string> Previous_Link_Foto { get; set; }
        public string University { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public uint Course { get; set; }
        public string Group { get; set; }
        public List<string> Evaluation { get; set; }
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Now_Link_Foto { get; set; }
        //Копіювання об'єкта
        public object Clone()
        {
            return new Student
            {
                Id = this.Id,
                Previous_Link_Foto = this.Previous_Link_Foto,
                First_Name = this.First_Name,
                Name = this.Name,
                Surname = this.Surname,
                University = this.University,
                Email = this.Email,
                Password = this.Password,
                Role = this.Role,
                Course = this.Course,
                Group = this.Group,
                Evaluation = this.Evaluation,
                Now_Link_Foto = this.Now_Link_Foto
            };
        }
        //Перевірка чи однакові об'єкти за приватними властивостями
        public bool Equals(IPrivateInfo other)
        {
            return Previous_Link_Foto.Equals(other.Previous_Link_Foto) &&
                (
                    ReferenceEquals(Now_Link_Foto, other.Now_Link_Foto) ||
                    Now_Link_Foto.Equals(other.Now_Link_Foto)
                ) &&
                (
                    ReferenceEquals(Password, other.Password) ||
                    Password.Equals(other.Password)
                );
        }
        //Перевірка чи однакові об'єкти за публічними властивостями
        public bool Equals(IPerson other)
        {
            return Email.Equals(other.Email);
        }

        public bool Equals(IStudent other)
        {
            return University.Equals(other.University) &&
                (
                    ReferenceEquals(Course, other.Course) ||
                    Course.Equals(other.Course)
                ) &&
                (
                    ReferenceEquals(Group, other.Group) ||
                    Group.Equals(other.Group)
                ) &&
                (
                    ReferenceEquals(Evaluation, other.Evaluation) ||
                    Evaluation.Equals(other.Evaluation)
                );
        }
    }
}
