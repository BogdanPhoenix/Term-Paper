using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.ClassCode.WordDocument;
using TeacherManajar.Enum;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Клас для викладача, який надає йому можливість створення нових журналів для груп
    /// </summary>
    public partial class FormCreateGroup : Form
    {
        private readonly List<IconChar> icon = new List<IconChar>()
        {
            IconChar.Accusoft,
            IconChar.Ad,
            IconChar.Adjust,
            IconChar.Adn,
            IconChar.Adversal,
            IconChar.Affiliatetheme,
            IconChar.Alipay,
            IconChar.Allergies,
            IconChar.Amazon,
            IconChar.AmazonPay,
            IconChar.AmericanSignLanguageInterpreting,
            IconChar.Amilia,
            IconChar.Anchor,
            IconChar.Android,
            IconChar.Angellist,
            IconChar.Angrycreative,
            IconChar.Angular,
            IconChar.Ankh,
            IconChar.Apper,
            IconChar.Apple,
            IconChar.AppleAlt,
            IconChar.ApplePay,
            IconChar.AppStore,
            IconChar.Archive,
            IconChar.Archway
        };
        private DataTable data = null;
        private GroupData dataGroup = null;
        private readonly OtherGroupData otherGroupData = new OtherGroupData() { StudentsEstimates = new List<StudentsEstimates>(), CalendarPlan = new List<CalendarPlan>() };
        private readonly AccountEmail accountEmail = null;
        private readonly List<string> universityList = new List<string>()
        {
            "Лекція",
            "Практика",
            "Модульна",
            "Курсова",
            "Дипломна робота"
        };
        private readonly List<string> schoolList = new List<string>()
        {
            "Урок",
            "Практика",
            "Самостійна робота",
            "Підсумкова робота",
            "Семестрова робота",
            "Контрольна"
        };
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="accountEmail">Основні дані викладача</param>
        public FormCreateGroup(AccountEmail accountEmail)
        {
            InitializeComponent();
            this.accountEmail = accountEmail;
            bunifuDropdowneValuationSystemOptions.Click += (s, e) => { bunifuTextBoxSystemOptions.Visible = bunifuDropdowneValuationSystemOptions.Text.Equals("Задати вручну"); };
        }
        /// <summary>
        /// Метод для відображення форми після повного її завантаження
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void FormCreateGroup_Load(object sender, EventArgs e)
        {
            iconButtonImportData.Click += (s, ev) => { rjDropdownMenu.Show(iconButtonImportData, iconButtonImportData.Width, 0); };
            bunifuDropdownIconChar.SelectedIndexChanged += (s, ev) => { iconPictureBox.IconChar = icon[bunifuDropdownIconChar.SelectedIndex]; };

            buttonChoiceColorTextAndIcon.Click += (s, ev) => { iconPictureBox.IconColor = colorIconAndText.BackColor = colorDialog.ShowDialog() == DialogResult.OK ? colorDialog.Color : colorIconAndText.BackColor; };
            buttonChoiceColorBackgroundIcon.Click += (s, ev) => { iconPictureBox.BackColor = colorIconBackground.BackColor = colorDialog.ShowDialog() == DialogResult.OK ? colorDialog.Color : colorIconBackground.BackColor; };
            buttonBackgrounfForm.Click += (s, ev) => { colorBackgroundForm.BackColor = colorDialog.ShowDialog() == DialogResult.OK ? colorDialog.Color : colorBackgroundForm.BackColor; };

            bunifuTextBoxCourse.KeyPress += (s, ev) => { ev.Handled = bunifuTextBoxCourse.Text.Length > 0 && ev.KeyChar != Convert.ToChar(Keys.Back); };
            bunifuTextBoxSystemOptions.KeyPress += (s, ev) => { ev.Handled = bunifuTextBoxCourse.Text.Length > 4 && ev.KeyChar != Convert.ToChar(Keys.Back); };

            таблицяToolStripMenuItem.Click += Import;
            списокToolStripMenuItem.Click += Import;
            документExelToolStripMenuItem.Click += Import;
            текстовийДокументToolStripMenuItem.Click += Import;
            базаДанихToolStripMenuItem.Click += Import;

            foreach (IconChar iconChar in icon)
            {
                bunifuDropdownIconChar.Items.Add(iconChar.ToString());
            }
            bunifuDropdownIconChar.SelectedIndex = 0;

            rjDropdownMenu.IsMainMenu = false;
            iconPictureBox.IconChar = icon[bunifuDropdownIconChar.SelectedIndex];
        }
        /// <summary>
        /// Метод для отримання унікальних ідентифікаторів з файдів або бази даних
        /// </summary>
        private void GetId()
        {
            try
            {
                otherGroupData.StudentsEstimates.Clear();
                bunifuDataGridView.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    if (!row.ItemArray[0].ToString().Equals("") && !row.ItemArray[0].ToString().ToLower().Equals("ідентифікатор") && !row.ItemArray[0].ToString().ToLower().Equals("піб") && !row.ItemArray[0].ToString().ToLower().Equals("ініціали"))
                    {
                        StudentsEstimates studentsEstimates = new StudentsEstimates
                        {
                            StudentId = row.ItemArray[0].ToString(),
                            Estimates = new List<string>()
                        };
                        otherGroupData.StudentsEstimates.Add(studentsEstimates);
                    }
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
        /// Метод для формування списку студентів
        /// </summary>
        private void ReadTable()
        {
            otherGroupData.CalendarPlan.Clear();
            if (data.Columns.Count > 1 && otherGroupData != null)
            {
                string buffer;
                int index;
                for (int i = 1; i < data.Columns.Count; ++i)
                {
                    CalendarPlan calendarPlan = new CalendarPlan();
                    calendarPlan.Occution.Date = Convert.ToDateTime(data.Columns[i].ToString());
                    calendarPlan.Record = "";
                    calendarPlan.Occution.Add = false;

                    if (data.Rows[0].ItemArray[0].ToString().Equals(""))
                    {
                        buffer = data.Rows[0].ItemArray[i].ToString();
                        index = buffer.IndexOf("№");
                        calendarPlan.Occution.TypesClasses = buffer.Substring(0, index - 1);
                        calendarPlan.Occution.NumberOccution = buffer.Substring(index + 1);
                    }
                    otherGroupData.CalendarPlan.Add(calendarPlan);
                }
                if (data.Rows[0].ItemArray[0].ToString().Equals(""))
                {
                    data.Rows.RemoveAt(0);
                }
                index = 0;
                foreach (DataRow row in data.Rows)
                {
                    StudentsEstimates studentsEstimates = new StudentsEstimates() { Estimates = new List<string>() };
                    for (int i = 1; i < row.ItemArray.Length; ++i)
                    {
                        studentsEstimates.Estimates.Add(row[i].ToString());
                    }
                    otherGroupData.StudentsEstimates[index++].Estimates = studentsEstimates.Estimates;
                }
            }
        }
        /// <summary>
        /// Метод для занесення всіх вхідних даних у відповідні об'єкти перед створенням журналу
        /// </summary>
        private void WriteData()
        {
            string systemOption = "";
            switch (bunifuDropdowneValuationSystemOptions.Text)
            {
                case "5 - бальна": systemOption = "5"; break;
                case "12 - бальна": systemOption = "12"; break;
                case "100 - бальна": systemOption = "100"; break;
                case "Задати вручну": systemOption = bunifuTextBoxSystemOptions.Text; break;
            }
            dataGroup = new GroupData
            {
                IdGroup = Guid.NewGuid().ToString(),
                Specialty = bunifuTextBoxSpecialty.Text.Replace("'", "^"),
                NameSubject = bunifuTextBoxNameSubject.Text.Replace("'", "^"),
                Course = Convert.ToUInt32(bunifuTextBoxCourse.Text),
                IdTeacher = accountEmail.IdPerson,
                SettingGroup = new SettingGroup()
            };
            dataGroup.SettingGroup.Custom = new CustomGroup()
            {
                ForeColor = colorIconAndText.BackColor,
                BackIconColor = colorIconBackground.BackColor,
                BackColor = colorBackgroundForm.BackColor,
                Icon = icon[bunifuDropdownIconChar.SelectedIndex]
            };
            dataGroup.SettingGroup.SystemOption = systemOption;
            MySqlDataReader sqlDataReader = DataBase.Select(accountEmail, VariantSelect.Person);
            sqlDataReader.Read();
            dataGroup.SettingGroup.EducationType = sqlDataReader["EducationType"].ToString();

            switch (dataGroup.SettingGroup.EducationType)
            {
                case "University": dataGroup.SettingGroup.TypesClasses = universityList; break;
                case "School": dataGroup.SettingGroup.TypesClasses = schoolList; break;
            }
        }
        /// <summary>
        /// Метод для отримання даних за допомогою одного із запропонованих варіантів
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Import(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                switch (menu.Tag.ToString())
                {
                    case "таблиця":
                        {
                            data = WordDocument.ImportWordTableFile();
                            if (data.Rows[0].ItemArray[0].ToString().All(char.IsLetter))
                            {
                                data.Rows.RemoveAt(0);
                            }
                            GetId();
                            ReadTable();
                            AddDataInTable();
                            break;
                        }
                    case "список":
                        {
                            data = WordDocument.ImportWordListFile();
                            GetId();
                            AddDataInTable();
                            break;
                        }
                    case "документExel":
                        {
                            data = ExcelDocument.ImportExcelFile();
                            GetId();
                            ReadTable();
                            AddDataInTable();
                            break;
                        }
                    case "текстовийДокумент":
                        {
                            data = TXTDocument.ImportTXTFile();
                            GetId();
                            AddDataInTable();
                            break;
                        }
                    case "базаДаних":
                        {
                            if (bunifuTextBoxSpecialty.Text.Equals("") && bunifuTextBoxCourse.Text.Equals(""))
                            {
                                bunifuTextBoxCourse.BorderColorIdle = Color.Red;
                                bunifuTextBoxSpecialty.BorderColorIdle = Color.Red;
                                MessageBox.Show("Не всі необхідні дані є введеними", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MySqlDataReader sqlDataReaderEducation = DataBase.Select(accountEmail, VariantSelect.Education);
                                sqlDataReaderEducation.Read();
                                string education = sqlDataReaderEducation["Education"].ToString();
                                MySqlDataReader sqlDataReader = DataBase.SelectStudentsBase(bunifuTextBoxSpecialty.Text, bunifuTextBoxCourse.Text, education);
                                otherGroupData.StudentsEstimates = new List<StudentsEstimates>();
                                while (sqlDataReader.Read())
                                {
                                    StudentsEstimates studentsEstimates = new StudentsEstimates
                                    {
                                        StudentId = sqlDataReader["IdPerson"].ToString(),
                                        Estimates = new List<string>()
                                    };
                                    otherGroupData.StudentsEstimates.Add(studentsEstimates);
                                }
                                AddDataInTable();
                            }
                            break;
                        }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Виникла помилка під час підключення до бази даних. \nОсь текст помилки: {ex.Message} \nПрограма завершила свою роботу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка. \nОсь текст помилки: {ex.Message} \nПрограма завершила свою роботу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для додання даних в таблицю для перегляду, хто буде доданий в журнал
        /// </summary>
        private void AddDataInTable()
        {
            string firstName, name, surname;
            for (int index = 0; index < otherGroupData.StudentsEstimates.Count; ++index)
            {
                try
                {
                    MySqlDataReader sqlDataReader = DataBase.SelectPersonStudent(otherGroupData.StudentsEstimates[index].StudentId);
                    sqlDataReader.Read();
                    firstName = sqlDataReader["FirstName"].ToString();
                    name = sqlDataReader["Name"].ToString();
                    surname = sqlDataReader["Surname"].ToString();
                    bunifuDataGridView.Rows.Add(bunifuDataGridView.Rows.Count + 1, $"{firstName} {name} {surname}");
                }
                catch (MySqlException)
                {
                    otherGroupData.StudentsEstimates.RemoveAt(index);
                    data.Rows.RemoveAt(index);
                }
            }
            bunifuVScrollBar.Visible = bunifuDataGridView.Rows.Count * bunifuDataGridView.RowHeadersWidth >= bunifuDataGridView.Height - bunifuDataGridView.ColumnHeadersHeight;
        }
        /// <summary>
        /// Метод для відміни створення журналу. Очищує всі поля
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Close_Click(object sender, EventArgs e)
        {
            bunifuTextBoxNameSubject.Text = "";
            bunifuTextBoxSpecialty.Text = "";
            bunifuTextBoxCourse.Text = "";
            iconPictureBox.BackColor = groupBoxCustom.BackColor;
            iconPictureBox.IconColor = Color.White;
            iconPictureBox.IconChar = IconChar.None;
            iconPictureBox.IconChar = icon[bunifuDropdownIconChar.SelectedIndex];
            bunifuDropdownIconChar.SelectedIndex = 0;
            colorIconAndText.BackColor = Color.White;
            colorIconBackground.BackColor = groupBoxCustom.BackColor;
            colorBackgroundForm.BackColor = groupBoxCustom.BackColor;
            bunifuDataGridView.Rows.Clear();
            bunifuVScrollBar.LargeChange = 100;
            bunifuVScrollBar.Visible = false;
        }
        /// <summary>
        /// Метод для створення нового журналу
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                WriteData();
                DataBase.InsertGroup(dataGroup, otherGroupData);
                Close_Click(sender, e);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Виникла помилка під час підключення до бази даних. \nОсь текст помилки: {ex.Message} \nПрограма завершила свою роботу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка. \nОсь текст помилки: {ex.Message} \nПрограма завершила свою роботу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Метод для визначення розміру вертикального повзунка при додаванні нових даних
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
        /// Метод для визначення розміру вертикального повзунка при видалені даних з таблиці
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