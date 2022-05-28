using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Teacher_Manajar
{
    public partial class Form_Greetings : Form
    {
        public Form_Greetings()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(System_Process.ExePath, System_Process.DefaultFolder, "TeachingFoto.jpg"));
        }

        //Увійти у свій акаунт
        private void ButtonCustom_Login_Click(object sender, EventArgs e)
        {
            FormEntry entry = new FormEntry();
            entry.Show();
            Hide();
        }
        //Зареєструвати свій акаунт
        private void ButtonCustom_Registration_Click(object sender, EventArgs e)
        {
            FormRole role = new FormRole();
            role.Show();
            Hide();
        }

        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Закрити форму
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Пересування форми
        private void panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
    }
}
