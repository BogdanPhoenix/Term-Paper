using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Custom;
using Newtonsoft.Json;

namespace Teacher_Manajar
{
    public partial class TeacherOffice : Form
    {
        //Клас для додаткової інформації при створенні групи
        private class LinkDataGroup
        {
            public string Name_Button { get; set; }
            public Group Data_Group { get; set; }
            public string Link_Group { get; set; }
            public ButtonCustom Button { get; set; }
        }

        private int left = 230;
        private int top = 5;
        private Teacher teacher = new Teacher();
        private readonly List<LinkDataGroup> dataGroups = new List<LinkDataGroup>();
        private Setting setting = new Setting();
        private readonly string user_directory = default;
        private readonly List<ButtonCustom> buttonsCustom = new List<ButtonCustom>();
        //Конструктор
        public TeacherOffice(Teacher _teacher)
        {
            InitializeComponent();
            teacher = _teacher;
            rjCircularPictureBox_Setting.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, "Settings.jpg"));
            rjCircularPictureBox_Setting.ContextMenuStrip = contextMenuStrip1;

            user_directory = Path.Combine(System_Process.ExePath, System_Process.RootDirectory, System_Process.TeacherDirectory, "User " + teacher.Email);
            FillingData();
            FindGroup();
            setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(Path.Combine(user_directory, System_Process.Setting_File)));
            CustomForm();
        }
        //Ініціалізація даних про користувача
        private void FillingData()
        {
            buttonsCustom.Add(buttonCustom_CreatGroup);
            buttonsCustom.Add(buttonCustom_ExitSession);

            label_FirstName.Text = teacher.First_Name;
            label_Name.Text = teacher.Name;
            label_Surname.Text = teacher.Surname;
            label_ID.Text = teacher.Id.ToString();

            label_University.Text = System_Process.Abbreviation(teacher.University);
            toolTip_University.SetToolTip(label_University, teacher.University);

            label_Diploma_Number.Text = teacher.Diploma_Number;
            label_Diploma_Series.Text = teacher.Diploma_Series;
            label_Scientific_Title.Text = teacher.Scientific_Title;

            toolTip_Id.SetToolTip(label_ID, "Натисніть. щоб скопіювати свій індентифікатор");
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
            if(MessageBox.Show("Ви дійсно хочете вийти з облікового запису?", "Увага", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormEntry entry = new FormEntry();
                entry.Show();
                Close();
            }
        }
        //Додати кнопку про групу
        private void AddButton(Group groupdata, string link_File)
        {
            ButtonCustom button = System_Process.AddButton(groupdata);
            ToolTip tool = new ToolTip();

            button.Click += ButtonOnClick;
            button.Left = left;
            button.Top = top;
            LinkDataGroup link = new LinkDataGroup
            {
                Name_Button = button.Name,
                Data_Group = groupdata,
                Link_Group = link_File,
                Button = button
            };           
            dataGroups.Add(link);
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
            foreach (var data in dataGroups)
            {
                if (button.Name == data.Name_Button)
                {
                    FormMagazineGroup magazine = new FormMagazineGroup(data.Data_Group, teacher){ Link_File = data.Link_Group };
                    Hide();
                    magazine.ShowDialog();
                    data.Data_Group = (Group)magazine.Group.Clone();
                    if (magazine.Delete_Group)
                    {
                        ButtonShift();
                        panel_GroupFrontColor.Controls.Remove(button);
                        dataGroups.Remove(data);
                    }
                    Show();
                    break;
                }
            }
        }
        //Зсув кнопок, якщо було видалено одну із груп
        private void ButtonShift()
        {
            for(int i = 1; i < dataGroups.Count; ++i)
            {
                dataGroups[i].Button.Location = dataGroups[i - 1].Button.Location;
            }
        }
        //Пошук всіх груп, де викладачем є даний користувач
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

                foreach (var it in group_file)
                {
                    if (File.Exists(it) && File.ReadAllLines(it).Length != 0)
                    {
                        group = JsonConvert.DeserializeObject<Group>(File.ReadAllText(it));

                        if (teacher.Email == group.Teacher.Email)
                        {
                            AddButton(group, it);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при пошуку групи. Викладач", "Увага");
            }
        }
        //Створення нової групи
        private void ButtonCustom_CreatGroup_Click(object sender, EventArgs e)
        {
            FormCreatGroup creatGroup = new FormCreatGroup(teacher);
            Hide();
            creatGroup.ShowDialog();
            if (creatGroup.Group.Name_Subject != null)
                AddButton(creatGroup.Group, creatGroup.File_Name);
            Show();
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
            rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.RootDirectory, System_Process.TeacherDirectory, "User " + teacher.Email, teacher.Now_Link_Foto));
            
            panel_BackgroundColor.BackColor = setting.Background_Form_Color;
            ForeColor = setting.Font_Color;
            panel_IDFrontColor.BackColor =  panel_GroupFrontColor.BackColor = panel_DataFrontColor.BackColor = panel_FotoAvatarFrontColor.BackColor = setting.Front_Form_Color;
        }
        //Перейти до налаштувань аватарки
        private void НалаштуванняАватаркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher copy_teacher = (Teacher)teacher.Clone();
            Setting copy_setting = (Setting)setting.Clone();
            teacher = (Teacher)System_Process.SettingAvatar(teacher, ref setting);
            if (!copy_setting.Equals(setting) || !copy_teacher.Equals((IPrivateInfo)teacher))
                CustomForm();
            Show();
        }
        //Перейти до налаштувань кольорової палітри
        private void НалаштуванняКольоровоїПалітриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Setting copy_setting = (Setting)setting.Clone();
            setting = System_Process.SettingPalitraColor(teacher, setting);
            if (!copy_setting.Equals(setting))
                CustomForm();
            Show();
        }
        //Перейти до персональних налаштувань
        private void НалаштуванняПерсональнихДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher copy_teacher = (Teacher)teacher.Clone();
            teacher = (Teacher)System_Process.SettingPersonalData(teacher, setting);
            if(!copy_teacher.Equals((IPerson)teacher) || !copy_teacher.Equals((IPrivateInfo)teacher))
                CustomForm();
            Show();
        }
        //Визначення позиції спливаючого меню
        private void RjCircularPictureBox_Setting_Click(object sender, EventArgs e)
        {
            Point position = new Point
            {
                X = panel_IDFrontColor.Location.X + rjCircularPictureBox_Setting.Location.X + rjCircularPictureBox_Setting.Height,
                Y = panel_IDFrontColor.Location.Y + rjCircularPictureBox_Setting.Location.Y + rjCircularPictureBox_Setting.Width
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
                    System_Process.DeleteAccount(teacher);
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
