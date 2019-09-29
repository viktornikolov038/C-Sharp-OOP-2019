using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Mankind
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal worksHoursPerDay;
        public Worker(string firstName,string lastName, decimal weekSalary, decimal worksHoursPerDay) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorksHoursPerDay = worksHoursPerDay;
            
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch!Argument: {nameof(weekSalary)}");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorksHoursPerDay
        {
            get { return this.worksHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch!Argument: workHoursPerDay");
                }
                this.worksHoursPerDay = value;
            }
        }

        public decimal salaryPerHours()
        {
            return this.weekSalary / (5m * this.worksHoursPerDay);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorksHoursPerDay:f2}")
                .Append($"Salary per hour: {this.salaryPerHours():f2}");

            return sb.ToString();
        }
    }
}
