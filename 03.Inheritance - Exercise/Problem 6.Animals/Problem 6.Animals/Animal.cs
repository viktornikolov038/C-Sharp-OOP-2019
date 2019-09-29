using System;
using System.Text;

public abstract class Animal
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Gender
    {
        get { return this.gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.gender = value;
        }
    }

    protected int Age
    {
        get { return this.age; }
        set
        {
            this.age = value;
        }
    }

    protected string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");   
            }
            this.name = value;
        }
    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.GetType().Name);
        sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
        sb.AppendLine(this.ProduceSound());

        return sb.ToString();
    }
}
