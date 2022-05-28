using System;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace TeacherManajar
{
    /// <summary>
    /// Графічний вибір закладу навчання (університет, школа) і відповідної ролі для кожного із закладів.
    /// </summary>
    public partial class FormRole : Form
    {
        private string EducationType = "University";
        private string Role = "Proffesor";
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormRole()
        {
            InitializeComponent();
            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            bunifuButtonClose.Click += (s, e) => { Application.Exit(); };
            Assignment_Values();
        }
        /// <summary>
        /// Метод  для зміни зображення та підпису ролей в залежності від того який тип навчального закладу вибраний
        /// </summary>
        private void Assignment_Values()
        {
            switch (EducationType)
            {
                case "University":
                    bunifuPictureBoxTeacher.Image = Properties.Resources.Proffesor;
                    bunifuPictureBoxStudent.Image = Properties.Resources.Student;
                    label_RoleTeacher.Text = "Викладач";
                    label_RoleStudent.Text = "Студент";
                    break;
                case "School":
                    bunifuPictureBoxTeacher.Image = Properties.Resources.Teacher;
                    bunifuPictureBoxStudent.Image = Properties.Resources.Schoolboy;
                    label_RoleTeacher.Text = "Вчитель";
                    label_RoleStudent.Text = "Учень";
                    break;
            }
        }
        /// <summary>
        /// Метод для вибору типу навчального закладу
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класy BunifuToggleSwitch, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void SwitchEducational_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            EducationType = bunifuToggleSwitchEducational.Checked ? "School" : "University";
            Assignment_Values();
        }
        /// <summary>
        /// Метод для вибору ролі в залежності від вибраного типу навчального закладу
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класy BunifuToggleSwitch, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void SwitchRole_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitchRole.Checked)
            {
                Role = bunifuToggleSwitchEducational.Checked ? "Schoolboy" : "Student";
            }
            else
            {
                Role = bunifuToggleSwitchEducational.Checked ? "Teacher" : "Proffesor";
            }
        }
        /// <summary>
        /// Метод для повернення на попередню форму, для входу в особистий кабінет
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Entry_Click(object sender, EventArgs e)
        {
            FormEntry formEntry = new FormEntry();
            Hide();
            formEntry.Show();
        }
        /// <summary>
        /// Метод для продовження реєстрації особистого кабінету
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Next_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister(Role, EducationType);
            Hide();
            register.ShowDialog();
            if (register.DialogResult == DialogResult.No)
            {
                Show();
            }
        }
    }
}
