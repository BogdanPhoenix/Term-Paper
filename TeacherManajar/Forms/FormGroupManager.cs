using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.Enum;
using TeacherManajar.Forms.Manajar;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Відображає вибраний журнал групи та дозволяє взаємодіяти з ним
    /// </summary>
    public partial class FormGroupManager : Form
    {
        private GroupData groupData = null;
        private readonly GroupData newGroupData = null;
        private readonly AccountEmail account = null;
        private OtherGroupData otherGroupData = null;
        private readonly OtherGroupData newOtherGroupData = null;
        private bool activateForm = true;
        private ManagerCommand managerCommand = ManagerCommand.None;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="account">Дані користувача</param>
        /// <param name="groupData">Дані журналу</param>
        public FormGroupManager(AccountEmail account, GroupData groupData)
        {
            InitializeComponent();
            this.account = account;
            this.groupData = groupData;
            MySqlDataReader sqlDataReader = DataBase.SelectGroupsBase(groupData.IdGroup);
            sqlDataReader.Read();
            otherGroupData = JsonConvert.DeserializeObject<OtherGroupData>(sqlDataReader["OtherGroupData"].ToString());

            bunifuLabelGroupName.Text = groupData.NameSubject;

            bunifuIconButtonUpload.Click += (s, e) => { dropdownMenuUploadGroup.Show(bunifuIconButtonUpload, bunifuIconButtonUpload.Width, 0); };
            ReadData();

            newGroupData = (GroupData)groupData.Clone();
            newOtherGroupData = (OtherGroupData)otherGroupData.Clone();
            if (!account.Role.Equals("Вчитель") && !account.Role.Equals("Викладач"))
            {
                tableLayoutPanelTeacher.Visible = false;
            }

            /*foreach (var element in otherGroupData.CalendarPlan)
            {
                bufferHeaderName.Add(element.Occution.Date.ToString("d"));
            }*/
        }
        /// <summary>
        /// Метод для зчитування даних та заповнення таблиці
        /// </summary>
        private void ReadData()
        {
            try
            {
                foreach (var element in otherGroupData.CalendarPlan)
                {
                    AddColumn(element.Occution);
                }
                MySqlDataReader sqlDataReader = null;
                AccountEmail accountEmail = new AccountEmail() { Role = "Студент" };
                Person person = new Person();
                foreach (StudentsEstimates students in otherGroupData.StudentsEstimates)
                {
                    accountEmail.IdPerson = students.StudentId;
                    sqlDataReader = DataBase.Select(accountEmail, VariantSelect.Person);
                    sqlDataReader.Read();
                    person.ConvertFromMySql(sqlDataReader);
                    bunifuDataGridView.Rows.Add(bunifuDataGridView.Rows.Count + 1, $"{person.FirstName} {person.Name[0]}.{person.Surname[0]}.");
                    bunifuDataGridView.Height += bunifuDataGridView.RowHeadersWidth;

                    for (int indexColumn = 0; indexColumn < students.Estimates.Count; ++indexColumn)
                    {
                        bunifuDataGridView.Rows[bunifuDataGridView.Rows.Count - 1].Cells[indexColumn + 2].Value = students.Estimates[indexColumn];
                    }

                    bunifuVScrollBar.Visible = bunifuDataGridView.Height > panelTable.Height;
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show($"Під час занесення даних в таблицю сталася помилка\n{ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        /// <summary>
        /// Метод для горизонтального прокручування
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані вертикального прокручування і надає значення для прокручування, не зберігаючи в собі даних</param>
        private void HScrollBar_Scroll(object sender, BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                bunifuHScrollBar.Maximum = bunifuDataGridView.ColumnCount - 1;
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Метод для визначення розміру горизонтального повзунка при додаванні нових колонок
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані для додання даних в таблицю, не зберігаючи в собі даних</param>
        private void DataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                bunifuHScrollBar.Maximum = bunifuDataGridView.ColumnCount - 1;
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Метод для визначення розміру горизонтального повзунка при видалені колонок
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані для видалення даних з таблицю, не зберігаючи в собі даних</param>
        private void DataGridView_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                bunifuHScrollBar.Maximum = bunifuDataGridView.ColumnCount - 1;
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Метод для додання в журнал нового заняття
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void AddOccution_Click(object sender, EventArgs e)
        {
            FormAddOccution formAddOccution = new FormAddOccution(groupData.SettingGroup.TypesClasses);
            formAddOccution.ShowDialog();
            if (formAddOccution.DialogResult != DialogResult.Cancel)
            {
                if (!formAddOccution.NewOccution.Equals(""))
                {
                    newGroupData.SettingGroup.TypesClasses.Add(formAddOccution.NewOccution);
                }
                AddColumn(formAddOccution.Occution);

                CalendarPlan calendarPlan = new CalendarPlan()
                {
                    Record = "",
                    Occution = (NewOccution)formAddOccution.Occution.Clone()
                };

                newOtherGroupData.CalendarPlan.Add(calendarPlan);
                foreach (StudentsEstimates students in newOtherGroupData.StudentsEstimates)
                {
                    students.Estimates.Add("");
                }
                CheckSave();
            }
        }
        /// <summary>
        /// Метод для додання в журнал нового студента, якого не було в базі даних на момент створення журналу
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddStudent formAddStudent = new FormAddStudent();
                formAddStudent.ShowDialog();
                if (formAddStudent.DialogResult == DialogResult.OK)
                {
                    StudentsEstimates studentsEstimates = new StudentsEstimates
                    {
                        StudentId = formAddStudent.Identification,
                        Estimates = new List<string>()
                    };
                    newOtherGroupData.StudentsEstimates.Add(studentsEstimates);
                    MySqlDataReader sqlDataReader = DataBase.SelectPersonStudent(formAddStudent.Identification);
                    sqlDataReader.Read();
                    bunifuDataGridView.Rows.Add(bunifuDataGridView.Rows.Count - 1, $"{sqlDataReader["FirstName"]} {sqlDataReader["Name"].ToString()[0]} {sqlDataReader["Surname"].ToString()[0]}");
                    bunifuDataGridView.Height += bunifuDataGridView.RowHeadersWidth;
                    bunifuVScrollBar.Visible = bunifuDataGridView.Height > panelTable.Height;
                    CheckSave();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Під час роботи з базою даних сталася помилка: {ex.Message}. Студента не додано.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Під час роботи сталася помилка: {ex.Message}. Студента не додано.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Метод для додання та редагування записів до кожного із занять
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void AddCalendarPlan_Click(object sender, EventArgs e)
        {
            FormCalendarPlan calendarPlan = new FormCalendarPlan(newOtherGroupData.CalendarPlan, newGroupData.SettingGroup.AutoSave);
            calendarPlan.ShowDialog();
        }
        /// <summary>
        /// Метод для збереження змін в журналі
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                groupData = (GroupData)newGroupData.Clone();
                otherGroupData = (OtherGroupData)newOtherGroupData.Clone();
                DataBase.UpdateGroupData(newGroupData, newOtherGroupData);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Під час оновленна даних в базі даних виникла помилка: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Під час оновленна даних виникла помилка: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для редагування вже створених занять, якщо під час їх створення була допущена помилка
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void SettingOccutionColumn_Click(object sender, EventArgs e)
        {
            if (activateForm)
            {
                bunifuSnackbar.Show(this, "Натисніть на заголовок колонки для її редагування", duration: 7500, position: BunifuSnackbar.Positions.BottomRight);
                managerCommand = ManagerCommand.SettingOccution;
            }
            TableWork("bunifuIconButtonSettingColumn");
            bunifuDataGridView.ReadOnly = activateForm;
            if (!activateForm)
            {
                bunifuDataGridView.Columns["IdPerson"].ReadOnly = bunifuDataGridView.Columns["FullName"].ReadOnly = true;
            }
            activateForm = !activateForm;
        }
        /// <summary>
        /// Метод для видалення колонки заняття
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            if (activateForm)
            {
                bunifuSnackbar.Show(this, "Натисніть на заголовок колонки для видалення заняття", duration: 7500, position: BunifuSnackbar.Positions.BottomRight);
                managerCommand = ManagerCommand.DeleteOccution;
            }
            TableWork("bunifuIconButtonDeleteColumn");
            bunifuDataGridView.ReadOnly = activateForm;
            if (!activateForm)
            {
                bunifuDataGridView.Columns["IdPerson"].ReadOnly = bunifuDataGridView.Columns["FullName"].ReadOnly = true;
            }
            activateForm = !activateForm;
        }
        /// <summary>
        /// Метод який блокує майже увесь функціонал журналу. Залишає лише активними колонки таблиці, які відповідають за заняття та ту кнопку, яка викликала даний метод
        /// </summary>
        /// <param name="nameButton">Назва кнопки, яку потрібно ігнорувати</param>
        private void TableWork(string nameButton)
        {
            bunifuDataGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = (activateForm ? DataGridViewColumnSortMode.NotSortable : DataGridViewColumnSortMode.Automatic));
            for (int index = 0; index < tableLayoutPanelButtons.ColumnCount; ++index)
            {
                TableLayoutPanel table = (TableLayoutPanel)tableLayoutPanelButtons.GetControlFromPosition(index, 0);
                for (int indexButton = 0; indexButton < table.ColumnCount; ++indexButton)
                {
                    BunifuIconButton element = (BunifuIconButton)table.GetControlFromPosition(indexButton, 0);
                    if (element != null && !element.Name.Equals(nameButton))
                    {
                        element.Enabled = !activateForm;
                        element.BackgroundColor = activateForm ? Color.Silver : Color.DodgerBlue;
                    }
                }
            }
            bunifuDataGridView.Columns["IdPerson"].HeaderCell.Style.BackColor = bunifuDataGridView.Columns["FullName"].HeaderCell.Style.BackColor = activateForm ? Color.Silver : Color.Teal;
        }
        /// <summary>
        /// Метод для перевірки чи відбулися зміни в журналі. Якщо так, то кнопка "Зберегти" стає активною
        /// </summary>
        private void CheckSave()
        {
            bunifuIconButtonSave.Enabled = !groupData.Equals(newGroupData) || !otherGroupData.Equals(newOtherGroupData);
        }
        /// <summary>
        /// Метод для взаємодії із заголовками колонок в залежності від вибору варіанту взаємодії з ними
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані виділення мишкою комірки і надає значення для властивості</param>
        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!activateForm)
            {
                switch (managerCommand)
                {
                    case ManagerCommand.SettingOccution:
                        {
                            FormAddOccution formAddOccution = new FormAddOccution(groupData.SettingGroup.TypesClasses, newOtherGroupData.CalendarPlan[e.ColumnIndex - bunifuDataGridView.Columns["FullName"].Index - 1].Occution);
                            formAddOccution.ShowDialog();
                            if (formAddOccution.DialogResult != DialogResult.Cancel)
                            {
                                newOtherGroupData.CalendarPlan[e.ColumnIndex - bunifuDataGridView.Columns["FullName"].Index - 1].Occution = (NewOccution)formAddOccution.Occution.Clone();

                                string nameOccution = formAddOccution.Occution.TypesClasses.Length > 8 ? $"{formAddOccution.Occution.TypesClasses.Substring(0, 7)}." : formAddOccution.Occution.TypesClasses;
                                bunifuDataGridView.Columns[e.ColumnIndex].HeaderText = $"{nameOccution} {formAddOccution.Occution.NumberOccution}\n{formAddOccution.Occution.Date:d}";
                                bunifuDataGridView.Columns[e.ColumnIndex].Name = $"Column_{nameOccution}_{formAddOccution.Occution.NumberOccution}_{formAddOccution.Occution.Date:d}";

                                SettingOccutionColumn_Click(new object(), new EventArgs());
                            }
                            break;
                        }
                    case ManagerCommand.DeleteOccution:
                        {
                            DialogResult result = MessageBox.Show($"Ви дійсно бажаєте видалити заняття \n{bunifuDataGridView.Columns[e.ColumnIndex].HeaderText}?\nСтовпчик буде видалено назавжди і його не можна буде відновити.", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                bunifuDataGridView.Columns.RemoveAt(e.ColumnIndex);
                                foreach (StudentsEstimates students in newOtherGroupData.StudentsEstimates)
                                {
                                    students.Estimates.RemoveAt(e.ColumnIndex - bunifuDataGridView.Columns["FullName"].Index - 1);
                                }
                                newOtherGroupData.CalendarPlan.RemoveAt(e.ColumnIndex - bunifuDataGridView.Columns["FullName"].Index - 1);
                                bunifuSnackbar.Show(this, "Операція виконана успішно.", duration: 3000, position: BunifuSnackbar.Positions.BottomRight);
                                DeleteColumn_Click(new object(), new EventArgs());
                            }
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// Метод для редагування комірок, який після завершення редагування зберігає та оновлює дані
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані взаємодії з комірками і надає значення для властивості</param>
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > bunifuDataGridView.Columns["FullName"].Index)
            {
                string text = (string)bunifuDataGridView[e.ColumnIndex, e.RowIndex].Value;
                bool check = text.Equals(newOtherGroupData.StudentsEstimates[e.RowIndex].Estimates[e.ColumnIndex - bunifuDataGridView.Columns["FullName"].Index - 1]);
                if (!check)
                {
                    newOtherGroupData.StudentsEstimates[e.RowIndex].Estimates[e.ColumnIndex - bunifuDataGridView.Columns["FullName"].Index - 1] = SystemProcess.ConvertTextToMySQL(text);
                }
                CheckSave();
            }
        }
        private void BunifuDataGridView_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            /*int indexName = bunifuDataGridView.Columns["FullName"].Index + 1;
            int column1 = 0, column2 = e.Column.Index;
            for (int index = 0; index < bufferHeaderName.Count; ++index)
            {
                if (!bunifuDataGridView.Columns[index + 2].HeaderText.Equals(bufferHeaderName[index]))
                {
                    if (column1 == 0)
                    {
                        column1 = index;
                    }
                    else
                    {
                        column2 = index;
                        break;
                    }
                }
            }
            for (int index = 0; index < otherGroupData.CalendarPlan.Count; ++index)
            {
                string buffer = otherGroupData.StudentsEstimates[index].Estimates[column1];
                otherGroupData.StudentsEstimates[index].Estimates[column1] = otherGroupData.StudentsEstimates[index].Estimates[column2];
                otherGroupData.StudentsEstimates[index].Estimates[column2] = buffer;
            }
            CalendarPlan bufferCalendar = (CalendarPlan)otherGroupData.CalendarPlan[column1].Clone();
            otherGroupData.CalendarPlan[column1] = (CalendarPlan)otherGroupData.CalendarPlan[column2].Clone();
            otherGroupData.CalendarPlan[column2] = bufferCalendar;*/
        }
        /// <summary>
        /// Метод для виведення інформації про журнал
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void InformtionGroup_Click(object sender, EventArgs e)
        {
            InformationGroup informationGroup = new InformationGroup(groupData);
            informationGroup.Show();
        }
        /// <summary>
        /// Метод для створення колонок із заповненням необхідної інформації про заняття
        /// </summary>
        /// <param name="occution">Дані про заняття</param>
        /// <returns>Повертає колонку, яка додається в таблицю</returns>
        private DataGridViewTextBoxColumn AddColumn(NewOccution occution)
        {
            string nameOccution = occution.TypesClasses.Length > 8 ? $"{occution.TypesClasses.Substring(0, 7)}." : occution.TypesClasses;
            DataGridViewTextBoxColumn columnCollection = new DataGridViewTextBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Resizable = DataGridViewTriState.False,
                Width = 100,
                HeaderText = $"{nameOccution} {occution.NumberOccution}\n{occution.Date:d}",
                Name = $"Column_{nameOccution}_{occution.NumberOccution}_{occution.Date:d}"
                
            };
            switch (account.Role.ToLower())
            {
                case "учень":
                case "студент": columnCollection.ReadOnly = true; break;
                case "викладач":
                case "вчитель": columnCollection.ReadOnly = false; break;
            }

            columnCollection.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            columnCollection.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView.Width += columnCollection.Width;
            bunifuDataGridView.Columns.Add(columnCollection);

            bunifuHScrollBar.Visible = bunifuDataGridView.Width > panelTable.Width;

            return columnCollection;
        }
    }
}