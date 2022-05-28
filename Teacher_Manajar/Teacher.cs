using System.Collections.Generic;

namespace Teacher_Manajar
{
    //Клас для реалізації персони - викладач
    public class Teacher : IPerson, IPrivateInfo, ITeacher
    {
        public string Id { get; set; }
        public List<string> Previous_Link_Foto { get; set; }
        public string First_Name { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Diploma_Number { get; set; }
        public string Diploma_Series { get; set; }
        public string Scientific_Title { get; set; }
        public string Now_Link_Foto { get; set; }
        //Копіювання об'єктів
        public object Clone()
        {
            return new Teacher
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
                Diploma_Number = this.Diploma_Number,
                Diploma_Series = this.Diploma_Series,
                Scientific_Title = this.Scientific_Title,
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
        //Перевірка чи однакові об'єкти за публічними ознаками
        public bool Equals(IPerson other)
        {
            return Email.Equals(other.Email);
        }
    }
}
