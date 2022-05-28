using Custom;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teacher_Manajar
{
    public partial class FormChooseData : Form
    {
        private readonly Setting setting = new Setting();
        private readonly List<ButtonCustom> buttonCustoms = new List<ButtonCustom>();
        //Вибір дати для нового стовпчика
        public DateTime Date { get; private set; }
        //Конструктор
        public FormChooseData(Setting _setting)
        {
            InitializeComponent();
            setting = _setting;
            Initialize();
        }
        //Присвоєння початкових значень та зміна зовнішнього вигляду
        private void Initialize()
        {
            panel_Background.BackColor = setting.Background_Form_Color;
            panel_FrontColor.BackColor = setting.Front_Form_Color;
            panel_FrontColor.ForeColor = setting.Font_Color;

            buttonCustoms.Add(buttonCustom_Close);
            buttonCustoms.Add(buttonCustom_Next);

            System_Process.OnPaintButton(buttonCustoms, setting);
        }
        //Присвоєння дати
        private void ButtonCustom_Next_Click(object sender, EventArgs e)
        {
            Date = monthCalendar1.SelectionStart.Date;
            DialogResult = DialogResult.OK;
        }
        //Відмінна вибору дати
        private void ButtonCustom_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
