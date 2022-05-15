using CourseManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication.Services
{
   static class MenuServices
    {
        public static Service service = new Service();
        public static void CreateCourseManagmentMenu()
        {
            Console.WriteLine("Please enter the groupno");
            string groupno;
            groupno = Console.ReadLine();
            Console.WriteLine("Please enter the category");
           object category;
          bool result= Enum.TryParse(typeof(Categories), Console.ReadLine(), out category);
            if (string.IsNullOrEmpty(groupno)||string.IsNullOrWhiteSpace(groupno))
            {

            }
        }
    }
}
