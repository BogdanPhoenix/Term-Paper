using System;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Custom;
using System.Drawing;

namespace Teacher_Manajar
{
    enum PersonData
    {
        ID,
        Link_Foto,
        First_Name,
        Name,
        Surname,
        University,
        Course,
        Group,
        Email,
        Password,
        Role,
        Diploma_Number,
        Scientific_Title
    }

    static class System_Process
    {
        public static string ExePath { get => AppDomain.CurrentDomain.BaseDirectory; }
        public static string GroupDirectory { get => "Groups"; }
        public static string StudentDirextory { get => "Students"; }
        public static string TeacherDirectory { get => "Teachers"; }
        public static string RootDirectory { get => "Account"; }
        public static string DefaultFotoUser { get => "User.png"; }
        public static string DefaultFolder { get => "Default"; }
        public static string Setting_File { get => "Setting.json"; }
        //Пошук акаунту за введеним логіном
        static public T Find_Account<T>(string data, string role)
        {
            T person = default;
            try
            {
                string combine = Path.Combine(ExePath, RootDirectory, role, "User " + data);

                if (!Directory.Exists(combine))
                    throw new Exception();

                combine = Path.Combine(combine, data + ".json");
                if (!File.Exists(combine))
                    throw new Exception();
                person = JsonConvert.DeserializeObject<T>(File.ReadAllText(combine));
            }
            catch (Exception) { }
            return person;
        }

