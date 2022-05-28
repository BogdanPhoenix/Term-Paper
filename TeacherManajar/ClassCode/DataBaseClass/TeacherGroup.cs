using TeacherManajar.InterfaceCode;
using MySql.Data.MySqlClient;
using System;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання даних користувача, які пов’язані з місцем роботи, якщо він є викладачем
    /// </summary>
    public class TeacherGroup : IGroup, ICloneable, IEquatable<TeacherGroup>
    {
        public string Education { get; set; }
        public string DiplomaNumber { get; set; }
        public string DiplomaSeries { get; set; }
        public string ScientificTitle { get; set; }
        public string EducationType { get; set; }

        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            return new TeacherGroup
            {
                Education = this.Education,
                DiplomaNumber = this.DiplomaNumber,
                DiplomaSeries = this.DiplomaSeries,
                ScientificTitle = this.ScientificTitle,
                EducationType = this.EducationType
            };
        }
        /// <summary>
        /// Метод для зчитування отриманого результату з бази даних та запису його у відповідні поля
        /// </summary>
        /// <param name="sqlDataReader">Об'єкт бази даних</param>
        public void ConvertGroupFromMySql(MySqlDataReader sqlDataReader)
        {
            Education = SystemProcess.ConvertMySQLToText(sqlDataReader["Education"].ToString());
            DiplomaNumber = SystemProcess.ConvertMySQLToText(sqlDataReader["DiplomaNumber"].ToString());
            DiplomaSeries = SystemProcess.ConvertMySQLToText(sqlDataReader["DiplomaSeries"].ToString());
            ScientificTitle = SystemProcess.ConvertMySQLToText(sqlDataReader["ScientificTitle"].ToString());
            EducationType = SystemProcess.ConvertMySQLToText(sqlDataReader["EducationType"].ToString());
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(TeacherGroup other)
        {
            return Education.Equals(other.Education) &&
                (
                    ReferenceEquals(DiplomaNumber, other.DiplomaNumber) ||
                    DiplomaNumber.Equals(other.DiplomaNumber)
                ) &&
                (
                    ReferenceEquals(DiplomaSeries, other.DiplomaSeries) ||
                    DiplomaSeries.Equals(other.DiplomaSeries)
                ) &&
                (
                    ReferenceEquals(ScientificTitle, other.ScientificTitle) ||
                    ScientificTitle.Equals(other.ScientificTitle)
                ) &&
                (
                    ReferenceEquals(EducationType, other.EducationType) ||
                    EducationType.Equals(other.EducationType)
                );
        }
    }
}