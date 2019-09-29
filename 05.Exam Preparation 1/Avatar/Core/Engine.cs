using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private string input;
    private bool IsRunning;
    private NationsBuilder builder;
    public Engine()
    {
        this.builder = new NationsBuilder();
        IsRunning = true;
    }

    public void Run()
    {
        while (IsRunning)
        {
            var cmdArgs = input.Split(' ').ToList();
            var command = cmdArgs[0];
            cmdArgs.RemoveAt(0);
            switch (command)	
            {
                case "Bender":
                    builder.AssignBender(cmdArgs);
                    break;
                case "Monument":
                    break;           
                case "Status":
                    break;
                case "War":
                    break;
                case "Quit":
                    IsRunning = false;
                    break;
            }
        }
    }
}

