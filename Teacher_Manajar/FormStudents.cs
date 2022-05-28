using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormStudents : Form
    {
        //Анкета яку необхідно заповнити
        private readonly Student student = new Student();
        private readonly Setting setting = new Setting();
        //Шлях до фото для аватарки
        private string link_foto = string.Empty;
        //Список для перевірки чи всі поля заповненні
        private readonly List<Label> warning = new List<Label>();
        //Конструктор
        public FormStudents()
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
            warning.Add(label_warningGroup);
            warning.Add(label_warningEmail);
            warning.Add(label_warningPassword);
        }
        //Кнопка реєстрації акаунта
        private void ButtonCustom_Register_Click(object sender, EventArgs e)
        {
            try
            {
                AddData();
                if (System_Process.CheckAccount(student, Path.Combine(System_Process.RootDirectory, System_Process.StudentDirextory)))
                {
                    string user_directory = Path.Combine(System_Process.RootDirectory, System_Process.StudentDirextory, "User " + student.Email);
                    string user_foto = Path.Combine(user_directory, student.Previous_Link_Foto[student.Previous_Link_Foto.Count - 1]);
                    string user_data = Path.Combine(user_directory, student.Email + ".json");

                    Directory.CreateDirectory(Path.Combine(System_Process.ExePath, user_directory));
                    File.Copy(link_foto, Path.Combine(System_Process.ExePath, user_foto));
                    string json = JsonConvert.SerializeObject(student, Formatting.Indented);
                    File.WriteAllText(Path.Combine(System_Process.ExePath, user_data), json);

                    File.WriteAllText(Path.Combine(System_Process.ExePath, user_directory, System_Process.Setting_File), JsonConvert.SerializeObject(setting, Formatting.Indented));

                    MessageBox.Show("Ваш акаунт створено", "Повідомлення");

                    StudentOffice form_student = new StudentOffice(student);
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
            student.First_Name = MyTextBox_FirstName.Texts;
            student.Name = MyTextBox_Name.Texts;
            student.Surname = MyTextBox_Surname.Texts;
            student.University = MyTextBox_University.Texts;
            student.Course = Convert.ToUInt32(MaskedTextBox_Course.Text);
            student.Group = MyTextBox_Group.Texts;
            student.Email = MyTextBox_Email.Texts;
            student.Password = MyTextBox_Password.Texts;
            student.Role = "Student";
            student.Evaluation = null;
            student.Id = Guid.NewGuid().ToString();
            student.Previous_Link_Foto = new List<string>();
            student.Previous_Link_Foto.Add("Avatar_Foto_" + student.Previous_Link_Foto.Count + Path.GetExtension(link_foto));
            student.Now_Link_Foto = student.Previous_Link_Foto[0];
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
            MaskedTextBox_Course.Enabled = !label_warningUniversity.Visible;
        }

        private void MaskedTextBox_Course_TextChanged(object sender, EventArgs e)
        {
            label_warningCourse.Visible = MaskedTextBox_Course.Text.Length != 1;
            MyTextBox_Group.Enabled = !label_warningCourse.Visible;
        }

        private void MyTextBox_Group__TextChanger(object sender, EventArgs e)
        {
            label_warningGroup.Visible = System_Process.CheckField(MyTextBox_Group.Texts);
            MyTextBox_Email.Enabled = !label_warningGroup.Visible;
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
            foreach(var label in warning)
            {
                if (label.Visible)
                {
                    ButtonCustom_Register.Enabled = false;
                    return;
                }
            }
            ButtonCustom_Register.Enabled = link_foto != string.Empty && label_warningRepeadPassword.Text == "Паролі співпадають";
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
