using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace TeacherManajar.InterfaceCode
{
    /// <summary>
    /// Опис особливостей, які притаманні студентам
    /// </summary>
    public interface IStudent
    {
        uint Course { get; set; }
        string GroupName { get; set; }
        string Education { get; set; }
        string FormStudy { get; set; }
        string EducationalDegree { get; set; }
        string EducationType { get; set; }
        void ConvertGroupFromMySql(MySqlDataReader sqlDataReader);
    }
}
