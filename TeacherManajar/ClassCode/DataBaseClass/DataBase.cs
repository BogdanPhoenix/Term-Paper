using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Newtonsoft.Json;
using TeacherManajar.Enum;

namespace TeacherManajar.ClassCode.DataBaseClass
{
    /// <summary>
    /// Клас для взаємодії з базою даних
    /// </summary>
    static class DataBase
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["TeacherManagerDB"].ConnectionString;
        private static readonly MySqlConnection conn = new MySqlConnection(connectionString);
        private static MySqlDataReader sqlDataReader = null;
        private static MySqlCommand command = null;
        private static readonly Dictionary<BaseName, string> dataBase = new Dictionary<BaseName, string>()
        {
            { BaseName.AccountEmailBase, "accountemail" },
            { BaseName.StudentBase, "accountstudents" },
            { BaseName.TeacherBase, "accountteacher" },
            { BaseName.GroupBase, "groupdata" },
            { BaseName.GroupConnectBase, "groupconnect" }
        };
        /// <summary>
        /// Метод для відкриття підключення до бази даних
        /// </summary>
        public static void CreateConectDataBase()
        {
            conn.Open();
        }
        /// <summary>
        /// Метод для закриття підключення до бази даних
        /// </summary>
        public static void CloseConectDataBase()
        {
            if (sqlDataReader != null)
            {
                sqlDataReader.Close();
            }
            conn.Close();
        }
        /// <summary>
        /// Метод для пошуку
        /// </summary>
        /// <param name="accountEmail">Дані користувача</param>
        /// <param name="variantSelect">Тип пошуку</param>
        /// <returns>Повертає рядок даних з бази даних</returns>
        public static MySqlDataReader Select(AccountEmail accountEmail, VariantSelect variantSelect)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandString = "", baseName = "";
                if (variantSelect != VariantSelect.AccountBase && variantSelect != VariantSelect.GroupsConnectBase)
                {
                    switch (accountEmail.Role.ToLower())
                    {
                        case "учень":
                        case "студент": baseName = dataBase[BaseName.StudentBase]; break;
                        case "викладач":
                        case "вчитель": baseName = dataBase[BaseName.TeacherBase]; break;
                    }
                }
                switch (variantSelect)
                {
                    case VariantSelect.Person:
                        commandString = $"SELECT * FROM `{baseName}` WHERE `IdPerson`='{accountEmail.IdPerson}'";
                        break;
                    case VariantSelect.AccountBase:
                        commandString = $"SELECT * FROM `{dataBase[BaseName.AccountEmailBase]}` WHERE `Email`='{accountEmail.Email}'";
                        break;
                    case VariantSelect.GroupsConnectBase:
                        commandString = $"SELECT IdGroup FROM `{dataBase[BaseName.GroupConnectBase]}` WHERE `IdPerson` = '{accountEmail.IdPerson}'";
                        break;
                    case VariantSelect.Notes:
                        commandString = $"SELECT `Notes` FROM `{baseName}` WHERE `IdPerson`='{accountEmail.IdPerson}'";
                        break;
                    case VariantSelect.Education:
                        commandString = $"SELECT Education FROM `{baseName}` WHERE `IdPerson` = '{accountEmail.IdPerson}'";
                        break;
                }
                command = new MySqlCommand(commandString, conn);
                sqlDataReader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час входу в обліковий запис {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDataReader;
        }
        /// <summary>
        /// Метод для пошуку студента
        /// </summary>
        /// <param name="idPerson">Унікальний ідентифікатор користувача</param>
        /// <returns>Повертає рядок даних з бази даних</returns>
        public static MySqlDataReader SelectPersonStudent(string idPerson)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandString = $"SELECT `FirstName`, `Name`, `Surname` FROM `{dataBase[BaseName.StudentBase]}` WHERE `IdPerson`='{idPerson}';";
                command = new MySqlCommand(commandString, conn);
                sqlDataReader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час входу в обліковий запис {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDataReader;
        }
        /// <summary>
        /// Метод для пошуку особи
        /// </summary>
        /// <param name="firstname">Прізвище</param>
        /// <param name="name">Ім'я</param>
        /// <param name="surname">По-батькові</param>
        /// <returns>Повертає рядок даних з бази даних</returns>
        public static MySqlDataReader SelectPersonInitials(string firstname, string name, string surname)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandString = $"SELECT `IdPerson` FROM `{dataBase[BaseName.StudentBase]}` WHERE `FirstName`='{firstname}' AND `Name`='{name}' AND `Surname`='{surname}';";
                command = new MySqlCommand(commandString, conn);
                sqlDataReader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час входу в обліковий запис {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDataReader;
        }
        /// <summary>
        /// Метод для пошуку студентів для створення журналу групи
        /// </summary>
        /// <param name="specialty">Назва спеціальності</param>
        /// <param name="course">Номер курсу</param>
        /// <param name="education">Назва навчального закладу</param>
        /// <returns>Повертає рядок даних з бази даних</returns>
        public static MySqlDataReader SelectStudentsBase(string specialty, string course, string education)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string comandString = $"SELECT IdPerson FROM `{dataBase[BaseName.StudentBase]}` WHERE `Specialty` = '{specialty}' AND `Course` = '{course}' And `Education` = '{education}';";
                command = new MySqlCommand(comandString, conn);
                sqlDataReader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час входу в обліковий запис {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDataReader;
        }
        /// <summary>
        /// Метод для пошуку журналів, до яких належить користувач
        /// </summary>
        /// <param name="idGroup">Унікальний ідентифікатор журналу</param>
        /// <returns>Повертає рядок даних з бази даних</returns>
        public static MySqlDataReader SelectGroupsBase(string idGroup)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string comandString = $"SELECT * FROM `{dataBase[BaseName.GroupBase]}` WHERE `IdGroup` = '{idGroup}';";
                command = new MySqlCommand(comandString, conn);
                sqlDataReader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час входу в обліковий запис {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDataReader;
        }
        /// <summary>
        /// Метод для створення особистого кабінету користувача
        /// </summary>
        /// <param name="accountEmail">Основні дані користувача для входу</param>
        /// <param name="person">Персональні дані користувача</param>
        /// <param name="dataEducation">Дані користувача, які залежать від його ролі</param>
        /// <param name="password">Пароль від особистого кабінету</param>
        public static void InsertAccount(AccountEmail accountEmail, Person person, object dataEducation, string password)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandAccount = $"INSERT INTO `{dataBase[BaseName.AccountEmailBase]}`(`Email`, `Password`, `IdPerson`, `Role`) VALUES ('{accountEmail.Email}','{password}','{accountEmail.IdPerson}','{accountEmail.Role}')";
                string commandPerson = "";

