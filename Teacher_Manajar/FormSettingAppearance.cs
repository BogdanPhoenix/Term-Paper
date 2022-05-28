using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Custom;

namespace Teacher_Manajar
{
    public partial class FormSettingAppearance : Form
    {
        private readonly string user_directory = default;
        private readonly string role = default;
        private Setting setting = new Setting();
        private readonly Setting new_setting = new Setting();
        private readonly List<ButtonCustom> buttonsCustom = new List<ButtonCustom>();
        //Повернення еастройок
        public Setting Setting { get => new_setting; }
        //Конструктор
        public FormSettingAppearance(IPerson _person, Setting _setting)
        {
            InitializeComponent();
            IPrivateInfo privateInfo = (IPrivateInfo)_person;

            role = privateInfo.Role == "Teacher" ? System_Process.TeacherDirectory : System_Process.StudentDirextory;
            user_directory = Path.Combine(System_Process.ExePath, System_Process.RootDirectory, role, "User " + _person.Email);

            setting = _setting;
            new_setting = (Setting)setting.Clone();
            Initialize();
        }
        //Початкова ініціалізація зовнішнього вигляду
        private void Initialize()
        {
            buttonsCustom.Add(button_ChooseFontColor);
            buttonsCustom.Add(button_BackgroundFormColor);
            buttonsCustom.Add(button_FrontFormColor);
            buttonsCustom.Add(button_ColorButton);
            buttonsCustom.Add(button_ColorBorderButton);
            buttonsCustom.Add(button_ColorTextButton);
            buttonsCustom.Add(buttonCustom_SaveAppearance);

            System_Process.OnPaintButton(buttonsCustom, setting);

            panel_demoFontColor.BackColor = new_setting.Font_Color;
            panel_AppearanceBackgroundFormColor.BackColor = panel_demoBackgroundFormColor.BackColor = new_setting.Background_Form_Color;
            panel_AppearanceBackgroundFormColor.ForeColor = new_setting.Font_Color;
            panel_appearanceForm.BackColor = panel_demoFrontFormColor.BackColor = new_setting.Front_Form_Color;
            panel_demoBackgroundButtonColor.BackColor = new_setting.Button_Background;
            panel_demoBorderButtonColor.BackColor = new_setting.Button_Border_Color;
            panel_demoTextButtonColor.BackColor = new_setting.Button_Text_Color;
            numericUpDown_BorderButtonSize.Value = Convert.ToDecimal(new_setting.Button_Border_Size);
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Закрити форму
        private void buttonCustom_Exit_Click(object sender, EventArgs e)
        {
            if (!setting.Equals(new_setting))
            {
                DialogResult result = MessageBox.Show("Увага, ви не зберегли зміни. Ви хочете зберегти зміни та вийти з налаштувань?", "Увага", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes: SaveSetting(); Close(); break;
                    case DialogResult.No: Close(); break;
                    case DialogResult.Cancel: break;
                }
            }
            else
            {
                Close();
            }
        }
        //Зберегти налаштування
        private void SaveSetting()
        {
            var setting_person = JsonConvert.SerializeObject(new_setting, Formatting.Indented);
            File.WriteAllText(Path.Combine(user_directory, System_Process.Setting_File), setting_person);
            setting = new_setting;
        }
        //Пересування форми
        private void panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Вибрати колір шрифта
        private void Button_ChooseFontColor_Click(object sender, EventArgs e)
        {
            new_setting.Font_Color = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Font_Color;
            panel_AppearanceBackgroundFormColor.ForeColor = new_setting.Font_Color;
            panel_demoFontColor.BackColor = new_setting.Font_Color;
        }
        //Вибрати колір заднього фону форми
        private void Button_BackgroundFormColor_Click(object sender, EventArgs e)
        {
            new_setting.Background_Form_Color = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Background_Form_Color;
            panel_demoBackgroundFormColor.BackColor = new_setting.Background_Form_Color;
            panel_AppearanceBackgroundFormColor.BackColor = new_setting.Background_Form_Color;
        }
        //Вибір переднього фону форми
        private void Button_FrontFormColor_Click(object sender, EventArgs e)
        {
            new_setting.Front_Form_Color = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Front_Form_Color;
            panel_appearanceForm.BackColor = new_setting.Front_Form_Color;
            panel_demoFrontFormColor.BackColor = new_setting.Front_Form_Color;
        }
        //Вибір кольору кнопок
        private void Button_ColorButton_Click(object sender, EventArgs e)
        {
            new_setting.Button_Background = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Button_Background;
            panel_demoBackgroundButtonColor.BackColor = new_setting.Button_Background;
            foreach (var button in buttonsCustom)
                button.BackColor = new_setting.Button_Background;
        }
        //Вибір кольору меж кнопок
        private void Button_ColorBorderButton_Click(object sender, EventArgs e)
        {
            new_setting.Button_Border_Color = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Button_Border_Color;
            panel_demoBorderButtonColor.BackColor = new_setting.Button_Border_Color;
            foreach (var button in buttonsCustom)
                button.BorderColor = new_setting.Button_Border_Color;
        }
        //Вибір кольору тексту кнопок
        private void Button_ColorTextButton_Click(object sender, EventArgs e)
        {
            new_setting.Button_Text_Color = colorDialog1.ShowDialog() == DialogResult.OK ? colorDialog1.Color : new_setting.Button_Text_Color;
            panel_demoTextButtonColor.BackColor = new_setting.Button_Text_Color;
            foreach (var button in buttonsCustom)
                button.ForeColor = new_setting.Button_Text_Color;
        }
        //Вибір товщини меж кнопок
        private void NumericUpDown_BorderButtonSize_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_BorderButtonSize.Value < 0)
            {
                MessageBox.Show("Увага, рамки кнопок не можуть бути меншими за нуль. Мінімальне допустиме значення становить нуль", "Увага");
                numericUpDown_BorderButtonSize.Value = 0;
            }
            new_setting.Button_Border_Size = Convert.ToInt32(numericUpDown_BorderButtonSize.Value);
            foreach (var button in buttonsCustom)
                button.BorderSize = new_setting.Button_Border_Size;
        }
        //Зберегти зміни
        private void ButtonCustom_SaveAppearance_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSetting();
                MessageBox.Show("Дані збережено", "Увага");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час збереження даних", "Увага");
            }
        }
    }
}
