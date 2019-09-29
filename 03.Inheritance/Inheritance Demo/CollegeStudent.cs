using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CollegeStudent : Student
    {
        private List<double> grades;

        public List<double> Grades
        {
            get { return this.grades; }
            set { this.grades = value; }
        }

        public CollegeStudent(string name,int age, string town ,List<double> grades)
        {         
            this.Name = name;
            this.Age = age;
            this.Town = town;
            this.grades = grades;
        }
    }
}
