using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeacherManajar.ClassCode.DataBaseClass;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Відображення та вибір віджетів користувача
    /// </summary>
    public partial class FormWidgets : Form
    {
        private readonly Panel downBorderBtn = new Panel { Size = new Size(60, 15), Visible = false };
        private readonly Label labelCopy = new Label()
        {
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204),
            ForeColor = Color.White,
            Name = "labelCopy",
            Dock = DockStyle.Fill,
            Size = new Size(150, 20),
            TabIndex = 1,
            Text = "Скопійовано в буфер",
            TextAlign = ContentAlignment.MiddleCenter
        };
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="accountEmail">Основні дані користувача</param>
        public FormWidgets(AccountEmail accountEmail)
        {
            InitializeComponent();

            iconButtonID.MouseEnter += (s, e) => { iconButtonID.Text = accountEmail.IdPerson; };
            iconButtonID.Controls.Add(downBorderBtn);
        }
        /// <summary>
        /// Метод для повернення кнопки до того вигляду, яке було в неї до моменту копіювання
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void IconButtonID_MouseLeave(object sender, EventArgs e)
        {
            iconButtonID.Text = "Ваш ID";
            if (downBorderBtn.Visible)
            {
                downBorderBtn.Visible = false;
            }
        }
        /// <summary>
        /// Метод для копіювання даних в буфер обміну та відображення того, що дані було скопійовано
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void IconButtonID_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(iconButtonID.Text, true, 2, 1);
            downBorderBtn.BackColor = Color.FromArgb(253, 138, 114);
            downBorderBtn.Dock = DockStyle.Bottom;
            downBorderBtn.Controls.Add(labelCopy);
            downBorderBtn.Visible = true;
            downBorderBtn.BringToFront();
        }
        /// <summary>
        /// Метод для відображення віджетів
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void FormWidgets_Load(object sender, EventArgs e)
        {
            foreach (BunifuCards element in tableLayoutPanel3.Controls.OfType<BunifuCards>())
            {
                bunifuTransition1.ShowSync(element, false, Animation.Mosaic);
            }
        }
    }
}