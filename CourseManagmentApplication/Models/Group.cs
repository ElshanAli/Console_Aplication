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
            ++count;
            groupcount++;
            count++;
            Limit = Isonline ? 2 : 3;

          

            switch (category)
            {

                case Categories.Software_Development:
                    GroupNo = $"SD-" + groupcount;
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
        public  byte CheckLimit
        {
            get => _limit;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    if (_limit<=15)
                    {
                    Console.WriteLine(" Online limit is 15");

                    }
                    else
                    {
                        Console.WriteLine(" You can't add greater than 15");
                    }
                }
                else if (IsOnline)
                {
                    _limit = 10;

                    if (_limit<=10)
                    {
                    Console.WriteLine(" Ofline limit is 10");

                    }
                    else
                    {
                        Console.WriteLine(" You can't add greater than 10");
                    }
                   
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
