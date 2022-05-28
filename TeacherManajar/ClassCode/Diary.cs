using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TeacherManajar.ClassCode
{
    /// <summary>
    /// Клас для роботи з календарем українською мовою
    /// </summary>
    public class Diary
    {
        private static readonly Calendar calendar = new CultureInfo("ua-UA").Calendar;
        private static readonly Dictionary<int, string> weekName = new Dictionary<int, string>()
        {
            {0, "Понеділок" },
            {1, "Вівторок" },
            {2, "Середа" },
            {3, "Четвер" },
            {4, "П'ятниця" },
            {5, "Субота" },
            {6, "Неділя" }
        };

        public int MondayNumber => 1;
        public int SundayNumber => 6;
        public BunifuDatePicker DatePickerStart { private get; set; }
        public BunifuDatePicker DatePickerEnd { private get; set; }
        public TableLayoutPanel TitleWeek { private get; set; }
        public Panel PanelWork { private get; set; }
        public Label TitleDay { private get; set; }
        /// <summary>
        /// Метод для оновлення відображення домашніх завдань на тиждень
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        public void UpdateWeek(object sender, EventArgs e)
        {
            int step = 1;
            BunifuButton2 datePicker = (BunifuButton2)sender;
            if (datePicker.Name.Contains("PreviousWeek"))
            {
                step *= -1;
            }
            DatePickerStart.Value = calendar.AddWeeks(DatePickerStart.Value, step);
            CompleteWeek();
        }
        /// <summary>
        /// Метод для створення кнопки, якщо на даний день присутні домашні завдання
        /// </summary>
        /// <returns>Повертає кнопку</returns>
        public IconButton ButtonHomeworkNotExecuted()
        {
            IconButton button = new IconButton
            {
                BackColor = Color.FromArgb(240, 167, 38),
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.FromArgb(24, 128, 240),
                IconChar = IconChar.FileAlt,
                IconColor = Color.FromArgb(24, 128, 240),
                IconFont = IconFont.Solid,
                Location = new Point(0, 0),
                Margin = new Padding(0, 0, 5, 5),
                Name = "buttonHomeworkNotExecuted",
                Size = new Size(135, 140),
                TabIndex = 0,
                Text = "Є не виконане домашнє завдання",
                TextAlign = ContentAlignment.BottomCenter,
                TextImageRelation = TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += ActivePanelWork;
            return button;
        }
        /// <summary>
        /// Метод для створення кнопки, якщо на даний день відсутні домашні завдання
        /// </summary>
        /// <returns>Повертає кнопку</returns>
        public IconButton ButtonHomeworkMissing()
        {
            IconButton button = new IconButton
            {
                BackColor = Color.FromArgb(240, 167, 38),
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 11.25F, FontStyle.Bold),
                ForeColor = Color.FromArgb(24, 128, 204),
                IconChar = IconChar.File,
                IconColor = Color.FromArgb(24, 128, 204),
                IconFont = IconFont.Solid,
                Location = new Point(280, 0),
                Margin = new Padding(0, 0, 5, 5),
                Name = "buttonHomeworkMissing",
                Size = new Size(135, 140),
                TabIndex = 1,
                Text = "Домашнє завдання відсутнє",
                TextAlign = ContentAlignment.BottomCenter,
                TextImageRelation = TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += ActivePanelWork;
            return button;
        }
        /// <summary>
        /// Метод для формування днів тижня
        /// </summary>
        public void CompleteWeek()
        {
            TitleWeek.Controls.Clear();
            for (int index = 0; index < weekName.Count; ++index)
            {

                DateTime day = DatePickerStart.Value.AddDays(index);
                Label label = new Label
                {
                    BackColor = Color.FromArgb(67, 64, 145),
                    Dock = DockStyle.Fill,
                    ForeColor = Color.White,
                    Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                    Location = new Point(0, 0),
                    Margin = new Padding(0, 5, 5, 5),
                    Name = $"labelMonday{weekName[index]}",
                    Size = new Size(135, 50),
                    Tag = $"{day.Date:dd MMMM}",
                    Text = $"{weekName[index]}\n{day.Date:dd MMMM}",
                    TextAlign = ContentAlignment.MiddleCenter
                };
                TitleWeek.Controls.Add(label, index, 0);
                TitleWeek.Controls.Add(ButtonHomeworkNotExecuted(), index, 1);
            }
        }
        /// <summary>
        /// Метод для виведення інформації про домашні завдання на вибраний день
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void ActivePanelWork(object sender, EventArgs e)
        {
            PanelWork.Visible = true;
            Point? cellPos = SystemProcess.GetRowColIndex(TitleWeek, TitleWeek.PointToClient(Cursor.Position));
            Label panelCell = (Label)TitleWeek.GetControlFromPosition(cellPos.Value.X, 0);
            TitleDay.Text = $"Розклад на: {panelCell.Tag}";
        }
    }
}