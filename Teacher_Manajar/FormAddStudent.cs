using Custom;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormAddStudent : Form
    {
        private readonly Group group = new Group();
        private List<StudentGroup> students = new List<StudentGroup>();
        private readonly Setting setting = new Setting();
        private readonly List<ButtonCustom> buttonCustoms = new List<ButtonCustom>();
        //Дані про студента
        public StudentGroup Student { get; private set; }
        //Конструктор
        public FormAddStudent(Group _group, Setting _setting)
        {
            InitializeComponent();
            group = _group;
            setting = _setting;
            Initialize();
            Timer_AddStudent.Start();
        }
        //Присвоєння початкового вигляду формі
        private void Initialize()
        {
            panel_Background.BackColor = setting.Background_Form_Color;
            dataGridView1.BackgroundColor = panel_FrontColor.BackColor = setting.Front_Form_Color;
            panel_FrontColor.ForeColor = setting.Font_Color;

            buttonCustoms.Add(buttonCustom_AddStudent);
            buttonCustoms.Add(buttonCustom_DeleteData);
            buttonCustoms.Add(buttonCustom_СreatGroup);
            System_Process.OnPaintButton(buttonCustoms, setting);
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Закрити форму
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        //Пересування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Перевірка чи користувач з указаним індентифікатором знаходиться в списку чи ні
        private bool CheckExistingUsers()
        {
            if(group.Students != null)
            {
                foreach (var person in group.Students)
                {
                    if (person.Id.ToString() == MyTextBox_Identifier.Texts)
                    {
                        MessageBox.Show("Користувач з даним індентифікатором вже знаходиться в групі. Спробуйте іще раз", "Увага");
                        return false;
                    }
                }
            }
            return true;
        }
        //Додання студента в список і в групу
        private void ButtonCustom_AddStudent_Click(object sender, EventArgs e)
        {
            if (CheckExistingUsers())
            {
                students = System_Process.FindStudent(group.Name_Group, group.Course.ToString());

                foreach (var person in students)
                {
                    if (person.Id.ToString() == MyTextBox_Identifier.Texts)
                    {
                        var full_name = System_Process.Abbreviation(person.Name + " " + person.Surname);
                        var groun_name = System_Process.Abbreviation(person.Group);
                        dataGridView1.Rows.Add(1, person.First_Name + " " + full_name, groun_name + "-" + person.Course);
                        Student = person;
                        break;
                    }
                }
                if (Student == default(StudentGroup))
                    MessageBox.Show("За вашим запитом нікого не виявлено.", "Увага");
            }   
        }
        //Перехід до основного меню групи
        private void ButtonCustom_СreatGroup_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Поле для введення індентифікатора
        private void MyTextBox_Identifier__TextChanger(object sender, EventArgs e)
        {
            label_warningIdentifier.Visible = System_Process.CheckField(MyTextBox_Identifier.Texts);
        }
        //Таймер для активізації необхідних кнопок
        private void Timer_AddStudent_Tick(object sender, EventArgs e)
        {
            buttonCustom_DeleteData.Enabled = buttonCustom_СreatGroup.Enabled = dataGridView1.Rows.Count != 0;
            buttonCustom_AddStudent.Enabled = dataGridView1.Rows.Count == 0 && MyTextBox_Identifier.Texts.Length != 0;
        }
        //Очистити таблицю
        private void ButtonCustom_DeleteData_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            students.Clear();
            Student = default;
        }
    }
}
