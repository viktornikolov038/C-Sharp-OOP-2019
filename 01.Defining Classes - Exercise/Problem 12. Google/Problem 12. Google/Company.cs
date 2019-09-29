using System;

namespace Problem_12.Google
{
    public class Company
    {
        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        private string name;
        private string department;
        private decimal salary;

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Department} {this.Salary:F2}";
        }
    }
}