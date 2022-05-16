using CourseManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Services
{
   static class MenuServices
    {
       
       
        public static Service service = new Service();
        public static void CreateGroupMenu()
        {
            
            Group group = new Group();
            
            Console.WriteLine("Please enter the category");
          object category;

            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
          bool result= Enum.TryParse(typeof(Categories), Console.ReadLine(), out category);
            Console.WriteLine("How do you want to join the lessons?");
            Console.WriteLine(" 1.Online \n 2.Ofline");

            byte selection=Convert.ToByte(Console.ReadLine());

            if (selection==1)
            {
                group.IsOnline = true;
            }
            else if (selection==2)
            {
                group.IsOnline = false;
            }
          
            if (result)
            {
                service.CreateNewGroup((Categories)category, group.IsOnline);
            }
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Enter The Group Number");

            string oldgroupnum = Console.ReadLine();
            Console.WriteLine("Enter The New Group Number");
            string newgroupnum = Console.ReadLine();
            service.EditGroup(oldgroupnum, newgroupnum);
        }
        public static void ShowAllGroupListMenu()
        {
            service.ShowAllGroupList();
        }
        public static void ShowAllOfStudentsMenu()
        {
            
            service.ShowAllOfStudents();
        }
        public static void ShowListOfStudentsByGroupMenu()
        {
            foreach (Group grouplist in service.Groupss)
            {
                Console.WriteLine(grouplist);
            }
            Console.WriteLine("Enter the Group name");
          
            string groupnum = Console.ReadLine();
           
            service.ShowListOfStudentsByGroup(groupnum);
        }
        public static void CreateStudentMenu()
        {

            Console.WriteLine("Enter The Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter The Group Number\n");
                foreach (Group grouplist in service.Groupss)
                {
                    Console.WriteLine(grouplist);
                }
            Console.WriteLine("\n Which of the above do you want to add to the group?");
            string groupnum = Console.ReadLine();
            Console.WriteLine("Enter your entry point");
            byte point = Convert.ToByte(Console.ReadLine());
            service.CreateStudent(name, surname, groupnum,point);
        }
        public static void DeleteStudentMenu()
        {
            Console.WriteLine("Please, enter ID of student");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Group Number");
            string groupnumber = Console.ReadLine();
            service.DeleteStudent(id,groupnumber);
        }
    }
}
