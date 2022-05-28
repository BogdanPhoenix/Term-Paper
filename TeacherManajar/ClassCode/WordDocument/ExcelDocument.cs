using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TeacherManajar.ClassCode.WordDocument
{
    /// <summary>
    /// Клас для взаємодії з Excel файлами
    /// </summary>
    class ExcelDocument
    {
        private static DataTable dataTable = null;
        private static string nameOpenFile;
        /// <summary>
        /// Метод для зчитування даних з файлів Excel
        /// </summary>
        /// <returns>Повертає таблицю даних, файлів Excel</returns>
        public static DataTable ImportExcelFile()
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "Type file(*.xls;*.xlsx)|*.xls;*.xlsx" };
            nameOpenFile = openFile.ShowDialog() == DialogResult.OK ? openFile.FileName : "";
            if (!nameOpenFile.Equals(""))
            {
                try
                {
                    dataTable = new DataTable();
                    switch (Path.GetExtension(nameOpenFile))
                    {
                        case ".xls":
                            ReadXlsFile();
                            break;
                        case ".xlsx":
                            ReadXlsxFile();
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
        /// Метод для зчитування даних з електронної таблиці Office Open XML
        /// </summary>
        private static void ReadXlsxFile()
        {
            using (SpreadsheetDocument xlsx = SpreadsheetDocument.Open(nameOpenFile, false))
            {
                WorkbookPart workbookPart = xlsx.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                foreach (Row row in sheetData.Elements<Row>())
                {
                    if (row.RowIndex.Value == 1)
                    {
                        foreach (Cell cell in row.Elements<Cell>())
                        {
                            string buffer = GetCellValue(xlsx, cell);
                            if (char.IsDigit(buffer, 0))
                            {
                                buffer = DateTime.FromOADate(Convert.ToDouble(buffer)).ToString("d");
                            }
                            dataTable.Columns.Add(buffer);
                        }
                    }
                    else
                    {
                        DataRow tempRow = dataTable.NewRow();
                        int columnIndex = 0;
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            int cellColumnIndex = (int)GetColumnIndexFromName(GetColumnName(cell.CellReference));
                            cellColumnIndex--;
                            if (columnIndex < cellColumnIndex)
                            {
                                do
                                {
                                    tempRow[columnIndex] = "";
                                    columnIndex++;
                                }
                                while (columnIndex < cellColumnIndex);
                            }
                            tempRow[columnIndex] = GetCellValue(xlsx, cell);

                            columnIndex++;
                        }
                        dataTable.Rows.Add(tempRow);
                    }
                }
            }
        }
        /// <summary>
        /// Метод для вираховування імені комірки, аналізуючи вказану клітинку, щоб отримати назву стовпця
        /// </summary>
        /// <param name="cellReference">Адреса комірки</param>
        /// <returns>Повертає ім'я стовпчика</returns>
        public static string GetColumnName(string cellReference)
        {
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellReference);
            return match.Value;
        }
        /// <summary>
        /// Метод враховує лише ім’я стовпця (без індексу рядка), він поверне нульовий індекс стовпця.
        /// Примітка. Цей метод оброблятиме лише стовпці довжиною до двох (тобто від A до Z і від AA до ZZ).
        /// За потреби можна застосувати довжину три.
        /// </summary>
        /// <param name="columnName">Ім'я колонки</param>
        /// <returns>Повертає не нульовий індекс, якщо перетворення було успішним; інакше нульовий</returns>
        public static int? GetColumnIndexFromName(string columnName)
        {
            string name = columnName;
            int number = 0;
            int pow = 1;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                number += (name[i] - 'A' + 1) * pow;
                pow *= 26;
            }
            return number;
        }
        /// <summary>
        /// Метод для отримання даних з комірки
        /// </summary>
        /// <param name="document">Поточний Excel документ</param>
        /// <param name="cell">Дані про комірку</param>
        /// <returns>Повертає вміст комірки</returns>
        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            if (cell.CellValue == null)
            {
                return "";
            }
            string value = cell.CellValue.InnerXml;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[int.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
        /// <summary>
        /// Метод для зчитування даних з листа Microsoft Excel
        /// </summary>
        private static void ReadXlsFile()
        {
            using (Spire.Xls.Workbook workbook = new Spire.Xls.Workbook())
            {
                workbook.LoadFromFile(nameOpenFile);
                foreach (Spire.Xls.Worksheet sheet in workbook.Worksheets)
                {
                    dataTable = sheet.ExportDataTable();
                    if (dataTable.Rows.Count > 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}