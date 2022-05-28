using System;

namespace Teacher_Manajar
{
    //Опис персони
    public interface IPerson : IEquatable<IPerson>, ICloneable
    {
        string Id { get; set; }
        string First_Name { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
    }
}
