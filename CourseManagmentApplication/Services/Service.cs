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
        List<Student> _listOfStudent = new List<Student>(); 
        public List<Group> Groupss { get => _listOfGroups; }

        public List<Student> Studentss => _listOfStudent;

        public string CreateNewGroup(string groupno, Categories category)
        {
            if (string.IsNullOrEmpty(groupno) || string.IsNullOrWhiteSpace(groupno))
            {
                return " Please enter the correct Group Number: ";
            }
            Group group = new Group(groupno, category);

            if (Group.groupcount >= 0)
            {
                Group.groupcount++;
                _listOfGroups.Add(group);
                return $"{group.GroupNo} is succesfully";
            }
            foreach (Group groups in _listOfGroups)
            {
                if (!string.IsNullOrEmpty(groupno)||!string.IsNullOrWhiteSpace(groupno))
                {
                    _listOfGroups.Add(groups);
                    return $"{groups.GroupNo} is succesfully";
                }
            }
            return " Group can't created";
        }

        public void CreateStudent(string name,string surname,string groupnumber)
        {
            Student student = new Student();
            if (string.IsNullOrEmpty(student.FullName())||string.IsNullOrWhiteSpace(student.FullName()))
            {
                Console.WriteLine("Please enter the correct Student FullName");
            }
            else
            {
                Console.WriteLine($"{student.FullName()}");
                _listOfStudent.Add(student);
            }           
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroup(string oldgroupnum,string newgroupnum)
        {
            if (FindGroup(newgroupnum)==null)
            {
                Group group = FindGroup(oldgroupnum);
                if (group!=null)
                {
                    group.GroupNo = newgroupnum.ToUpper().Trim();
                    Console.WriteLine($"{group.GroupNo} is succesfully edited");
                }
                else
                {
                    Console.WriteLine($"There is no group => {oldgroupnum.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine($"There is group => {newgroupnum.ToUpper()}");
            }
           
        }

        public void ShowAllGroupList()
        {
            if (Group.count>0)
            {
                foreach (Group grouplist in  Groupss)
                {
                    Console.WriteLine(grouplist);
                }
            }
            else
            {
                Console.WriteLine("There is no group here");
            }
        }

        public void ShowAllOfStudents()
        {
            if (Student.Count>0)
            {
                foreach (Student student in Studentss)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("There is no students");
            }
        }

        public void ShowListOfStudentsByGroup()
        {
            foreach (Student student in _listOfStudent)
            {
                Console.WriteLine(student);
            }
          
        }
        public Group FindGroup(string groupnum)
        {
            foreach (Group group in Groupss)
            {
                if (group.GroupNo.ToLower().Trim()==groupnum.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }
    }
}
