using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;

namespace TeacherManajar.Forms.Manajar
{
    /// <summary>
    /// Клас для введення контролю занять. Дозволяє вводити головне, що було розглянуто на занятті
    /// </summary>
    public partial class FormCalendarPlan : Form
    {
        private readonly List<CalendarPlan> calendarPlans = null;
        private readonly bool autoSave;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="calendarPlans">Список календарного плану даного журналу</param>
        /// <param name="autoSave">Вказівник того чи увімкнене автозбереження</param>
        public FormCalendarPlan(List<CalendarPlan> calendarPlans, bool autoSave)
        {
            InitializeComponent();
            this.calendarPlans = calendarPlans;
            this.autoSave = autoSave;

            labelAutoSave.Text += autoSave ? "увімкнено" : "вимкнено";
            bunifuIconButtonSave.Visible = !autoSave;
            AddTable();
            bunifuIconButtonBack.Click += (s, e) => { Hide(); };
        }
        /// <summary>
        /// Метод для заповнення таблиці
        /// </summary>
        private void AddTable()
        {
            foreach (CalendarPlan plan in calendarPlans)
            {
                bunifuDataGridView.Rows.Add(bunifuDataGridView.Rows.Count + 1, plan.Occution.Date.ToString("d"), SystemProcess.ConvertMySQLToText(plan.Record));
                bunifuDataGridView.CellEndEdit += EndEditCell;
            }
            if (bunifuDataGridView.Height > panelTable.Height)
            {
                bunifuVScrollBar.Visible = true;
                Width = MaximumSize.Width;
            }
            else
            {
                bunifuVScrollBar.Visible = false;
                Width = MinimumSize.Width;
            }
        }
        private void PanelMoveShape_MouseDown(object sender, MouseEventArgs e)
        {
            SystemProcess.ReleaseCapture();
            SystemProcess.SendMessage(Handle);
        }
        /// <summary>
        /// Метод для редагування комірок, який після завершення редагування зберігає та оновлює дані
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані взаємодії з комірками і надає значення для властивості</param>
        private void EndEditCell(object sender, DataGridViewCellEventArgs e)
        {
            if (autoSave && e.ColumnIndex == bunifuDataGridView.Columns["CalendarText"].Index)
            {
                string text = (string)bunifuDataGridView[e.ColumnIndex, e.RowIndex].Value;
                bool check = text.Equals(calendarPlans[e.RowIndex].Record);
                if (autoSave && !check)
                {
                    calendarPlans[e.RowIndex].Record = SystemProcess.ConvertTextToMySQL(text);
                }
                bunifuIconButtonSave.Enabled = !autoSave && !check && !bunifuIconButtonSave.Enabled;
            }
        }
        /// <summary>
        /// Метод для збереження даних, якщо автозбереження вимкнене
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Save_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < bunifuDataGridView.Rows.Count; ++index)
            {
                calendarPlans[index].Record = SystemProcess.ConvertTextToMySQL(bunifuDataGridView.Rows[index].Cells["CalendarText"].Value.ToString());
            }
            bunifuIconButtonSave.Enabled = false;
        }
        /// <summary>
        /// Метод для вертикального прокручування
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані вертикального прокручування і надає значення для прокручування, не зберігаючи в собі даних</param>
        private void VScrollBar_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                bunifuDataGridView.FirstDisplayedScrollingRowIndex = bunifuDataGridView.Rows[e.Value].Index;
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Метод для визначення розміру вертикального повзунка при додаванні нових рядків
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані для додання даних в таблицю, не зберігаючи в собі даних</param>
        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar.Maximum = bunifuDataGridView.RowCount - 1;
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Метод для визначення розміру вертикального повзунка при видалені рядків
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані для видалення даних з таблицю, не зберігаючи в собі даних</param>
        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                bunifuVScrollBar.Maximum = bunifuDataGridView.RowCount - 1;
            }
            catch (Exception) { }
        }
    }
}
