using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Student   
    {
         static string ID;
        public string Name;
        public string Surname;
        public string GroupNumber;
        public bool Type;
        public static int Count;

        public Student()
        {

        }
        public Student(string id, string name,string surname, string groupnumber)
        {
            ID = id;
            Name = name;
            Surname = surname;
            GroupNumber = groupnumber;
            Type = false;
        }
        public string FullName()
        {
            return $"Name {Name} Surname {Surname} Group Number: {GroupNumber}";
        }
       
    }
}
