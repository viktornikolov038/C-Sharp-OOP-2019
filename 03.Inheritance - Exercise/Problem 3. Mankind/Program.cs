using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Mankind
{
    public class Program
    {
        public static void Main()
        {
            
            PrintStudentAndWorkerInfo();
        }

        private static void PrintStudentAndWorkerInfo()
        {

            try
            {
                var studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var studentFirstName = studentInfo[0];
                var studentLastName = studentInfo[1];
                var studentFacultyNum = studentInfo[2];
                var student = new Student(studentFirstName, studentLastName, studentFacultyNum);

                var workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var workerFirstName = workerInfo[0];
                var workerLastName = workerInfo[1];
                var weekSalary = decimal.Parse(workerInfo[2]);
                var worksHoursPerDay = decimal.Parse(workerInfo[3]);
                var worker = new Worker(workerFirstName, workerLastName, weekSalary, worksHoursPerDay);
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}
