using System;

namespace Teacher_Manajar
{
    //Опис особливостей притаманних викладачам
    interface ITeacher : ICloneable
    {
        string Diploma_Number { get; set; }
        string Diploma_Series { get; set; }
        string Scientific_Title { get; set; }
        string University { get; set; }
    }
}
