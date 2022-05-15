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
        public int Limit;
        public List<Group>_listOfGroups = new List<Group>();
        public static int count;
        public static int groupcount;

        public List<Student> ListOfStudent = new List<Student>();
        public Group()
        {

        }
        static Group()
        {
            count = 0;
            groupcount = 100;

        }
        public Group(Categories category,bool Isonline)
        {
            Category = category;
            IsOnline =Isonline;
            count++;
            groupcount++;
            Limit = Isonline ? 10 : 15;

          

            switch (category)
            {

                case Categories.Software_Development:
                    GroupNo = $" SD-" + groupcount;
                    break;
                case Categories.System_Administrator:
                    GroupNo = $"SA-" + groupcount;
                    break;
                case Categories.Design:
                    GroupNo = $"D-" + groupcount;
                    break;
                default:
                    break;
            }         
            count++;

        }
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
        public void ShowStudent()
        {
            foreach (Student student in ListOfStudent)
            {
                Console.WriteLine(student);
            }
        }
        public override string ToString()
        {
            return $"{GroupNo}  {Category}";
        }


    }
}
