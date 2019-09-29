using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main()
    {
        var acconts = new Dictionary<int, BankAccount>();
        while (true)
        {
            var inpiLine = Console.ReadLine();
            if (inpiLine == "End")
            {
                break;
            }
            var cmdArgs = inpiLine.Split();

            var command = cmdArgs[0];
            switch (command)
            {
                case "Create":
                    Create(cmdArgs, acconts);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, acconts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, acconts);
                    break;
                case "Print":
                    Print(cmdArgs, acconts);
                    break;
                    
            }
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> acconts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);
        if (acconts.ContainsKey(id))
        {
            acconts[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> acconts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);
        if (acconts.ContainsKey(id))
        {
            if (acconts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                acconts[id].Withdraw(amount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> acconts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (acconts.ContainsKey(id))
        {
            Console.WriteLine(acconts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
        
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> acconts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (acconts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            acconts.Add(id,acc);
        }
    }

    
}

