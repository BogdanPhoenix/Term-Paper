using MySql.Data.MySqlClient;
using System;

namespace TeacherManajar.InterfaceCode
{
    //Опис особливостей притаманних викладачам
    interface ITeacher : ICloneable
    {
        string DiplomaNumber { get; set; }
        string DiplomaSeries { get; set; }
        string ScientificTitle { get; set; }
        string Education { get; set; }
        string EducationType { get; set; }
        void ConvertGroupFromMySql(MySqlDataReader sqlDataReader);
    }
}
