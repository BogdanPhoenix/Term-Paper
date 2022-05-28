using FontAwesome.Sharp;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Bunifu.UI.WinForms;
using TeacherManajar.Enum;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Відображає користувачу всі доступні журнали до яких він належить
    /// </summary>
    public partial class FormGroup : Form
    {
        private int indexColumnGroup = 0;
        private FormGroupManager manager;
        private GroupData group = null;
        private Person teacher = null;
        private readonly AccountEmail account = null;
        private AccountEmail accountTeacher = null;
        private readonly BunifuToolTip toolTip = new BunifuToolTip();
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="account">Основні дані користувача</param>
        public FormGroup(AccountEmail account)
        {
            InitializeComponent();
            this.account = account;
            CreateGroupPanel();
        }
        /// <summary>
        /// Метод для створення інформаційній панелі для кожної групи в якій знаходиться користувач
        /// </summary>
        private void CreateGroupPanel()
        {
            MySqlDataReader sqlDataReaderIdGroup = DataBase.Select(account, VariantSelect.GroupsConnectBase);
            List<string> listIdGroup = new List<string>();
            while (sqlDataReaderIdGroup.Read())
            {
                listIdGroup.Add(sqlDataReaderIdGroup["IdGroup"].ToString());
            }
            foreach (string id in listIdGroup)
            {
                MySqlDataReader sqlDataReader = DataBase.SelectGroupsBase(id);
                sqlDataReader.Read();
                group = new GroupData();
                group.ConvertGroupFromMySql(sqlDataReader);

                accountTeacher = account.IdPerson.Equals(group.IdTeacher) ? (AccountEmail)account.Clone() : new AccountEmail() { Role = "Викладач", IdPerson = group.IdTeacher };

                MySqlDataReader sqlTeacher = DataBase.Select(accountTeacher, VariantSelect.Person);
                teacher = new Person();
                sqlTeacher.Read();
                teacher.ConvertFromMySql(sqlTeacher);

                if (indexColumnGroup == 0)
                {
                    tableLayoutPanelGroups.Height = 110;
                }
                else if (indexColumnGroup % 3 == 0)
                {
                    tableLayoutPanelGroups.RowCount++;
                    tableLayoutPanelGroups.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
                    tableLayoutPanelGroups.Height = tableLayoutPanelGroups.RowCount * 110;
                    indexColumnGroup = 0;
                }
                tableLayoutPanelGroups.Controls.Add(CreatePanelGroup(indexColumnGroup), indexColumnGroup, tableLayoutPanelGroups.RowCount - 1);
                ++indexColumnGroup;
            }
            panelBackground.Visible = tableLayoutPanelGroups.Controls.Count == 0;
        }
        /// <summary>
        /// Метод для створення панелі на якій буде виводитися стисло інформація про журнал
        /// </summary>
        /// <param name="index">Номер журналу до якої належить користувач</param>
        /// <returns>Повертає панель, на якій розміщено кнопку для переходу до журналу та основні дані журналу</returns>
        private Panel CreatePanelGroup(int index)
        {
            Panel panel = new Panel
            {
                BackColor = group.SettingGroup.Custom.BackColor,
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Margin = new Padding(5),
                Name = $"panel{index}",
                Size = new Size(325, 105),
                TabIndex = 0
            };

            panel.Controls.Add(CreateLabelTitleSubject());
            panel.Controls.Add(CreateLabelSubject());
            panel.Controls.Add(CreateLabelTitleNameGroup());
            panel.Controls.Add(CreateLabelNameGroup());
            panel.Controls.Add(CreateLabelTitleTeacher());
            panel.Controls.Add(CreateLabelTeacher());
            panel.Controls.Add(CreateIconButton());
            toolTip.SetToolTip(panel, "Будь ласка натисніть на значок групи, щоб відкрити дані про дану групу.");
            return panel;
        }
        /// <summary>
        /// Метод для створення позначки "Предмет"
        /// </summary>
        /// <returns>Повертає позначку</returns>
        private Label CreateLabelTitleSubject()
        {
            return new Label
            {
                Anchor = AnchorStyles.None,
                Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = group.SettingGroup.Custom.ForeColor,
                Location = new Point(90, 10),
                Margin = new Padding(5, 0, 5, 0),
                Name = "labelTitleSubject",
                Size = new Size(100, 25),
                TabIndex = 1,
                Text = "Предмет",
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
        /// <summary>
        /// Метод для створення позначки в які вводиться назва предмету журналу
        /// </summary>
        /// <returns>Повертає позначку</returns>
        private Label CreateLabelSubject()
        {
            ToolTip toolTip = new ToolTip();
            Label laberSubject = new Label
            {
                Anchor = AnchorStyles.None,
                Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = group.SettingGroup.Custom.ForeColor,
                Location = new Point(195, 10),
                Margin = new Padding(5, 0, 5, 0),
                Name = "labelSubject",
                Size = new Size(115, 25),
                TabIndex = 3,
                Text = SystemProcess.Abbreviation(group.Specialty),
                TextAlign = ContentAlignment.MiddleLeft
            };
            toolTip.SetToolTip(laberSubject, group.Specialty);
            return laberSubject;
        }
        /// <summary>
        /// Метод для створення позначки "Група №"
        /// </summary>
        /// <returns>Повертає позначку</returns>
        private Label CreateLabelTitleNameGroup()
        {
            return new Label
            {
                Anchor = AnchorStyles.None,
                Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = group.SettingGroup.Custom.ForeColor,
                Location = new Point(90, 40),
                Margin = new Padding(5, 0, 5, 0),
                Name = "labelTitleNameGroup",
                Size = new Size(100, 25),
                TabIndex = 1,
                Text = "Група №",
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
        /// <summary>
        /// Метод для створення позначки в які вводиться назва абревіатура групи та номер курсу
        /// </summary>
        /// <returns>Повертає позначку</returns>
        private Label CreateLabelNameGroup()
        {
            ToolTip toolTip = new ToolTip();
            Label laberSubject = new Label
            {
                Anchor = AnchorStyles.None,
                Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = group.SettingGroup.Custom.ForeColor,
                Location = new Point(200, 40),
                Margin = new Padding(5, 0, 5, 0),
                Name = "labelNameGroup",
                Size = new Size(115, 25),
                TabIndex = 3,
                Text = $"{SystemProcess.Abbreviation(group.NameSubject)} {group.Course}",
                TextAlign = ContentAlignment.MiddleLeft
            };
            toolTip.SetToolTip(laberSubject, $"{group.NameSubject} Курс №{group.Course}");
            return laberSubject;
        }
        /// <summary>
        /// Метод для створення позначки "Викладач"
        /// </summary>
        /// <returns>Повертає позначку</returns>
        private Label CreateLabelTitleTeacher()
        {
            return new Label
            {
                Anchor = AnchorStyles.None,
                Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = group.SettingGroup.Custom.ForeColor,
                Location = new Point(90, 70),
                Margin = new Padding(0),
                Name = "labelTitleTeacher",
                Size = new Size(100, 25),
                TabIndex = 2,
                Text = "Викладач",
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
        /// <summary>
        /// Метод для створення позначки в які вводиться прізвище та ініціали викладача
        /// </summary>
        /// <returns>Повертає позначку</returns>
        private Label CreateLabelTeacher()
        {
            ToolTip toolTip = new ToolTip();
            Label labelTeacher = new Label
            {
                Anchor = AnchorStyles.None,
                Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = group.SettingGroup.Custom.ForeColor,
                Location = new Point(195, 72),
                Margin = new Padding(0),
                Name = "labelTeacher",
                Size = new Size(120, 25),
                TabIndex = 4,
                Text = $"{teacher.FirstName} {teacher.Name[0]}.{teacher.Surname[0]}.",
                TextAlign = ContentAlignment.MiddleLeft
            };
            toolTip.SetToolTip(labelTeacher, $"{teacher.FirstName} {teacher.Name} {teacher.Surname}");
            return labelTeacher;
        }
        /// <summary>
        /// Метод для створення кнопки для переходу до основної інформації журналу
        /// </summary>
        /// <returns>Повертає кнопку з іконкою журналу</returns>
        private IconButton CreateIconButton()
        {
            GroupData buffer = (GroupData)group.Clone();
            IconButton button = new IconButton()
            {
                Anchor = AnchorStyles.None,
                BackColor = group.SettingGroup.Custom.BackIconColor,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                IconChar = group.SettingGroup.Custom.Icon,
                IconColor = group.SettingGroup.Custom.ForeColor,
                IconFont = IconFont.Auto,
                IconSize = 65,
                ImageAlign = ContentAlignment.TopCenter,
                Location = new Point(10, 20),
                Margin = new Padding(0),
                Name = "iconButton",
                Size = new Size(70, 65),
                TabIndex = 0,
                TabStop = false,
                UseMnemonic = false,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += (s, e) => { GroupActivate(buffer); };
            toolTip.SetToolTip(button, "Натисніть, щоб відкрити дані про групу");
            return button;
        }
        /// <summary>
        /// Метод для відкриття вибраного журналу
        /// </summary>
        /// <param name="group">Журнал який потрібно відкрити</param>
        private void GroupActivate(GroupData group)
        {
            labelNoGroups.Visible = iconPictureBoxNoGroups.Visible = tableLayoutPanelGroups.Visible = false;
            panelBackground.Visible = true;
            manager = new FormGroupManager(account, group)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelBackground.Controls.Add(manager);
            panelBackground.Tag = manager;
            manager.BringToFront();
            manager.Show();
        }
    }
}