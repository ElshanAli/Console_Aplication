using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Interface
{
    interface IMethods
    {
        public List<Student> Students { get; set; }
        string CreateNewGroup();
        void ShowAllGroupList();
        void EditGroup();
        void ShowListOfStudents();
        void ShowAllOfStudents();
        void CreateStudent();
        void DeleteStudent();
    }
}
