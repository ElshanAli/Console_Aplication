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
        List<Group>_listOfGroups = new List<Group>();
        public static int count = 100;
        public static int groupcount;

        public List<Group>CheckLimit
        {
            get => _listOfGroups;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    _listOfGroups = new List<Group>(_limit);
                    Console.WriteLine(" Online limit is 15");
                }
                else if (IsOnline)
                {
                    _limit = 10;
                    _listOfGroups = new List<Group>(_limit);
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
