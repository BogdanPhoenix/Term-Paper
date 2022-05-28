using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Custom;
using System.Collections.Generic;

namespace Teacher_Manajar
{
    public partial class FormSettingAvatarFoto : Form
    {
        private IPrivateInfo privateInfo = null;
        private readonly IPrivateInfo new_privateInfo = null;
        private readonly IPerson person = null;
        private int number_picture = 0;
        private readonly string role = default;
        private string colection_link_foto = default;
        private Setting setting = new Setting();
        private readonly Setting new_setting = new Setting();
        private readonly string user_directory = default;
        private readonly List<ButtonCustom> buttonsCustom = new List<ButtonCustom>();

        //Повернуння змінених налаштувань
        public Setting Setting_Parametr { get => new_setting; }
        //Повернення змінених приватних налаштувань
        public IPrivateInfo PrivateInfo { get => new_privateInfo; }
        public FormSettingAvatarFoto(IPerson _person, Setting _setting)
        {
            InitializeComponent();
            person = _person;
            privateInfo = (IPrivateInfo)person;
            new_privateInfo = (IPrivateInfo)privateInfo.Clone();
            role = privateInfo.Role == "Teacher" ? System_Process.TeacherDirectory : System_Process.StudentDirextory;

            user_directory = Path.Combine(System_Process.ExePath, System_Process.RootDirectory, role, "User " + person.Email);
            setting = _setting;
            new_setting = (Setting)setting.Clone();

            Initialize();
        }
        //Ініціалізація зовнішнього вигляду
        private void Initialize()
        {
            buttonsCustom.Add(buttonCustom_ChooseFoto);
            buttonsCustom.Add(buttonCustom_SaveFotoAvatar);
            buttonsCustom.Add(buttonCustom_ChooseColor1);
            buttonsCustom.Add(buttonCustom_ChooswColor2);

            System_Process.OnPaintButton(buttonsCustom, setting);

            colection_link_foto = privateInfo.Now_Link_Foto;
            rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(Path.Combine(user_directory, colection_link_foto));
            pictureBox_ArrowLeft.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, "Arrow_Left.png"));
            pictureBox_ArrowRight.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, "Arrow_Right.png"));

            rjCircularPictureBox_AvatarFoto.BorderColor = panel_demoAvatarBorderColor1.BackColor = new_setting.Border1;
            rjCircularPictureBox_AvatarFoto.BorderColor2 = panel_demoAvatarBorderColor2.BackColor = new_setting.Border2;
            rjCircularPictureBox_AvatarFoto.BorderSize = new_setting.Border_Size;
            numericUpDown_BorderAvatarSize.Value = Convert.ToDecimal(new_setting.Border_Size);

            panel_AvatarBackgroundColor.BackColor = new_setting.Background_Form_Color;
            panel_AvatarFotoFrontColor.BackColor = new_setting.Front_Form_Color;
            new_setting.Border_Size = new_setting.Border_Size;

            number_picture = privateInfo.Previous_Link_Foto.Count - 1;
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Вийти з форми
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            if (!setting.Equals(new_setting) || !privateInfo.Equals(new_privateInfo))
            {
                DialogResult result = MessageBox.Show("Увага, ви не зберегли зміни. Ви хочете зберегти зміни та вийти з налаштувань?", "Увага", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes: SavePerson(); SaveSetting(); Close(); break;
                    case DialogResult.No: Close(); break;
                    case DialogResult.Cancel: break;
                }
            }
            else
            {
                Close();
            }
        }
        //Пересування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Вибір де вуде вибиратися фото для заставки
        private void ToggleButton_VariantFoto_CheckedChanged(object sender, EventArgs e)
        {
            panel_Previous.Visible = !toggleButton_VariantFoto.Checked;
            if (!toggleButton_VariantFoto.Checked)
                rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(Path.Combine(user_directory, privateInfo.Previous_Link_Foto[number_picture]));
            panel_Choose.Visible = toggleButton_VariantFoto.Checked;
        }
        //Вибір фото не з колекції
        private void ButtonCustom_ChooseFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Type file(*.jpg)| *.jpg|Type file(*.png)|*.png|Type file(*.bmp)|*.bmp|Type file(*.psd)|*.psd|Type file(*.tga)|*.tga";
            colection_link_foto = openFileDialog1.ShowDialog() == DialogResult.OK ? openFileDialog1.FileName : colection_link_foto;
            rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(colection_link_foto);
            LinkFoto(Path.GetFileName(colection_link_foto));
        }
        //Вибір аватарки з колекції вліво
        private void PictureBox_ArrowLeft_Click(object sender, EventArgs e)
        {
            --number_picture;
            CheckFoto(ref number_picture);
        }
        //Вибір аватарки з колекції вправо
        private void PictureBox_ArrowRight_Click(object sender, EventArgs e)
        {
            ++number_picture;
            CheckFoto(ref number_picture);
        }
        //Перевірка, щоб можна було перебирати зображення по-кругу
        private void CheckFoto(ref int index)
        {
            if (index < 0)
                index = privateInfo.Previous_Link_Foto.Count - 1;
            if (index >= privateInfo.Previous_Link_Foto.Count)
                index = 0;
            rjCircularPictureBox_AvatarFoto.Image = Image.FromFile(Path.Combine(user_directory, privateInfo.Previous_Link_Foto[index]));
            colection_link_foto = privateInfo.Previous_Link_Foto[index];
            LinkFoto(colection_link_foto);
        }
        //Присвоєння зображення у відповідне поле
        private void LinkFoto(string name_picture)
        {
            new_privateInfo.Now_Link_Foto = name_picture;
        }
        //Вибір розміру рамок аватарки
        private void NumericUpDown_BorderAvatarSize_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_BorderAvatarSize.Value <= 0)
            {
                MessageBox.Show("Увага, рамки аватарки не можуть бути меншими або дорівнювати нулю. Мінімальне допустиме значення становить одиниця", "Увага");
                numericUpDown_BorderAvatarSize.Value = 1;
            }
            new_setting.Border_Size = rjCircularPictureBox_AvatarFoto.BorderSize = Convert.ToInt32(numericUpDown_BorderAvatarSize.Value);
        }
        //Зберегти зміни
        private void ButtonCustom_SaveFotoAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                SavePerson();
                SaveSetting();
                MessageBox.Show("Дані збережено", "Увага");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час збереження даних", "Увага");
            }
        }
        //Збереження налаштувань
        private void SaveSetting()
        {
            var setting_person = JsonConvert.SerializeObject(new_setting, Formatting.Indented);
            File.WriteAllText(Path.Combine(user_directory, System_Process.Setting_File), setting_person);
            setting = new_setting;
        }
        //Збереження приватних даних
        private void SavePerson()
        {
            if (!CheckColection())
            {
                var new_file = "Avatar_Foto_" + privateInfo.Previous_Link_Foto.Count.ToString() + Path.GetExtension(colection_link_foto);
                File.Copy(colection_link_foto, Path.Combine(user_directory, new_file));
                new_privateInfo.Now_Link_Foto = new_file;
                new_privateInfo.Previous_Link_Foto.Add(new_file);
            }
            var data_person = JsonConvert.SerializeObject(new_privateInfo, Formatting.Indented);
            File.WriteAllText(Path.Combine(user_directory, person.Email + ".json"), data_person);
            privateInfo = new_privateInfo;
        }
        //Перевірка щоб вибране користувачем фото не повторювалося в колекції
        private bool CheckColection()
        {
            foreach (var picture in privateInfo.Previous_Link_Foto)
            {
                if (picture == colection_link_foto)
                    return true;
            }
            return false;
        }
        //Вибрати другий колір для рамок аватарки
        private void ButtonCustom_ChooseColor2_Click(object sender, EventArgs e)
        {
            new_setting.Border2 = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Border2;
            rjCircularPictureBox_AvatarFoto.BorderColor2 = new_setting.Border2;
            panel_demoAvatarBorderColor2.BackColor = new_setting.Border2;
        }
        //Вибрати перший колір для рамок аватарки
        private void ButtonCustom_ChooseColor1_Click(object sender, EventArgs e)
        {
            new_setting.Border1 = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Border1;
            rjCircularPictureBox_AvatarFoto.BorderColor = new_setting.Border1;
            panel_demoAvatarBorderColor1.BackColor = new_setting.Border1;
        }
    }
}
