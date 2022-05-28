using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.Enum;

namespace TeacherManajar
{
    /// <summary>
    /// Відображення форми входу в особистий кабінет
    /// </summary>
    public partial class FormEntry : Form
    {
        /// <summary>
        /// Список адрес поштових скриньок з якими співпрацює програма
        /// </summary>
        private static readonly List<string> emailList = new List<string>()
        {
            "gmail.com",
            "ukr.net"
        };
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormEntry()
        {
            InitializeComponent();
            //bunifuLoader.Location = new Point(Width / 2 - bunifuLoader.Width / 2, Height / 2 - bunifuLoader.Height / 2);

            bunifuTextBoxPassword.Enter += SystemProcess.PasswordEnter;
            bunifuTextBoxPassword.Leave += SystemProcess.PasswordLeave;
            bunifuTextBoxPassword.OnIconRightClick += (s, e) => { SystemProcess.TextBoxOnIconRightClick(bunifuTextBoxPassword); };

            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            bunifuButtonClose.Click += (s, e) => { Application.Exit(); };
        }
        /// <summary>
        /// Метод для перевірки чи користувач ввів адрес електронної пошти тієї служби, яка підтримується програмою
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Email_TextChanged(object sender, EventArgs e)
        {
            bool result = false;
            foreach (string variant in emailList)
            {
                if (bunifuTextBoxEmail.Text.EndsWith(variant))
                {
                    result = true;
                    break;
                }
            }
            if (result)
            {
                bunifuLabelError.Visible = false;
                bunifuTextBoxEmail.BorderColorActive = Color.DodgerBlue;
                bunifuTextBoxEmail.BorderColorDisabled = Color.FromArgb(255, 153, 0);
                bunifuTextBoxEmail.BorderColorHover = Color.FromArgb(105, 181, 255);
                bunifuTextBoxEmail.BorderColorIdle = Color.Silver;
                bunifuTextBoxEmail.PlaceholderForeColor = Color.Silver;
            }
            else
            {
                bunifuLabelError.Visible = true;
                bunifuTextBoxEmail.BorderColorActive = bunifuLabelError.ForeColor;
                bunifuTextBoxEmail.BorderColorDisabled = bunifuLabelError.ForeColor;
                bunifuTextBoxEmail.BorderColorHover = bunifuLabelError.ForeColor;
                bunifuTextBoxEmail.BorderColorIdle = bunifuLabelError.ForeColor;
                bunifuTextBoxEmail.PlaceholderForeColor = bunifuLabelError.ForeColor;
            }
        }
        /// <summary>
        /// Метод для входу в особистий кабінет
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Entry_Click(object sender, EventArgs e)
        {
            try
            {
                AccountEmail accountEmail = new AccountEmail() { Email = bunifuTextBoxEmail.Text };
                MySqlDataReader sqlDataReader = DataBase.Select(accountEmail, VariantSelect.AccountBase);
                if (sqlDataReader == null)
                {
                    MessageBox.Show($"Не вдалося підключитися до бази даних.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!sqlDataReader.HasRows)
                {
                    MessageBox.Show("Користувач з таким email не знайдено.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;                    
                }
                sqlDataReader.Read();
                accountEmail.ConvertFromMySql(sqlDataReader);
                string resultConvertPassword = SystemProcess.StringCheckPassword(bunifuTextBoxPassword.Text);
                if (!resultConvertPassword.Equals(SystemProcess.GetPasswordTranslate((byte[])sqlDataReader["Password"])))
                {
                    MessageBox.Show("Паролі не співпадають", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UserProfile userProfile = new UserProfile(accountEmail);
                userProfile.Show();
                Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Під час взаємодії з базою даних виникла помилка:\nКод: {ex.Code}\nПовідомлення{ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Повідомлення: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод реєстрації, якщо користувач не має особистого кабінету
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Register_Click(object sender, EventArgs e)
        {
            FormRole role = new FormRole();
            role.Show();
            Hide();
        }
    }
}