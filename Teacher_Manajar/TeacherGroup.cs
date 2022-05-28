namespace Teacher_Manajar
{
    //Клас для реалізації даних викладача, які доступні в групі
    public class TeacherGroup : IPerson
    {
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        //Копіювання об'єктів
        public object Clone()
        {
            return new TeacherGroup
            {
                Id = this.Id,
                First_Name = this.First_Name,
                Name = this.Name,
                Surname = this.Surname,
                Email = this.Email
            };
        }
        //Перевірка чи однакові об'єкти за публічними властивостями
        public bool Equals(IPerson other)
        {
            return Email.Equals(other.Email);
        }
    }
}
