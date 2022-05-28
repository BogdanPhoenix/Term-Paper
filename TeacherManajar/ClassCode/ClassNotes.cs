using System;
using System.Collections.Generic;

namespace TeacherManajar.ClassCode
{
    /// <summary>
    /// Клас для взаємодії з нотатками та списками справ
    /// </summary>
    public class ClassNotes : ICloneable, IEquatable<ClassNotes>
    {
        public List<TextNotes> TextNotes { get; set; }
        public List<CheckNotes> CheckNotes { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            ClassNotes classNotes = new ClassNotes()
            {
                TextNotes = new List<TextNotes>(),
                CheckNotes = new List<CheckNotes>()
            };
            foreach (TextNotes textNotes in this.TextNotes)
            {
                classNotes.TextNotes.Add((TextNotes)textNotes.Clone());
            }
            foreach (CheckNotes checkNotes in this.CheckNotes)
            {
                classNotes.CheckNotes.Add((CheckNotes)checkNotes.Clone());
            }
            return classNotes;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(ClassNotes other)
        {
            if (TextNotes.Count != other.TextNotes.Count || CheckNotes.Count != other.CheckNotes.Count)
            {
                return false;
            }
            for (int index = 0; index < TextNotes.Count; ++index)
            {
                if (!TextNotes[index].Equals(other.TextNotes[index]))
                {
                    return false;
                }
            }
            for (int index = 0; index < CheckNotes.Count; ++index)
            {
                if (!CheckNotes[index].Equals(other.CheckNotes[index]))
                {
                    return false;
                }
            }
            return true;
        }
    }
    /// <summary>
    /// Клас для реалізації основних складових нотатки
    /// </summary>
    public class TextNotes : ICloneable, IEquatable<TextNotes>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            TextNotes textNotes = new TextNotes
            {
                Title = this.Title,
                Text = this.Text
            };
            return textNotes;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(TextNotes other)
        {
            return Title.Equals(other.Title) &&
                (
                    ReferenceEquals(Text, other.Text) ||
                    Text.Equals(other.Text)
                );
        }
    }
    /// <summary>
    /// Клас для реалізації основних складових списку справ
    /// </summary>
    public class CheckNotes : ICloneable, IEquatable<CheckNotes>
    {
        public string Title { get; set; }
        public List<ListCheck> ListChecks { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            CheckNotes checkNotes = new CheckNotes()
            {
                Title = this.Title,
                ListChecks = new List<ListCheck>()
            };
            foreach (ListCheck listCheck in this.ListChecks)
            {
                checkNotes.ListChecks.Add((ListCheck)listCheck.Clone());
            }
            return checkNotes;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(CheckNotes other)
        {
            if (ListChecks.Count != other.ListChecks.Count)
            {
                return false;
            }
            for (int index = 0; index < ListChecks.Count; ++index)
            {
                if (!ListChecks[index].Equals(other.ListChecks[index]))
                {
                    return false;
                }
            }
            return Title.Equals(other.Title);
        }
    }
    /// <summary>
    /// Клас для реалізації основних складових поля для використання його в списку справ
    /// </summary>
    public class ListCheck : ICloneable, IEquatable<ListCheck>
    {
        public bool Check { get; set; }
        public string Text { get; set; }
        /// <summary>
        /// Метод для копіювання даних
        /// </summary>
        /// <returns>Повертає копію об'єкта</returns>
        public object Clone()
        {
            ListCheck listCheck = new ListCheck
            {
                Check = this.Check,
                Text = this.Text
            };
            return listCheck;
        }
        /// <summary>
        /// Метод для перевірки двох об'єктів на рівність
        /// </summary>
        /// <param name="other">Об'єкт з яким потрібно провести порівняння</param>
        /// <returns>Повертає true,якщо об'єкти однакові, інакше - false</returns>
        public bool Equals(ListCheck other)
        {
            return Check.Equals(other.Check) &&
                (
                    ReferenceEquals(Text, other.Text) ||
                    Text.Equals(other.Text)
                );
        }
    }
}
