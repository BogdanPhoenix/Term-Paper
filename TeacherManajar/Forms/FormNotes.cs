using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeacherManajar.ClassCode;
using TeacherManajar.ClassCode.DataBaseClass;
using TeacherManajar.Enum;

namespace TeacherManajar.Forms
{
    /// <summary>
    /// Клас для створення коротких заміток або списків справ, які пов’язані із навчанням
    /// </summary>
    public partial class FormNotes : Form
    {
        private const int rowHeight = 175;
        private TableLayoutPanel tableLayoutPanelNotes;
        private ClassNotes notes = null;
        private readonly ClassNotes notesNew = null;
        private readonly AccountEmail accountEmail = null;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="accountEmail">Дані користувача</param>
        public FormNotes(AccountEmail accountEmail)
        {
            InitializeComponent();
            MySqlDataReader sqlDataReader = DataBase.Select(accountEmail, VariantSelect.Notes);
            sqlDataReader.Read();
            notes = JsonConvert.DeserializeObject<ClassNotes>(sqlDataReader["Notes"].ToString());
            if (notes == null)
            {
                notes = new ClassNotes()
                {
                    TextNotes = new List<TextNotes>(),
                    CheckNotes = new List<CheckNotes>()
                };
                notesNew = new ClassNotes()
                {
                    TextNotes = new List<TextNotes>(),
                    CheckNotes = new List<CheckNotes>()
                };
            }
            else
            {
                notesNew = (ClassNotes)notes.Clone();
            }
            this.accountEmail = accountEmail;
            CreateGroupPanel();
            iconButtonCreateNote.Click += (s, e) => { OpenNotes(ManagerCommand.CreateNotes, WindowType.NotesText); };
            iconButtonOpenNotesText.Click += (s, e) => { tableLayoutPanelNotesText.Height = tableLayoutPanelNotesText.Height == 0 ? tableLayoutPanelNotesText.RowCount * rowHeight : 0; };
            iconButtonOpenListCheck.Click += (s, e) => { tableLayoutPanelNotesListCheck.Height = tableLayoutPanelNotesListCheck.Height == 0 ? tableLayoutPanelNotesListCheck.RowCount * rowHeight : 0; };
        }
        /// <summary>
        /// Метод для збереження змін в базу даних
        /// </summary>
        private void SaveBase()
        {
            if (!notesNew.Equals(notes))
            {
                try
                {
                    notes = (ClassNotes)notesNew.Clone();
                    DataBase.UpdateNotesAndSetting(accountEmail, notes, VariantUpdate.Notes);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Метод для виведення нотаток на екран
        /// </summary>
        private void CreateGroupPanel()
        {
            foreach (TextNotes text in notesNew.TextNotes)
            {
                CreatNewPanel(tableLayoutPanelNotesText, text, WindowType.NotesText);
            }
            foreach (CheckNotes check in notesNew.CheckNotes)
            {
                CreatNewPanel(tableLayoutPanelNotesListCheck, check, WindowType.NotesCheckList);
            }
            CheckPanelFont();
        }
        /// <summary>
        /// Метод для перевірки чи створювати новий рядок для виведення нотаток на екран
        /// </summary>
        /// <param name="tableLayoutPanel">Таблиця в яку виводяться дані</param>
        private void CheckNewLine(TableLayoutPanel tableLayoutPanel)
        {
            if (tableLayoutPanel == null || tableLayoutPanel.Controls.Count % 3 == 0)
            {
                if (tableLayoutPanel.Controls.Count != 0)
                {
                    ++tableLayoutPanel.RowCount;
                }
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, rowHeight));
                tableLayoutPanel.Height += rowHeight;
            }
        }
        /// <summary>
        /// Метод для створення панелі під нотатку або список справ
        /// </summary>
        /// <param name="tableLayout">Панель в яку буде додаватися нотатка або список справ</param>
        /// <param name="data">Дані які будуть задаватися в панель</param>
        /// <param name="windowType">Тип об'єкта</param>
        private void CreatNewPanel(TableLayoutPanel tableLayout, object data, WindowType windowType)
        {
            CheckNewLine(tableLayout);
            tableLayout.Controls.Add(CreateTableLayoutPanel(tableLayout.Controls.Count, data, windowType));
        }
        /// <summary>
        /// Метод для оновлення даних вибраного списку справ
        /// </summary>
        /// <param name="tableLayoutPanel">Панель на якій розташований список справ</param>
        /// <param name="listChecks">Дані списку справ</param>
        private void UpdateListCheck(TableLayoutPanel tableLayoutPanel, CheckNotes listChecks)
        {
            Label title = (Label)tableLayoutPanel.GetControlFromPosition(0, 0);
            title.Text = listChecks.Title;
            tableLayoutPanel.Controls.Remove(tableLayoutPanel.GetControlFromPosition(0, 1));
            tableLayoutPanel.Controls.Add(CheckList(listChecks.ListChecks));
        }
        /// <summary>
        /// Метод для перевірки чи присутні нотатки, якщо ні то відображається відповідна картинка
        /// </summary>
        private void CheckPanelFont()
        {
            CheckVisible(tableLayoutPanelNotesText, panelOpenNotesText);
            CheckVisible(tableLayoutPanelNotesListCheck, panelOpenNotesListCheck);
            panelFont.Visible = tableLayoutPanelNotesText.Controls.Count == 0 && tableLayoutPanelNotesListCheck.Controls.Count == 0;
        }
        /// <summary>
        /// Метод для перевірки чи присутні в таблиці нотатків або в таблиці списків справ хоч якісь об'єкти, якщо ні то вони не відображаються
        /// </summary>
        /// <param name="tableLayoutPanel">Таблиця для перевірки</param>
        /// <param name="panel">Панель заголовка</param>
        private void CheckVisible(TableLayoutPanel tableLayoutPanel, Panel panel)
        {
            if (tableLayoutPanel.Controls.Count == 0)
            {
                tableLayoutPanel.Height = 0;
                panel.Visible = false;
            }
            else
            {
                if (tableLayoutPanel.Controls.Count != 0 && !panel.Visible)
                {
                    panel.Visible = true;
                }
            }
        }
        /// <summary>
        /// Метод для створення панелі, в якій розташовується заголовок та текст нотатки або списку справ
        /// </summary>
        /// <param name="index">Порядковий номер нотатки для ідентифікації</param>
        /// <param name="data">Об'єкт даних, які потрібно додати в таблицю</param>
        /// <param name="windowType">Тип об'єкта даних</param>
        /// <returns>Повертає панель із заголовком та тілом для нотатки або списку справ</returns>
        private TableLayoutPanel CreateTableLayoutPanel(int index, object data, WindowType windowType)
        {
            tableLayoutPanelNotes = new TableLayoutPanel
            {
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Location = new Point(331, 3),
                Name = $"tableLayoutPanelNotes{index}",
                Margin = new Padding(0, 0, 5, 5),
                RowCount = 2,
                Size = new Size(322, 169)
            };

            tableLayoutPanelNotes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelNotes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelNotes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            switch (windowType)
            {
                case WindowType.NotesText:
                    tableLayoutPanelNotes.Controls.Add(LabelTitle(((TextNotes)data).Title, windowType));
                    tableLayoutPanelNotes.Controls.Add(LabelText(((TextNotes)data).Text)); break;
                case WindowType.NotesCheckList:
                    tableLayoutPanelNotes.Controls.Add(LabelTitle(((CheckNotes)data).Title, windowType));
                    tableLayoutPanelNotes.Controls.Add(CheckList(((CheckNotes)data).ListChecks)); break;
            }

            return tableLayoutPanelNotes;
        }
        /// <summary>
        /// Метод для створення заголовку нотатки або списку справ
        /// </summary>
        /// <param name="text">Текст заголовку</param>
        /// <param name="windowType">Тип об'єкта</param>
        /// <returns>Повертає текстове поле</returns>
        private Label LabelTitle(string text, WindowType windowType)
        {
            Label labelTitle = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.FromArgb(51, 153, 102),
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(0, 0),
                Margin = new Padding(0),
                Name = "labelTitle",
                Size = new Size(300, 30),
                Tag = windowType,
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft
            };
            if (labelTitle.Text.Length == 0)
            {
                tableLayoutPanelNotes.RowStyles[0] = new RowStyle(SizeType.Absolute, 0F);
            }
            labelTitle.Click += (s, e) => { OpenNotes(ManagerCommand.OpenNotes, windowType); };
            return labelTitle;
        }
        /// <summary>
        /// Метод для створення поля в яке виводиться вміст нотатки
        /// </summary>
        /// <param name="text">Текст нотатки</param>
        /// <returns>Повертає текстове поле</returns>
        private Label LabelText(string text)
        {
            Label labelText = new Label()
            {
                AutoEllipsis = true,
                Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204),
                BackColor = Color.Yellow,
                Dock = DockStyle.Fill,
                Location = new Point(0, 30),
                Name = "labelText",
                Margin = new Padding(0),
                Size = new Size(318, 139),
                Text = text,
                TextAlign = ContentAlignment.TopLeft,
            };
            return labelText;
        }
        /// <summary>
        /// Метод для створення панелі для відображення списку справ
        /// </summary>
        /// <param name="data">Список даних пунктів</param>
        /// <returns>Повертає панель</returns>
        private TableLayoutPanel CheckList(List<ListCheck> data)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                AutoScroll = true,
                BackColor = Color.Yellow,
                ColumnCount = 1
            };
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;

            foreach (ListCheck notes in data)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                tableLayoutPanel.Controls.Add(PanelCheckList(tableLayoutPanel.RowCount - 1, notes));
                ++tableLayoutPanel.RowCount;
            }

            return tableLayoutPanel;
        }
        /// <summary>
        /// Метод для створення панелі в якій відображається завдання та ідентифікатор його виконання
        /// </summary>
        /// <param name="index">Індекс завдання в даній нотатці</param>
        /// <param name="element">Дані про завдання</param>
        /// <returns>Повертає панель взаємодії з полем</returns>
        private Panel PanelCheckList(int index, ListCheck element)
        {
            Label label = new Label
            {
                Dock = DockStyle.Fill,
                Location = new Point(35, 0),
                Font = element.Check ? new Font("Times New Roman", 9.75F, FontStyle.Strikeout, GraphicsUnit.Point, 204) : new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Name = $"label1{index}",
                Margin = new Padding(0),
                Padding = new Padding(7, 0, 0, 0),
                Size = new Size(330, 35),
                Text = element.Text
            };

            CheckBox checkBox = new CheckBox
            {
                BackgroundImageLayout = ImageLayout.None,
                Checked = element.Check,
                Enabled = false,
                Dock = DockStyle.Left,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, 0),
                Margin = new Padding(0),
                Name = $"checkBox{index}",
                Padding = new Padding(10, 0, 0, 0),
                Size = new Size(35, 35),
                UseMnemonic = false,
                UseVisualStyleBackColor = false
            };
            checkBox.FlatAppearance.BorderSize = 0;

            Panel panel = new Panel();
            panel.SuspendLayout();
            panel.Controls.Add(label);
            panel.Controls.Add(checkBox);
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(0);
            panel.Name = $"panel1{index}";
            panel.Size = new Size(365, 35);

            panel.ResumeLayout(false);
            return panel;
        }
        /// <summary>
        /// Метод для створення або відкриття нотатки або списку справ та дозволяє здійснювати над нею певні дії
        /// </summary>
        /// <param name="command">Команда, яку потрібно виконати з нотаткою (створити або відкрити)</param>
        /// <param name="windowType">Тип об'єкта</param>
        private void OpenNotes(ManagerCommand command, WindowType windowType)
        {
            FormNoteWork createNote = null;
            switch (command)
            {
                case ManagerCommand.CreateNotes:
                    createNote = new FormNoteWork();
                    createNote.ShowDialog();
                    if (createNote.Command == ManagerCommand.Save)
                    {
                        WindowType type = createNote.WindowType;
                        switch (createNote.WindowType)
                        {
                            case WindowType.NotesText:
                                TextNotes textNotes = new TextNotes()
                                {
                                    Title = createNote.NotesTitle,
                                    Text = createNote.NotesText
                                };
                                notesNew.TextNotes.Add(textNotes);
                                CreatNewPanel(tableLayoutPanelNotes, notesNew.TextNotes[notesNew.TextNotes.Count - 1], type);
                                break;
                            case WindowType.NotesCheckList:
                                CheckNotes checkNotes = new CheckNotes()
                                {
                                    Title = createNote.NotesTitle,
                                    ListChecks = createNote.NotesChechLists
                                };
                                notesNew.CheckNotes.Add(checkNotes);
                                CreatNewPanel(tableLayoutPanelNotesListCheck, notesNew.CheckNotes[notesNew.CheckNotes.Count - 1], type);
                                break;
                        }
                    }
                    break;
                case ManagerCommand.OpenNotes:
                    Point? cellPos;
                    int index = 0;
                    object panelCell = null, component = null;
                    switch (windowType)
                    {
                        case WindowType.NotesText:
                            cellPos = SystemProcess.GetRowColIndex(tableLayoutPanelNotesText, tableLayoutPanelNotesText.PointToClient(Cursor.Position));
                            index = cellPos.Value.X + cellPos.Value.Y * tableLayoutPanelNotesText.ColumnCount;
                            panelCell = tableLayoutPanelNotesText.GetControlFromPosition(cellPos.Value.X, cellPos.Value.Y);
                            component = ((TableLayoutPanel)panelCell).GetControlFromPosition(0, 0);
                            createNote = new FormNoteWork(notesNew.TextNotes[index].Title, notesNew.TextNotes[index].Text);
                            break;
                        case WindowType.NotesCheckList:
                            cellPos = SystemProcess.GetRowColIndex(tableLayoutPanelNotesListCheck, tableLayoutPanelNotesListCheck.PointToClient(Cursor.Position));
                            index = cellPos.Value.X + cellPos.Value.Y * tableLayoutPanelNotesListCheck.ColumnCount;
                            panelCell = tableLayoutPanelNotesListCheck.GetControlFromPosition(cellPos.Value.X, cellPos.Value.Y);
                            component = ((TableLayoutPanel)panelCell).GetControlFromPosition(0, 0);
                            createNote = new FormNoteWork(notesNew.CheckNotes[index].Title, notesNew.CheckNotes[index].ListChecks);
                            break;
                    }
                    createNote.ShowDialog();
                    switch (createNote.Command)
                    {
                        case ManagerCommand.Delete:
                            switch (createNote.WindowType)
                            {
                                case WindowType.NotesText:
                                    tableLayoutPanelNotesText.Controls.Remove((Control)panelCell);
                                    if (tableLayoutPanelNotesText.RowCount > 1 && tableLayoutPanelNotesText.Controls.Count % 3 == 0)
                                    {
                                        tableLayoutPanelNotesText.Height = --tableLayoutPanelNotesText.RowCount * rowHeight;
                                    }
                                    notesNew.TextNotes.RemoveAt(index);
                                    break;
                                case WindowType.NotesCheckList:
                                    tableLayoutPanelNotesListCheck.Controls.Remove((Control)panelCell);
                                    if (tableLayoutPanelNotesListCheck.RowCount > 1 && tableLayoutPanelNotesListCheck.Controls.Count % 3 == 0)
                                    {
                                        tableLayoutPanelNotesListCheck.Height = --tableLayoutPanelNotesListCheck.RowCount * rowHeight;
                                    }
                                    notesNew.CheckNotes.RemoveAt(index);
                                    break;
                            }
                            break;
                        case ManagerCommand.Save:
                            ((Label)component).Text = createNote.NotesTitle;
                            switch (createNote.WindowType)
                            {
                                case WindowType.NotesText:
                                    notesNew.TextNotes[index].Title = createNote.NotesTitle;
                                    notesNew.TextNotes[index].Text = createNote.NotesText;
                                    component = ((TableLayoutPanel)panelCell).GetControlFromPosition(0, 1);
                                    ((Label)component).Text = createNote.NotesText;
                                    break;
                                case WindowType.NotesCheckList:
                                    notesNew.CheckNotes[index].Title = createNote.NotesTitle;
                                    notesNew.CheckNotes[index].ListChecks = createNote.NotesChechLists;
                                    UpdateListCheck((TableLayoutPanel)panelCell, notesNew.CheckNotes[index]);
                                    break;
                            }
                            break;
                    }
                    break;
            }
            SaveBase();
            CheckPanelFont();
        }
    }
}