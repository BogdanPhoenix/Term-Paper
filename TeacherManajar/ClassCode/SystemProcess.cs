using Bunifu.UI.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace TeacherManajar.ClassCode
{
    /// <summary>
    /// Клас для реалізації функціоналу програми, який використовується в різних класах
    /// </summary>
    static class SystemProcess
    {
        public static string ExePath { get => AppDomain.CurrentDomain.BaseDirectory; }
        public static string AvatarFoto { get => Path.Combine(ExePath, "Image"); }

        
        /// <summary>
        /// Викликає віконну процедуру для зазначеного вікна і не повертається, доки віконна процедура не обробить повідомлення
        /// </summary>
        /// <param name="hWnd">Дескриптор вікна, який призначений для отримання повідомлення</param>
        /// <param name="Msg">Повідомлення яке необхідно опублікувати</param>
        /// <param name="wParam">Додаткова інформація про повідомлення</param>
        /// <param name="lParam">Додаткова інформація про повідомлення</param>
        /// <returns>Повертає одне із значень перерахування System.Windows.Forms.DialogResult</returns>
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg = 0xa1, int wParam = 0x2, int lParam = 0);
        /// <summary>
        /// Звільняє захоплення мишею з вікна в поточному потоці та відновлює нормальну обробку введення мишею
        /// </summary>
        /// <returns>Якщо функція виконується успішно, повертається значення відмінне від нуля</returns>
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// Метод для отримати номер комірки в таблиці
        /// </summary>
        /// <param name="tlp">Панель в якій перевіряється комірка</param>
        /// <param name="point">Координати курсора над таблицею в момент натиску на клавішу</param>
        /// <returns>Повертає координати комірки в якій було натиснено клавішу миші</returns>
        public static Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }
        /// <summary>
        /// Метод для створення абревіатури
        /// </summary>
        /// <param name="value">Рядок з якого потрібно отримати абревіатуру</param>
        /// <returns>Повертає рядок лише з перших букв кожного слова з речення</returns>
        public static string Abbreviation(string value)
        {
            var pattern = @"((?<=^|\s)(\w{1})|([A-Z]))";
            return string.Join(string.Empty, Regex.Matches(value, pattern).OfType<Match>().Select(x => x.Value.ToUpper()));
        }
        /// <summary>
        /// Метод для кодування паролю користувача в базу даних
        /// </summary>
        /// <param name="password">Пароль користувача</param>
        /// <returns>Повертає закодований пароль користувача</returns>
        public static string StringCheckPassword(string password)
        {
            string resultConvertPassword;
            using (MD5 md5 = MD5.Create())
            {
                byte[] passwordHash = Encoding.UTF8.GetBytes(password);
                byte[] passwordHashCode = md5.ComputeHash(passwordHash);
                resultConvertPassword = Convert.ToBase64String(passwordHashCode);
            }
            return resultConvertPassword;
        }
        /// <summary>
        /// Метод для декодування паролю користувача з байтів в хеш рядок
        /// </summary>
        /// <param name="array">Масив байтів</param>
        /// <returns>Повертає хеш пароль</returns>
        public static string GetPasswordTranslate(byte[] array)
        {
            string value = Encoding.UTF8.GetString(array);
            return value.Substring(0, value.IndexOf("\0"));
        }
        /// <summary>
        /// Метод для перетворення одинарних лапок та слеш в спеціальні символи, щоб їх можна було занести в базу даних
        /// </summary>
        /// <param name="text">Текст в якому потрібно замінити символи</param>
        /// <returns>Повертає змінений рядок</returns>
        public static string ConvertTextToMySQL(string text)
        {
            text = text.Replace("\"", "*");
            return text.Replace("'", "^");
        }
        /// <summary>
        /// Метод для перетворення спеціальних символів в ті, які були ними замінені
        /// </summary>
        /// <param name="text">Текст в якому потрібно замінити символи</param>
        /// <returns>Повертає змінений рядок</returns>
        public static string ConvertMySQLToText(string text)
        {
            text = text.Replace("*", "\"");
            return text.Replace("^", "'");
        }
        /// <summary>
        /// Метод для приховування введених даних для поле для пароля
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        public static void PasswordEnter(object sender, EventArgs e)
        {
            BunifuTextBox password = (BunifuTextBox)sender;
            if(password.Text.Length != 0 && password.PasswordChar.Equals('\0'))
            {
                PasswordLeave(sender, e);
            }
            else
            {
                password.PasswordChar = '*';
                password.PlaceholderText = "";
            }
        }
        /// <summary>
        /// Метод для вимкнення режиму приховування даних в полі для введення паролю, якщо воно є пустим
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        public static void PasswordLeave(object sender, EventArgs e)
        {
            BunifuTextBox password = (BunifuTextBox)sender;
            if(password.Text.Length == 0)
            {
                password.PasswordChar = '\0';
                password.PlaceholderText = password.Tag.ToString();
            }
        }
        /// <summary>
        /// Метод для зміни відображення індикатора того чи вимкнений чи увімкнений режим приховування даних в полі для введення паролю
        /// </summary>
        /// <param name="textBox">Текстове поле для перевірки</param>
        public static void TextBoxOnIconRightClick(BunifuTextBox textBox)
        {
            if (textBox.PasswordChar.Equals('*'))
            {
                textBox.IconRight = Properties.Resources.eye_45px;
                textBox.PasswordChar = '\0';
            }
            else
            {
                textBox.IconRight = Properties.Resources.closed_eye_45px;
                textBox.PasswordChar = '*';
            }
        }
    }
}
