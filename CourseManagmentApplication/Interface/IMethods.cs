using CourseManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Interface
{
    interface IMethods
    {
        public List<Group> Groupss { get;  }
        string CreateNewGroup(string groupno,Categories category);
        void ShowAllGroupList();
        void EditGroup();
        void ShowListOfStudents();
        void ShowAllOfStudents();
        void CreateStudent(string name,string surname);
        void DeleteStudent();
    }
}
