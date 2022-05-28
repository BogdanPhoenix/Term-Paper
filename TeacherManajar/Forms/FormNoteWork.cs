using TeacherManajar.Enum;
using System;
using System.Windows.Forms;
using RJCodeAdvance.RJControls;
using System.Drawing;
using FontAwesome.Sharp;
using System.Collections.Generic;
using TeacherManajar.ClassCode;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Клас для створення або редагування нотаток або списків справ
    /// </summary>
    public partial class FormNoteWork : Form
    {
        private RJTextBox textBoxNotesTitle, textBoxNotesText;
        private TableLayoutPanel tableLayoutPanelCheckList;
        private Panel panelCheck, panelCheckBox;
        private IconButton buttonAddCheck;
        private WindowType windowType = WindowType.NotesText;
        private ManagerCommand command = ManagerCommand.None;
        private List<ListCheck> chechLists = null;
        private string title;
        private string text;
        private const int indexTextBox = 0, indexCheckBox = 1, rowHeight = 65;

        /// <summary>
        /// Повертає заголовок нотатки
        /// </summary>
        public string NotesTitle { get => title; }
        /// <summary>
        /// Повертає текстворий вміст нотатки, якщо користувач вибрав тип нотатки "Текст"
        /// </summary>
        public string NotesText { get => text; }
        /// <summary>
        /// Повертає команду для виконання
        /// </summary>
        public ManagerCommand Command { get => command; }
        /// <summary>
        /// Повертає тип нотатки
        /// </summary>
        public WindowType WindowType { get => windowType; }
        /// <summary>
        /// Повертає список справ
        /// </summary>
        public List<ListCheck> NotesChechLists { get => chechLists; }
        /// <summary>
        /// Конструктор для створення або редагування нотатки
        /// </summary>
        /// <param name="title">Заголовок нотатки</param>
        /// <param name="text">Текстовий зміст нотатки для варіанту "Текст"</param>
        public FormNoteWork(string title, string text)
        {
            InitializeStart(title);
            this.text = text;

            CreateText();
            tableLayoutPanel1.Controls.Add(textBoxNotesText, 0, 1);
            iconButtonDelete.Enabled = !title.Equals("") && !text.Equals("");
        }
        /// <summary>
        /// Конструктор за замовчуванням
        /// </summary>
        public FormNoteWork() : this("", "") { }
        /// <summary>
        /// Конструктор для створення або редагування списку справ
        /// </summary>
        /// <param name="title">Заголовок нотатки</param>
        /// <param name="chechLists">Перерахування списку пунктів справ</param>
        public FormNoteWork(string title, List<ListCheck> chechLists)
        {
            InitializeStart(title);
            this.chechLists = new List<ListCheck>();
            this.chechLists.AddRange(chechLists);

            CreateTableCheckList();
            tableLayoutPanel1.Controls.Add(tableLayoutPanelCheckList, 0, 1);
            ReadCheckList();
            iconButtonDelete.Enabled = !title.Equals("") && chechLists.Count != 0;
        }
        /// <summary>
        /// Метод для заповнення початкового коду всіх конструкторів
        /// </summary>
        /// <param name="title">Заголовок нотатки або списку справ</param>
        private void InitializeStart(string title)
        {
            InitializeComponent();
            this.title = title;
            CreateTitle();
            tableLayoutPanel1.Controls.Add(textBoxNotesTitle, 0, 0);
            iconButtonSave.Click += (s, e) => { Save(); iconButtonSave.Enabled = false; };
        }
        /// <summary>
        /// Метод для зберігання зміни, які відбулися з вмістом нотатки або списку справ
        /// </summary>
        private void Save()
        {
            title = textBoxNotesTitle.Texts;
            switch (windowType)
            {
                case WindowType.NotesText:
                    text = textBoxNotesText.Texts;
                    break;
                case WindowType.NotesCheckList:
                    chechLists.Clear();
                    foreach (Control panel in tableLayoutPanelCheckList.Controls)
                    {
                        ListCheck notesChechList = new ListCheck
                        {
                            Check = ((CheckBox)panel.Controls[indexCheckBox]).Checked,
                            Text = ((RJTextBox)panel.Controls[indexTextBox]).Texts
                        };
                        chechLists.Add(notesChechList);
                    }
                    break;
            }
            command = ManagerCommand.Save;
        }
        /// <summary>
        /// Метод для перевірки чи відбулися зміни у списку справ
        /// </summary>
        /// <returns>Повертає значення true, якщо список є порожнім або кількість елементів списку що вводився відрізняється від поточного або вміст списку змінився, в іншому випадку повертає значення false</returns>
        private bool CheckEquals()
        {
            if (chechLists.Count == 0 || chechLists.Count != tableLayoutPanelCheckList.RowCount)
            {
                return true;
            }
            int index = 0;
            foreach (ListCheck notesChech in chechLists)
            {
                Panel panel = (Panel)tableLayoutPanelCheckList.GetControlFromPosition(0, index++);
                CheckBox checkBox = (CheckBox)panel.Controls[indexCheckBox];
                RJTextBox textBox = (RJTextBox)panel.Controls[indexTextBox];
                if (!checkBox.Equals(notesChech.Check) || !textBox.Equals(notesChech.Text))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Метод для перевірки чи потрібно активувати кнопку для зберігання змін
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void CheckSave(object sender, EventArgs e)
        {
            switch (windowType)
            {
                case WindowType.NotesText:
                    iconButtonSave.Enabled = !title.Equals(textBoxNotesTitle.Texts) || !text.Equals(textBoxNotesText.Texts);
                    break;
                case WindowType.NotesCheckList:
                    iconButtonSave.Enabled = !title.Equals(textBoxNotesTitle.Texts) || CheckEquals();
                    break;
            }
        }
        /// <summary>
        /// Метод для створення заголовку нотатки
        /// </summary>
        private void CreateTitle()
        {
            textBoxNotesTitle = new RJTextBox()
            {
                BackColor = Color.FromArgb(34, 33, 74),
                BorderColor = Color.FromArgb(34, 33, 74),
                BorderFocusColor = Color.FromArgb(34, 33, 74),
                BorderRadius = 0,
                BorderSize = 1,
                Dock = DockStyle.Fill,
                Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.White,
                Location = new Point(0, 0),
                Margin = new Padding(0, 0, 0, 5),
                Multiline = true,
                Name = "textBoxNotesTitle",
                Padding = new Padding(7),
                PasswordChar = false,
                PlaceholderColor = Color.DarkGray,
                PlaceholderText = title.Equals("") ? "Заголовок" : "",
                Size = new Size(700, 40),
                TabIndex = 0,
                Texts = title,
                UnderlinedStyle = false
            };
            textBoxNotesTitle._TextChanged += CheckSave;
            textBoxNotesTitle.KeyPress += (s, e) => { e.Handled = e.KeyChar.Equals(Keys.Enter); };
            textBoxNotesTitle.KeyPress += ReplaceDoubleQuotes;
        }
        /// <summary>
        /// Метод для створення текстового поля нотатки, якщо вибраний варіант "Текст"
        /// </summary>
        private void CreateText()
        {
            windowType = WindowType.NotesText;
            iconButtonCheckList.Enabled = true;
            iconButtonText.Enabled = false;

            textBoxNotesText = new RJTextBox()
            {
                BackColor = Color.FromArgb(34, 33, 74),
                BorderColor = Color.FromArgb(34, 33, 74),
                BorderFocusColor = Color.FromArgb(34, 33, 74),
                BorderRadius = 0,
                BorderSize = 1,
                Dock = DockStyle.Fill,
                Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = Color.White,
                Location = new Point(0, 45),
                Margin = new Padding(0, 0, 0, 5),
                Multiline = true,
                Name = "textBoxNotesText",
                Padding = new Padding(10, 7, 10, 7),
                PasswordChar = false,
                PlaceholderColor = Color.DarkGray,
                PlaceholderText = text.Equals("") ? "Введіть текст" : "",
                Texts = text,
                UnderlinedStyle = false
            };
            textBoxNotesText._TextChanged += CheckSave;
            textBoxNotesText.KeyPress += ReplaceDoubleQuotes;
        }
        /// <summary>
        /// Метод для створення панелі на якій будуть розміщуватися список завдань
        /// </summary>
        private void CreateCheckList()
        {
            text = "";
            iconButtonText.Enabled = true;
            iconButtonCheckList.Enabled = false;
            windowType = WindowType.NotesCheckList;

            panelCheck = new Panel();
            panelCheck.SuspendLayout();
            panelCheck.AutoScroll = true;
            panelCheck.BackColor = Color.FromArgb(34, 33, 74);
            panelCheck.Dock = DockStyle.Fill;
            panelCheck.Location = new Point(0, 45);
            panelCheck.Margin = new Padding(0, 0, 0, 5);
            panelCheck.Name = "panelCheck";
            CreateButtonAddCheck();
            CreateTableCheckList();
            panelCheck.Controls.Add(buttonAddCheck);
            panelCheck.Controls.Add(tableLayoutPanelCheckList);
            panelCheck.ResumeLayout(false);
        }
        /// <summary>
        /// Метод для створення таблиці в якій будуть створюватися завдання
        /// </summary>
        private void CreateTableCheckList()
        {
            tableLayoutPanelCheckList = new TableLayoutPanel {  ColumnCount = 1 };
            tableLayoutPanelCheckList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, rowHeight));
            tableLayoutPanelCheckList.Dock = DockStyle.Top;
            tableLayoutPanelCheckList.Location = new Point(0, 0);
            tableLayoutPanelCheckList.Name = "tableLayoutPanelCheckList";
            tableLayoutPanelCheckList.Size = new Size(500, rowHeight);
            if (chechLists.Count == 0)
            {
                tableLayoutPanelCheckList.RowCount = 1;
                tableLayoutPanelCheckList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                CreateCheckBox(tableLayoutPanelCheckList.RowCount - 1, new ListCheck() { Text = "", Check = false });
                tableLayoutPanelCheckList.Controls.Add(panelCheckBox);
            }
        }
        /// <summary>
        /// Метод для зчитування даних з списку справ
        /// </summary>
        private void ReadCheckList()
        {
            if (chechLists != null)
            {
                int index = 0;
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(0, 1));
                CreateCheckList();
                tableLayoutPanel1.Controls.Add(panelCheck, 0, 1);
                foreach (ListCheck element in chechLists)
                {
                    CreateCheck();
                    CreateCheckBox(index++, element);
                    tableLayoutPanelCheckList.Controls.Add(panelCheckBox);
                }
            }
        }
        /// <summary>
        /// Метод для створення поля для введення нового пункту списку справ
        /// </summary>
        /// <param name="index">Номер завдання</param>
        /// <param name="listCheck">Дані про завдання</param>
        private void CreateCheckBox(int index, ListCheck listCheck)
        {
            CheckBox checkBox = new CheckBox()
            {
                AutoSize = false,
                Checked = listCheck.Check,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Left,
                Margin = new Padding(0),
                Name = $"checkBox{index}",
                Padding = new Padding(10, 0, 0, 0),
                Tag = index,
                UseVisualStyleBackColor = true,
                Width = 35
            };
            checkBox.Click += ActiveCheck;

            RJTextBox textBox = new RJTextBox()
            {
                BackColor = Color.FromArgb(34, 33, 74),
                BorderColor = Color.FromArgb(34, 33, 74),
                BorderFocusColor = Color.FromArgb(34, 33, 74),
                BorderRadius = 0,
                BorderSize = 1,
                Dock = DockStyle.Fill,
                Font = new Font("Times New Roman", 11.25F, listCheck.Check ? FontStyle.Strikeout : FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = Color.White,
                Margin = new Padding(0, 0, 0, 5),
                Multiline = true,
                Name = $"textBox{index}",
                Padding = new Padding(10, 7, 10, 7),
                PasswordChar = false,
                PlaceholderColor = Color.DarkGray,
                PlaceholderText = listCheck.Text.Equals("") ? "Введіть текст" : "",
                Tag = index,
                Texts = listCheck.Text,
                UnderlinedStyle = false
            };
            textBox.KeyPress += DeleteCheck;
            textBox.KeyPress += ReplaceDoubleQuotes;
            textBox._TextChanged += CheckSave;

            panelCheckBox = new Panel();
            panelCheckBox.SuspendLayout();
            panelCheckBox.Dock = DockStyle.Fill;
            panelCheckBox.Location = new Point(0, 0);
            panelCheckBox.Margin = new Padding(5);
            panelCheckBox.Name = $"panel{index}";
            panelCheckBox.Tag = index;
            panelCheckBox.Controls.Add(textBox);
            panelCheckBox.Controls.Add(checkBox);
            panelCheckBox.ResumeLayout(false);
        }
        /// <summary>
        /// Метод для позначення виконаного пункту списку справ 
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void ActiveCheck(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            Panel panel = (Panel)tableLayoutPanelCheckList.GetControlFromPosition(0, (int)check.Tag);
            if (panel != null)
            {
                RJTextBox text = (RJTextBox)panel.Controls[indexTextBox];
                text.Font = check.Checked ? new Font("Times New Roman", 11.25F, FontStyle.Strikeout, GraphicsUnit.Point, 204) : new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            }
        }
        /// <summary>
        /// Метод для видалення пункту списку справ, якщо він є пустий і користувач натиснув іще раз видалити
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Ббазовий клас для класів, який містить дані властивостей натиску на клавішу клавіатури і надає значення для властивостей, не зберігаючи в собі даних</param>
        public void DeleteCheck(object sender, KeyPressEventArgs e)
        {
            if (((RJTextBox)sender).Texts.Equals("") && (e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))
            {
                int index = (int)((RJTextBox)sender).Tag;
                if (tableLayoutPanelCheckList.RowCount > 1)
                {
                    tableLayoutPanelCheckList.Controls.RemoveAt(index);
                    for (; index < tableLayoutPanelCheckList.RowCount - 1; ++index)
                    {
                        Panel panel = (Panel)tableLayoutPanelCheckList.GetControlFromPosition(0, index);
                        panel.Tag = index;
                        CheckBox check = (CheckBox)panel.Controls[indexCheckBox];
                        check.Tag = index;
                        RJTextBox textBox = (RJTextBox)panel.Controls[indexTextBox];
                        textBox.Tag = index;
                    }
                    --tableLayoutPanelCheckList.RowCount;
                    tableLayoutPanelCheckList.Height -= rowHeight;
                }
            }
        }
        /// <summary>
        /// Метод для створення кнопки, яка додає нове текстове поле для створення завдання
        /// </summary>
        private void CreateButtonAddCheck()
        {
            buttonAddCheck = new IconButton
            {
                BackgroundImageLayout = ImageLayout.None,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                IconChar = IconChar.PlusSquare,
                IconColor = Color.White,
                IconFont = IconFont.Auto,
                IconSize = 45,
                ImageAlign = ContentAlignment.BottomCenter,
                Margin = new Padding(0),
                Name = "buttonAddCheck",
                Size = new Size(695, 60),
                UseVisualStyleBackColor = true
            };
            buttonAddCheck.FlatAppearance.BorderSize = 0;
            buttonAddCheck.Click += CreateNewCheck;
        }
        /// <summary>
        /// Метод для створення нового поля-прапорця
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void CreateNewCheck(object sender, EventArgs e)
        {
            CreateCheck();
            CreateCheckBox(tableLayoutPanelCheckList.RowCount - 1, new ListCheck() { Text = "", Check = false });
            tableLayoutPanelCheckList.Controls.Add(panelCheckBox);
        }
        /// <summary>
        /// Метод для створення нового поля для завдання
        /// </summary>
        private void CreateCheck()
        {
            ++tableLayoutPanelCheckList.RowCount;
            tableLayoutPanelCheckList.RowStyles.Add(new RowStyle(SizeType.Absolute, rowHeight));
            tableLayoutPanelCheckList.Height = tableLayoutPanelCheckList.RowCount * rowHeight;
        }
        /// <summary>
        /// Метод для виходу з редагування або створення нотаток або списку справ
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Exit_Click(object sender, EventArgs e)
        {
            if (iconButtonSave.Enabled)
            {
                DialogResult result = MessageBox.Show("Ви не зберегли зміни в нотатці. Чи бажаєте ви зберегти зміни перед виходом?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Save();
                    command = ManagerCommand.Save;
                }
            }
            Hide();
        }
        /// <summary>
        /// Метод для перемикання на варіант "Список справ"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void CheckList_Click(object sender, EventArgs e)
        {
            chechLists = new List<ListCheck>();
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(0, 1));
            CreateCheckList();
            tableLayoutPanel1.Controls.Add(panelCheck, 0, 1);
        }
        /// <summary>
        /// Метод для перемикання на варіант "Текст"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Text_Click(object sender, EventArgs e)
        {
            chechLists.Clear();
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(0, 1));
            CreateText();
            tableLayoutPanel1.Controls.Add(textBoxNotesText, 0, 1);
        }
        /// <summary>
        /// Метод для видалення нотатки або списку справ
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте видалити нотатку?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                switch (windowType)
                {
                    case WindowType.NotesText: text = ""; break;
                    case WindowType.NotesCheckList: chechLists.Clear(); break;
                }
                title = "";
            }
            command = ManagerCommand.Delete;
            Hide();
        }
        /// <summary>
        /// Метод для заміни звичайних подвійних лапок на трикутні
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей натиску на клавішу клавіатури і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void ReplaceDoubleQuotes(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\u0022'))
            {
                RJTextBox textBox = (RJTextBox)sender;
                int indexLeft = DoubleQuotes((string)textBox.Texts.Clone(), '\u00AB');
                int indexRigth = DoubleQuotes((string)textBox.Texts.Clone(), '\u00BB');
                if ((indexLeft == 0 && indexRigth == 0) || indexLeft == indexRigth || indexLeft < indexRigth)
                {
                    e.KeyChar = '\u00AB';
                }
                else
                {
                    e.KeyChar = '\u00BB';
                }
            }
        }
        /// <summary>
        /// Метод для визначення які лапки ставити (<< або >>)
        /// </summary>
        /// <param name="buffer">Рядок в якому здійснюється пошук</param>
        /// <param name="quotes">Символ, який потрібно знайти</param>
        /// <returns>Повертає числове значення кількості того, скільки разів зустрічається ті чи інші мапки</returns>
        private int DoubleQuotes(string buffer, char quotes)
        {
            int index, indexQuotes = 0;
            while (true)
            {
                index = buffer.IndexOf(quotes);
                if (index >= 0)
                {
                    ++indexQuotes;
                    buffer = buffer.Substring(index + 1);
                }
                else
                {
                    break;
                }
            }
            return indexQuotes;
        }
    }
}