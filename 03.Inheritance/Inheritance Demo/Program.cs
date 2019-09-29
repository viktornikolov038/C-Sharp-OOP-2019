using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {
            var grades = new List<double>
            {
                3.50,5.50,2.99
            };
            var collegeStudent = new CollegeStudent("Svetlin",17,"Kyustendil",grades);

            Console.WriteLine(collegeStudent.Age);
        }
    }
}
