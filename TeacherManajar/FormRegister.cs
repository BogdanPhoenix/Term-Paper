using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.Enum;
using TeacherManajar.Forms.Register;
using TeacherManajar.InterfaceCode;

namespace TeacherManajar
{
    /// <summary>
    /// Продовження реєстрації, де потрібно вказати персональні дані користувача
    /// </summary>
    public partial class FormRegister : Form
    {
        private readonly OpenFileDialog openFileDialogAvatar = new OpenFileDialog();
        private readonly string educationType;
        private readonly string role;

        private readonly Person person = new Person();
        private readonly AccountEmail account = new AccountEmail();
        private readonly IGroup group = null;

        private Form currentChildForm;
        private readonly StudentRegister studentRegister = null;
        private readonly TeacherRegister teacherRegister = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="role">Роль користувача</param>
        /// <param name="education">Тип навчального закладу</param>
        public FormRegister(string role, string education)
        {
            InitializeComponent();

            this.role = role;
            educationType = education;
            switch (role)
            {
                case "Schoolboy":
                case "Student":
                    group = new StudentGroup();
                    studentRegister = new StudentRegister();
                    OpenChildForm(studentRegister);
                    break;
                case "Teacher":
                case "Proffesor":
                    group = new TeacherGroup();
                    teacherRegister = new TeacherRegister();
                    OpenChildForm(teacherRegister);
                    break;
            }

            bunifuPictureBoxAvatarFoto.Image = Properties.Resources.Man;

            foreach (GroupBox group in Controls.OfType<GroupBox>())
            {
                foreach (BunifuTextBox text in group.Controls.OfType<BunifuTextBox>())
                {
                    text.KeyPress += KeyPressEnter;
                }
            }

            bunifuTextBoxPassword.KeyPress += KeyPressWhiteSpace;
            bunifuTextBoxRepeatPassword.KeyPress += KeyPressWhiteSpace;

            bunifuRadioButtonMan.Click += RadioCheckedChanged;
            bunifuRadioButtonWoman.Click += RadioCheckedChanged;


            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            bunifuButtonClose.Click += (s, e) => { Application.Exit(); };
            timerButtonRegister.Start();

            bunifuTextBoxPassword.Enter += SystemProcess.PasswordEnter;
            bunifuTextBoxPassword.Leave += SystemProcess.PasswordLeave;

            bunifuTextBoxRepeatPassword.Enter += SystemProcess.PasswordEnter;
            bunifuTextBoxRepeatPassword.Leave += SystemProcess.PasswordLeave;

            bunifuTextBoxPassword.OnIconRightClick += (s, e) => { SystemProcess.TextBoxOnIconRightClick(bunifuTextBoxPassword); };
            bunifuTextBoxRepeatPassword.OnIconRightClick += (s, e) => { SystemProcess.TextBoxOnIconRightClick(bunifuTextBoxRepeatPassword); };
        }

