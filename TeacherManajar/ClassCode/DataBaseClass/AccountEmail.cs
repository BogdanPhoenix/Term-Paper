using MySql.Data.MySqlClient;
using System;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання та передачу даних користувача, які необхідні під час входу в особистий кабінет або його пошуку в базі даних
    /// </summary>
    public class AccountEmail : IEquatable<AccountEmail>, ICloneable
    {
        public string Email { get; set; }
        public string IdPerson { get; set; }
        public string Role { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            AccountEmail account = new AccountEmail()
            {
                Email = this.Email,
                IdPerson = this.IdPerson,
                Role = this.Role
            };
            return account;
        }
        /// <summary>
        /// Метод для зчитування отриманого результату з бази даних та запису його у відповідні поля
        /// </summary>
        /// <param name="sqlDataReader">Об'єкт бази даних</param>
        public void ConvertFromMySql(MySqlDataReader sqlDataReader)
        {
            IdPerson = SystemProcess.ConvertMySQLToText(sqlDataReader["IdPerson"].ToString());
            Email = SystemProcess.ConvertMySQLToText(sqlDataReader["Email"].ToString());
            Role = SystemProcess.ConvertMySQLToText(sqlDataReader["Role"].ToString());
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(AccountEmail other)
        {
            return IdPerson.Equals(other.IdPerson) &&
                (
                    ReferenceEquals(Email, other.Email) ||
                    Email.Equals(other.Email)
                ) &&
                (
                    ReferenceEquals(Role, other.Role) ||
                    Role.Equals(other.Role)
                );
        }
    }
}
