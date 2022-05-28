using MySql.Data.MySqlClient;

namespace TeacherManajar.InterfaceCode
{
    /// <summary>
    /// Інтерфейс для реалізації основних необхідних даних, які можуть описувати журнал групи
    /// </summary>
    public interface IGroup
    {
        string Education { get; set; }
        string EducationType { get; set; }

        void ConvertGroupFromMySql(MySqlDataReader sqlDataReader);
    }
}
