using Bunifu.UI.WinForms.BunifuButton;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.Enum;
using TeacherManajar.Forms;
using TeacherManajar.InterfaceCode;

namespace TeacherManajar
{
    /// <summary>
    /// Клас для відображення користувачу меню та вікон кожного з пунктів
    /// </summary>
    public partial class UserProfile : Form
    {
        private BunifuButton2 currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
        private readonly Person person = new Person();
        private readonly AccountEmail accountEmail = null;
        private readonly IGroup group = null;

        /// <summary>
        /// Конструктор класу
        /// </summary>
        /// <param name="accountEmail">Об’єкт класу в якому зберігаються дані користувача, які необхідні при вході в особистий кабінет або для пошуку в базі даних</param>
        public UserProfile(AccountEmail accountEmail)
        {
            InitializeComponent();

            this.accountEmail = accountEmail;
            MySqlDataReader sqlDataReader = DataBase.Select(accountEmail, VariantSelect.Person);
            switch (accountEmail.Role.ToLower())
            {
                case "учень":
                case "студент":
                    group = new StudentGroup();
                    bunifuButtonDependsOnTheRobotChosen.IdleIconLeftImage = Properties.Resources.area_chart_48px;
                    bunifuButtonDependsOnTheRobotChosen.Tag = bunifuButtonDependsOnTheRobotChosen.Text = "Статистика";
                    bunifuToolTip.SetToolTip(bunifuButtonDependsOnTheRobotChosen, "Статистика ваших персональних успіхів");
                    break;
                case "викладач":
                case "вчитель":
                    group = new TeacherGroup();
                    bunifuButtonDependsOnTheRobotChosen.IdleIconLeftImage = Properties.Resources.create_group;
                    bunifuButtonDependsOnTheRobotChosen.Tag = bunifuButtonDependsOnTheRobotChosen.Text = "Створити журнал";
                    bunifuToolTip.SetToolTip(bunifuButtonDependsOnTheRobotChosen, "Створення нової групи");
                    break;
            }

            while (sqlDataReader.Read())
            {
                person.ConvertFromMySql(sqlDataReader);
                group.ConvertGroupFromMySql(sqlDataReader);
            }

            leftBorderBtn = new Panel { Size = new Size(7, 70) };
            bunifuGradientPanelMenu.Controls.Add(leftBorderBtn);
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            CollapseMenu();
            ActivateHome();

            bunifuButtonMenu.Click += (s, e) => { CollapseMenu(); };
            bunifuButtonProfile.Click += (s, e) => { ActivateHome(); };
            bunifuButtonClose.Click += (s, e) => { Application.Exit(); };
            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            bunifuButtonMaximize.Click += (s, e) => { WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal; };
        }
        /// <summary>
        /// Метод для відображення активованої кнопки та виведення форми даного пункту меню
        /// </summary>
        /// <param name="sender">Об'єкт активованої кнопки</param>
        private void ActivateButton(object sender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            if (sender != null && (BunifuButton2)sender != currentBtn)
            {
                DisableButton();
                
                currentBtn = (BunifuButton2)sender;
                
                leftBorderBtn.BackColor = Color.FromArgb(240, 170, 104);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                
                iconCurrentChildForm.Image = currentBtn.IdleIconLeftImage;
                currentBtn.TextPadding = new Padding(40, 0, 0, 0);
                currentBtn.IconLeftPadding = new Padding(30, 0, 0, 0);
            }
        }
        /// <summary>
        /// Метод для надання активованій кнопці звичайного вигляду, який в неї був до активації
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.TextPadding = new Padding(10, 0, 0, 0);
                currentBtn.IconLeftPadding = new Padding(10, 0, 0, 0);
            }
        }
        /// <summary>
        /// Метод для відкриває необхідної форми в залежності від того, який пункт меню є активованим
        /// </summary>
        /// <param name="childForm">Об'єкт форми, яка належить до даного пункту меню</param>
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
            bunifuGradientPanelDesktop.Controls.Add(childForm);
            bunifuGradientPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelCurrentChildForm.Text = childForm.Text;
        }
        /// <summary>
        /// Метод для згортання/розгортання бокового меню
        /// </summary>
        private void CollapseMenu()
        {
            bool width = bunifuGradientPanelMenu.Width > 200;
            bunifuGradientPanelMenu.Width = width ? 100 : 230;
            foreach (BunifuButton2 menuButton in bunifuGradientPanelMenu.Controls.OfType<BunifuButton2>())
            {
                menuButton.Text = width ? "" : menuButton.Tag.ToString();
            }
            bunifuButtonMenu.Text = width ? "" : bunifuButtonMenu.Tag.ToString();
            bunifuButtonMenu.IconLeftPadding = new Padding((width ? 30 : 10), 3, 3, 3);
        }
        /// <summary>
        /// Метод для активації пункту меню "Профіль"
        /// </summary>
        private void ActivateHome()
        {
            ActivateButton(bunifuButtonProfile);
            OpenChildForm(new FormUser(accountEmail, person, group));
        }
        /// <summary>
        /// Метод для активації кнопки, яка залежить від ролі користувача. Для студента/учня - це "Статистка", для викладача/вчителя - "Створити групу"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void DependsOnTheRobotChosen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            switch (accountEmail.Role.ToLower())
            {
                case "учень":
                case "студент":
                    OpenChildForm(new FormStatic());
                    break;
                case "викладач":
                case "вчитель":
                    OpenChildForm(new FormCreateGroup(accountEmail));
                    break;
            }
        }
        /// <summary>
        /// Метод для активації пункту меню "Групи"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Groups_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormGroup(accountEmail));
        }
        /// <summary>
        /// Метод для активації пункту меню "Щоденник"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Diary_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormDiary());
        }
        /// <summary>
        /// Метод для активації пункту меню "Нотатки"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Notes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormNotes(accountEmail));
        }
        /// <summary>
        /// Метод для активації пункту меню "Налаштування"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Setting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormSetting());
        }
        /// <summary>
        /// Метод для активації пункту меню "Вихід"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void ExitAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormLogOut());
            DialogResult result = MessageBox.Show("Ви дійсно хочете вийти з акаунту?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                FormEntry formEntry = new FormEntry();
                formEntry.Show();
                Close();
            }
        }
    }
}