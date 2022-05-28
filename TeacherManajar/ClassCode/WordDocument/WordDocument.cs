using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TeacherManajar.ClassCode.WordDocument
{
    /// <summary>
    /// Клас для взаємодії з Word файлами
    /// </summary>
    class WordDocument
    {
        private static DataTable dataTable = new DataTable();
        private static string nameOpenFile;
        /// <summary>
        /// Метод для зчитування даних з файлів Word, що містять в собі таблицю
        /// </summary>
        /// <returns>Повертає таблицю даних, файлів Word</returns>
        public static DataTable ImportWordTableFile()
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "Type file(*.doc;*.docx)|*.doc;*.docx" };
            nameOpenFile = openFile.ShowDialog() == DialogResult.OK ? openFile.FileName : "";
            if (!nameOpenFile.Equals(""))
            {
                try
                {
                    switch (Path.GetExtension(nameOpenFile))
                    {
                        case ".doc":
                            ReadDocFileTable();
                            break;
                        case ".docx":
                            ReadDocxFileTable();
                            break;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Відбувся збій під час отримання даних з файлу.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataTable.Clear();
                    dataTable = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataTable.Clear();
                    dataTable = null;
                }
            }
            return dataTable;
        }
        /// <summary>
        /// Метод для зчитування даних з файлів Word, що містять в собі список
        /// </summary>
        /// <returns>Повертає таблицю даних, файлів Word</returns>
        public static DataTable ImportWordListFile()
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "Type file(*.doc;*.docx)|*.doc;*.docx" };
            nameOpenFile = openFile.ShowDialog() == DialogResult.OK ? openFile.FileName : "";
            if (!nameOpenFile.Equals(""))
            {
                try
                {
                    switch (Path.GetExtension(nameOpenFile))
                    {
                        case ".doc":
                            ReadDocFileList();
                            break;
                        case ".docx":
                            ReadDocxFileList();
                            break;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Відбувся збій під час отримання даних з файлу.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return dataTable;
        }
        /// <summary>
        /// Метод для отримання даних з вибраного файлу DOCX "Таблиця"
        /// </summary>
        private static void ReadDocxFileTable()
        {
            using (WordprocessingDocument docx = WordprocessingDocument.Open(nameOpenFile.Trim(), false))
            {
                int rowCount = 0;
                Table table = docx.MainDocumentPart.Document.Body.Elements<Table>().First();
                IEnumerable<TableRow> rows = table.Elements<TableRow>();

                foreach (TableRow row in rows)
                {
                    dataTable.Rows.Add();
                    int i = 0;
                    foreach (TableCell cell in row.Descendants<TableCell>())
                    {
                        if (rowCount == 0)
                        {
                            dataTable.Columns.Add(cell.InnerText);
                        }
                        dataTable.Rows[dataTable.Rows.Count - 1][i] = cell.InnerText;
                        i++;
                    }
                    rowCount += 1;
                }
            }
        }
        /// <summary>
        /// Метод для отримання даних з вибраного файлу DOCX "Список"
        /// </summary>
        private static void ReadDocxFileList()
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(nameOpenFile, false))
            {
                var paragraphs = wordDocument.MainDocumentPart.Document.Body.Descendants<Paragraph>().ToList();
                dataTable.Columns.Add(paragraphs[0].InnerText);
                foreach (var paragraph in paragraphs)
                {
                    dataTable.Rows.Add(paragraph.InnerText);
                }
            }
        }
        /// <summary>
        /// Метод для отримання даних з вибраного файлу DOC "Таблиця"
        /// </summary>
        private static void ReadDocFileTable()
        {
            using (Spire.Doc.Document doc = new Spire.Doc.Document())
            {
                doc.LoadFromFile(nameOpenFile);

                Spire.Doc.Section section = doc.Sections[0];
                Spire.Doc.Table table = section.Tables[0] as Spire.Doc.Table;

                for (int i = 0; i < table.Rows[0].Cells.Count; i++)
                {
                    dataTable.Columns.Add(i.ToString(), typeof(string));
                }
                for (int r = 0; r < table.Rows.Count; r++)
                {
                    DataRow row = dataTable.NewRow();
                    for (int c = 0; c < table.Rows[r].Cells.Count; c++)
                    {
                        string text = "";
                        if (table.Rows[r].Cells[c].Paragraphs.Count < 2)
                        {
                            text = table.Rows[r].Cells[c].Paragraphs[0].Text;
                        }
                        else
                        {
                            foreach (Spire.Doc.Documents.Paragraph p in table.Rows[r].Cells[c].Paragraphs)
                            {
                                text += "\n" + p.Text;
                            }
                        }
                        row[c] = text;
                    }
                    dataTable.Rows.Add(row);
                }
            }
        }
        /// <summary>
        /// Метод для отримання даних з вибраного файлу DOC "Список"
        /// </summary>
        private static void ReadDocFileList()
        {
            using (Spire.Doc.Document doc = new Spire.Doc.Document())
            {
                doc.LoadFromFile(nameOpenFile);

                Spire.Doc.Section section = doc.Sections[0];
                dataTable.Columns.Add(section.Paragraphs[0].Text);
                foreach (Spire.Doc.Documents.Paragraph paragraph in section.Paragraphs)
                {
                    dataTable.Rows.Add(paragraph.Text);
                }
            }
        }
    }
}