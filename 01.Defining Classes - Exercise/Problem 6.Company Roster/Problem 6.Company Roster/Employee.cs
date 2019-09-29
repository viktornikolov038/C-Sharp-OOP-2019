public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; } = "n/a";
    public int Age { get; set; } = -1;

    public Employee(string name, decimal salary, string position, string department)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
    }
}

