using System;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        //Згорнути вікно
        private void buttonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Закрити програму
        private void buttonCustom_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Пересування форми
        private void panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Перехід до форми реєстрації викладача
        private void buttonCustomTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher teacher = new FormTeacher();
            teacher.Show();
            Close();
        }
        //Перехід до форми реєстрації студента
        private void buttonCustom_Student_Click(object sender, EventArgs e)
        {
            FormStudents student = new FormStudents();
            student.Show();
            Close();
        }
        //Кнопка входу
        private void buttonCustom_Entry_Click(object sender, EventArgs e)
        {
            FormEntry entry = new FormEntry();
            entry.Show();
            Close();
        }
    }
}