                switch (accountEmail.Role.ToLower())
                {
                    case "учень":
                    case "студент": commandPerson = $"INSERT INTO `{dataBase[BaseName.StudentBase]}`(`IdPerson`, `FirstName`, `Name`, `Surname`, `DateBirthday`, `Education`, `Course`, `Specialty`, `AvatarFoto`, `Gender`, `FormStudy`, `EducationalDegree`, `EducationType`, `Notes`) VALUES ('{accountEmail.IdPerson}','{person.FirstName}','{person.Name}','{person.Surname}','{person.DateBirthday:yyyy-MM-dd}','{((StudentGroup)dataEducation).Education}','{((StudentGroup)dataEducation).Course}','{((StudentGroup)dataEducation).Specialty}','{person.AvatarFoto}','{person.Gender}','{((StudentGroup)dataEducation).FormStudy}','{((StudentGroup)dataEducation).EducationalDegree}','{((StudentGroup)dataEducation).EducationType}','{JsonConvert.SerializeObject(new ClassNotes() { CheckNotes = new List<CheckNotes>(), TextNotes = new List<TextNotes>() })}')"; break;
                    case "викладач":
                    case "вчитель": commandPerson = $"INSERT INTO `{dataBase[BaseName.TeacherBase]}`(`IdPerson`, `FirstName`, `Name`, `Surname`, `Education`, `DiplomaNumber`, `DiplomaSeries`, `ScientificTitle`, `AvatarFoto`, `DateBirthday`, `Gender`, `EducationType`, `Notes`) VALUES ('{accountEmail.IdPerson}','{person.FirstName}','{person.Name}','{person.Surname}','{((TeacherGroup)dataEducation).Education}','{((TeacherGroup)dataEducation).DiplomaNumber}','{((TeacherGroup)dataEducation).DiplomaSeries}','{((TeacherGroup)dataEducation).ScientificTitle}','{person.AvatarFoto}','{person.DateBirthday:yyyy-MM-dd}','{person.Gender}','{((TeacherGroup)dataEducation).EducationType}','{JsonConvert.SerializeObject(new ClassNotes() { CheckNotes = new List<CheckNotes>(), TextNotes = new List<TextNotes>() })}')"; break;
                }
                InsertCommand(commandAccount);
                InsertCommand(commandPerson);
                MessageBox.Show($"Ваш акаун створено успішно!!!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час створення облікового запису {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для створення журналу
        /// </summary>
        /// <param name="groupData">Основні дані журналу</param>
        /// <param name="otherGroupData">Додаткові дані журналу</param>
        public static void InsertGroup(GroupData groupData, OtherGroupData otherGroupData)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandAccount = "";
                commandAccount = $"INSERT INTO `{dataBase[BaseName.GroupBase]}`(`IdGroup`, `IdTeacher`, `Specialty`, `NameSubject`, `Course`, `OtherGroupData`, `SettingGroup`) VALUES ('{groupData.IdGroup}','{groupData.IdTeacher}','{groupData.Specialty}','{groupData.NameSubject}','{groupData.Course}','{JsonConvert.SerializeObject(otherGroupData)}','{JsonConvert.SerializeObject(groupData.SettingGroup)}')";
                InsertCommand(commandAccount);
                commandAccount = $"INSERT INTO `{dataBase[BaseName.GroupConnectBase]}`(`IdPerson`, `IdGroup`) VALUES ('{groupData.IdTeacher}','{groupData.IdGroup}')";
                InsertCommand(commandAccount);
                foreach (StudentsEstimates studentsEstimates in otherGroupData.StudentsEstimates)
                {
                    commandAccount = $"INSERT INTO `{dataBase[BaseName.GroupConnectBase]}`(`IdPerson`, `IdGroup`) VALUES ('{studentsEstimates.StudentId}','{groupData.IdGroup}')";
                    InsertCommand(commandAccount);
                }
                MessageBox.Show($"Групу створено успішно!!!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час створення облікового запису {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для виконання команди створення об'єктів в базі даних
        /// </summary>
        /// <param name="commandString">Рядок для виконання</param>
        private static void InsertCommand(string commandString)
        {
            command = new MySqlCommand(commandString, conn);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Метод для оновлення даних користувача
        /// </summary>
        /// <param name="accountEmail">Основні дані користувача для пошуку користувача</param>
        /// <param name="password">Пароль від особистого кабінету</param>
        public static void UpdateAccountEmail(AccountEmail accountEmail, string password = "")
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string updatePassword = !password.Equals("") ? $"`Password`='{password}'," : "";
                string commandString = $"UPDATE `{dataBase[BaseName.AccountEmailBase]}` SET `Email`='{accountEmail.Email}',{updatePassword} WHERE `IdPerson`='{accountEmail.IdPerson}'";
                command = new MySqlCommand(commandString, conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час оновлення даних облікового запису {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для оновлення нотаток або налаштувань користувача
        /// </summary>
        /// <param name="accountEmail">Основні дані для пошуку користувача</param>
        /// <param name="data">Об'єкт даних, які потрібно занести в базу даних, замість старих</param>
        /// <param name="variantUpdate">Варіант оновлення</param>
        public static void UpdateNotesAndSetting(AccountEmail accountEmail, object data, VariantUpdate variantUpdate)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandString = "", baseName = "";
                switch (accountEmail.Role.ToLower())
                {
                    case "учень":
                    case "студент": baseName = dataBase[BaseName.StudentBase]; break;
                    case "викладач":
                    case "вчитель": baseName = dataBase[BaseName.TeacherBase]; break;
                }
                switch (variantUpdate)
                {
                    case VariantUpdate.Notes:
                        commandString = $"UPDATE `{baseName}` SET `Notes`='{JsonConvert.SerializeObject((ClassNotes)data)}' WHERE `IdPerson`='{accountEmail.IdPerson}'";
                        break;
                }
                command = new MySqlCommand(commandString, conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час оновлення даних облікового запису {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для оновлення даних журналу
        /// </summary>
        /// <param name="groupData">Оновлені основні дані журналу</param>
        /// <param name="otherGroupData">Оновлені додаткові дані журналу</param>
        public static void UpdateGroupData(GroupData groupData, OtherGroupData otherGroupData)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string commandString = "";
                commandString = $"UPDATE `{dataBase[BaseName.GroupBase]}` SET `Course`='{groupData.Course}',`OtherGroupData`='{JsonConvert.SerializeObject(otherGroupData)}',`SettingGroup`='{JsonConvert.SerializeObject(groupData.SettingGroup)}' WHERE `IdGroup`='{groupData.IdGroup}'";
                command = new MySqlCommand(commandString, conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час оновлення даних облікового запису {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для видалення особистого кабінету
        /// </summary>
        /// <param name="IdPerson">Унікальний ідентифікатор користувача</param>
        /// <param name="baseName">База даних з якої потрібно видалити дані</param>
        public static void Delete(string IdPerson, BaseName baseName)
        {
            try
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                string com = $"DELETE FROM `{dataBase[baseName]}` WHERE `Id`='{IdPerson}'";
                command = new MySqlCommand(com, conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Сталася помилка із підключенням до бази даних.\n\nКод помилки: {ex.ErrorCode}\nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка під час видалення облікового запису {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}