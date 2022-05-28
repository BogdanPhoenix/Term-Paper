using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.Enum;

namespace TeacherManajar.Forms.Manajar
{
    /// <summary>
    /// Клас для виведення користувачу інформації про журнал групи
    /// </summary>
    public partial class InformationGroup : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="groupData">Дані про журнал групи</param>
        public InformationGroup(GroupData groupData)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(labelTeacher, "Додати спливаюче поле bunifuSnackbar в якому використати спливаючу панель, щоб відображати дані про користувача");

            labelSubjectName.Text = groupData.Specialty;
            labelGroupName.Text = groupData.NameSubject;
            labelCourse.Text = groupData.Course.ToString();

            try
            {
                MySqlDataReader sqlDataReader = DataBase.Select(new AccountEmail() { IdPerson = groupData.IdTeacher, Role = "Викладач" }, VariantSelect.Person);
                Person teacher = new Person();
                sqlDataReader.Read();
                teacher.ConvertFromMySql(sqlDataReader);
                labelTeacher.Text = $"{teacher.FirstName} {teacher.Name} {teacher.Surname}";
            }
            catch (Exception)
            {
                labelTeacher.Text = "Невдалося знайти інформацію про викладача.";
            }
            bunifuIconButtonExit.Click += (s, e) => { Hide(); };
        }
    }
}
