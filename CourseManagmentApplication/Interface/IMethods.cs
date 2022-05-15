using CourseManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Interface
{
    interface IMethods
    {
        public List<Group> Groupss { get;  }
        public List<Student> Studentss { get; }
        string CreateNewGroup(string groupno,Categories category);
        void ShowAllGroupList();
        void EditGroup(string oldgroupnum, string newgroupnum);
        void ShowListOfStudentsByGroup();
        void ShowAllOfStudents();
        void CreateStudent(string name,string surname,string groupnumber);
        void DeleteStudent();
    }
}
