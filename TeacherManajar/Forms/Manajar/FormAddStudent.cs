using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TeacherManajar.ClassCode.DataBaseClass;

namespace TeacherManajar.Forms.Manajar
{
    /// <summary>
    /// Клас додає студента, якщо його не було знайдено при створенні журналу або він був переведений в групу після створення журналу
    /// </summary>
    public partial class FormAddStudent : Form
    {
        private string identification;
        public string Identification => identification;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAddStudent()
        {
            InitializeComponent();
            bunifuButtonAdd.Click += (s, e) => { DialogResult = DialogResult.OK; Hide(); };
        }
        /// <summary>
        /// Метод для повернення назад на форму із журналом
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете вийти з меню створення нового заняття?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Hide();
            }
        }
        /// <summary>
        /// Метод для пошуку студента
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Search_OnIconRightClick(object sender, EventArgs e)
        {
            if (bunifuTextBoxSearch.Text.Length > 0)
            {
                try
                {
                    switch (bunifuDropdownVariantSearch.Text)
                    {
                        case "За ідентифікатором":
                            {
                                MySqlDataReader mySqlDataReader = DataBase.SelectPersonStudent(bunifuTextBoxSearch.Text);
                                mySqlDataReader.Read();
                                labelResult.Text = $"{mySqlDataReader["FirstName"]} {mySqlDataReader["Name"]} {mySqlDataReader["Surname"]}";
                                identification = bunifuTextBoxSearch.Text;
                                break;
                            }
                        case "За повним ПІБ":
                            {
                                string[] initials = bunifuTextBoxSearch.Text.Split(' ');
                                MySqlDataReader mySqlDataReader = DataBase.SelectPersonInitials(initials[0], initials[1], initials[2]);
                                mySqlDataReader.Read();
                                identification = mySqlDataReader["IdPerson"].ToString();
                                labelResult.Text = "Студента знайдено";
                                break;
                            }
                    }
                    bunifuButtonAdd.Enabled = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Користувача не знайдено. Будь ласка перевірте коректність введених вами даних і повторить спробу.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Дане поле не заповнене. Будь ласка спершу заповніть його.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для виведення інформації, як здійснювати пошук
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Help_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }
        /// <summary>
        /// Метод для вибору варіанту пошуку та очищення полів
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void DropdownVariantSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuTextBoxSearch.Text = "";
            labelResult.Text = "";
            bunifuButtonAdd.Enabled = false;
        }
    }
}