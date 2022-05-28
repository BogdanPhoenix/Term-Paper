using System;
using System.Collections.Generic;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для зберігання всі доступних налаштувань журналу
    /// </summary>
    public class SettingGroup : IEquatable<SettingGroup>, ICloneable
    {
        public CustomGroup Custom { get; set; }
        public string SystemOption { get; set; }
        public string EducationType { get; set; }
        public bool AutoSave { get; set; }
        public List<string> TypesClasses { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            SettingGroup setting = new SettingGroup()
            {
                SystemOption = this.SystemOption,
                EducationType = this.EducationType,
                AutoSave = this.AutoSave,
                Custom = (CustomGroup)this.Custom.Clone()
            };

            List<string> buffer = new List<string>();
            foreach (string element in TypesClasses)
            {
                buffer.Add(element);
            }
            setting.TypesClasses = buffer;

            return setting;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(SettingGroup other)
        {
            if (TypesClasses.Count != other.TypesClasses.Count)
            {
                return false;
            }
            for (int index = 0; index < TypesClasses.Count; ++index)
            {
                if (!TypesClasses[index].Equals(other.TypesClasses[index]))
                {
                    return false;
                }
            }
            return Custom.Equals(other.Custom) &&
                (
                    ReferenceEquals(SystemOption, other.SystemOption) ||
                    SystemOption.Equals(other.SystemOption)
                ) &&
                (
                    ReferenceEquals(EducationType, other.EducationType) ||
                    EducationType.Equals(other.EducationType)
                ) &&
                (
                    ReferenceEquals(AutoSave, other.AutoSave) ||
                    AutoSave.Equals(other.AutoSave)
                );
        }
    }
}