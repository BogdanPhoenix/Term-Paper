using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Custom;

namespace Teacher_Manajar
{
    public partial class FormCreatGroup : Form
    {
        private readonly Group group = new Group();
        private readonly Teacher teacher = new Teacher();
        private List<StudentGroup> student_list = new List<StudentGroup>();
        private readonly Setting setting = new Setting();
        private uint index_student = 0;
        private readonly List<Label> warning = new List<Label>();
        private readonly List<ButtonCustom> buttonCustoms = new List<ButtonCustom>();
        //Отримання групи
        public Group Group { get => group; }
        //Отримання шляху до файла групи
        public string File_Name { get; private set; }

        //Конструктор
        public FormCreatGroup(Teacher _teacher)
        {
            InitializeComponent();
            teacher = _teacher;
            Initialize();
            setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(Path.Combine(System_Process.ExePath, System_Process.RootDirectory, System_Process.TeacherDirectory, "User " + teacher.Email, System_Process.Setting_File)));
            group.Students = new List<StudentGroup>();
            Timer_CheckButton.Start();
        }
        ~FormCreatGroup()
        {
            index_student = 0;
            GC.Collect();
        }
        //Початкова ініціалізація та присвоєння зовнішнього вигляду
        private void Initialize()
        {
            buttonCustom_AddStudent.Enabled = buttonCustom_FindStudentsAll.Enabled = false;
            buttonCustom_СreatGroup.Enabled = false;
            
            panel_BackgroundColor.BackColor = setting.Background_Form_Color;
            dataGridView1.BackgroundColor = panel_FrontColor.BackColor = setting.Front_Form_Color;
            panel_FrontColor.ForeColor = setting.Font_Color;

            warning.Add(label_warningCourse);
            warning.Add(label_warningGroup);
            warning.Add(label_warningName_Subject);
            buttonCustoms.Add(buttonCustom_AddStudent);
            buttonCustoms.Add(buttonCustom_FindStudentsAll);
            buttonCustoms.Add(buttonCustom_DeleteData);
            buttonCustoms.Add(buttonCustom_СreatGroup);
            System_Process.OnPaintButton(buttonCustoms, setting);
        }
        //Пошук студентів з бази даних, які задовільняють пошук
        private void ButtonCustom_FindStudentsAll_Click(object sender, EventArgs e)
        {
            try
            {
                student_list = System_Process.FindStudent(MyTextBox_Group.Texts, MaskedTextBox_Course.Text);
                if(group.Students != null)
                {
                    for(int i = 0; i < group.Students.Count; ++i)
                    {
                        for(int j = 0; j < student_list.Count; ++j)
                        {
                            if (group.Students[i].Id == student_list[j].Id)
                            {
                                student_list.RemoveAt(j); 
                                break;
                            }
                        }
                    }
                }
                foreach (var person in student_list)
                {
                    AddStudent(person);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час пошуку студентів", "Увага");
            }
        }
        //Додання студента в таблицю
        private void AddStudent(StudentGroup person)
        {
            var full_name = System_Process.Abbreviation(person.Name + " " + person.Surname);
            var groun_name = System_Process.Abbreviation(person.Group);
            dataGridView1.Rows.Add(++index_student, person.First_Name + " " + full_name, groun_name + "-" + person.Course);
        }
        //Введення назви заняття
        private void MyTextBox_Name_Subject__TextChanger(object sender, EventArgs e)
        {
            label_warningName_Subject.Visible = System_Process.CheckField(MyTextBox_Name_Subject.Texts);
            MyTextBox_Group.Enabled = !label_warningName_Subject.Visible;
        }
        //Введення назви групи
        private void MyTextBox_Group__TextChanger(object sender, EventArgs e)
        {
            label_warningGroup.Visible = System_Process.CheckField(MyTextBox_Group.Texts);
            MaskedTextBox_Course.Enabled = !label_warningGroup.Visible;
            group.Name_Group = MyTextBox_Group.Texts;
        }
        //Введення номеру курсу
        private void MaskedTextBox_Course_TextChanged(object sender, EventArgs e)
        {
            label_warningCourse.Visible = System_Process.CheckField(MaskedTextBox_Course.Text);
            group.Course = Convert.ToInt32(MaskedTextBox_Course.Text);
        }
        //Перевірка чи можна активувати необхідні кнопки, коли користувач введе всі кнопки
        private void Timer_CheckButton_Tick(object sender, EventArgs e)
        {
            buttonCustom_AddStudent.Enabled = buttonCustom_FindStudentsAll.Enabled = System_Process.CheckWarning(warning);
            buttonCustom_DeleteData.Enabled = buttonCustom_СreatGroup.Enabled = dataGridView1.Rows.Count != 0;
        }
        //Створення групи
        private void ButtonCustom_СreatGroup_Click(object sender, EventArgs e)
        {
            try
            {
                string compline = Path.Combine(System_Process.ExePath, System_Process.GroupDirectory);
                File_Name = Path.Combine(compline, "Group_" + System_Process.Abbreviation(MyTextBox_Group.Texts) + "_" + MaskedTextBox_Course.Text + "_" + System_Process.Abbreviation(MyTextBox_Name_Subject.Texts) + ".json");
                if (!File.Exists(File_Name))
                {
                    group.Name_Subject = MyTextBox_Name_Subject.Texts;
                    group.Teacher = System_Process.ConvertTeacher(teacher);
                    group.Students.AddRange(student_list);
                    group.Dates = new List<DateTime>();
                    group.Calendar_Plan = new List<string>();

                    string json = JsonConvert.SerializeObject(group, Formatting.Indented);
                    File.WriteAllText(File_Name, json);

                    MessageBox.Show("Групу успішно створено", "Повідомлення");
                    DialogResult = DialogResult.OK;
                    Timer_CheckButton.Stop();
                    Close();
                }
                else
                {
                    MessageBox.Show("Дана група вже існує. Спробуйте іще раз", "Увага");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час створення групи", "Увага");
            }
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Вийти з форми
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Пересування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Додати студента за індентифікатором
        private void ButtonCustom_AddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent form_AddStudent = new FormAddStudent(group, setting);
            Hide();
            form_AddStudent.ShowDialog();
            if (form_AddStudent.Student != default)
            {
                if (group.Students == null)
                    group.Students = new List<StudentGroup>();
                group.Students.Add(form_AddStudent.Student);
                AddStudent(group.Students[group.Students.Count - 1]);
            }
            form_AddStudent.Close();
            Show();
        }
        //Очистити таблицю
        private void ButtonCustom_DeleteData_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            index_student = 0;
            group.Students = default;
        }
    }
}
