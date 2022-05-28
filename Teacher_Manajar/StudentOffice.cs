using Custom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class StudentOffice : Form
    {
        private int left = 10;
        private int top = 5;
        private Student student = new Student();
        private Setting setting = new Setting();
        private readonly string user_directory = default;
        private Dictionary<string, Group> groups = new Dictionary<string, Group>();
        private readonly List<ButtonCustom> buttonsCustom = new List<ButtonCustom>();
        //Конструктор
        public StudentOffice(Student _student)
        {
            InitializeComponent();
            student = _student;
            rjCircularPictureBox_Setting.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, "Settings.jpg"));
            rjCircularPictureBox_Setting.ContextMenuStrip = contextMenuStrip1;

            user_directory = Path.Combine(System_Process.ExePath, System_Process.RootDirectory, System_Process.StudentDirextory, "User " + student.Email);
            FillingData();
            FindGroup();
            setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(Path.Combine(user_directory, System_Process.Setting_File)));
            CustomForm();
        }
        //Початкова ініціалізація зовнішнього вигляду форми
        private void FillingData()
        {
            buttonsCustom.Add(buttonCustom_ExitSession);

            label_FirstName.Text = student.First_Name;
            label_Name.Text = student.Name;
            label_Surname.Text = student.Surname;
            label_ID.Text = student.Id.ToString();

            label_University.Text = System_Process.Abbreviation(student.University);
            toolTip_University.SetToolTip(label_University, student.University);

            label_Group.Text = System_Process.Abbreviation(student.Group);
            toolTip_Group.SetToolTip(label_Group, student.Group);
            toolTip_Id.SetToolTip(label_ID, "Натисніть. щоб скопіювати свій індентифікатор");

            label_Course.Text = student.Course.ToString();
            toolTip_Setting.SetToolTip(rjCircularPictureBox_Setting, "Налаштування");
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Зактрити форму
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з програми?", "Увага", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Пересування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Вийти з облікового запису
        private void ButtonCustom_ExitSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з облікового запису?", "Увага", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormEntry entry = new FormEntry();
                entry.Show();
                Close();
            }
        }
        //Додати кнопку про групу
        private void AddButton(Group groupdata)
        {
            ButtonCustom button = System_Process.AddButton(groupdata);
            ToolTip tool = new ToolTip();
           
            button.Left = left;
            button.Top = top;
            button.Click += ButtonOnClick;
            groups.Add(button.Name, groupdata);
            buttonsCustom.Add(button);
            tool.SetToolTip(button, "Група: " + groupdata.Name_Group + "-" + groupdata.Course + "\nПредмет: " + groupdata.Name_Subject);
            panel_GroupFrontColor.Controls.Add(button);
            System_Process.OnPaintButton(buttonsCustom, setting, buttonsCustom.Count - 1);

            left += 20 + button.Size.Width;
            System_Process.NextPositionButton(ref left, ref top, button, panel_GroupFrontColor);
        }
        //Відкрити конкретну групу
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (ButtonCustom)sender;
            Group this_group = groups[button.Name];
            FormMagazineGroup magazine = new FormMagazineGroup(this_group, student);
            Hide();
            magazine.ShowDialog();
            Show();
        }
        //Пошук всіх груп, де студентом є даний користувач
        private void FindGroup()
        {
            try
            {
                string combine = Path.Combine(System_Process.ExePath, System_Process.GroupDirectory);
                if (!Directory.Exists(combine))
                    throw new Exception();

                List<string> group_file = new List<string>();
                Group group = new Group();
                group_file.AddRange(Directory.GetFiles(combine, "*.json"));

                foreach(var it in group_file)
                {
                    if (File.Exists(it) && File.ReadAllLines(it).Length != 0)
                    {
                        group = JsonConvert.DeserializeObject<Group>(File.ReadAllText(it));

                        foreach(var stud in group.Students)
                        {
                            if(student.Email == stud.Email)
                            {
                                AddButton(group);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Не вдалося зчитати дані");
            }
        }
        //Скопіювати індентифікатор
        private void Label_ID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_ID.Text);
        }
        //Перемалювання всіх компонентів форми після їх змін
        private void CustomForm()
        {
            System_Process.OnPaintButton(buttonsCustom, setting);

            rjCircularPictureBox_AvatarFoto.BorderColor = setting.Border1;
            rjCircularPictureBox_AvatarFoto.BorderColor2 = setting.Border2;
            rjCircularPictureBox_AvatarFoto.BorderSize = setting.Border_Size;
            rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.RootDirectory, System_Process.StudentDirextory, "User " + student.Email, student.Now_Link_Foto));

            panel_Background.BackColor = setting.Background_Form_Color;
            ForeColor = setting.Font_Color;
            panel_IDFrontColor.BackColor = panel_GroupFrontColor.BackColor = panel_FrontColor.BackColor = panel_FotoAvatarFrontColor.BackColor = setting.Front_Form_Color;
        }

        //Перейти до налаштувань аватарки
        private void НалаштуванняАватаркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Student copy_student = (Student)student.Clone();
            Setting copy_setting = (Setting)setting.Clone();
            student = (Student)System_Process.SettingAvatar(student, ref setting);
            if (!copy_setting.Equals(setting) || !copy_student.Equals((IPrivateInfo)student))
                CustomForm();
            Show();
        }
        //Перейти до налаштувань кольорової палітри
        private void НалаштуванняКольоровоїПалітриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Setting copy_setting = (Setting)setting.Clone();
            setting = System_Process.SettingPalitraColor(student, setting);
            if (!copy_setting.Equals(setting))
                CustomForm();
            Show();
        }
        //Перейти до персональних налаштувань
        private void НалаштуванняПерсональнихДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Student copy_student = (Student)student.Clone();
            student = (Student)System_Process.SettingPersonalData(student, setting);
            if (!copy_student.Equals((IPerson)student) || !copy_student.Equals((IPrivateInfo)student))
                CustomForm();
            Show();
        }
        //Визначення позиції спливаючого меню
        private void RjCircularPictureBox_Setting_Click(object sender, EventArgs e)
        {
            Point position = new Point
            {
                X = panel_IDFrontColor.Location.X + rjCircularPictureBox_Setting.Location.X + rjCircularPictureBox_Setting.Width,
                Y = panel_IDFrontColor.Location.Y + rjCircularPictureBox_Setting.Location.Y + rjCircularPictureBox_Setting.Height
            };
            contextMenuStrip1.Show(PointToScreen(position));
        }
        //Видалення акаунта
        private void ВидалитиАкаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Ви дійсно хочете видалити свій акаунт? Всі дані будуть втрачено", "Увага", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, System_Process.DefaultFotoUser));
                    FormEntry entry = new FormEntry();
                    entry.Show();
                    Close();
                    System_Process.DeleteAccount(student);
                    MessageBox.Show("Ваш акаунт успішно видалено", "Увага");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час видалення акаунта", "Увага");
            }
        }
    }
}
