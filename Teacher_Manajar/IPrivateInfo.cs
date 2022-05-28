using System;
using System.Collections.Generic;

namespace Teacher_Manajar
{
    //Опис приватних властивостей особи
    public interface IPrivateInfo : IEquatable<IPrivateInfo>, ICloneable
    {
        List<string> Previous_Link_Foto { get; set; }
        string Now_Link_Foto { get; set; }
        string Password { get; set; }
        string Role { get; set; }
    }
}
