using TeacherManajar.ClassCode;
using System;
using System.Windows.Forms;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Клас для відображення користувачу інформації про домашнє заняття на тиждень або за вибраний день
    /// </summary>
    public partial class FormDiary : Form
    {
        private readonly Diary dairy = new Diary();
        /// <summary>
        /// Конструтор
        /// </summary>
        public FormDiary()
        {
            InitializeComponent();
            dairy.DatePickerStart = datePickerStart;
            dairy.DatePickerEnd = datePickerEnd;
            dairy.TitleWeek = tableLayoutPanelWeek;
            dairy.PanelWork = panelWork;
            dairy.TitleDay = labelTitleDay;

            datePickerStart.Value = datePickerStart.Value.AddDays(dairy.MondayNumber - (int)datePickerStart.Value.DayOfWeek);
            iconButtonNextWeek.Click += dairy.UpdateWeek;
            iconButtonPreviousWeek.Click += dairy.UpdateWeek;
        }
        /// <summary>
        /// Метод для вибору дати в календарі та виведення тижня, до якого належить вибрана дата
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Start_ValueChanged(object sender, EventArgs e)
        {
            if ((int)datePickerStart.Value.DayOfWeek != dairy.MondayNumber)
            {
                datePickerStart.Value = datePickerStart.Value.AddDays(dairy.MondayNumber - (int)datePickerStart.Value.DayOfWeek);
            }
            datePickerEnd.Value = datePickerStart.Value.AddDays(dairy.SundayNumber);
            dairy.CompleteWeek();
        }
    }
}