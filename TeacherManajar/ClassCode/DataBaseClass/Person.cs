using MySql.Data.MySqlClient;
using System;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання особистих даних користувача
    /// </summary>
    public class Person : ICloneable, IEquatable<Person>
    {
        public string IdPerson { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirthday { get; set; }
        public string AvatarFoto { get; set; }
        public string Gender { get; set; }

        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            Person person = new Person
            {
                IdPerson = this.IdPerson,
                FirstName = this.FirstName,
                Name = this.Name,
                Surname = this.Surname,
                AvatarFoto = this.AvatarFoto,
                DateBirthday = this.DateBirthday,
                Gender = this.Gender
            };
            return person;
        }
        /// <summary>
        /// Метод для зчитування отриманого результату з бази даних та запису його у відповідні поля
        /// </summary>
        /// <param name="sqlDataReader">Об'єкт бази даних</param>
        public void ConvertFromMySql(MySqlDataReader sqlDataReader)
        {
            IdPerson = SystemProcess.ConvertMySQLToText(sqlDataReader["IdPerson"].ToString());
            FirstName = SystemProcess.ConvertMySQLToText(sqlDataReader["FirstName"].ToString());
            Name = SystemProcess.ConvertMySQLToText(sqlDataReader["Name"].ToString());
            Surname = SystemProcess.ConvertMySQLToText(sqlDataReader["Surname"].ToString());
            AvatarFoto = SystemProcess.ConvertMySQLToText(sqlDataReader["AvatarFoto"].ToString());
            DateBirthday = Convert.ToDateTime(sqlDataReader["DateBirthday"]);
            Gender = SystemProcess.ConvertMySQLToText(sqlDataReader["Gender"].ToString());
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(Person other)
        {
            return IdPerson.Equals(other.IdPerson) &&
                (
                    ReferenceEquals(FirstName, other.FirstName) ||
                    FirstName.Equals(other.FirstName)
                ) &&
                (
                    ReferenceEquals(Name, other.Name) ||
                    Name.Equals(other.Name)
                ) &&
                (
                    ReferenceEquals(Surname, other.Surname) ||
                    Surname.Equals(other.Surname)
                ) &&
                (
                    ReferenceEquals(DateBirthday, other.DateBirthday) ||
                    DateBirthday.Equals(other.DateBirthday)
                ) &&
                (
                    ReferenceEquals(AvatarFoto, other.AvatarFoto) ||
                    AvatarFoto.Equals(other.AvatarFoto)
                ) &&
                (
                    ReferenceEquals(Gender, other.Gender) ||
                    Gender.Equals(other.Gender)
                );
        }
    }
}