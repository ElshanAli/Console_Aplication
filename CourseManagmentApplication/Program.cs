using CourseManagmentApplication.Services;
using System;

namespace CourseManagmentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            byte selection;
            do
            {
                Console.WriteLine(" Welcome to the course!");
                Console.WriteLine(" 1. Create New Group");
                Console.WriteLine(" 2. Edit Group");
                Console.WriteLine(" 3. Create Student");
                Console.WriteLine(" 4. Show All Student");
                Console.WriteLine(" 5. Show All Group");
                Console.WriteLine(" 6. Show All Students in Group");
                Console.WriteLine(" 7. Delete Student");
                Console.WriteLine(" 0. Exit");

                bool result = byte.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreateGroupMenu();
                            break;
                        case 2:
                            MenuServices.EditGroupMenu();
                            break;
                        case 3:
                            MenuServices.CreateStudentMenu();
                            break;
                        case 4:
                            MenuServices.ShowAllOfStudentsMenu();
                            break;
                        case 5:
                            MenuServices.ShowAllGroupListMenu();
                            break;
                        case 6:
                            MenuServices.ShowListOfStudentsByGroupMenu();
                            break;
                        case 7:
                            MenuServices.DeleteStudentMenu();
                            break;                   
                    }
                }

            } while (selection!=0);


        }
    }
}
