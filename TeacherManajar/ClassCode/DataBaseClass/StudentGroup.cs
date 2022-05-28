using TeacherManajar.InterfaceCode;
using MySql.Data.MySqlClient;
using System;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання даних користувача, які пов’язані з навчанням, якщо він є студентом
    /// </summary>
    public class StudentGroup : IGroup, ICloneable, IEquatable<StudentGroup>
    {
        public string Education { get; set; }
        public uint Course { get; set; }
        public string Specialty { get; set; }
        public string FormStudy { get; set; }
        public string EducationalDegree { get; set; }
        public string EducationType { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            return new StudentGroup
            {
                Education = this.Education,
                Course = this.Course,
                Specialty = this.Specialty,
                FormStudy = this.FormStudy,
                EducationalDegree = this.EducationalDegree,
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
            Course = Convert.ToUInt32(sqlDataReader["Course"]);
            Specialty = SystemProcess.ConvertMySQLToText(sqlDataReader["Specialty"].ToString());
            FormStudy = SystemProcess.ConvertMySQLToText(sqlDataReader["FormStudy"].ToString());
            EducationalDegree = SystemProcess.ConvertMySQLToText(sqlDataReader["EducationalDegree"].ToString());
            EducationType = SystemProcess.ConvertMySQLToText(sqlDataReader["EducationType"].ToString());
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(StudentGroup other)
        {
            return Education.Equals(other.Education) &&
                (
                    ReferenceEquals(Course, other.Course) ||
                    Course.Equals(other.Course)
                ) &&
                (
                    ReferenceEquals(Specialty, other.Specialty) ||
                    Specialty.Equals(other.Specialty)
                ) &&
                (
                    ReferenceEquals(FormStudy, other.FormStudy) ||
                    FormStudy.Equals(other.FormStudy)
                ) &&
                (
                    ReferenceEquals(EducationalDegree, other.EducationalDegree) ||
                    EducationalDegree.Equals(other.EducationalDegree)
                ) &&
                (
                    ReferenceEquals(EducationType, other.EducationType) ||
                    EducationType.Equals(other.EducationType)
                );
        }
    }
}