        /*
         * SendMessage - викликає віконну процедуру для зазначеного вікна і не повертається, доки віконна процедура не обробить повідомлення
         * hWnd - дескриптор вікна, який призначений для отримання повідомлення
         * Msg - повідомлення яке необхідно опублікувати
         * wParam - додаткова інформація про повідомлення
         * lParam - додаткова інформація про повідомлення
         */
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /*
         * Звільняє захоплення мишею з вікна в поточному потоці та відновлює нормальну обробку введення мишею. 
         * Вікно, яке захопило мишу, отримує всі дані, введені мишею, незалежно від положення курсору, за 
         * винятком випадків натискання кнопки миші, коли гаряча точка курсору знаходиться у вікні іншого потоку.
         */
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //Створення абрувіатури
        public static string Abbreviation(string value)
        {
            var pattern = @"((?<=^|\s)(\w{1})|([A-Z]))";
            return string.Join(string.Empty, Regex.Matches(value, pattern).OfType<Match>().Select(x => x.Value.ToUpper()));
        }
        //Перевірка чи поле порожнє
        public static bool CheckField(string value)
        {
            return value == string.Empty;
        }
        //Перевірка чи існує акаунт з таким логіном
        public static bool CheckAccount(IPerson person, string name_directory)
        {
            if (Directory.Exists(Path.Combine(ExePath, name_directory, "User " + person.Email)))
            {
                MessageBox.Show("Акаунт з таким логіном вже існує. Спробуйте іще раз", "Увага");
                return false;
            }
            return true;
        }
        //Пошук студента для групи
        public static List<StudentGroup> FindStudent(string group, string course)
        {
            List<StudentGroup> student_list = new List<StudentGroup>();
            string combine = Path.Combine(ExePath, RootDirectory, StudentDirextory);
            if (!Directory.Exists(Path.Combine(combine)))
                throw new Exception();
            List<string> group_file = new List<string>();

            foreach (var catalog in Directory.GetDirectories(Path.Combine(combine)))
            {
                group_file.AddRange(Directory.GetFiles(catalog, "*.json"));
                foreach (var data_person in group_file)
                {
                    Student student = JsonConvert.DeserializeObject<Student>(File.ReadAllText(data_person));
                    if (string.Compare(student.Role, "Student", StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(student.Group, group, StringComparison.OrdinalIgnoreCase) == 0 && student.Course.ToString() == course)
                    {
                        student_list.Add(ConvertStudent(student));
                    }
                }
                group_file.Clear();
            }
            return student_list;
        }
        //Конвертація приватних даних студента в публічні
        private static StudentGroup ConvertStudent(Student stud)
        {
            StudentGroup student_buffer = new StudentGroup
            {
                Id = stud.Id,
                First_Name = stud.First_Name,
                Name = stud.Name,
                Surname = stud.Surname,
                University = stud.University,
                Course = stud.Course,
                Group = stud.Group,
                Email = stud.Email,
                Evaluation = new List<string>()
            };
            return student_buffer;
        }
        //Конвертація приватних даних викладача в публічні
        public static TeacherGroup ConvertTeacher(Teacher teacher)
        {
            TeacherGroup teacher_buffer = new TeacherGroup
            {
                Id = teacher.Id,
                First_Name = teacher.First_Name,
                Name = teacher.Name,
                Surname = teacher.Surname,
                Email = teacher.Email
            };
            return teacher_buffer;
        }
        //Перевірка чи можна активувати кнопки
        public static bool CheckWarning(List<Label> warning)
        {
            foreach (var label in warning)
            {
                if (label.Visible)
                {
                    return false;
                }
            }
            return true;
        }
        //Перемалювання кнопок
        public static void OnPaintButton(List<ButtonCustom> buttonsCustom, Setting setting, int index = 0)
        {
            for (; index < buttonsCustom.Count; ++index)
            {
                buttonsCustom[index].BackgroundColor = setting.Button_Background;
                buttonsCustom[index].BorderColor = setting.Button_Border_Color;
                buttonsCustom[index].BorderSize = setting.Button_Border_Size;
                buttonsCustom[index].TextColor = setting.Button_Text_Color;
            }
        }
        //Визначення наступної позиції для кнопок групи
        public static void NextPositionButton(ref int left, ref int top, ButtonCustom button, Panel panel)
        {
            if (left >= panel.Width - 10)
            {
                left = 10;
                top += 10 + button.Height;
            }
            if (top >= panel.Height)
            {
                panel.Height += button.Height + 10;
            }
        }
        //Додати кнопку
        public static ButtonCustom AddButton(Group groupdata)
        {
            ButtonCustom button = new ButtonCustom
            {
                Name = "button_" + Abbreviation(groupdata.Name_Subject) + groupdata.Course,
                Text = "Група: " + Abbreviation(groupdata.Name_Group) + "-" + groupdata.Course + "\nПредмет: " + System_Process.Abbreviation(groupdata.Name_Subject),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0),
                Size = new Size(200, 60),
                Cursor = Cursors.Hand
            };

            return button;
        }
        //Налаштування аватарки
        public static IPrivateInfo SettingAvatar(IPerson person, ref Setting setting)
        {
            FormSettingAvatarFoto form_SettingAvatar = new FormSettingAvatarFoto(person, setting);
            form_SettingAvatar.ShowDialog();
            setting = form_SettingAvatar.Setting_Parametr;
            return form_SettingAvatar.PrivateInfo;
        }
        //Налаштування палітри кольорів
        public static Setting SettingPalitraColor(IPerson person, Setting setting)
        {
            FormSettingAppearance form_SettingAppearance = new FormSettingAppearance(person, setting);
            form_SettingAppearance.ShowDialog();
            return form_SettingAppearance.Setting;
        }
        //Налаштування персональних даних
        public static IPerson SettingPersonalData(IPerson person, Setting setting)
        {
            FormSettingPersonData setting_form = new FormSettingPersonData(person, setting);
            setting_form.ShowDialog();
            return setting_form.Person;
        }
        //Видалення акаунту
        public static void DeleteAccount(IPerson person)
        {
            IPrivateInfo privateInfo = (IPrivateInfo)person;
            string role = privateInfo.Role == "Teacher" ? TeacherDirectory : StudentDirextory;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Directory.Delete(Path.Combine(ExePath, RootDirectory, role, "User " + person.Email), true);
        }
    }
}
