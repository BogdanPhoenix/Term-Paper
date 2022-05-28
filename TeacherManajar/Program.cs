using TeacherManajar.ClassCode.DataBaseClass;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TeacherManajar
{
    /// <summary>
    /// Запуск програми
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Головна точка для входу в програму
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                DataBase.CreateConectDataBase();
                Application.Run(new FormEntry());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Виникла помилка під час підключення до бази даних. \nОсь текст помилки: {ex.Message} \nПрограма завершила свою роботу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка. \nОсь текст помилки: {ex.Message} \nПрограма завершила свою роботу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBase.CloseConectDataBase();
        }
    }
}