        #region -> Private Method
        /// <summary>
        /// Метод для відкриття відповідної анкети для заповнення, яка залежить від вибраної ролі
        /// </summary>
        /// <param name="childForm">Анкета, яку необхідно відкрити</param>
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /// <summary>
        /// Метод для збору даних в один об'єкт перед створенням особистого кабінету
        /// </summary>
        private void WriteDate()
        {
            if (person.AvatarFoto == null || person.AvatarFoto.Length == 0)
            {
                MessageBox.Show("Ви не обрали фото для автарки, тому буде використано фото за замовчуванням.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                person.AvatarFoto = "";
            }

            account.IdPerson = Guid.NewGuid().ToString();
            person.Gender = bunifuRadioButtonMan.Checked ? "Чоловік" : "Жінка";
            person.FirstName = SystemProcess.ConvertTextToMySQL(bunifuTextBoxFirstName.Text);
            person.Name = SystemProcess.ConvertTextToMySQL(bunifuTextBoxName.Text);
            person.Surname = SystemProcess.ConvertTextToMySQL(bunifuTextBoxSurname.Text);
            account.Email = bunifuTextBoxEmail.Text;
            person.DateBirthday = bunifuDatePicker.Value;
            person.AvatarFoto = Path.GetFileName(person.AvatarFoto);

            switch (role.ToLower())
            {
                case "schoolboy": account.Role = "Учень"; RegisterStudent(); break;
                case "student": account.Role = "Студент"; RegisterStudent(); break;
                case "teacher": account.Role = "Вчитель"; RegisterTeacher(); break;
                case "proffesor": account.Role = "Викладач"; RegisterTeacher(); break;
            }
        }
        /// <summary>
        /// Метод для отримання даних з анкети, яка призначена для студентів
        /// </summary>
        private void RegisterStudent()
        {
            ((StudentGroup)group).Course = Convert.ToUInt32(studentRegister.Course);
            ((StudentGroup)group).Specialty = SystemProcess.ConvertTextToMySQL(studentRegister.NameGroup);
            ((StudentGroup)group).FormStudy = SystemProcess.ConvertTextToMySQL(studentRegister.FormStudy);
            ((StudentGroup)group).EducationalDegree = SystemProcess.ConvertTextToMySQL(studentRegister.EducationalDegree);
            group.EducationType = educationType;
            group.Education = studentRegister.Education;
        }
        /// <summary>
        /// Метод для отримання даних з анкети, яка призначена для викладачів
        /// </summary>
        private void RegisterTeacher()
        {
            ((TeacherGroup)group).DiplomaNumber = teacherRegister.DiplomaNumber;
            ((TeacherGroup)group).DiplomaSeries = teacherRegister.DiplomaSeries;
            ((TeacherGroup)group).ScientificTitle = SystemProcess.ConvertTextToMySQL(teacherRegister.ScientificTitle);
            group.EducationType = educationType;
            group.Education = teacherRegister.Education;
        }
        /// <summary>
        /// Метод для перевірки чи користувач вірно ввів свій пароль повторно
        /// </summary>
        private void CheckPassword()
        {
            if (bunifuTextBoxPassword.Text.Equals(bunifuTextBoxRepeatPassword.Text) && !string.IsNullOrEmpty(bunifuTextBoxPassword.Text))
            {
                bunifuTextBoxPassword.BorderColorHover = bunifuTextBoxPassword.BorderColorDisabled = bunifuTextBoxPassword.BorderColorActive = bunifuTextBoxPassword.BorderColorIdle = Color.Green;
                bunifuTextBoxRepeatPassword.BorderColorHover = bunifuTextBoxRepeatPassword.BorderColorDisabled = bunifuTextBoxRepeatPassword.BorderColorActive = bunifuTextBoxRepeatPassword.BorderColorIdle = Color.Green;
            }
            else
            {
                bunifuTextBoxPassword.BorderColorHover = bunifuTextBoxPassword.BorderColorDisabled = bunifuTextBoxPassword.BorderColorActive = bunifuTextBoxPassword.BorderColorIdle = Color.Red;
                bunifuTextBoxRepeatPassword.BorderColorHover = bunifuTextBoxRepeatPassword.BorderColorDisabled = bunifuTextBoxRepeatPassword.BorderColorActive = bunifuTextBoxRepeatPassword.BorderColorIdle = Color.Red;
            }
        }
        /// <summary>
        /// Метод для перевірки чи користувач заповнив всі поля, щоб можна було активувати кнопку реєстрації
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void TimerRegister_Tick(object sender, EventArgs e)
        {
            bool resultCheck = CheckGroupBox(groupBoxPersonalData) && CheckGroupBox(groupBoxAccountData);
            CheckPassword();
            switch (role)
            {
                case "Schoolboy":
                case "Student":
                    {
                        bunifuButtonRegistration.Enabled = resultCheck && !string.IsNullOrEmpty(studentRegister.Education) && !string.IsNullOrEmpty(studentRegister.NameGroup) && !string.IsNullOrEmpty(studentRegister.Course)
                             && !string.IsNullOrEmpty(studentRegister.FormStudy) && !string.IsNullOrEmpty(studentRegister.EducationalDegree) && bunifuTextBoxPassword.BorderColorIdle == Color.Green;
                        break;
                    }
                case "Teacher":
                case "Proffesor":
                    {
                        bunifuButtonRegistration.Enabled = resultCheck && !string.IsNullOrEmpty(teacherRegister.Education) && !string.IsNullOrEmpty(teacherRegister.DiplomaNumber)
                            && !string.IsNullOrEmpty(teacherRegister.DiplomaSeries) && !string.IsNullOrEmpty(teacherRegister.ScientificTitle) && bunifuTextBoxPassword.BorderColorIdle == Color.Green;
                        break;
                    }
            }
        }
        /// <summary>
        /// Метод для перевірка чи всі текстові поля заповнені в указаній групі об'єктів
        /// </summary>
        /// <param name="groupBox">Об'єкт групи об'єктів</param>
        /// <returns>Повертає true - якщо всі текстові поля заповнені, інакше false.</returns>
        private bool CheckGroupBox(GroupBox groupBox)
        {
            foreach (BunifuTextBox text in groupBox.Controls.OfType<BunifuTextBox>())
            {
                if (text.Text.Equals(""))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод для встановлення зображення на аватарку особистого кабінету в залежності від вибраної статті, якщо користувач не обрав власне зображення
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            if (person.AvatarFoto == null || person.AvatarFoto.Equals(""))
            {
                DeleteFoto_Click(new object(), new EventArgs());
            }
        }
        /// <summary>
        /// Метод для перевірки, щоб коли користувач натискає клавішу Enter не неприємностей з текстовим полем
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані натиску на клавіші, не зберігаючи в собі даних</param>
        private void KeyPressEnter(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Keys)e.KeyChar == Keys.Enter;
        }
        /// <summary>
        /// Метод для перевірки чи даний символ відноситься до пробілів Юнікод
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані натиску на клавіші, не зберігаючи в собі даних</param>
        private void KeyPressWhiteSpace(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
        /// <summary>
        /// Метод для вибору користувачем зображення для аватарки особистого кабінету
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void AddAvatarFoto_Click(object sender, EventArgs e)
        {
            openFileDialogAvatar.Filter = "Type file(*.jpg)| *.jpg|Type file(*.png)|*.png|Type file(*.bmp)|*.bmp|Type file(*.psd)|*.psd|Type file(*.tga)|*.tga";
            person.AvatarFoto = openFileDialogAvatar.ShowDialog() == DialogResult.OK ? openFileDialogAvatar.FileName : "";
            if (person.AvatarFoto == null || person.AvatarFoto.Equals(""))
            {
                DeleteFoto_Click(new object(), new EventArgs());
            }
            else
            {
                bunifuPictureBoxAvatarFoto.Image = Image.FromFile(person.AvatarFoto);
                bunifuImageButtonDeleteFoto.Visible = true;
            }
        }
        /// <summary>
        /// Метод для реєстрації особистого кабінету і вхід в нього
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Registration_Click(object sender, EventArgs e)
        {
            try
            {
                account.Email = bunifuTextBoxEmail.Text;
                if (!DataBase.Select(account, VariantSelect.AccountBase).HasRows)
                {
                    WriteDate();

                    DataBase.InsertAccount(account, person, group, SystemProcess.StringCheckPassword(bunifuTextBoxPassword.Text));
                    timerButtonRegister.Stop();
                    UserProfile userProfile = new UserProfile(account);
                    userProfile.Show();
                    DialogResult = DialogResult.Yes;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Користувач з таким email вже існує. Використовуйте інший email", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Під час взаємодії з базою даних виникла помилка:\nКод: {ex.Code}\nПовідомлення{ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Повідомлення{ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для видалення зображення аватарки, якщо воно не сподобалося користувачу
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void DeleteFoto_Click(object sender, EventArgs e)
        {
            bunifuPictureBoxAvatarFoto.Image = bunifuRadioButtonMan.Checked ? Properties.Resources.Man : Properties.Resources.Woman;
            bunifuImageButtonDeleteFoto.Visible = false;
        }
        /// <summary>
        /// Метод для повернення на попередню форму для вибору ролі та типу закладу
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Hide();
        }
        #endregion
    }
}