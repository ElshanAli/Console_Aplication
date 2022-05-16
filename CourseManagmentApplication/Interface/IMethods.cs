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
       void CreateNewGroup(Categories category,bool iSOnline);
        void ShowAllGroupList();
        void EditGroup(string oldgroupnum, string newgroupnum);
        void ShowListOfStudentsByGroup(string groupnum);
        void ShowAllOfStudents();
        void CreateStudent(string name,string surname,string groupnumber,byte point);
        void DeleteStudent(int id, string groupnumber);
    }
}
