using System;
using System.Collections.Generic;

namespace Teacher_Manajar
{
    //Опис особливостей, які притаманні студентам
    public interface IStudent : IEquatable<IStudent>
    {
        uint Course { get; set; }
        string Group { get; set; }
        string University { get; set; }
        List<string> Evaluation { get; set; }
    }
}
