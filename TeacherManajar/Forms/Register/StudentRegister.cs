using TeacherManajar.ClassCode;
using System;
using System.Windows.Forms;

namespace TeacherManajar.Forms.Register
{
    /// <summary>
    /// Клас реєстрації, якщо користувач є студентом
    /// </summary>
    public partial class StudentRegister : Form
    {
        #region -> Properties
        public string FormStudy => comboBoxFormStudy.Text;
        public string EducationalDegree => comboBoxEducationalDegree.Text;
        public string Course => maskedTextBox_Course.Text;
        public string Education => bunifuTextBoxEducation.Text;
        public string NameGroup => bunifuTextBoxNameGroup.Text;
        #endregion
        public StudentRegister()
        {
            InitializeComponent();
            comboBoxFormStudy.SelectedIndex = 0;
            comboBoxEducationalDegree.SelectedIndex = 0;
            bunifuTextBoxEducation.TextChanged += (s, e) => { 
                labelEducationShort.Text = SystemProcess.Abbreviation(bunifuTextBoxEducation.Text);
                if(bunifuTextBoxEducation.Text.Length >= bunifuTextBoxEducation.MaxLength)
                {
                    bunifuSnackbar.Show(this, $"Досягнуто ліміт символів в {bunifuTextBoxEducation.MaxLength}");
                }
            };
            bunifuTextBoxNameGroup.TextChanged += (s, e) => { 
                labelGroupNameShort.Text = SystemProcess.Abbreviation(bunifuTextBoxNameGroup.Text);
                if (bunifuTextBoxNameGroup.Text.Length >= bunifuTextBoxNameGroup.MaxLength)
                {
                    bunifuSnackbar.Show(this, $"Досягнуто ліміт символів в {bunifuTextBoxNameGroup.MaxLength}");
                }
            };
            bunifuTextBoxEducation.KeyPress += (s, e) => { e.Handled = e.KeyChar == Convert.ToChar(Keys.Enter); };
            bunifuTextBoxNameGroup.KeyPress += (s, e) => { e.Handled = e.KeyChar == Convert.ToChar(Keys.Enter); };
        }
    }
}
