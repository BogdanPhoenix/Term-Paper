using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormEntry : Form
    {
        private Student student = new Student();
        private Teacher teacher = new Teacher();
        private IPerson person = null;
        //Список для перевірки чи всі поля заповненні
        private readonly List<Label> warning = new List<Label>();
        //Конструктор
        public FormEntry()
        {
            InitializeComponent();

            label_forgotPassword.Enabled = false;
            buttonCustom_Entry.Enabled = false;
            warning.Add(label_warningLogin);
            warning.Add(label_warningPassword);
            timer1.Start();
        }
        //Кнопка входу
        private void ButtonCustom_Entry_Click(object sender, EventArgs e)
        {
            try
            {
                student = System_Process.Find_Account<Student>(myTextBox_Login.Texts, System_Process.StudentDirextory);
                teacher = System_Process.Find_Account<Teacher>(myTextBox_Login.Texts, System_Process.TeacherDirectory);
                if (student != default(Student))
                    person = student;
                else
                    person = teacher;

                if (CheckCorectDataPublic(person) && CheckCorectDataPrivate(myTextBox_Password.Texts, PersonData.Password, (IPrivateInfo)person) )
                {
                    IPrivateInfo privateInfo = (IPrivateInfo)person;
                    switch (privateInfo.Role)
                    {
                        case "Student":
                            StudentOffice person_student = new StudentOffice(student);
                            person_student.Show();
                            break;
                        case "Teacher":
                            TeacherOffice person_teacher = new TeacherOffice(teacher);
                            person_teacher.Show();
                            break;
                        default: break;
                    }
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Сталася помилка при вході в акаунт");
            }
        }
        //Перевірка на коректність введених публічних даних
        private bool CheckCorectDataPublic(IPerson info)
        {
            if(info == null)
            {
                MessageBox.Show("За даним Email нікого не виявлено. Перевірте введені дані і спробуйте іще раз", "Увага");
                return false;
            }
            return true;
        }
        //Перевірка на коректність введених приватних даних
        private bool CheckCorectDataPrivate(string data, PersonData index, IPrivateInfo info)
        {
            string warning = "";
            switch (Convert.ToInt32(index))
            {
                case (int)PersonData.Password: warning = info.Password == data ? string.Empty : "Паролі не співпадають. "; break;
            }
            if (warning != string.Empty)
                MessageBox.Show(warning + "Перевірте введені дані і спробуйте іще раз", "Увага");
            return warning == string.Empty;
        }
        //Таймер який перевіряє чи можна активувати кнопку входу в акаунт
        private void Timer1_Tick(object sender, EventArgs e)
        {
            buttonCustom_Entry.Enabled = System_Process.CheckWarning(warning);
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Закрити форму
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Пересування форми
        private void panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Перевірка чи ввів користувач хоч якісь дані, щоб можна було далі активувати поле для вводу пароля
        private void MyTextBox_Login__TextChanger(object sender, EventArgs e)
        {
            label_warningLogin.Visible = System_Process.CheckField(myTextBox_Login.Texts);
            myTextBox_Password.Enabled = !label_warningLogin.Visible;
        }
        //Перевірка чи ввів користувач хоч якісь дані, щоб можна було далі активувати поле для вводу кнопки входу
        private void myTextBox_Password__TextChanger(object sender, EventArgs e)
        {
            label_warningPassword.Visible = System_Process.CheckField(myTextBox_Password.Texts);
        }
        //Кнопка для реєстрації акаунта
        private void ButtonCustom_Register_Click(object sender, EventArgs e)
        {
            FormRole role = new FormRole();
            role.Show();
            Close();
        }
    }
}
