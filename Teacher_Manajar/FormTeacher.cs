using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormTeacher : Form
    {
        //Об'єкт класу який зберігає інформацію про нового користувача
        private readonly Teacher teacher = new Teacher();
        private readonly Setting setting = new Setting();
        //Шлях до фото для аватарки
        private string link_foto = string.Empty;
        //Список для перевірки чи всі поля заповненні
        private readonly List<Label> warning = new List<Label>();
        //Конструктор
        public FormTeacher()
        {
            InitializeComponent();
            rjCircularPictureBox1.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, System_Process.DefaultFotoUser));
            ButtonCustom_Register.Enabled = false;
            Timer_ButtonRegister.Start();
            InitializeData();
        }

        //Перерахунок необхідних компонентів для перевірки чи всі поля заповнено
        private void InitializeData()
        {
            warning.Add(label_warningEmail);
            warning.Add(label_warningFirstName);
            warning.Add(label_warningSurname);
            warning.Add(label_warningUniversity);
            warning.Add(label_warningDiplomaSeries);
            warning.Add(label_warningDiplomaNumber);
            warning.Add(label_warningScientificTitle);
            warning.Add(label_warningEmail);
            warning.Add(label_warningPassword);
        }
        //Кнопка реєстрації акаунта
        private void ButtonCustom_Register_Click(object sender, EventArgs e)
        {
            try
            {
                AddData();
                if (System_Process.CheckAccount(teacher, Path.Combine(System_Process.RootDirectory, System_Process.TeacherDirectory)))
                {
                    string user_directory = Path.Combine(Path.Combine(System_Process.RootDirectory, System_Process.TeacherDirectory), "User " + teacher.Email);
                    string user_foto = Path.Combine(user_directory, teacher.Previous_Link_Foto[teacher.Previous_Link_Foto.Count - 1]);
                    string user_data = Path.Combine(user_directory, teacher.Email + ".json");

                    Directory.CreateDirectory(Path.Combine(System_Process.ExePath, user_directory));
                    File.Copy(link_foto, Path.Combine(System_Process.ExePath, user_foto));
                    string json = JsonConvert.SerializeObject(teacher, Formatting.Indented);
                    File.WriteAllText(Path.Combine(System_Process.ExePath, user_data), json);
                    File.WriteAllText(Path.Combine(System_Process.ExePath, user_directory, System_Process.Setting_File), JsonConvert.SerializeObject(setting, Formatting.Indented));

                    MessageBox.Show("Ваш акаунт створено", "Повідомлення");

                    TeacherOffice form_student = new TeacherOffice(teacher);
                    form_student.Show();
                    Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка", "Увага");
            }
        }
        //Занесення даних про особу
        private void AddData()
        {
            teacher.First_Name = MyTextBox_FirstName.Texts;
            teacher.Name = MyTextBox_Name.Texts;
            teacher.Surname = MyTextBox_Surname.Texts;
            teacher.University = MyTextBox_University.Texts;
            teacher.Scientific_Title = MyTextBox_Scientific_Title.Texts;
            teacher.Diploma_Number = MaskedTextBox_Diploma_Number.Text.ToString();
            teacher.Diploma_Series = MaskedTextBox_Diploma_Series.Text.ToString();
            teacher.Email = MyTextBox_Email.Texts;
            teacher.Password = MyTextBox_Password.Texts;
            teacher.Role = "Teacher";
            teacher.Id = Guid.NewGuid().ToString();
            teacher.Previous_Link_Foto = new List<string>();
            teacher.Previous_Link_Foto.Add("Avatar_Foto_" + teacher.Previous_Link_Foto.Count + Path.GetExtension(link_foto));
            teacher.Now_Link_Foto = teacher.Previous_Link_Foto[0];
        }
        //Вибір фото для аватарки
        private void ButtonCustom_AvatarFoto_Click(object sender, EventArgs e)
        {
            string remember_link = link_foto;
            if (remember_link == string.Empty)
                remember_link = Path.Combine(System_Process.ExePath, System_Process.DefaultFotoUser);

            openFileDialog1.Filter = "Type file(*.jpg)| *.jpg|Type file(*.png)|*.png|Type file(*.bmp)|*.bmp|Type file(*.psd)|*.psd|Type file(*.tga)|*.tga";
            link_foto = openFileDialog1.ShowDialog() == DialogResult.OK ? openFileDialog1.FileName : "";
            if (link_foto == string.Empty)
            {
                MessageBox.Show("Ви не вибрали фото для аватарки.", "Увага");
                link_foto = remember_link;
            }
            else
                rjCircularPictureBox1.Image = Image.FromFile(link_foto);
        }

        //Згорнути вікно
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Закрити програму
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Перетягування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        /*
         * Перевірка чи всі поля заповнено
         */
        private void MyTextBox_FirstName__TextChanger(object sender, EventArgs e)
        {
            label_warningFirstName.Visible = System_Process.CheckField(MyTextBox_FirstName.Texts);
            MyTextBox_Name.Enabled = !label_warningFirstName.Visible;
        }

        private void MyTextBox_Name__TextChanger(object sender, EventArgs e)
        {
            label_warningName.Visible = System_Process.CheckField(MyTextBox_Name.Texts);
            MyTextBox_Surname.Enabled = !label_warningName.Visible;
        }


        private void MyTextBox_Surname__TextChanger(object sender, EventArgs e)
        {
            label_warningSurname.Visible = System_Process.CheckField(MyTextBox_Surname.Texts);
            MyTextBox_University.Enabled = !label_warningSurname.Visible;
        }

        private void MyTextBox_University__TextChanger(object sender, EventArgs e)
        {
            label_warningUniversity.Visible = System_Process.CheckField(MyTextBox_University.Texts);
            MaskedTextBox_Diploma_Series.Enabled = !label_warningUniversity.Visible;
        }

        private void MaskedTextBox_Diploma_Series_TextChanged(object sender, EventArgs e)
        {
            label_warningDiplomaSeries.Visible = MaskedTextBox_Diploma_Series.Text.Length != 6;
            MaskedTextBox_Diploma_Number.Enabled = !label_warningDiplomaSeries.Visible;
        }
        private void MaskedTextBox_Diploma_Number_TextChanged(object sender, EventArgs e)
        {
            label_warningDiplomaNumber.Visible = MaskedTextBox_Diploma_Number.Text.Length != 7;
            MyTextBox_Scientific_Title.Enabled = !label_warningDiplomaNumber.Visible;
        }
        private void MyTextBox_Scientific_Title__TextChanger(object sender, EventArgs e)
        {
            label_warningScientificTitle.Visible = System_Process.CheckField(MyTextBox_Scientific_Title.Texts);
            MyTextBox_Email.Enabled = !label_warningScientificTitle.Visible;
        }

        private void MyTextBox_Email__TextChanger(object sender, EventArgs e)
        {
            label_warningEmail.Visible = System_Process.CheckField(MyTextBox_Email.Texts);
            MyTextBox_Password.Enabled = !label_warningEmail.Visible;
        }

        private void MyTextBox_Password__TextChanger(object sender, EventArgs e)
        {
            label_warningPassword.Visible = System_Process.CheckField(MyTextBox_Password.Texts);
            MyTextBox_RepeatPassword.Enabled = !label_warningPassword.Visible;
            CheckPassword();
        }

        private void MyTextBox_RepeatPassword__TextChanger(object sender, EventArgs e)
        {
            CheckPassword();
        }

        /*
        * Маска, щоб користувач не вводив цифри
        */
        private void MyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NotDiginAndSymbol(e.KeyChar))
                e.Handled = true;
        }

        //Перевірка чи паролі співпадають
        private void CheckPassword()
        {
            if (MyTextBox_RepeatPassword.Texts != string.Empty)
            {
                label_warningRepeadPassword.ForeColor = MyTextBox_Password.Texts == MyTextBox_RepeatPassword.Texts ? Color.Green : Color.Red;
                label_warningRepeadPassword.Text = MyTextBox_Password.Texts == MyTextBox_RepeatPassword.Texts ? "Паролі співпадають" : "Паролі не співпадають";
            }
        }
        //Перевірка чи всі поля заповнені і чи можна активувати кнопку для реєстрації
        private void Timer_ButtonRegister_Tick(object sender, EventArgs e)
        {
            ButtonCustom_Register.Enabled = System_Process.CheckWarning(warning) && link_foto != string.Empty && label_warningRepeadPassword.Text == "Паролі співпадають";
        }
        //Визначення які символи можна вводити, а які ні
        private bool NotDiginAndSymbol(char key)
        {
            return (char.IsDigit(key) || char.IsSymbol(key));
        }

        private void ButtonCustom_goBack_Click(object sender, EventArgs e)
        {
            FormRole role = new FormRole();
            role.Show();
            Close();
        }
    }
}
