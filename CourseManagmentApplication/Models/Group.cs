using CourseManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Group
    {
        public string GroupNo;
        public Categories Category;
        public bool IsOnline;
        byte _limit;
        List<Student>_listOfStudents = new List<Student>();
        public static int count = 100;

        public List<Student>CheckLimit
        {
            get => _listOfStudents;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    _listOfStudents = new List<Student>(_limit);
                    Console.WriteLine(" Online limit is 15");
                }
                else if (IsOnline)
                {
                    _limit = 10;
                    _listOfStudents = new List<Student>(_limit);
                    Console.WriteLine(" Ofline limit is 10");
                }
            }
        } 

        public Group(string groupno, Categories category)
        {
            GroupNo = groupno;          
            IsOnline = false;

            switch (category)
            {
               
                case Categories.Software_Development:
                    GroupNo = $" SD - " + count;
                    break;
                case Categories.System_Administrator:
                    GroupNo = $"SA - " + count;
                    break;
                case Categories.Design:
                    GroupNo = $"D - " + count;
                    break;
                default:
                    break;
            }
            Category = category;
            count++;
        }
    }
}
