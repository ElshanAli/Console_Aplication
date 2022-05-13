using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Student
    {
        public static string ID;
        public string Name;
        public string Surname;
        public string GroupNumber;
        public bool Type;
       

       
        public Student(string id, string name,string surname, string groupnumber)
        {
            ID = id;
            Name = name;
            Surname = surname;
            GroupNumber = groupnumber;
           
        }
        public string FullName()
        {
            return $"Name {Name} Surname {Surname}";
        }

        public void CreateNewGroup()
        {

        }
    }
}
