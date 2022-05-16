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

        public void CreateNewGroup( Categories category, bool iSOnline)
        {
            Group group = new Group(category, iSOnline);

            _listOfGroups.Add(group);

            Console.WriteLine(group);           
        }
        public void CreateStudent(string name,string surname,string groupnumber,byte point)
        {           
            if (Group.count>0)
            {
                Student student = new Student(name,surname,groupnumber,point);
                if (string.IsNullOrEmpty(student.FullName()) || string.IsNullOrWhiteSpace(student.FullName()))
                {
                    Console.WriteLine("Please enter the correct Student FullName");
                }
                else
                {
                  
                    Group group = GetGroup(groupnumber);
                    if (group==null)
                    {
                        Console.WriteLine("Group not found");
                        return;
                    }
                    if (group.ListOfStudent.Count>=group.Limit)
                    {
                        Console.WriteLine(" Dont");
                        return;
                    }
                   
                    _listOfStudent.Add(student);
                    Console.WriteLine($" Name : {name} Surname {surname} Group Number {groupnumber} Guarantee Point: {student.PointCheck}");
                }
            }
            else
            {
                Console.WriteLine("You can not add student in group. Because this group is not found");
            }          
        }
        Group GetGroup(string groupumber)
        {
            foreach (Group group in _listOfGroups)
            {
                if (group.GroupNo==groupumber)
                {
                    return group;
                }
            }
            return null; 
        }
        public void DeleteStudent(int id, string groupnumber)
        {
            Group group = FindGroup(groupnumber);
            if (group==null)
            {
                Console.WriteLine("Group not found");
            }
            if (group.ListOfStudent.Count==0)
            {
                Console.WriteLine("Student not found");
            }
            foreach (var item in group.ListOfStudent)
            {
                if (item.ID==id)
                {
                    group.ListOfStudent.Remove(item);
                }
            }
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
            if (Studentss.Count>0)
            {

                foreach (Group group in Groupss)
                {

                    foreach (Student student in Studentss)
                    {
                        Console.WriteLine($"Fullname: {student.FullName()} Group Number : {student.GroupNumber} Guarantee Type: {student.PointCheck}");
                    }
                }               
            }
            else
            {
                Console.WriteLine("There is no students");
            }
        }
        public void ShowListOfStudentsByGroup(string groupnum)
        {
            Group group = FindGroup(groupnum);
            if (groupnum!=null)
            {

            foreach (Student student in _listOfStudent)
            {
                Console.WriteLine(student);
            }
            }
            else
            {
                Console.WriteLine("Group not Found");
            }
        }
        public Group FindGroup(string groupnum)
        {
            foreach (Group group in _listOfGroups)
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
