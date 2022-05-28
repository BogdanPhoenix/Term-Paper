using System;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormCalendarPlan : Form
    {
        private readonly Group group = new Group();
        private readonly Setting setting = new Setting();
        //Конструктор
        public FormCalendarPlan(Group _group, Setting _setting)
        {
            InitializeComponent();
            group = _group;
            label_MagazineNameTitle.Text += group.Name_Subject + " " + System_Process.Abbreviation(group.Name_Group) + "-" + group.Course;
            setting = _setting;
            Initialize();
            AddData();
        }
        //Початкове присвоєння зовнішнього вигляду
        private void Initialize()
        {
            panel_Background.BackColor = setting.Background_Form_Color;
            dataGridView1.BackgroundColor = panel_FrontColor.BackColor = setting.Front_Form_Color;
            panel_FrontColor.ForeColor = setting.Font_Color;
        }
        //Створення полів для записів
        private void AddData()
        {
            for (int i = 0; i < group.Dates.Count; ++i)
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, group.Dates[i].ToString("dd/MM/yyyy"), group.Calendar_Plan[i]);
            }
        }
        //Вихід
        private void ButtonCustom_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Пересування форми
        private void Panel_moveShape_MouseDown(object sender, MouseEventArgs e)
        {
            System_Process.ReleaseCapture();
            System_Process.SendMessage(Handle, 0xa1, 0x2, 0);
        }
        //Згорнути форму
        private void ButtonCustom_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Оновлення та занесення даних в таблицю
        private void UpdateGroup()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Record"].Index)
                    group.Calendar_Plan[dataGridView1.CurrentCell.RowIndex] = dataGridView1.CurrentCell.Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час занесення даних в таблицю", "Увага");
            }
        }
        //Занесення записів про заняття
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
                UpdateGroup();
        }
    }
}
