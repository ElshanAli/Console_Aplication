using CourseManagmentApplication.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Services
{
    class Service : IMethods
    {
        List<Student> _listOfStudents;

        public List<Student> Students => _listOfStudents;

        List<Student> IMethods.Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string CreateNewGroup()
        {
            throw new NotImplementedException();
        }

        public void CreateStudent()
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowAllGroupList()
        {
            throw new NotImplementedException();
        }

        public void ShowAllOfStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowListOfStudents()
        {
            throw new NotImplementedException();
        }
    }
}
