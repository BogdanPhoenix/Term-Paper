using System.Collections.Generic;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using System;

namespace TeacherManajar.Forms.Manajar
{
    /// <summary>
    /// Додає або надає можливість редагувати заняття
    /// </summary>
    public partial class FormAddOccution : Form
    {
        private NewOccution occution = null;
        public NewOccution Occution => occution;
        public string NewOccution => bunifuTextBoxNewOccution.Text;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="typesClasses">Список типів занять</param>
        /// <param name="occution">Об’єкт даних про про заняття</param>
        public FormAddOccution(List<string> typesClasses, NewOccution occution) : this(typesClasses)
        {
            bunifuDatePicker.Value = occution.Date;
            bunifuDropdownTypesClasses.Text = occution.TypesClasses;
            bunifuTextBoxNumberLessons.Text = occution.NumberOccution;
            bunifuCheckBoxAddToResult.Checked = occution.Add;
            bunifuButtonCreate.Text = "Редагувати";
            labelTitle.Text = "Редагувати заняття";
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="typesClasses">Список типів занять</param>
        public FormAddOccution(List<string> typesClasses)
        {
            InitializeComponent();

            bunifuDropdownTypesClasses.Items.AddRange(typesClasses.ToArray());
            bunifuDropdownTypesClasses.Items.Add("Додати новий варіант");

            bunifuTextBoxNumberLessons.KeyPress += (s, e) => { e.Handled = bunifuTextBoxNumberLessons.Text.Length == 3 && e.KeyChar != (char)Keys.Back; };
        }
        /// <summary>
        /// Метод для повернення назад на форму із журналом
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете вийти з меню створення нового заняття?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Hide();
            }
        }
        /// <summary>
        /// Метод для створення заняття
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Create_Click(object sender, EventArgs e)
        {
            occution = new NewOccution()
            {
                Date = bunifuDatePicker.Value,
                Add = bunifuCheckBoxAddToResult.Checked,
                NumberOccution = bunifuTextBoxNumberLessons.Text
            };
            if (bunifuDropdownTypesClasses.SelectedIndex == bunifuDropdownTypesClasses.Items.Count - 1)
            {
                occution.TypesClasses = bunifuTextBoxNewOccution.Text;
            }
            else
            {
                occution.TypesClasses = bunifuDropdownTypesClasses.Text;
            }
            DialogResult = DialogResult.Yes;
            Hide();
        }
        /// <summary>
        /// Метод для введення типу навчання вручну, якщо його немає в списку
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void DropdownTypesClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdownTypesClasses.SelectedIndex == bunifuDropdownTypesClasses.Items.Count - 1 && tableLayoutPanel.RowStyles[2].Height == 0)
            {
                tableLayoutPanel.RowStyles[2].Height = 50;
                Height += 50;
            }
            else
            {
                tableLayoutPanel.RowStyles[2].Height = 0;
                if (Height > MinimumSize.Height)
                {
                    Height -= 50;
                }
            }
        }
    }
}