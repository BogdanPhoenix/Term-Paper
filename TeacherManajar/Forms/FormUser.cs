using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.InterfaceCode;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Клас для відображення особистих даних користувача та його віджетів
    /// </summary>
    public partial class FormUser : Form
    {
        private Form widgets;
        private readonly IGroup group = null;
        private readonly AccountEmail accountEmail = null;
        /// <summary>
        /// Конструктор класу
        /// </summary>
        /// <param name="accountEmail">Дані користувача для пошуку його в базі даних</param>
        /// <param name="person">Особисті дані користувача</param>
        /// <param name="group">Основні дані про навчальний заклад</param>
        public FormUser(AccountEmail accountEmail, Person person, IGroup group)
        {
            InitializeComponent();
            this.accountEmail = accountEmail;
            this.group = group;

            labelFirstName.Text = person.FirstName;
            labelName.Text = person.Name;
            labelSurname.Text = person.Surname;
            labelSex.Text = person.Gender;
            labelBirthday.Text = person.DateBirthday.ToString("d");
            labelEducation.Text = group.Education;
            switch (accountEmail.Role.ToLower())
            {
                case "учень":
                case "студент": EducationInformationStudent(); break;
                case "викладач":
                case "вчитель": EducationInformationTeacher(); break;
            }

            switch (group.EducationType)
            {
                case "University": labelEducationType.Text = "Університет"; break;
                case "School": labelEducationType.Text = "Школа"; break;
            }

            if (person.AvatarFoto.Equals(""))
                bunifuPictureBoxAvatarFoto.Image = person.Gender.Equals("Чоловік") ? Properties.Resources.Man : Properties.Resources.Woman;
            else
                bunifuPictureBoxAvatarFoto.Image = Image.FromFile(Path.Combine(SystemProcess.AvatarFoto, person.AvatarFoto));

            OpenWidgetsForm();
        }
        /// <summary>
        /// Метод для відображення віджетів користувача
        /// </summary>
        private void OpenWidgetsForm()
        {
            if (widgets != null)
            {
                widgets.Close();
            }
            else
            {
                widgets = new FormWidgets(accountEmail)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panelWidgets.Controls.Add(widgets);
                panelWidgets.Tag = widgets;
                widgets.BringToFront();
                widgets.Show();
            }
        }
        /// <summary>
        /// Метод для створення полів для відображення інформації про студента
        /// </summary>
        private void EducationInformationStudent()
        {
            Label labelRole = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 50),
                Name = "labelRole",
                Size = new Size(240, 40),
                Text = accountEmail.Role,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelCourse = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 90),
                Name = "labelCourse",
                Size = new Size(240, 40),
                Text = $"Курс {((StudentGroup)group).Course}",
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelGroupName = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Location = new Point(0, 210),
                Name = "labelGroupName",
                Size = new Size(240, 130),
                Text = ((StudentGroup)group).Specialty,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelEducationDegree = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 170),
                Name = "labelEducationDegree",
                Size = new Size(240, 40),
                Text = ((StudentGroup)group).EducationalDegree,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelFormStudy = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 130),
                Name = "labelFormStudy",
                Size = new Size(240, 40),
                Text = "Денна",
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelStudy.Controls.Add(labelGroupName);
            panelStudy.Controls.Add(labelEducationDegree);
            panelStudy.Controls.Add(labelFormStudy);
            panelStudy.Controls.Add(labelCourse);
            panelStudy.Controls.Add(labelRole);
        }
        /// <summary>
        /// Метод для створення полів для відображення інформації про викладача
        /// </summary>
        private void EducationInformationTeacher()
        {
            Label labelRole = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 50),
                Name = "labelRole",
                Size = new Size(240, 40),
                Text = accountEmail.Role,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelScientificTitle = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 170),
                Name = "labelScientificTitle",
                Size = new Size(240, 40),
                Text = ((TeacherGroup)group).ScientificTitle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelDiplomSeries = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 130),
                Name = "labelDiplomSeries",
                Size = new Size(240, 40),
                Text = ((TeacherGroup)group).DiplomaSeries,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label labelDiplomNumber = new Label
            {
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Location = new Point(0, 90),
                Name = "labelDiplomNumber",
                Size = new Size(240, 40),
                Text = ((TeacherGroup)group).DiplomaNumber,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelStudy.Controls.Add(labelScientificTitle);
            panelStudy.Controls.Add(labelDiplomSeries);
            panelStudy.Controls.Add(labelDiplomNumber);
            panelStudy.Controls.Add(labelRole);
        }
    }
}