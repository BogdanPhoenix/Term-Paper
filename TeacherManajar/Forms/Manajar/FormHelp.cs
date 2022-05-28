using System.Windows.Forms;
using TeacherManajar.ClassCode;

namespace TeacherManajar.Forms.Manajar
{
    /// <summary>
    /// Клас для виведення інформації користувачу, як саме потрібно користуватися тим чи іншим вікном програми
    /// </summary>
    public partial class FormHelp : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormHelp()
        {
            InitializeComponent();
            bunifuButtonClose.Click += (s, e) => { Hide(); };
        }
        /// <summary>
        /// Метод для переміщення форми
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей миші і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void PanelMoveShape_MouseDown(object sender, MouseEventArgs e)
        {
            SystemProcess.ReleaseCapture();
            SystemProcess.SendMessage(Handle);
        }
    }
}