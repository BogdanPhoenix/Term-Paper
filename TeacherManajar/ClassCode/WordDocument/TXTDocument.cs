using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TeacherManajar.ClassCode.WordDocument
{
    /// <summary>
    /// Клас для взаємодії з текстовими файлами
    /// </summary>
    class TXTDocument
    {
        private static DataTable dataTable = null;
        private static string nameOpenFile;
        /// <summary>
        /// Метод для зчитування даних з текстового файлу
        /// </summary>
        /// <returns>Повертає таблицю даних</returns>
        public static DataTable ImportTXTFile()
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "Type file(*.txt)|*.txt" };
            nameOpenFile = openFile.ShowDialog() == DialogResult.OK ? openFile.FileName : "";
            if (!nameOpenFile.Equals(""))
            {
                StreamReader file = null;
                try
                {
                    dataTable = new DataTable();
                    file = new StreamReader(nameOpenFile, Encoding.UTF8);
                    dataTable.Columns.Add("0", typeof(string));
                    while (!file.EndOfStream)
                    {
                        dataTable.Rows.Add(file.ReadLine());
                    }
                    file.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Відбувся збій під час отримання даних з файлу.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataTable.Clear();
                    file.Close();
                    dataTable = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataTable.Clear();
                    file.Close();
                    dataTable = null;
                }
            }
            return dataTable;
        }
    }
}
