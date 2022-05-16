using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Student   
    {
         public int ID;
        public string Name;
        public string Surname;
        public string GroupNumber;
        public bool Type;
        public static int Count;
        public static int IdCount;
        byte _point;
        bool _guarated;
        

        public byte PointCheck 
        {
            get => _point;
                
            set
            {
                if (value>80)
                {
                    Console.WriteLine(" You are a guaranteed student");
                    _point = value;
                    _guarated = true;
                }
                else if (value<=80)
                {
                    Console.WriteLine("You aren't a guaranteed student");
                    _point = value;
                    _guarated = false;
                }
            }
        }
        static Student()
        {
            Count = 0;
            IdCount = 1;
        }
        public Student( string name,string surname, string groupnumber,byte point)
        {
          
            Name = name;
            Surname = surname;
            GroupNumber = groupnumber;
            Type = false;
            PointCheck = point;
            Count++;
            ID = IdCount;
            IdCount++;
        }
        public string FullName()
        {
            return $"Name {Name} \n Surname {Surname}";
        }
        public override string ToString()
        {
            return $"About Student \n {FullName()} \n Group Number {GroupNumber} \n Is Guarantee {PointCheck} {_guarated} \n Is Online {PointCheck}";
        }


    }
}
