using FontAwesome.Sharp;
using System;
using System.Drawing;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання даних про налаштування відображення журналу групи в списку інших журналів
    /// </summary>
    public class CustomGroup : IEquatable<CustomGroup>, ICloneable
    {
        public IconChar Icon { get; set; }
        public Color ForeColor { get; set; }
        public Color BackIconColor { get; set; }
        public Color BackColor { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            CustomGroup custom = new CustomGroup()
            {
                Icon = this.Icon,
                ForeColor = this.ForeColor,
                BackColor = this.BackColor,
                BackIconColor = this.BackIconColor
            };
            return custom;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(CustomGroup other)
        {
            return ForeColor.Equals(other.ForeColor) ||
               (
                   ReferenceEquals(BackIconColor, other.BackIconColor) ||
                   BackIconColor.Equals(other.BackIconColor)
               ) &&
               (
                   ReferenceEquals(BackColor, other.BackColor) ||
                   BackColor.Equals(other.BackColor)
               ) &&
               (
                   ReferenceEquals(Icon, other.Icon) ||
                   Icon.Equals(other.Icon)
               );
        }
    }
}