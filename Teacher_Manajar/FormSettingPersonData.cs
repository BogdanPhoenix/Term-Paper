using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Custom;

namespace Teacher_Manajar
{
    public partial class FormSettingPersonData : Form
    {
        private IPrivateInfo privateInfo = null;
        private readonly IPrivateInfo new_privateInfo = null;
        private IPerson person = null;
        private readonly IPerson new_person = null;
        private readonly string role = default;
        private readonly List<ButtonCustom> buttonsCustom = new List<ButtonCustom>();
        private readonly Setting setting = new Setting();
        private readonly string user_directory = default;
        //Повернення персональних налаштувань
        public IPerson Person { get => new_person; }

        public FormSettingPersonData(IPerson _person, Setting _setting)
        {
            InitializeComponent();
            privateInfo = (IPrivateInfo)_person;
            new_privateInfo = (IPrivateInfo)privateInfo.Clone();
            person = _person;
            new_person = (IPerson)person.Clone();
            role = privateInfo.Role == "Teacher" ? System_Process.TeacherDirectory : System_Process.StudentDirextory;
            user_directory = Path.Combine(System_Process.ExePath, System_Process.RootDirectory, role);
            setting = _setting;
            Initialize();
        }
        //Ініціалізація зовнішнього вигляду форми
        private void Initialize()
        {
            buttonsCustom.Add(buttonCustom_SaveLogin);
            buttonsCustom.Add(buttonCustom_SavePassword);

            System_Process.OnPaintButton(buttonsCustom, setting);

            panel_SystemBackgroundColor.BackColor = setting.Background_Form_Color;
            panel_SystemFrontColor.BackColor = setting.Front_Form_Color;
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Вийти з форми
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            if (!person.Equals(new_person))
            {
                DialogResult result = MessageBox.Show("Увага, ви не зберегли зміни. Ви хочете зберегти зміни та вийти з налаштувань?", "Увага", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes: SaveLogin(); SavePassword(); Close(); break;
                    case DialogResult.No: Close(); break;
                    case DialogResult.Cancel: break;
                }
            }
            else
            {
                Close();
            }
        }
        //Пересування форми
        private void panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Поле для введення нового логіна
        private void MyTextBox_Login__TextChanger(object sender, EventArgs e)
        {
            buttonCustom_SaveLogin.Enabled = !System_Process.CheckField(myTextBox_Login.Texts);
            new_person.Email = myTextBox_Login.Texts.Length != 0 ? myTextBox_Login.Texts : person.Email;
        }
        //Поле для введення старого пароля
        private void MyTextBox_OldPassword__TextChanger(object sender, EventArgs e)
        {
            label_warningOldPassword.Visible = myTextBox_OldPassword.Texts != privateInfo.Password;
            myTextBox_NewPassword.Enabled = !System_Process.CheckField(myTextBox_OldPassword.Texts) && !label_warningOldPassword.Visible;
        }
        //Поле для введення нового пароля
        private void MyTextBox_NewPassword__TextChanger(object sender, EventArgs e)
        {
            myTextBox_RepeatNewPassword.Enabled = !System_Process.CheckField(myTextBox_NewPassword.Texts);
            new_privateInfo.Password = myTextBox_NewPassword.Texts.Length != 0 ? myTextBox_NewPassword.Texts : privateInfo.Password;
            CheckPassword();
        }
        //Поле для введення повторно нового пароля
        private void MyTextBox_RepeatNewPassword__TextChanger(object sender, EventArgs e)
        {
            CheckPassword();
        }
        //Перевірка чи паролі співпадають
        private void CheckPassword()
        {
            if (myTextBox_RepeatNewPassword.Texts != string.Empty)
            {
                label_warningRepeatNewPassword.ForeColor = myTextBox_NewPassword.Texts == myTextBox_RepeatNewPassword.Texts ? Color.Green : Color.Red;
                label_warningRepeatNewPassword.Text = myTextBox_NewPassword.Texts == myTextBox_RepeatNewPassword.Texts ? "Паролі співпадають" : "Паролі не співпадають";
                buttonCustom_SavePassword.Enabled = myTextBox_NewPassword.Texts == myTextBox_RepeatNewPassword.Texts;
            }
        }
        //Зберегти новий логін
        private void SaveLogin()
        {
            var data_person = JsonConvert.SerializeObject(new_person, Formatting.Indented);
            if (person.Email != new_person.Email)
            {
                Directory.Move(Path.Combine(user_directory, "User " + person.Email), Path.Combine(user_directory, "User " + new_person.Email));
                File.Move(Path.Combine(user_directory, "User " + new_person.Email, person.Email + ".json"), Path.Combine(user_directory, "User " + new_person.Email, new_person.Email + ".json"));
            }
            File.WriteAllText(Path.Combine(user_directory, "User " + new_person.Email, new_person.Email + ".json"), data_person);
            person = (IPerson)new_person.Clone();
        }
        //Зберегти новий пароль
        private void SavePassword()
        {
            var data_person = JsonConvert.SerializeObject(new_privateInfo, Formatting.Indented);
            File.WriteAllText(Path.Combine(user_directory, "User " + new_person.Email, new_person.Email + ".json"), data_person);
            privateInfo = (IPrivateInfo)privateInfo.Clone();
        }
        //Кнопка для збереження нового логіна
        private void ButtonCustom_SaveLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SaveLogin();
                MessageBox.Show("Дані збережено", "Увага");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час збереження даних", "Увага");
            }
        }
        //Збереження нового пароля
        private void ButtonCustom_SavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                SavePassword();
                MessageBox.Show("Дані збережено", "Увага");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час збереження даних", "Увага");
            }
        }
    }
}
