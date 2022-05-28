using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Teacher_Manajar
{
    //Опис групи
    public class Group : IEquatable<Group>, ICloneable
    {
        public string Name_Subject { get; set; }
        public int Course { get; set; }
        public string Name_Group { get; set; }
        public List<StudentGroup> Students { get; set; }
        public TeacherGroup Teacher { get; set; }
        public List<DateTime> Dates { get;  set; }
        public List<string> Calendar_Plan { get; set; }
        //Копіювання об'єктів
        public object Clone()
        {
            return JsonConvert.DeserializeObject<Group>(JsonConvert.SerializeObject(this));
        }
        //Перевірка чи однакові об'єкти
        public bool Equals(Group other)
        {
            if (Students.Count != other.Students.Count || Dates.Count != other.Dates.Count)
                return false;

            for(int i = 0; i < Students.Count; ++i)
                if (!Students[i].Equals((IStudent)other.Students[i]))
                    return false;
            for (int i = 0; i < Dates.Count; ++i)
                if (!Dates[i].Equals(other.Dates[i]))
                    return false;

            return Name_Subject.Equals(other.Name_Subject) &&
                (
                    ReferenceEquals(Course, other.Course) ||
                    Course.Equals(other.Course)
                ) &&
                (
                    ReferenceEquals(Name_Group, other.Name_Group) ||
                    Name_Group.Equals(other.Name_Group)
                ) &&
                (
                    ReferenceEquals(Teacher, other.Teacher) ||
                    Teacher.Equals(other.Teacher)
                ) &&
                (
                    ReferenceEquals(Calendar_Plan, other.Calendar_Plan) ||
                    Calendar_Plan.SequenceEqual(other.Calendar_Plan)
                );
        }
    }
}
