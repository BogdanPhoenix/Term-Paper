using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання основних даних про журнал групи
    /// </summary>
    public class GroupData : IEquatable<GroupData>, ICloneable
    {
        public string IdGroup { get; set; }
        public string Specialty { get; set; }
        public string NameSubject { get; set; }
        public uint Course { get; set; }
        public string IdTeacher { get; set; }
        public SettingGroup SettingGroup { get; set; }

        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(GroupData other)
        {
            return Specialty.Equals(other.Specialty) &&
                (
                    ReferenceEquals(Course, other.Course) ||
                    Course.Equals(other.Course)
                ) &&
                (
                    ReferenceEquals(NameSubject, other.NameSubject) ||
                    NameSubject.Equals(other.NameSubject)
                ) &&
                (
                    ReferenceEquals(Course, other.Course) ||
                    Course.Equals(other.Course)
                ) &&
                (
                    ReferenceEquals(SettingGroup, other.SettingGroup) ||
                    SettingGroup.Equals(other.SettingGroup)
                );
        }
        /// <summary>
        /// Метод для зчитування отриманого результату з бази даних та запису його у відповідні поля
        /// </summary>
        /// <param name="sqlDataReader">Об'єкт бази даних</param>
        public void ConvertGroupFromMySql(MySqlDataReader sqlDataReader)
        {
            IdGroup = SystemProcess.ConvertMySQLToText(sqlDataReader["IdGroup"].ToString());
            Specialty = SystemProcess.ConvertMySQLToText(sqlDataReader["Specialty"].ToString());
            NameSubject = SystemProcess.ConvertMySQLToText(sqlDataReader["NameSubject"].ToString());
            Course = Convert.ToUInt32(sqlDataReader["Course"]);
            IdTeacher = SystemProcess.ConvertMySQLToText(sqlDataReader["IdTeacher"].ToString());
            SettingGroup = JsonConvert.DeserializeObject<SettingGroup>(sqlDataReader["SettingGroup"].ToString());
        }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            GroupData group = new GroupData()
            {
                IdGroup = this.IdGroup,
                Specialty = this.Specialty,
                NameSubject = this.NameSubject,
                Course = this.Course,
                IdTeacher = this.IdTeacher
            };
            group.SettingGroup = (SettingGroup)this.SettingGroup.Clone();
            return group;
        }
    }
}