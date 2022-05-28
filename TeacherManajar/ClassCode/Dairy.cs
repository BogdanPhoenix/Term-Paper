using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using RJCodeAdvance.RJControls;

namespace TeacherManajar.ClassCode
{
    public class Dairy
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
        public RJDatePicker DatePickerStart { private get; set; }
        public RJDatePicker DatePickerEnd { private get; set; }
        public TableLayoutPanel TitleWeek { private get; set; }
        public Panel PanelWork { private get; set; }
        public Label TitleDay { private get; set; }
        public Form ParentsForm { private get; set; }

        public void UpdateWeek(object sender, EventArgs e)
        {
            int step = 1;
            IconButton datePicker = (IconButton)sender;
            if (datePicker.Name.Contains("PreviousWeek"))
            {
                step *= -1;
            }
            DatePickerStart.Value = calendar.AddWeeks(DatePickerStart.Value, step);
            CompleteWeek();
        }
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
        public void CompleteWeek()
        {
            TitleWeek.Controls.Clear();
            for (int index = 0; index < weekName.Count; ++index){

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
        private void ActivePanelWork(object sender, EventArgs e)
        {
            PanelWork.Visible = true;
            Point? cellPos = SystemProcess.GetRowColIndex(TitleWeek, TitleWeek.PointToClient(Cursor.Position));
            Label panelCell = (Label)TitleWeek.GetControlFromPosition(cellPos.Value.X, 0);
            TitleDay.Text = $"Розклад на: {panelCell.Tag}";
        }
    }
}
