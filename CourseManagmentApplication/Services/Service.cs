using CourseManagmentApplication.Interface;
using CourseManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Services
{
    class Service : IMethods
    {
        List<Group> _listOfGroups = new List<Group>();
        public List<Group> Groupss { get => _listOfGroups; }



        public string CreateNewGroup(string groupno, Categories category)
        {
            if (string.IsNullOrEmpty(groupno) || string.IsNullOrWhiteSpace(groupno))
            {
                return " Please enter the correct Group Number: ";
            }
            Group group = new Group(groupno, category);

            if (Group.groupcount == 0)
            {
                Group.groupcount++;
                _listOfGroups.Add(group);
                return $"{group.GroupNo} is succesfully";
            }
            foreach (Group groups in _listOfGroups)
            {
                if (group.GroupNo.ToLower().Trim() != groups.GroupNo.ToLower().Trim())
                {
                    _listOfGroups.Add(group);
                    return $"{group.GroupNo} is succesfully";
                }
            }
            return " Group can't created";
        }

        public void CreateStudent(string name,string surname)
        {
            Student student = new Student();
            if (string.IsNullOrEmpty(student.FullName())!=string.IsNullOrWhiteSpace(student.FullName()))
            {
                Console.WriteLine("Please enter the correct Student FullName"); 
            }
            if ()
            {

            }
            
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
