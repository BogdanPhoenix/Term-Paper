using System;

namespace TeacherManajar.ClassCode
{
    /// <summary>
    /// Клас для реалізації необхідних даних для опису заняття
    /// </summary>
    public class NewOccution : IEquatable<NewOccution>, ICloneable
    {
        public DateTime Date { get; set; }
        public string TypesClasses { get; set; }
        public string NumberOccution { get; set; }
        public bool Add { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            return new NewOccution()
            {
                Date = this.Date,
                TypesClasses = this.TypesClasses,
                NumberOccution = this.NumberOccution,
                Add = this.Add
            };
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(NewOccution other)
        {
            return Date.Equals(other.Date) &&
                (
                    ReferenceEquals(TypesClasses, other.TypesClasses) ||
                    TypesClasses.Equals(other.TypesClasses)
                ) &&
                (
                    ReferenceEquals(NumberOccution, other.NumberOccution) ||
                    NumberOccution.Equals(other.NumberOccution)
                ) &&
                (
                    ReferenceEquals(Add, other.Add) ||
                    Add.Equals(other.Add)
                );
        }
    }
}
