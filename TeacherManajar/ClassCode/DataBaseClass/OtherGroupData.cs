using System;
using System.Collections.Generic;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання додаткової інформації журналу
    /// </summary>
    public class OtherGroupData : IEquatable<OtherGroupData>, ICloneable
    {
        public List<StudentsEstimates> StudentsEstimates { get; set; }
        public List<CalendarPlan> CalendarPlan { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            OtherGroupData newOther = new OtherGroupData() { StudentsEstimates = new List<StudentsEstimates>(), CalendarPlan = new List<CalendarPlan>() };

            foreach (StudentsEstimates students in StudentsEstimates)
            {
                StudentsEstimates estimates = (StudentsEstimates)students.Clone();
                newOther.StudentsEstimates.Add(estimates);
            }
            foreach (CalendarPlan students in CalendarPlan)
            {
                CalendarPlan calendar = (CalendarPlan)students.Clone();
                newOther.CalendarPlan.Add(calendar);
            }

            return newOther;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(OtherGroupData other)
        {
            if (StudentsEstimates.Count != other.StudentsEstimates.Count || CalendarPlan.Count != other.CalendarPlan.Count)
            {
                return false;
            }
            for (int index = 0; index < StudentsEstimates.Count; ++index)
            {
                if (!StudentsEstimates[index].Equals(other.StudentsEstimates[index]))
                {
                    return false;
                }
            }
            for (int index = 0; index < CalendarPlan.Count; ++index)
            {
                if (!CalendarPlan[index].Equals(other.CalendarPlan[index]))
                {
                    return false;
                }
            }
            return true;
        }
    }
    /// <summary>
    /// Клас для зберігання в собі інформації про студента в журналі та його оцінок
    /// </summary>
    public class StudentsEstimates : IEquatable<StudentsEstimates>, ICloneable
    {
        public string StudentId { get; set; }
        public List<string> Estimates { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            StudentsEstimates studentsEstimates = new StudentsEstimates
            {
                StudentId = this.StudentId,
                Estimates = new List<string>()
            };

            foreach (string element in this.Estimates)
            {
                studentsEstimates.Estimates.Add(element);
            }

            return studentsEstimates;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(StudentsEstimates other)
        {
            return StudentId.Equals(other.StudentId) &&
                (
                    ReferenceEquals(Estimates, other.Estimates) ||
                    Estimates.Equals(other.Estimates)
                );
        }
    }
    /// <summary>
    /// Клас для зберігання в собі інформації про додаткові записи заняття
    /// </summary>
    public class CalendarPlan : IEquatable<CalendarPlan>, ICloneable
    {
        public NewOccution Occution { get; set; }
        public string Record { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            return new CalendarPlan()
            {
                Record = this.Record,
                Occution = (NewOccution)this.Occution.Clone()
            };
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(CalendarPlan other)
        {
            return Record.Equals(other.Record) &&
                (
                    ReferenceEquals(Occution, other.Occution) ||
                    Occution.Equals(other.Occution)
                );
        }
    }
}