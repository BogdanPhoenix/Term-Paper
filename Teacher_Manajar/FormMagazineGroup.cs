using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Custom;
using System.Collections.Generic;

namespace Teacher_Manajar
{
    public partial class FormMagazineGroup : Form
    {
        private Group group = new Group();
        private readonly Group new_group = new Group();
        private bool delete_group = false;
        private readonly Setting setting = new Setting();
        private readonly List<ButtonCustom> buttonCustoms = new List<ButtonCustom>();
        private readonly IPrivateInfo privateInfo = null;
        //Силка на групу
        public string Link_File { get; set; }
        //Властивість чи видаляти групу
        public bool Delete_Group { get => delete_group; }

        public Group Group { get => new_group; }
        //Конструктор
        public FormMagazineGroup(Group _group, IPrivateInfo _privateInfo)
        {
            InitializeComponent();
            privateInfo = _privateInfo;
            buttonCustom_Save.Visible = panel_TeacherRole.Visible = privateInfo.Role == "Teacher";
            dataGridView1.ReadOnly = privateInfo.Role != "Teacher";
            IPerson person = (IPerson)privateInfo;
            group = (Group)_group.Clone();
            group.Students.Sort(delegate(StudentGroup student1, StudentGroup student2){ return string.Compare(student1.First_Name, student2.First_Name); });
            new_group = (Group)group.Clone();
            dataGridView1.AutoGenerateColumns = true;
            label_MagazineNameTitle.Text += new_group.Name_Subject + " " + System_Process.Abbreviation(new_group.Name_Group) + "-" + new_group.Course;
            setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(Path.Combine(System_Process.ExePath, System_Process.RootDirectory, privateInfo.Role + "s", "User " + person.Email, System_Process.Setting_File)));
            Initialize();
            AddData();
        }
        //Початкова ініціалізація зовнішнього вигляду
        private void Initialize()
        {
            panel_Background.BackColor = setting.Background_Form_Color;
            dataGridView1.BackgroundColor = panel_FrontColor.BackColor = setting.Front_Form_Color;
            panel_FrontColor.ForeColor = setting.Font_Color;

            buttonCustoms.Add(buttonCustom_Save);
            buttonCustoms.Add(ButtonCustom_goBack);
            buttonCustoms.Add(buttonCustom_DeleteMagazine);
            buttonCustoms.Add(buttonCustom_addStudent);
            buttonCustoms.Add(buttonCustom_CalendarPlan);
            buttonCustoms.Add(ButtonCustom_addClasses);
            System_Process.OnPaintButton(buttonCustoms, setting);
        }
        //Створення таблиці
        private void AddData()
        {
            AddColumn();
            AddDataGrid();
        }
        //Створення комірок
        private void AddColumn()
        {
            foreach(var date in new_group.Dates)
            {
                AddDateTime(date);
            }            
        }
        //Створити рядок з даними про студента
        private void AddDataGrid(int index = 0)
        {
            for (; index < new_group.Students.Count; ++index)
            {
                StudentGroup person = new_group.Students[index];
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, person.First_Name + " " + person.Name[0] + "." + person.Surname[0]);
                dataGridView1.Rows[index].Cells["Full_Name"].ToolTipText =  person.First_Name + " " + person.Name + " " + person.Surname;
                int omissions = 0;
                int index_colum = 2;
                foreach (var evaluation in person.Evaluation)
                {
                    switch (evaluation)
                    {
                        case "н": ++omissions; break;
                    }

                    dataGridView1.Rows[index].Cells[index_colum++].Value = evaluation;
                }
                var data = "Прізвище: " + person.First_Name + "\nІм'я: " + person.Name + "\nПо-батькові: " + person.Surname + "\nКількість пропусків: " + omissions;
                dataGridView1.Rows[index].Cells["Full_Name"].ToolTipText = data;
            }
        }
        //Додати колонку
        private void AddDateTime(DateTime date)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn
            {
                ReadOnly = false,
                Name = "Column_" + date.ToString("dd/MM/yyyy"),
                Resizable = DataGridViewTriState.False
            };
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            column1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column1.HeaderText = date.ToString("dd/MM/yyyy");
            column1.Width = 75;
            if(privateInfo.Role == "Teacher")
            {
                contextMenu.Items.Add("Видалити поточну колонку");
                contextMenu.Name = column1.Name;
                contextMenu.Click += DeleteColumn;
                column1.HeaderCell.ContextMenuStrip = contextMenu;
            }
            dataGridView1.Columns.Add(column1);
        }
        private void DeleteColumn(object sender, EventArgs eventArgs)
        {
            try
            {
                DialogResult result = MessageBox.Show("Ви дійсно хочете видалити даний стовпчик?", "Увага", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ContextMenuStrip contextMenu = (ContextMenuStrip)sender;
                    new_group.Dates.RemoveAt(dataGridView1.Columns[contextMenu.Name].Index - 2);
                    foreach(var evalution in new_group.Students)
                        evalution.Evaluation.RemoveAt(dataGridView1.Columns[contextMenu.Name].Index - 2);
                    dataGridView1.Columns.Remove(contextMenu.Name);
                    MessageBox.Show("Стовпчик було видалено успішно", "Увага");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час видалення стовпчика", "Увага");
            }
        }

        //Зберегти дані
        private void Save_Data()
        {
            try
            {
                string json = JsonConvert.SerializeObject(new_group, Formatting.Indented);
                File.WriteAllText(Path.Combine(System_Process.ExePath, Link_File), json);
                group = (Group)new_group.Clone();
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час збереження файлу", "Увага");
            }
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Перевірка на вихід
        private void CheckExit()
        {
            if (!group.Equals(new_group))
            {
                DialogResult result = MessageBox.Show("Ви не зберегли зміни в таблиці. Ви хочете зберегти зміни і вийти?", "", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes: Save_Data(); Close(); break;
                    case DialogResult.No: Close(); break;
                    case DialogResult.Cancel: break;
                }
            }
            else
            {
                Close();
            }
        }
        //Вихід
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            CheckExit();
        }
        //Пересування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Повернутися назад до акаунту
        private void ButtonCustom_goBack_Click(object sender, EventArgs e)
        {
            CheckExit();
        }
        //Додати заняття
        private void ButtonCustom_addClasses_Click(object sender, EventArgs e)
        {
            FormChooseData choose_date = new FormChooseData(setting);
            Hide();
            choose_date.ShowDialog();
            if (choose_date.Date != default)
            {
                AddDateTime(choose_date.Date);
                new_group.Dates.Add(choose_date.Date);
                new_group.Calendar_Plan.Add("");
                foreach (var person in new_group.Students)
                {
                    person.Evaluation.Add("");
                }
            }
            choose_date.Close();
            Show();
        }
        //Додати студента
        private void ButtonCustom_addStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent form_AddStudent = new FormAddStudent(new_group, setting);
            form_AddStudent.ShowDialog();
            if(form_AddStudent.Student != null)
            {
                new_group.Students.Add(form_AddStudent.Student);
                AddDataGrid(new_group.Students.Count - 1);
            }
            form_AddStudent.Close();
        }
        //Оновити таблицю
        private void UpdateGroup()
        {
            try
            {
                if(dataGridView1.CurrentCell.ColumnIndex > dataGridView1.Columns["Full_Name"].Index)
                {
                    int.TryParse(dataGridView1.CurrentCell.Value.ToString(), out int result);
                    if ((result > 0 && result <= 5) || string.Compare(dataGridView1.CurrentCell.Value.ToString(), "н") == 0)
                        new_group.Students[dataGridView1.CurrentCell.RowIndex].Evaluation[dataGridView1.CurrentCell.ColumnIndex - 2] = dataGridView1.CurrentCell.Value.ToString();
                    else
                        MessageBox.Show("Ви ввели не коректні дані в комірці \n\n\tІм'я студента: "+ dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Full_Name"].Value.ToString() + "\n\tДата проведення заняття: " + dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText + "\n\nМожна вводити числа від 1 до 5 включно, або використовувати для позначки літеру \"н\"");
                }
                   
            }
            catch(Exception) 
            {
                MessageBox.Show("Сталася помилка під час занесення даних в таблицю", "Увага");
            }
        }
        //Занесення даних в таблицю
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell != null)
                UpdateGroup();
        }
        //Видалити групу
        private void ButtonCustom_DeleteMagazine_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити дані про журнал?", "Увага", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                File.Delete(Link_File);
                delete_group = true;
                Close();
            }
        }
        //Додати записи в календарний план
        private void ButtonCustom_CalendarPlan_Click(object sender, EventArgs e)
        {
            FormCalendarPlan calendar_Plan = new FormCalendarPlan(new_group, setting);
            Hide();
            calendar_Plan.ShowDialog();
            Show();
        }
        //Зберегти зміни
        private void buttonCustom_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Save_Data();
                MessageBox.Show("Дані збережено", "Увага");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час збереження даних", "Увага");
            }
        }
    }
}
