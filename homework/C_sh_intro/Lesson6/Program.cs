using System;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        static void Warning()
        {
            Console.Write(@" Command usage:
tasklist - display processes list
taskkill /PID [PID] - kill by ID
taskkill /IM [name]  - kill by name

");
        }
        static void Main(string[] args)
        {

            Warning();
            while (true)
            {
                Console.Write(">>");
                string input = Console.ReadLine();
                input = input.ToUpper();                
                if (input.IndexOf("TASKLIST") != -1)
                {
                    input = input.Replace("TASKLIST", "");
                    input = input.Replace(" ", "");
                    if (input.Length == 0)
                    {
                        ProcManager.ProcList();
                    }
                    else
                    {
                        Warning();
                        continue;
                    }

                }
                if (input.IndexOf("TASKKILL") != -1)
                {
                    input = input.Replace("TASKKILL", "");
                    if (input.IndexOf("/PID") != -1)
                    {
                        input = input.Replace("/PID", "");
                        input = input.Replace(" ", "");                        

                        try
                        {
                            int pid = Convert.ToInt32(input);
                            ProcManager.ProcKillById(pid);
                            input = String.Empty;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                    if (input.IndexOf("/IM") != -1)
                    {
                        input = input.Replace("/IM", "");
                        input = input.Replace(" ", "");                        
                        ProcManager.ProcKillByName(input);
                        input = String.Empty;
                    }
                }
                if (input.Length > 0)
                {
                    Warning();
                }
            }
        }
    }
}
