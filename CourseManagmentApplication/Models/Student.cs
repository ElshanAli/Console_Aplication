using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Student   
    {
         static string ID;
        public string Name;
        public string Surname;
        public string GroupNumber;
        public bool Type;
        public static uint Count;
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
            Count = default;
        }
        public Student( string name,string surname, string groupnumber)
        {
          
            Name = name;
            Surname = surname;
            GroupNumber = groupnumber;
            Type = false;
        }
        public string FullName()
        {
            return $"Name {Name} Surname {Surname} Group Number: {GroupNumber}";
        }
        public override string ToString()
        {
            return $"About Student \n {FullName()} \n Group Number {GroupNumber}\n Is Guarantee {PointCheck} {_guarated} ";
        }


    }
}
