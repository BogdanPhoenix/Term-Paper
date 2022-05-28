using TeacherManajar.ClassCode;
using System;
using System.Windows.Forms;

namespace TeacherManajar.Forms.Register
{
    /// <summary>
    /// Клас реєстрації, якщо користувач є викладачем
    /// </summary>
    public partial class TeacherRegister : Form
    {
        #region -> Properties
        public string DiplomaNumber => maskedTextBoxNumberDiplom.Text.Length == 7 ? maskedTextBoxNumberDiplom.Text : "";
        public string DiplomaSeries => maskedTextBoxNumberSeries.Text.Length == 6 ? maskedTextBoxNumberSeries.Text : "";
        public string ScientificTitle => comboBoxScientificTitle.Text;
        public string Education => bunifuTextBoxEducation.Text;
        #endregion
        /// <summary>
        /// Конструктор
        /// </summary>
        public TeacherRegister()
        {
            InitializeComponent();
            comboBoxScientificTitle.SelectedIndex = 0;
            bunifuTextBoxEducation.TextChanged += (s, e) => { labelEducationShort.Text = SystemProcess.Abbreviation(bunifuTextBoxEducation.Text); };
            bunifuTextBoxEducation.KeyPress += (s, e) => { e.Handled = e.KeyChar == Convert.ToChar(Keys.Enter); };
        }
    }
}
