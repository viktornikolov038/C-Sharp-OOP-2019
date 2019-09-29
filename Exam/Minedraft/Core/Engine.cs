using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private string input;
    private DraftManager manager;
    private bool IsRunning;
    public Engine()
    {
        this.manager = new DraftManager();
        IsRunning = true;
    }

    public void Run()
    {
        while (IsRunning)
        {
            input = Console.ReadLine();
            var cmdArgs = input.Split(' ').ToList();
            var command = cmdArgs[0];
            cmdArgs.RemoveAt(0);
            try
            {
                switch (command)
                {
                    case "RegisterHarvester":
                        Console.WriteLine(manager.RegisterHarvester(cmdArgs));
                    
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(manager.RegisterProvider(cmdArgs));                  
                        break;
                    case "Day":
                        Console.WriteLine(manager.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(manager.Mode(cmdArgs).Split('|')[0]);
                        
                        break;
                    case "Check":
                        Console.WriteLine(manager.Check(cmdArgs));
                        
                        break;
                    case "Shutdown":
                        IsRunning = false;
                        Console.WriteLine(manager.ShutDown());
                        
                        break;
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}

